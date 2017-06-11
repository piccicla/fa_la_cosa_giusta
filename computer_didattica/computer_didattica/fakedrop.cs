using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Media;

namespace FakeDragAndDrop
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label lblDragger;
        private PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            SystemSounds.Beep.Play();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDragger = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDragger
            // 
            this.lblDragger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDragger.Image = ((System.Drawing.Image)(resources.GetObject("lblDragger.Image")));
            this.lblDragger.Location = new System.Drawing.Point(23, 39);
            this.lblDragger.Name = "lblDragger";
            this.lblDragger.Size = new System.Drawing.Size(72, 56);
            this.lblDragger.TabIndex = 2;
            this.lblDragger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblDragger_MouseMove);
            this.lblDragger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDragger_MouseDown);
            this.lblDragger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblDragger_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.Location = new System.Drawing.Point(164, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 106);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragOver);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lblDragger);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Fake Drag And Drop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        /////// <summary>
        /////// The main entry point for the application.
        /////// </summary>
        ////[STAThread]
        ////static void Main() 
        ////{
        ////    Application.Run(new Form1());
        ////}

		// Keep track of when fake "drag and drop" mode is enabled.
		private bool isDragging = false;

		// Store the location where the user clicked the control.
		private int clickOffsetX, clickOffsetY;

		// Start dragging.
		private void lblDragger_MouseDown(System.Object sender,
			System.Windows.Forms.MouseEventArgs e)
		{
            Label lbl = (Label)sender;
            lbl.DoDragDrop(lbl.Name, DragDropEffects.Copy);
            isDragging = true;
			clickOffsetX = e.X;
			clickOffsetY = e.Y;
		}

		// End dragging.
		private void lblDragger_MouseUp(System.Object sender,
			System.Windows.Forms.MouseEventArgs e)
		{
			isDragging = false;

		}

		// Move the control (during dragging).
		private void lblDragger_MouseMove(System.Object sender,
			System.Windows.Forms.MouseEventArgs e)
		{
			if (isDragging == true)
			{
				// The control coordinates are converted into form coordinates
				// by adding the label position offset.
				// The offset where the user clicked in the control is also
				// accounted for. Otherwise, it looks like the top-left corner
				// of the label is attached to the mouse.
				lblDragger.Left = e.X + lblDragger.Left - clickOffsetX;
				lblDragger.Top = e.Y + lblDragger.Top - clickOffsetY;
			}
		}

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void pictureBox1_DragOver(object sender, DragEventArgs e)
        {

        }

	}
}
