namespace computer_didattica
{
    partial class intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(intro));
            this.scopri = new System.Windows.Forms.Button();
            this.puzzle = new System.Windows.Forms.Button();
            this.quiz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scopri
            // 
            this.scopri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scopri.BackColor = System.Drawing.Color.CornflowerBlue;
            this.scopri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scopri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scopri.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scopri.ForeColor = System.Drawing.Color.White;
            this.scopri.Location = new System.Drawing.Point(364, 300);
            this.scopri.Name = "scopri";
            this.scopri.Size = new System.Drawing.Size(297, 84);
            this.scopri.TabIndex = 0;
            this.scopri.Text = "SCOPRI IL COMPUTER";
            this.scopri.UseCompatibleTextRendering = true;
            this.scopri.UseVisualStyleBackColor = false;
            this.scopri.MouseLeave += new System.EventHandler(this.scopri_MouseLeave);
            this.scopri.Click += new System.EventHandler(this.scopri_Click);
            this.scopri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scopri_MouseDown);
            this.scopri.MouseEnter += new System.EventHandler(this.scopri_MouseEnter);
            // 
            // puzzle
            // 
            this.puzzle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.puzzle.BackColor = System.Drawing.Color.LightSlateGray;
            this.puzzle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.puzzle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.puzzle.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puzzle.ForeColor = System.Drawing.Color.White;
            this.puzzle.Location = new System.Drawing.Point(364, 539);
            this.puzzle.Name = "puzzle";
            this.puzzle.Size = new System.Drawing.Size(297, 84);
            this.puzzle.TabIndex = 1;
            this.puzzle.Text = "COMPUTER PUZZLE";
            this.puzzle.UseCompatibleTextRendering = true;
            this.puzzle.UseVisualStyleBackColor = false;
            this.puzzle.MouseLeave += new System.EventHandler(this.puzzle_MouseLeave);
            this.puzzle.Click += new System.EventHandler(this.puzzle_Click);
            this.puzzle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.puzzle_MouseDown);
            this.puzzle.MouseEnter += new System.EventHandler(this.puzzle_MouseEnter);
            // 
            // quiz
            // 
            this.quiz.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quiz.BackColor = System.Drawing.Color.PaleVioletRed;
            this.quiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quiz.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz.ForeColor = System.Drawing.Color.White;
            this.quiz.Location = new System.Drawing.Point(364, 414);
            this.quiz.Name = "quiz";
            this.quiz.Size = new System.Drawing.Size(297, 84);
            this.quiz.TabIndex = 3;
            this.quiz.Text = "COMPUTER QUIZ";
            this.quiz.UseCompatibleTextRendering = true;
            this.quiz.UseVisualStyleBackColor = false;
            this.quiz.MouseLeave += new System.EventHandler(this.quiz_MouseLeave);
            this.quiz.Click += new System.EventHandler(this.quiz_Click);
            this.quiz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.quiz_MouseDown);
            this.quiz.MouseEnter += new System.EventHandler(this.quiz_MouseEnter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(983, 733);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ESCI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(486, 687);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quiz);
            this.Controls.Add(this.scopri);
            this.Controls.Add(this.puzzle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.Name = "intro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scopri;
        private System.Windows.Forms.Button puzzle;
        private System.Windows.Forms.Button quiz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

