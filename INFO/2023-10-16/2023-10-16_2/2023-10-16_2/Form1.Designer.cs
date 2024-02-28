namespace _2023_10_16_2 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Carta = new PictureBox();
            Forbici = new PictureBox();
            Sasso = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Umano = new PictureBox();
            PC = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Carta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Forbici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sasso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Umano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PC).BeginInit();
            SuspendLayout();
            // 
            // Carta
            // 
            Carta.Image = Properties.Resources.Carta;
            Carta.Location = new Point(63, 25);
            Carta.Name = "Carta";
            Carta.Size = new Size(100, 129);
            Carta.SizeMode = PictureBoxSizeMode.StretchImage;
            Carta.TabIndex = 0;
            Carta.TabStop = false;
            Carta.Click += Carta_Click;
            // 
            // Forbici
            // 
            Forbici.Image = Properties.Resources.Forbici;
            Forbici.Location = new Point(63, 160);
            Forbici.Name = "Forbici";
            Forbici.Size = new Size(100, 129);
            Forbici.SizeMode = PictureBoxSizeMode.StretchImage;
            Forbici.TabIndex = 1;
            Forbici.TabStop = false;
            Forbici.Click += Forbici_Click;
            // 
            // Sasso
            // 
            Sasso.Image = Properties.Resources.Sasso;
            Sasso.Location = new Point(63, 295);
            Sasso.Name = "Sasso";
            Sasso.Size = new Size(100, 129);
            Sasso.SizeMode = PictureBoxSizeMode.StretchImage;
            Sasso.TabIndex = 2;
            Sasso.TabStop = false;
            Sasso.Click += Sasso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 77);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Umano";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(545, 77);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 4;
            label2.Text = "PC";
            // 
            // Umano
            // 
            Umano.Location = new Point(334, 113);
            Umano.Name = "Umano";
            Umano.Size = new Size(100, 50);
            Umano.SizeMode = PictureBoxSizeMode.AutoSize;
            Umano.TabIndex = 5;
            Umano.TabStop = false;
            // 
            // PC
            // 
            PC.Location = new Point(508, 113);
            PC.Name = "PC";
            PC.Size = new Size(100, 50);
            PC.SizeMode = PictureBoxSizeMode.AutoSize;
            PC.TabIndex = 6;
            PC.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 229);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 229);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(289, 325);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "Punti:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 325);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(545, 325);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 11;
            label7.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(579, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PC);
            Controls.Add(Umano);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Sasso);
            Controls.Add(Forbici);
            Controls.Add(Carta);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Carta).EndInit();
            ((System.ComponentModel.ISupportInitialize)Forbici).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sasso).EndInit();
            ((System.ComponentModel.ISupportInitialize)Umano).EndInit();
            ((System.ComponentModel.ISupportInitialize)PC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Carta;
        private PictureBox Forbici;
        private PictureBox Sasso;
        private Label label1;
        private Label label2;
        private PictureBox Umano;
        private PictureBox PC;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}