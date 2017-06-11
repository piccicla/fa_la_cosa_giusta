namespace computer_didattica
{
	partial class DrawingArea2
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
            this.picDrawingArea = new System.Windows.Forms.PictureBox();
            this.picDrawingArea2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingArea2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDrawingArea
            // 
            this.picDrawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picDrawingArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDrawingArea.Location = new System.Drawing.Point(178, 35);
            this.picDrawingArea.Name = "picDrawingArea";
            this.picDrawingArea.Size = new System.Drawing.Size(279, 160);
            this.picDrawingArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDrawingArea.TabIndex = 2;
            this.picDrawingArea.TabStop = false;
            this.picDrawingArea.DragOver += new System.Windows.Forms.DragEventHandler(this.picDrawingArea_DragOver);
            this.picDrawingArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.picDrawingArea_DragDrop);
            this.picDrawingArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.picDrawingArea_DragEnter);
            // 
            // picDrawingArea2
            // 
            this.picDrawingArea2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDrawingArea2.Location = new System.Drawing.Point(525, 97);
            this.picDrawingArea2.Name = "picDrawingArea2";
            this.picDrawingArea2.Size = new System.Drawing.Size(279, 160);
            this.picDrawingArea2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDrawingArea2.TabIndex = 3;
            this.picDrawingArea2.TabStop = false;
            this.picDrawingArea2.DragEnter += new System.Windows.Forms.DragEventHandler(this.picDrawingArea2_DragEnter);
            // 
            // DrawingArea
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 673);
            this.Controls.Add(this.picDrawingArea2);
            this.Controls.Add(this.picDrawingArea);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "DrawingArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing Area";
            this.Load += new System.EventHandler(this.DrawingArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingArea2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.PictureBox picDrawingArea;
        private System.Windows.Forms.PictureBox picDrawingArea2;
	}
}

