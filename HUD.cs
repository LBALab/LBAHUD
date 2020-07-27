using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LBAMemoryModule;
using System.Drawing.Text;
using System.Reflection;
using System.IO;

namespace LBAHUD
{
    public partial class HUD : UserControl
    {
        private byte health;
        private byte magicLevel;
        private byte magicPoints;
        private byte keys;
        private byte cloverBoxes;
        private byte clovers;
        private int kashes;
        private int zilitos;
        private int magicMaxWidth = 112;
        oTimerGetItems otgi = new oTimerGetItems();
        private byte Health
        {
            get => health;
            set
            {
                health = value;
                sbHealth.Val = health;
            }
        }
        private byte MagicLevel
        {
            get => magicLevel;
            set
            {
                magicLevel = value;
                sbMagic.Width = (int)(magicMaxWidth * ((float)magicLevel / 4));
                sbMagic.Max = (uint)20 * magicLevel;
            }
        }
        private byte MagicPoints
        {
            get => magicPoints;
            set
            {
                magicPoints = value;
                sbMagic.Val = magicPoints;
            }
        }
        private byte Keys
        {
            get => keys;
            set
            {
                keys = value;
                lblKeysVal.Text = keys.ToString();
            }
        }
        private PictureBox[] pbCloverBoxes = new PictureBox[10];
        Image fullCloverBox;
        Image emptyCloverBox;
        Mem m = new Mem();
        private byte CloverBoxes
        {
            get => cloverBoxes;
            set
            {
                cloverBoxes = value;
                UpdateClovers();
            }
        }
        private byte Clovers
        {
            get => clovers;
            set
            {
                clovers = value;
                UpdateClovers();
            }
        }
        private int Kashes
        {
            get => kashes;
            set
            {
                kashes = value;
                lblKashesVal.Text = value.ToString();
            }
        }
        public HUD()
        {
            InitializeComponent();
            //this.TransparencyKey = this.BackColor;
        }
        private int Zilitos
        {
            get => zilitos;
            set
            {
                zilitos = value;
                lblKashesVal.Text = value.ToString();
            }
        }
        private string getFilesPath()
        {
            //return AppDomain.CurrentDomain.BaseDirectory;
            return new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
        }
        private enum LBA1Offsets : uint
        {
            MagicLevel = 0xE20,
            MagicPoints = 0xE22,
            Kashes = 0xE24,
            Keys = 0xE26,
            Clovers = 0xE2A,
            CloverBoxes = 0xE2C,
            Gas = 0xE30,
            Health = 0xD554
        }
        private enum LBA2Offsets : uint
        {
            Health = 0x57F29,
            Zilitos = 0x57DFB,
            CloverBoxes = 0x3D691,
            Clovers = 0x57DE9,
            Kashes = 0x57DF7,
            MagicLevel = 0x57DFF,
            MagicPoints = 0x57E00,
            Keys = 0x57E01
        }

