using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace computer_didattica
{
	public partial class DrawingArea : Form
	{

        //private Image ventola;
        //private Image schedavideo;
        //private Image ram;
        //private Image cpu;
        //private Image rete;
        //private Image tastiera;
        //private Image alimentatore;

        private Image immagine0;
        private Image immagine1;
        private Image immagine2;
        private Image immagine3;
        private Image immagine4;
        private Image immagine5;
        private Image immagine6;

        private Image immagine0sp;
        private Image immagine1sp;
        private Image immagine2sp;
        private Image immagine3sp;
        private Image immagine4sp;
        private Image immagine5sp;
        private Image immagine6sp;

        private Image ok;

        //rays
        private Image[] myImgArray;
        private string[] nomiSette;
        private string[] nomi;
        private string[] nomiToolTip;
        private Image[] myImgSpArray;
        private int[] index;
        private int[] indexNomi;

        //sound
        private SoundPlayer sound;
        //random number to play audio
        Random rndAudio;
        //variabile che conserva se è la fine del quiz
        private int win;
        
        
        public DrawingArea()
		{
			InitializeComponent();

            
             // Creates and initializes a new integer array and a new Object array.
           
            
            //load images
            ////ventola = Image.FromFile(Application.StartupPath + @"\images\parts\ventola.jpg");
            ////schedavideo = Image.FromFile(Application.StartupPath + @"\images\parts\schedavideo.jpg");       
            ////ram = Image.FromFile(Application.StartupPath + @"\images\parts\ram.jpg");
            ////cpu = Image.FromFile(Application.StartupPath + @"\images\parts\cpu.jpg");            
            ////rete = Image.FromFile(Application.StartupPath + @"\images\parts\rete.jpg");           
            ////tastiera = Image.FromFile(Application.StartupPath + @"\images\parts\tastiera.jpg");
            ////alimentatore = Image.FromFile(Application.StartupPath + @"\images\parts\alimentatore.jpg");
            ////Image[] myImgArray = new Image[7] { "alimentatore","case","cpu","discofisso","lettore","monitor","mouse","ram","rete","schedaaudio","schedamadre","schedavideo","tastiera","ventola"};
            ////myImgArray = shuffle(myImgArray);       
            ////pictureBox1.Image = myImgArray[0];
            ////pictureBox2.Image = myImgArray[1];
            ////pictureBox3.Image = myImgArray[2];
            ////pictureBox4.Image = myImgArray[3];
            ////pictureBox5.Image = myImgArray[4];
            ////pictureBox6.Image = myImgArray[5];
            ////pictureBox7.Image = myImgArray[6];



            //fai array con i nomi delle immagini senza prefisso
            nomi = new string[] { "alimentatore","case","cpu","discofisso","lettore","monitor","mouse","ram","rete","schedaaudio","schedamadre","schedavideo","tastiera","ventola","gruppocont"};
            nomiToolTip = new string[] { "ALIMENTATORE", "CASE", "CPU", "DISCO FISSO", "LETTORE CD/DVD", "MONITOR", "MOUSE", "RAM", "SCHEDA DI RETE", "SCHEDA AUDIO", "SCHEDA MADRE", "SCHEDA VIDEO", "TASTIERA", "VENTOLA","GRUPPO DI CONTINUITA'" };
            //////mischia array
            ////nomi = shuffleStrings(nomi);


            //crea un nuovo array con  sette numeri (0-14)
            indexNomi = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14};
            //mischia array
            indexNomi = shuffleInt(indexNomi);
            
            //seleziona i primi sette nomi
            nomiSette= new string[]{nomi[indexNomi[0]],nomi[indexNomi[1]],nomi[indexNomi[2]],nomi[indexNomi[3]],nomi[indexNomi[4]],nomi[indexNomi[5]],nomi[indexNomi[6]]};
            nomiToolTip = new string[] { nomiToolTip[indexNomi[0]], nomiToolTip[indexNomi[1]], nomiToolTip[indexNomi[2]], nomiToolTip[indexNomi[3]], nomiToolTip[indexNomi[4]], nomiToolTip[indexNomi[5]], nomiToolTip[indexNomi[6]] };

            ////seleziona i primi sette nomi
            //nomiSette= new string[]{nomi[0],nomi[1],nomi[2],nomi[3],nomi[4],nomi[5],nomi[6]};
            
            
            
            //crea sette immagini usando il nome e fai array con immagini
            immagine0 = Image.FromFile(Application.StartupPath + @"\images\parts\"+nomiSette[0]+".jpg");
            immagine1 = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[1] + ".jpg");
            immagine2 = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[2] + ".jpg");
            immagine3 = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[3] + ".jpg");
            immagine4 = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[4] + ".jpg");
            immagine5 = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[5] + ".jpg");
            immagine6 = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[6] + ".jpg");

            myImgArray = new Image[7] { immagine0,immagine1,immagine2,immagine3,immagine4,immagine5,immagine6};

            //crea sette immagini con le spiegazioni e fai l'array con le iimmagini
            immagine0sp = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[0] + "sp"+ ".jpg");
            immagine1sp = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[1] + "sp" + ".jpg");
            immagine2sp = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[2] + "sp" + ".jpg");
            immagine3sp = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[3] + "sp" + ".jpg");
            immagine4sp = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[4] + "sp" + ".jpg");
            immagine5sp = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[5] + "sp" + ".jpg");
            immagine6sp = Image.FromFile(Application.StartupPath + @"\images\parts\" + nomiSette[6] + "sp" + ".jpg");

            myImgSpArray = new Image[7] { immagine0sp, immagine1sp, immagine2sp, immagine3sp, immagine4sp, immagine5sp, immagine6sp};
            
            //cambia nome alle picturebox usando thumb+nome
            pictureBox0.Name = "thumb" + nomiSette[0];
            pictureBox1.Name = "thumb" + nomiSette[1];
            pictureBox2.Name = "thumb" + nomiSette[2];
            pictureBox3.Name = "thumb" + nomiSette[3];
            pictureBox4.Name = "thumb" + nomiSette[4];
            pictureBox5.Name = "thumb" + nomiSette[5];
            pictureBox6.Name = "thumb" + nomiSette[6];

            toolTip0.SetToolTip(this.pictureBox0, nomiToolTip[0]);
            toolTip0.SetToolTip(this.pictureBox1, nomiToolTip[1]);
            toolTip0.SetToolTip(this.pictureBox2, nomiToolTip[2]);
            toolTip0.SetToolTip(this.pictureBox3, nomiToolTip[3]);
            toolTip0.SetToolTip(this.pictureBox4, nomiToolTip[4]);
            toolTip0.SetToolTip(this.pictureBox5, nomiToolTip[5]);
            toolTip0.SetToolTip(this.pictureBox6, nomiToolTip[6]);

            //asegna immagini a picturebox
            pictureBox0.Image = immagine0;
            pictureBox1.Image = immagine1;
            pictureBox2.Image = immagine2;
            pictureBox3.Image = immagine3;
            pictureBox4.Image = immagine4;
            pictureBox5.Image = immagine5;
            pictureBox6.Image = immagine6;

            //crea un nuovo array con  sette numeri (0-6)
            index = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            //mischia array
            index = shuffleInt(index);
            
            //estrai numero dall'ultimo array che  userai come indice per estrarre immagine e sfondo

            //assegna in progressione le immagini di sfondo
            picDrawingArea0.Image = myImgSpArray[index[0]];
            picDrawingArea1.Image = myImgSpArray[index[1]];
            picDrawingArea2.Image = myImgSpArray[index[2]];
            picDrawingArea3.Image = myImgSpArray[index[3]];
            picDrawingArea4.Image = myImgSpArray[index[4]];
            picDrawingArea5.Image = myImgSpArray[index[5]];
            picDrawingArea6.Image = myImgSpArray[index[6]];

            //nell'interrogazione del drag-drop usa indice in sequenza

            //per cancellare l'immagine usa sempre l'array con i nomi per selezionare loa picturebox

            //crea immagine di sfondo per gli indovinati
            ok = Image.FromFile(Application.StartupPath + @"\images\parts\ok.jpg");

            // Create an instance of the Sound class.
            sound = new SoundPlayer();

            //initialize variable
            win = 0;
            
            //inizializza random
            rndAudio=new Random();

		}

		private void DrawingArea_Load(object sender, EventArgs e)
		{
			//Palette frmTool = new Palette();
			//this.AddOwnedForm(frmTool);
			//frmTool.Show();
			picDrawingArea0.AllowDrop = true;
            picDrawingArea1.AllowDrop = true;
            picDrawingArea2.AllowDrop = true;
            picDrawingArea3.AllowDrop = true;
            picDrawingArea4.AllowDrop = true;
            picDrawingArea5.AllowDrop = true;
            picDrawingArea6.AllowDrop = true;
		}

       
        private static void dragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void manageData(int id,PictureBox pB,DragEventArgs e)
        {
            //Image.FromFile(Application.StartupPath + @"\images\vantola.jpg");
            if (myImgArray[index[id]] == (((Image)e.Data.GetData(DataFormats.Bitmap))))
            {
                pB.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                win += 1;
                applauso();
                pB.Enabled = false;
                cancelPic(id, this);
            }
            else
            {
                buuu();
            }
            //picDrawingArea.SizeMode = PictureBoxSizeMode.StretchImage;
            //Graphics g = picDrawingArea.CreateGraphics();
            //g.DrawImage((Image)e.Data.GetData(DataFormats.Bitmap),
            //    new Point(e.X - this.Left - 12, e.Y - this.Top - 30));
        }

        private void picDrawingArea0_DragEnter(object sender, DragEventArgs e)
        {
            dragEnter(e);
        }


        private void picDrawingArea0_DragDrop(object sender, DragEventArgs e)
        {
            manageData(0, picDrawingArea0, e);

        }
        private void picDrawingArea1_DragEnter(object sender, DragEventArgs e)
        {
            dragEnter(e);
        }
        private void picDrawingArea1_DragDrop(object sender, DragEventArgs e)
        {
            manageData(1, picDrawingArea1, e);
        }
        private void cancelPic(int id, Control control)
        {
            string ctrlName="thumb" + nomiSette[index[id]];
            //foreach (Control ctrl in this.Controls) {
            
            if (control.GetType()==typeof(PictureBox))
            {
                if (control.Name == ctrlName)
                {                
                //assegnas immagine ok allo sfondo
                PictureBox pic = (PictureBox)control;
                pic.Image = ok;
                //pic.MouseLeave -= new System.EventHandler(this.pictureBox_MouseLeave);
                //pic.MouseEnter -= new System.EventHandler(this.pictureBox_MouseEnter);
                //pic.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
                //pic.Cursor = Cursors.Default;
                pic.Enabled = false;
                }
            }
            else { 
                foreach (Control child in control.Controls) {                
                cancelPic(id,child);                
                }
            }
         }               
        private void picDrawingArea2_DragEnter(object sender, DragEventArgs e)
        {
            dragEnter(e);
        }
        private void picDrawingArea2_DragDrop(object sender, DragEventArgs e)
        {
            manageData(2, picDrawingArea2, e);
        }
        private void picDrawingArea3_DragEnter(object sender, DragEventArgs e)
        {
            dragEnter(e);
        }
        private void picDrawingArea3_DragDrop(object sender, DragEventArgs e)
        {
            manageData(3, picDrawingArea3, e);
        }
        private void picDrawingArea4_DragEnter(object sender, DragEventArgs e)
        {
            dragEnter(e);
        }
        private void picDrawingArea4_DragDrop(object sender, DragEventArgs e)
        {
            manageData(4, picDrawingArea4, e);
        }
        private void picDrawingArea5_DragEnter(object sender, DragEventArgs e)
        {
            dragEnter(e);
        }
        private void picDrawingArea5_DragDrop(object sender, DragEventArgs e)
        {
            manageData(5, picDrawingArea5, e);
        }
        private void picDrawingArea6_DragEnter(object sender, DragEventArgs e)
        {
            dragEnter(e);
        }
        private void picDrawingArea6_DragDrop(object sender, DragEventArgs e)
        {
            manageData(6, picDrawingArea6, e);
        }
        
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox lbl = (PictureBox)sender;
            lbl.DoDragDrop(lbl.Image, DragDropEffects.Copy);
        }
        private void buuu()
        {
            int number = rndAudio.Next(8);
            string path = "";
            switch (number)
            {
                case 0:
                    path = "\\sound\\no\\abbaia.wav";
                    break;
                case 1:
                    path = "\\sound\\no\\au.wav";
                    break;
                case 2:
                    path = "\\sound\\no\\buu.wav";
                    break;
                case 3:
                    path = "\\sound\\no\\gulp.wav";
                    break;
                case 4:
                    path = "\\sound\\no\\risata1.wav";
                    break;
                case 5:
                    path = "\\sound\\no\\risata2.wav";
                    break;
                case 6:
                    path = "\\sound\\no\\risata3.wav";
                    break;
                case 7:
                    path = "\\sound\\no\\tosse.wav";
                    break;
                default:
                    break;
            }

            try
            {
                // Assign the selected file's path to 
                // the Sound object.  
                sound.SoundLocation = (Application.StartupPath + path);

                // Load the .wav file.

                sound.Play();
            }
            catch (Exception ex)
            {

            }
        } 
        private void applauso()
        {            
            if (win!=7){
                int number = rndAudio.Next(3);
                string path = "";
                switch (number)
                {
                    case 0:
                        path = "\\sound\\si\\heys.wav";
                        break;
                    case 1:
                        path = "\\sound\\si\\yeha.wav";
                        break;
                    case 2:
                        path = "\\sound\\si\\yes.wav";
                        break;
                    default:
                        break;
                }   
            try
                {
                    // Assign the selected file's path to 
                    // the Sound object.  
                    sound.SoundLocation = (Application.StartupPath + path);

                    // Load the .wav file.

                    sound.Play();
                }
                catch (Exception ex)
                {                  
                }
            
            //SystemSounds.Exclamation.Play();
            }
            else {
                try
                {
                    // Assign the selected file's path to 
                    // the Sound object.  
                    sound.SoundLocation = (Application.StartupPath + @"\sound\si\applauso.wav");

                    // Load the .wav file.

                    sound.Play();
                }
                catch (Exception ex)
                {
                }                        
            }
        }

        private Image[] shuffleImages(Image[] arrayst)
        {
            Random rnd = new Random();
            for (int i = arrayst.Length - 1; i > 0; i--)
            {
                // Set swapWithPos a random position such that 0 <= swapWithPos <= i
                int swapWithPos = rnd.Next(i + 1);
                // Swap the value at the "current" position (i) with value at swapWithPos
                Image tmp = arrayst[i];
                arrayst[i] = arrayst[swapWithPos];
                arrayst[swapWithPos] = tmp;                
            } 
            return arrayst;
        }
        private string[] shuffleStrings(string[] arrayst)
        {
            Random rnd = new Random();

            for (int i = arrayst.Length - 1; i > 0; i--)
            {
                // Set swapWithPos a random position such that 0 <= swapWithPos <= i
                int swapWithPos = rnd.Next(i + 1);

                // Swap the value at the "current" position (i) with value at swapWithPos
                string tmp = arrayst[i];
                arrayst[i] = arrayst[swapWithPos];
                arrayst[swapWithPos] = tmp;
            }
            return arrayst;
        }
        private int[] shuffleInt(int[] arrayst)
        {
            Random rnd = new Random();

            for (int i = arrayst.Length - 1; i > 0; i--)
            {
                // Set swapWithPos a random position such that 0 <= swapWithPos <= i
                int swapWithPos = rnd.Next(i + 1);

                // Swap the value at the "current" position (i) with value at swapWithPos
                int tmp = arrayst[i];
                arrayst[i] = arrayst[swapWithPos];
                arrayst[swapWithPos] = tmp;
            }
            return arrayst;
        }

        private void buttonRiprova_Click(object sender, EventArgs e)
        {
            DrawingArea dr = new DrawingArea();
            dr.Show();
            this.Close();
        }

        private void DrawingArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            sound.Stop();
        }

        //private void pictureBox0_MouseEnter(object sender, EventArgs e)
        //{
        //    pictureBoxBorderEnter(pictureBox0);
        //}

        //private void pictureBox0_MouseLeave(object sender, EventArgs e)
        //{
        //    pictureBoxBorderLeave(pictureBox0);
        //}
        
        //private void pictureBox1_MouseEnter(object sender, EventArgs e)
        //{
        //    pictureBoxBorderEnter(pictureBox1);
        //}

        //private void pictureBox1_MouseLeave(object sender, EventArgs e)
        //{
        //    pictureBoxBorderLeave(pictureBox1);
        //}

        //private void pictureBox2_MouseEnter(object sender, EventArgs e)
        //{
        //    pictureBoxBorderEnter(pictureBox2);
        //}

        //private void pictureBox2_MouseLeave(object sender, EventArgs e)
        //{
        //    pictureBoxBorderLeave(pictureBox2);
        //}

        //private void pictureBox3_MouseEnter(object sender, EventArgs e)
        //{
        //    pictureBoxBorderEnter(pictureBox3);
        //}

        //private void pictureBox3_MouseLeave(object sender, EventArgs e)
        //{
        //    pictureBoxBorderLeave(pictureBox3);
        //}

        //private void pictureBox4_MouseEnter(object sender, EventArgs e)
        //{
        //    pictureBoxBorderEnter(pictureBox4);
        //}

        //private void pictureBox4_MouseLeave(object sender, EventArgs e)
        //{
        //    pictureBoxBorderLeave(pictureBox4);
        //}

        //private void pictureBox5_MouseEnter(object sender, EventArgs e)
        //{
        //    pictureBoxBorderEnter(pictureBox5);
        //}

        //private void pictureBox5_MouseLeave(object sender, EventArgs e)
        //{
        //    pictureBoxBorderLeave(pictureBox5);
        //}

        //private void pictureBox6_MouseEnter(object sender, EventArgs e)
        //{
        //    pictureBoxBorderEnter(pictureBox6);
        //}
        //private void pictureBox6_MouseLeave(object sender, EventArgs e)
        //{
        //    pictureBoxBorderLeave(pictureBox6);
        //}
        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBorderEnter((PictureBox)sender);
        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBorderLeave((PictureBox)sender);
        }
        private void pictureBoxBorderEnter(PictureBox pc)
        {
            pc.BorderStyle = BorderStyle.Fixed3D;
        }       
        private void pictureBoxBorderLeave(PictureBox pc)
        {
            pc.BorderStyle = BorderStyle.None;
        }


	}
}



