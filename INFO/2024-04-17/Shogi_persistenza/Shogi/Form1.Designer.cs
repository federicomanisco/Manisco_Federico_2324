namespace Shogi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.kubomawashi1 = new System.Windows.Forms.PictureBox();
            this.kubomawashi2 = new System.Windows.Forms.PictureBox();
            this.pbox_timer1 = new System.Windows.Forms.PictureBox();
            this.pbox_timer2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Min1 = new System.Windows.Forms.Label();
            this.lbl_Sec1 = new System.Windows.Forms.Label();
            this.lbl_Min2 = new System.Windows.Forms.Label();
            this.lbl_Sec2 = new System.Windows.Forms.Label();
            this.SalvaPartita = new System.Windows.Forms.Button();
            this.CaricaPartita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kubomawashi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kubomawashi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_timer2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(830, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 11);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(193, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 11);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(134, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 11);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(406, 115);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 11);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // kubomawashi1
            // 
            this.kubomawashi1.Location = new System.Drawing.Point(144, 252);
            this.kubomawashi1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kubomawashi1.Name = "kubomawashi1";
            this.kubomawashi1.Size = new System.Drawing.Size(114, 67);
            this.kubomawashi1.TabIndex = 4;
            this.kubomawashi1.TabStop = false;
            // 
            // kubomawashi2
            // 
            this.kubomawashi2.Location = new System.Drawing.Point(393, 457);
            this.kubomawashi2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kubomawashi2.Name = "kubomawashi2";
            this.kubomawashi2.Size = new System.Drawing.Size(114, 67);
            this.kubomawashi2.TabIndex = 5;
            this.kubomawashi2.TabStop = false;
            // 
            // pbox_timer1
            // 
            this.pbox_timer1.Location = new System.Drawing.Point(89, 365);
            this.pbox_timer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbox_timer1.Name = "pbox_timer1";
            this.pbox_timer1.Size = new System.Drawing.Size(83, 159);
            this.pbox_timer1.TabIndex = 6;
            this.pbox_timer1.TabStop = false;
            // 
            // pbox_timer2
            // 
            this.pbox_timer2.Location = new System.Drawing.Point(193, 365);
            this.pbox_timer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbox_timer2.Name = "pbox_timer2";
            this.pbox_timer2.Size = new System.Drawing.Size(83, 159);
            this.pbox_timer2.TabIndex = 7;
            this.pbox_timer2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // lbl_Min1
            // 
            this.lbl_Min1.AutoSize = true;
            this.lbl_Min1.Location = new System.Drawing.Point(311, 299);
            this.lbl_Min1.Name = "lbl_Min1";
            this.lbl_Min1.Size = new System.Drawing.Size(50, 20);
            this.lbl_Min1.TabIndex = 9;
            this.lbl_Min1.Text = "label1";
            // 
            // lbl_Sec1
            // 
            this.lbl_Sec1.AutoSize = true;
            this.lbl_Sec1.Location = new System.Drawing.Point(311, 335);
            this.lbl_Sec1.Name = "lbl_Sec1";
            this.lbl_Sec1.Size = new System.Drawing.Size(50, 20);
            this.lbl_Sec1.TabIndex = 10;
            this.lbl_Sec1.Text = "label2";
            // 
            // lbl_Min2
            // 
            this.lbl_Min2.AutoSize = true;
            this.lbl_Min2.Location = new System.Drawing.Point(424, 159);
            this.lbl_Min2.Name = "lbl_Min2";
            this.lbl_Min2.Size = new System.Drawing.Size(50, 20);
            this.lbl_Min2.TabIndex = 11;
            this.lbl_Min2.Text = "label3";
            // 
            // lbl_Sec2
            // 
            this.lbl_Sec2.AutoSize = true;
            this.lbl_Sec2.Location = new System.Drawing.Point(424, 196);
            this.lbl_Sec2.Name = "lbl_Sec2";
            this.lbl_Sec2.Size = new System.Drawing.Size(50, 20);
            this.lbl_Sec2.TabIndex = 12;
            this.lbl_Sec2.Text = "label4";
            // 
            // SalvaPartita
            // 
            this.SalvaPartita.Location = new System.Drawing.Point(514, 669);
            this.SalvaPartita.Name = "SalvaPartita";
            this.SalvaPartita.Size = new System.Drawing.Size(134, 64);
            this.SalvaPartita.TabIndex = 13;
            this.SalvaPartita.Text = "Salva Partita";
            this.SalvaPartita.UseVisualStyleBackColor = true;
            this.SalvaPartita.Click += new System.EventHandler(this.SalvaPartita_Click);
            // 
            // CaricaPartita
            // 
            this.CaricaPartita.Location = new System.Drawing.Point(514, 599);
            this.CaricaPartita.Name = "CaricaPartita";
            this.CaricaPartita.Size = new System.Drawing.Size(134, 64);
            this.CaricaPartita.TabIndex = 14;
            this.CaricaPartita.Text = "Carica Partita";
            this.CaricaPartita.UseVisualStyleBackColor = true;
            this.CaricaPartita.Click += new System.EventHandler(this.CaricaPartita_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 837);
            this.Controls.Add(this.CaricaPartita);
            this.Controls.Add(this.SalvaPartita);
            this.Controls.Add(this.lbl_Sec2);
            this.Controls.Add(this.lbl_Min2);
            this.Controls.Add(this.lbl_Sec1);
            this.Controls.Add(this.lbl_Min1);
            this.Controls.Add(this.pbox_timer2);
            this.Controls.Add(this.pbox_timer1);
            this.Controls.Add(this.kubomawashi2);
            this.Controls.Add(this.kubomawashi1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Shogi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kubomawashi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kubomawashi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_timer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox kubomawashi1;
        private PictureBox kubomawashi2;
        private PictureBox pbox_timer1;
        private PictureBox pbox_timer2;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_Min1;
        private Label lbl_Sec1;
        private Label lbl_Min2;
        private Label lbl_Sec2;
        private Button SalvaPartita;
        private Button CaricaPartita;
    }
}