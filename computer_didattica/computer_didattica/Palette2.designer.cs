namespace computer_didattica
{
	partial class Palette2
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
            this.lblMother = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblDisco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
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
            // lblMother
            // 
            this.lblMother.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMother.ImageIndex = 2;
            this.lblMother.ImageList = this.images;
            this.lblMother.Location = new System.Drawing.Point(12, 116);
            this.lblMother.Name = "lblMother";
            this.lblMother.Size = new System.Drawing.Size(56, 48);
            this.lblMother.TabIndex = 6;
            this.lblMother.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            // 
            // lblRam
            // 
            this.lblRam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRam.ImageIndex = 1;
            this.lblRam.ImageList = this.images;
            this.lblRam.Location = new System.Drawing.Point(12, 65);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(56, 48);
            this.lblRam.TabIndex = 5;
            this.lblRam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            // 
            // lblDisco
            // 
            this.lblDisco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisco.ImageIndex = 0;
            this.lblDisco.ImageList = this.images;
            this.lblDisco.Location = new System.Drawing.Point(12, 17);
            this.lblDisco.Name = "lblDisco";
            this.lblDisco.Size = new System.Drawing.Size(56, 48);
            this.lblDisco.TabIndex = 4;
            this.lblDisco.Click += new System.EventHandler(this.lblPictureOne_Click);
            this.lblDisco.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "lblDisco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "lblRam";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(75, 134);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(50, 13);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "lblMother";
            // 
            // Palette
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 173);
            this.ControlBox = false;
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblDisco);
            this.Controls.Add(this.lblMother);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Palette";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Palette";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ImageList images;
		private System.Windows.Forms.Label lblMother;
		private System.Windows.Forms.Label lblRam;
		private System.Windows.Forms.Label lblDisco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl3;
	}
}