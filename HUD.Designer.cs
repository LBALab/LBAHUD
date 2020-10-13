namespace LBAHUD
{
    partial class HUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HUD));
            this.lblKeysVal = new System.Windows.Forms.Label();
            this.lblKashesVal = new System.Windows.Forms.Label();
            this.sbHealth = new DisplayBar.statusBar();
            this.pbHealth = new System.Windows.Forms.PictureBox();
            this.pbMagic = new System.Windows.Forms.PictureBox();
            this.sbMagic = new DisplayBar.statusBar();
            this.pbKash = new System.Windows.Forms.PictureBox();
            this.pbKey = new System.Windows.Forms.PictureBox();
            this.pbZlitos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZlitos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKeysVal
            // 
            this.lblKeysVal.AutoSize = true;
            this.lblKeysVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeysVal.Location = new System.Drawing.Point(363, 4);
            this.lblKeysVal.Name = "lblKeysVal";
            this.lblKeysVal.Size = new System.Drawing.Size(17, 17);
            this.lblKeysVal.TabIndex = 7;
            this.lblKeysVal.Text = "2";
            // 
            // lblKashesVal
            // 
            this.lblKashesVal.AutoSize = true;
            this.lblKashesVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKashesVal.Location = new System.Drawing.Point(281, 4);
            this.lblKashesVal.Name = "lblKashesVal";
            this.lblKashesVal.Size = new System.Drawing.Size(35, 17);
            this.lblKashesVal.TabIndex = 9;
            this.lblKashesVal.Text = "999";
            // 
            // sbHealth
            // 
            this.sbHealth.BackColor = System.Drawing.Color.Transparent;
            this.sbHealth.ColourEmpty = System.Drawing.Color.LightGray;
            this.sbHealth.ColourFont = System.Drawing.Color.Black;
            this.sbHealth.ColourFull = System.Drawing.Color.PaleVioletRed;
            this.sbHealth.DisplayValue = true;
            this.sbHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbHealth.Location = new System.Drawing.Point(25, 0);
            this.sbHealth.Max = ((uint)(100u));
            this.sbHealth.Min = ((uint)(0u));
            this.sbHealth.Name = "sbHealth";
            this.sbHealth.Size = new System.Drawing.Size(100, 24);
            this.sbHealth.TabIndex = 13;
            this.sbHealth.Val = ((uint)(50u));
            // 
            // pbHealth
            // 
            this.pbHealth.Image = ((System.Drawing.Image)(resources.GetObject("pbHealth.Image")));
            this.pbHealth.Location = new System.Drawing.Point(0, 0);
            this.pbHealth.Name = "pbHealth";
            this.pbHealth.Size = new System.Drawing.Size(23, 23);
            this.pbHealth.TabIndex = 14;
            this.pbHealth.TabStop = false;
            this.pbHealth.WaitOnLoad = true;
            this.pbHealth.Click += new System.EventHandler(this.pbHealth_Click);
            // 
            // pbMagic
            // 
            this.pbMagic.Image = ((System.Drawing.Image)(resources.GetObject("pbMagic.Image")));
            this.pbMagic.Location = new System.Drawing.Point(126, 0);
            this.pbMagic.Name = "pbMagic";
            this.pbMagic.Size = new System.Drawing.Size(24, 24);
            this.pbMagic.TabIndex = 15;
            this.pbMagic.TabStop = false;
            this.pbMagic.Click += new System.EventHandler(this.pbMagic_Click);
            // 
            // sbMagic
            // 
            this.sbMagic.BackColor = System.Drawing.Color.Transparent;
            this.sbMagic.ColourEmpty = System.Drawing.Color.LightGray;
            this.sbMagic.ColourFont = System.Drawing.Color.Black;
            this.sbMagic.ColourFull = System.Drawing.Color.CornflowerBlue;
            this.sbMagic.DisplayValue = true;
            this.sbMagic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbMagic.Location = new System.Drawing.Point(150, 0);
            this.sbMagic.Max = ((uint)(80u));
            this.sbMagic.Min = ((uint)(0u));
            this.sbMagic.Name = "sbMagic";
            this.sbMagic.Size = new System.Drawing.Size(100, 24);
            this.sbMagic.TabIndex = 16;
            this.sbMagic.Val = ((uint)(70u));
            this.sbMagic.Load += new System.EventHandler(this.sbMagic_Load);
            // 
            // pbKash
            // 
            this.pbKash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKash.Image = ((System.Drawing.Image)(resources.GetObject("pbKash.Image")));
            this.pbKash.Location = new System.Drawing.Point(253, 0);
            this.pbKash.Name = "pbKash";
            this.pbKash.Size = new System.Drawing.Size(24, 24);
            this.pbKash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKash.TabIndex = 27;
            this.pbKash.TabStop = false;
            // 
            // pbKey
            // 
            this.pbKey.Image = ((System.Drawing.Image)(resources.GetObject("pbKey.Image")));
            this.pbKey.Location = new System.Drawing.Point(319, 0);
            this.pbKey.Name = "pbKey";
            this.pbKey.Size = new System.Drawing.Size(40, 24);
            this.pbKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKey.TabIndex = 28;
            this.pbKey.TabStop = false;
            // 
            // pbZlitos
            // 
            this.pbZlitos.Image = ((System.Drawing.Image)(resources.GetObject("pbZlitos.Image")));
            this.pbZlitos.Location = new System.Drawing.Point(253, 0);
            this.pbZlitos.Name = "pbZlitos";
            this.pbZlitos.Size = new System.Drawing.Size(24, 24);
            this.pbZlitos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZlitos.TabIndex = 56;
            this.pbZlitos.TabStop = false;
            // 
            // HUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.pbKey);
            this.Controls.Add(this.sbMagic);
            this.Controls.Add(this.pbMagic);
            this.Controls.Add(this.pbHealth);
            this.Controls.Add(this.sbHealth);
            this.Controls.Add(this.lblKashesVal);
            this.Controls.Add(this.lblKeysVal);
            this.Controls.Add(this.pbKash);
            this.Controls.Add(this.pbZlitos);
            this.Name = "HUD";
            this.Size = new System.Drawing.Size(640, 24);
            ((System.ComponentModel.ISupportInitialize)(this.pbHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZlitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKeysVal;
        private System.Windows.Forms.Label lblKashesVal;
        private DisplayBar.statusBar sbHealth;
        private System.Windows.Forms.PictureBox pbHealth;
        private System.Windows.Forms.PictureBox pbMagic;
        private DisplayBar.statusBar sbMagic;
        private System.Windows.Forms.PictureBox pbKash;
        private System.Windows.Forms.PictureBox pbKey;
        private System.Windows.Forms.PictureBox pbZlitos;
    }
}
