using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace computer_didattica
{
    public partial class intro : Form
    {
        //variabile che controlla se una form è già aperta
        private bool formclosed = true;

        public intro()
        {
            InitializeComponent();
        }

        private void scopri_Click(object sender, EventArgs e)
        {
            if(formclosed) {
            scopri sc = new scopri();
            sc.Show();
            formclosed = false;
            sc.FormClosed += new FormClosedEventHandler(sc_FormClosed);
            }
        }

        void sc_FormClosed(object sender, FormClosedEventArgs e)
        {
            formclosed = true;
        }

        private void quiz_Click(object sender, EventArgs e)
        {
            if (formclosed)
            {
                DrawingArea dr = new DrawingArea();
                dr.Show();
                formclosed = false;
                dr.FormClosed += new FormClosedEventHandler(sc_FormClosed);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void puzzle_Click(object sender, EventArgs e)
        {
            try{
            //Process.Start(Application.StartupPath + @"\puzzle\Pickture.exe");
            ProcessStartInfo startInfo = new ProcessStartInfo(Application.StartupPath + "\\Pickture.exe");
            //startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            Process.Start(startInfo); }

            //startInfo.Arguments = "www.northwindtraders.com";

            //Process.Start(startInfo);
            catch (Exception ex) { MessageBox.Show(ex.Message);}

        }

        private void scopri_MouseEnter(object sender, EventArgs e)
        {
            scopri.BackColor = Color.Red;
        }

        private void scopri_MouseLeave(object sender, EventArgs e)
        {
            scopri.BackColor = Color.CornflowerBlue;
        }
        
        private void scopri_MouseDown(object sender, MouseEventArgs e)
        {
            scopri.BackColor = Color.GreenYellow;
        }

        private void quiz_MouseEnter(object sender, EventArgs e)
        {
            quiz.BackColor = Color.Red;
        }

        private void quiz_MouseLeave(object sender, EventArgs e)
        {
            quiz.BackColor = Color.PaleVioletRed;
        }


        private void puzzle_MouseEnter(object sender, EventArgs e)
        {
            puzzle.BackColor = Color.Red;
        }

        private void puzzle_MouseLeave(object sender, EventArgs e)
        {
            puzzle.BackColor = Color.LightSlateGray;
        }

        private void puzzle_MouseDown(object sender, MouseEventArgs e)
        {
            puzzle.BackColor = Color.GreenYellow;
        }

        private void quiz_MouseDown(object sender, MouseEventArgs e)
        {
            quiz.BackColor = Color.GreenYellow;
        }

    }
}