using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace computer_didattica
{
	public partial class DrawingArea2: Form
	{

        private string nome;
        
        public DrawingArea2()
		{
			InitializeComponent();
		}

		private void DrawingArea_Load(object sender, EventArgs e)
		{
			Palette frmTool = new Palette();
			this.AddOwnedForm(frmTool);
			frmTool.Show();
            picDrawingArea.AllowDrop = true;
            //picDrawingArea.DragDrop+=new DragEventHandler(picDrawingArea_DragDrop);
            picDrawingArea2.AllowDrop = true;

		}

		private void picDrawingArea_DragEnter(object sender, DragEventArgs e)
		{
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
            nome=(string)e.Data.GetData(DataFormats.StringFormat);
            if (nome == "lblRam")
            {
                //Graphics g = picDrawingArea.CreateGraphics();
                picDrawingArea.ImageLocation = Application.StartupPath + @"\images\ventola.jpg";

                //g.DrawImage((Image)e.Data.GetData(DataFormats.Bitmap),new Point(e.X - this.Left - 12, e.Y - this.Top - 30));
            }
        }
 
        

        private void picDrawingArea_DragDrop(object sender, DragEventArgs e)
        {}
 

        private void picDrawingArea_DragOver(object sender, DragEventArgs e)
        {

        }

        private void picDrawingArea2_DragEnter(object sender, DragEventArgs e)
        {
            nome = (string)e.Data.GetData(DataFormats.StringFormat);
            if (nome == "lblMother")
            {
                //Graphics g = picDrawingArea.CreateGraphics();
                picDrawingArea2.ImageLocation = Application.StartupPath + @"\images\videocard.jpg";
                //g.DrawImage((Image)e.Data.GetData(DataFormats.Bitmap),new Point(e.X - this.Left - 12, e.Y - this.Top - 30));
            }
        }

       
	}
}