using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace computer_didattica
{
	public partial class Palette : Form
	{
        Image img;
        Image newImg;
        public Palette()
		{
			InitializeComponent();
            img= Bitmap.FromFile(Application.StartupPath + @"\images\Immagine.jpg");
            System.Drawing.Imaging.PropertyItem propTemp = img.GetPropertyItem(37510);// Keywords

            ////for debug
            byte[] Value = propTemp.Value;
            Encoding ascii = Encoding.ASCII;
            char[] asciiChars = new char[ascii.GetCharCount(Value, 0, Value.Length)];           
            ascii.GetChars(Value, 0, Value.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);
            MessageBox.Show(asciiString);
            ////////////////////77
                          
            
            byte[] newValue = System.Text.ASCIIEncoding.ASCII.GetBytes("ventola");           
            propTemp.Len = newValue.Length;
            propTemp.Value = newValue;
            
            ///open image and save a new image with propertyitem
            newImg = Bitmap.FromFile(Application.StartupPath + @"\images\ventola.jpg");
            newImg.SetPropertyItem(propTemp);
            newImg.Save(Application.StartupPath + @"\images\ventola2.jpg");

		}

		private void lbl_MouseDown(object sender, MouseEventArgs e)
		{
			Label lbl = (Label)sender;
            lbl.DoDragDrop(lbl.Image, DragDropEffects.Copy);

		}
        private void lbl2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox lbl = (PictureBox)sender;
            lbl.DoDragDrop(lbl.Image, DragDropEffects.Copy);

        }

        //for debug
        private void button1_Click(object sender, EventArgs e)
        {
            Image newImg2;
            newImg2 = Bitmap.FromFile(Application.StartupPath + @"\images\ventola2.jpg");
            System.Drawing.Imaging.PropertyItem propTemp = newImg2.GetPropertyItem(37510);// Keyword
            byte[] Value = propTemp.Value;
            Encoding ascii = Encoding.ASCII;
            char[] asciiChars = new char[ascii.GetCharCount(Value, 0, Value.Length)];
            ascii.GetChars(Value, 0, Value.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);
            MessageBox.Show(asciiString);
            MessageBox.Show(("ventola\0" == asciiString).ToString());

        }
	}
  
}