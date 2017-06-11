using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace computer_didattica
{
	public partial class Palette2 : Form
	{
		public Palette2()
		{
			InitializeComponent();
		}

		private void lbl_MouseDown(object sender, MouseEventArgs e)
		{
			Label lbl = (Label)sender;
            lbl.DoDragDrop(lbl.Name, DragDropEffects.None);

		}

        private void lblPictureOne_Click(object sender, EventArgs e)
        {

        }
	}
}