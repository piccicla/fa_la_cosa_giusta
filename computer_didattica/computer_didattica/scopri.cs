using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuartzTypeLib;

namespace computer_didattica
{
    public partial class scopri : Form
    {
        // Define constants used for specifying the window style.
        private const int WM_APP = 0x8000;
        private const int WM_GRAPHNOTIFY = WM_APP + 1;
        private const int EC_COMPLETE = 0x01;
        private const int WS_CHILD = 0x40000000;
        private const int WS_CLIPCHILDREN = 0x2000000;
        // Hold a form-level reference to the media control interface,
        // so the code can control playback of the currently loaded
        // movie.
        private IMediaControl mc = null;
       
        // Hold a form-level reference to the video window in case it
        // needs to be resized.
        private IVideoWindow videoWindow = null;

        // Load the movie file.
        FilgraphManager graphManager;

        //indirizzo video
        string pathVideo="";
        
        public scopri()
        {
            InitializeComponent();
        }

        private void playVideo(string videoPath)
        {
            if(pathVideo!=""){
            // Stop the playback for the current movie, if it exists.
            if (mc != null) mc.Stop();
            mc = null;
            videoWindow = null;
            graphManager = null;
            // Load the quartz graphmanager
            graphManager = new FilgraphManager();
            graphManager.RenderFile(videoPath);

            // Attach the view to a picture box on the form.
            try
            {
                videoWindow = (IVideoWindow)graphManager;
                videoWindow.Owner = (int)pictureBoxVideo.Handle;
                videoWindow.WindowStyle = WS_CHILD | WS_CLIPCHILDREN;
                videoWindow.SetWindowPosition(pictureBoxVideo.ClientRectangle.Left,
                    pictureBoxVideo.ClientRectangle.Top,
                    pictureBoxVideo.ClientRectangle.Width,
                    pictureBoxVideo.ClientRectangle.Height);
            }
            catch
            {
                // An error can occur if the file does not have a vide
                // source (for example, an MP3 file.)
                // You can ignore this error and still allow playback to
                // continue (without any visualization).
            }
            // Start the playback (asynchronously).
            mc = (IMediaControl)graphManager;
            mc.Run();
            }
        }
        
        private void showText(string textPath)
        {
            this.richTextSpiega.Text = "";
            //playVideo(Application.StartupPath + videoPath);
            try
            {
                this.richTextSpiega.LoadFile(Application.StartupPath + textPath);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void showTextVideo(string videoPath,string textPath, string thumbPath)
        {
            stopMovie();
            //sposta l'immagine del video nella picture box nascosta
            if (videoWindow != null)
            {
                videoWindow.Owner = (int)pictureBoxHide.Handle;
            }
            //assegna il nuovo path video
            pathVideo = videoPath;
            //mostra il testo
            showText(textPath);
            pictureBoxVideo.ImageLocation = Application.StartupPath+thumbPath;
        }

        #region BUTTON CLICK EVENTS
        private void buttonVentola_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\ventola.avi", @"\text\ventola.rtf", @"\images\videoThumb\ventolaThumb.jpg");
        }
        
        private void buttonScVideo_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\scvideo.avi", @"\text\schedavideo.rtf", @"\images\videoThumb\videoThumb.jpg");
        }
        private void buttonCase_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\case.avi", @"\text\case.rtf", @"\images\videoThumb\caseThumb.jpg");
        }
        private void buttonRam_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\ram.avi", @"\text\ram.rtf", @"\images\videoThumb\ramThumb.jpg");
        }
        private void buttonMonitor_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\monitor.avi", @"\text\monitor.rtf", @"\images\videoThumb\monitorThumb.jpg");
        }
        private void buttonCpu_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\cpu.avi", @"\text\cpu.rtf", @"\images\videoThumb\cpuThumb.jpg");
        }
        private void buttonAlimentatore_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\alimentatore.avi", @"\text\alimentatore.rtf", @"\images\videoThumb\alimentatoreThumb.jpg");
        }
        private void buttonRete_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\screte.avi", @"\text\schedarete.rtf", @"\images\videoThumb\reteThumb.jpg");
        }
        private void buttonCd_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\lettore.avi", @"\text\lettore.rtf", @"\images\videoThumb\lettoreThumb.jpg");
        }
        private void buttonAudio_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\scaudio.avi", @"\text\schedaaudio.rtf", @"\images\videoThumb\audioThumb.jpg");
        }
        private void buttonKey_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\tastiera.avi", @"\text\tastiera.rtf", @"\images\videoThumb\tastieraThumb.jpg");
        }
        private void buttonMouse_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\mouse.avi", @"\text\mouse.rtf", @"\images\videoThumb\mouseThumb.jpg");
        }
        private void buttonHd_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\discofisso.avi", @"\text\discofisso.rtf", @"\images\videoThumb\discofissoThumb.jpg");
        }
        private void buttonMother_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\scmadre.avi", @"\text\schedamadre.rtf", @"\images\videoThumb\madreThumb.jpg");
        }
        private void buttonGruppoCont_Click(object sender, EventArgs e)
        {
            showTextVideo(@"\video\gruppocont.avi", @"\text\gruppoCont.rtf", @"\images\videoThumb\gruppocontThumb.jpg");
        }
        #endregion

        #region MOVIE CONTROL
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            playVideo();
            
        }
        private void playVideo()
        {
            //if (mc != null)
            //mc.Run();
            playVideo(Application.StartupPath + pathVideo);
            buttonPlay.BackColor = Color.Red;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopMovie();
        }

        private void stopMovie()
        {
            // Stop the playback for the current movie, if it exists.
            if (mc != null) mc.Stop();
            buttonPlay.BackColor = Color.WhiteSmoke;
        }
        #endregion

        #region EVENTS
        private void scopri_Load(object sender, EventArgs e)
        {
            this.pictureBoxVideo.ImageLocation = Application.StartupPath + @"\images\logo1.jpg";

            // Load the quartz graphmanager
            //graphManager = new FilgraphManager();                           
        }
        private void scopri_FormClosing(object sender, FormClosingEventArgs e)
        {
            //chiudi video se è aperto 
            if (mc != null) { mc.Stop(); mc = null; }
        }
        #endregion

    }
}