        public void Refresh()
        {
            byte LBAVer = m.DetectLBAVersion();
            otgi = new oTimerGetItems();
            if (1 == LBAVer)
            {
                sbHealth.Max = 50;
                otgi.AddItem(UpdateHealth, (uint)LBA1Offsets.Health, 1);
                otgi.AddItem(UpdateMagicLevel, (uint)LBA1Offsets.MagicLevel, 1);
                otgi.AddItem(UpdateMagicPoints, (uint)LBA1Offsets.MagicPoints, 1);
                otgi.AddItem(UpdateKeys, (uint)LBA1Offsets.Keys, 1);
                otgi.AddItem(UpdateCloverBoxes, (uint)LBA1Offsets.CloverBoxes, 1);
                otgi.AddItem(UpdateClovers, (uint)LBA1Offsets.Clovers, 1);
                otgi.AddItem(UpdateKashes, (uint)LBA1Offsets.Kashes, 2);
                return;
            }
            if(2 == LBAVer)
            {
                sbHealth.Max = 255;
                otgi.AddItem(UpdateHealth, (uint)LBA2Offsets.Health, 1);
                otgi.AddItem(UpdateMagicLevel, (uint)LBA2Offsets.MagicLevel, 1);
                otgi.AddItem(UpdateMagicPoints, (uint)LBA2Offsets.MagicPoints, 1);
                otgi.AddItem(UpdateKeys, (uint)LBA2Offsets.Keys, 1);
                otgi.AddItem(UpdateCloverBoxes, (uint)LBA2Offsets.CloverBoxes, 1);
                otgi.AddItem(UpdateClovers, (uint)LBA2Offsets.Clovers, 1);
                otgi.AddItem(UpdateKashes, (uint)LBA2Offsets.Kashes, 2);
                otgi.AddItem(UpdateZilitos, (uint)LBA2Offsets.Zilitos, 2);
                return;
            }
        }
        public void UpdateHealth(ushort val)
        {
            if (val != health)
                Health = (byte)val;
        }
        public void UpdateMagicLevel(ushort val)
        {
            MagicLevel = (byte)val;
        }
        public void UpdateMagicPoints(ushort val)
        {
            if (val != magicPoints)
                MagicPoints = (byte)val;
        }
        public void UpdateKeys(ushort val)
        {
            Keys = (byte)val;
        }
        public void UpdateCloverBoxes(ushort val)
        {
            CloverBoxes = (byte)val;
        }
        public void UpdateClovers(ushort val)
        {
            Clovers = (byte)val;
        }
        public void UpdateKashes(ushort val)
        {
            if (isTwinsun())
            {
                pbKash.Visible = true;
                pbZlitos.Visible = false;
                kashes = val;
                lblKashesVal.Text = kashes.ToString();
            }
        }
        public void UpdateZilitos(ushort val)
        {
            if (!isTwinsun())
            {
                pbKash.Visible = false;
                pbZlitos.Visible = true;
                zilitos = val;
                lblKashesVal.Text = zilitos.ToString();
            }
        }

        private bool isTwinsun()
        {
            int islandOffset = -0x1C4EDD;
            byte LBAVer = m.DetectLBAVersion();
            if (1 == LBAVer) return true;
            int val = m.readAddress(2,(uint)islandOffset, 1);            
            if (0 == val || 2 == val) return true;
            return false;
        }
        private void initialCloverBoxLoad(int cloverCount, int cloverBoxCount)
        {
            int pictureBoxXPos = 429;
            int pictureBoxYPos = 0;
            int pictureBoxPadding = 1;
            int pictureBoxWidth = 20;
            Size boxSize = new Size(pictureBoxWidth, 20);

            for (int i = 0; i < pbCloverBoxes.Length; i++)
            {
                pbCloverBoxes[i] = new PictureBox();
                pbCloverBoxes[i].Location = new Point(pictureBoxXPos + (i * pictureBoxWidth) + (i * pictureBoxPadding), pictureBoxYPos);
                if (i < cloverCount)
                    pbCloverBoxes[i].Image = fullCloverBox;
                else
                    pbCloverBoxes[i].Image = emptyCloverBox;
                pbCloverBoxes[i].Size = boxSize;
                pbCloverBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pbCloverBoxes[i].Visible = false;
                Controls.Add(pbCloverBoxes[i]);
            }

            for (int i = 0; i < pbCloverBoxes.Length && i < cloverBoxCount; i++)
            {
                pbCloverBoxes[i].Visible = true;
            }
        }

        private void UpdateClovers()
        {
            for (int i = 0; i < pbCloverBoxes.Length && i < cloverBoxes; i++)
            {
                if (i < clovers)
                    pbCloverBoxes[i].Image = fullCloverBox;
                else
                    pbCloverBoxes[i].Image = emptyCloverBox;
                pbCloverBoxes[i].Visible = true;
            }
            for (int i = cloverBoxes; i < pbCloverBoxes.Length; i++)
                pbCloverBoxes[i].Visible = false;
        }

        private void sbMagic_Load(object sender, EventArgs e)
        {
            //fullCloverBox = Image.FromFile("./files/fullCloverBox.png");
            fullCloverBox = Image.FromFile(getFilesPath() + "/files/fullCloverBox.png");
            emptyCloverBox = Image.FromFile(getFilesPath() + "/files/emptyCloverBox.png");
            initialCloverBoxLoad(1, 2);
            Refresh();
        }

        private void pbHealth_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void pbMagic_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
