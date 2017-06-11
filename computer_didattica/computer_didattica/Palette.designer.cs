namespace computer_didattica
{
	partial class Palette
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Palette));
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.lblPictureThree = new System.Windows.Forms.Label();
            this.lblPictureTwo = new System.Windows.Forms.Label();
            this.lblPictureOne = new System.Windows.Forms.Label();
            this.lblVentola = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lblVentola)).BeginInit();
            this.SuspendLayout();
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "");
            this.images.Images.SetKeyName(1, "");
            this.images.Images.SetKeyName(2, "");
            // 
            // lblPictureThree
            // 
            this.lblPictureThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPictureThree.Image = ((System.Drawing.Image)(resources.GetObject("lblPictureThree.Image")));
            this.lblPictureThree.Location = new System.Drawing.Point(12, 149);
            this.lblPictureThree.Name = "lblPictureThree";
            this.lblPictureThree.Size = new System.Drawing.Size(56, 48);
            this.lblPictureThree.TabIndex = 6;
            this.lblPictureThree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            // 
            // lblPictureTwo
            // 
            this.lblPictureTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPictureTwo.Image = ((System.Drawing.Image)(resources.GetObject("lblPictureTwo.Image")));
            this.lblPictureTwo.Location = new System.Drawing.Point(12, 61);
            this.lblPictureTwo.Name = "lblPictureTwo";
            this.lblPictureTwo.Size = new System.Drawing.Size(56, 48);
            this.lblPictureTwo.TabIndex = 5;
            this.lblPictureTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            // 
            // lblPictureOne
            // 
            this.lblPictureOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPictureOne.Image = ((System.Drawing.Image)(resources.GetObject("lblPictureOne.Image")));
            this.lblPictureOne.Location = new System.Drawing.Point(12, 9);
            this.lblPictureOne.Name = "lblPictureOne";
            this.lblPictureOne.Size = new System.Drawing.Size(56, 48);
            this.lblPictureOne.TabIndex = 4;
            this.lblPictureOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            // 
            // lblVentola
            // 
            this.lblVentola.Image = ((System.Drawing.Image)(resources.GetObject("lblVentola.Image")));
            this.lblVentola.Location = new System.Drawing.Point(160, 12);
            this.lblVentola.Name = "lblVentola";
            this.lblVentola.Size = new System.Drawing.Size(111, 100);
            this.lblVentola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblVentola.TabIndex = 7;
            this.lblVentola.TabStop = false;
            this.lblVentola.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl2_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Palette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblVentola);
            this.Controls.Add(this.lblPictureTwo);
            this.Controls.Add(this.lblPictureOne);
            this.Controls.Add(this.lblPictureThree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Palette";
            this.ShowInTaskbar = false;
            this.Text = "Palette";
            ((System.ComponentModel.ISupportInitialize)(this.lblVentola)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList images;
		private System.Windows.Forms.Label lblPictureThree;
		private System.Windows.Forms.Label lblPictureTwo;
		private System.Windows.Forms.Label lblPictureOne;
        private System.Windows.Forms.PictureBox lblVentola;
        private System.Windows.Forms.Button button1;
	}
}