//#include <windows.h>
//#include <gdiplus.h>
//#include <stdio.h>
//using namespace Gdiplus;
//INT main()
//{
//   // Initialize <tla rid="tla_gdiplus"/>.
//   GdiplusStartupInput gdiplusStartupInput;
//   ULONG_PTR gdiplusToken;
//   GdiplusStartup(&gdiplusToken, &gdiplusStartupInput, NULL);
//   Status stat;
//   CLSID  clsid;
//   char   propertyValue[] = "Fake Photograph";
//   Bitmap* bitmap = new Bitmap(L"FakePhoto.jpg");
//   PropertyItem* propertyItem = new PropertyItem;
//   // Get the CLSID of the JPEG encoder.
//   GetEncoderClsid(L"image/jpeg", &clsid);
//   propertyItem->id = PropertyTagImageTitle;
//   propertyItem->length = 16;  // string length including NULL terminator
//   propertyItem->type = PropertyTagTypeASCII; 
//   propertyItem->value = propertyValue;
//   bitmap->SetPropertyItem(propertyItem);
//   stat = bitmap->Save(L"FakePhoto2.jpg", &clsid, NULL);
//   if(stat == Ok)
//      printf("FakePhoto2.jpg saved successfully.\n");
   
//   delete propertyItem;
//   delete bitmap;
//   GdiplusShutdown(gdiplusToken);
//   return 0;
//}