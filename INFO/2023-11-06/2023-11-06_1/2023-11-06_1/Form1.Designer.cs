namespace _2023_11_06_1 {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            Inserisci = new Button();
            Cancella = new Button();
            Modifica = new Button();
            Copia = new Button();
            Svuota = new Button();
            label6 = new Label();
            maxPrezzoLab = new Label();
            minPrezzoLab = new Label();
            avgPrezzoLab = new Label();
            label7 = new Label();
            label9 = new Label();
            monthCalendar1 = new MonthCalendar();
            label8 = new Label();
            Cerca = new Button();
            Reset = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 34);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Titolo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 63);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Prezzo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 92);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 4;
            label4.Text = "Data di acquisto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 277);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 5;
            label5.Text = "Piattaforma:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown1.Location = new Point(153, 57);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(113, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Computer", "PlayStation", "Xbox", "Nintendo" });
            comboBox1.Location = new Point(153, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(401, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(397, 274);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Inserisci
            // 
            Inserisci.Location = new Point(46, 319);
            Inserisci.Name = "Inserisci";
            Inserisci.Size = new Size(95, 23);
            Inserisci.TabIndex = 10;
            Inserisci.Text = "Inserisci";
            Inserisci.UseVisualStyleBackColor = true;
            Inserisci.Click += Inserisci_Click;
            // 
            // Cancella
            // 
            Cancella.Location = new Point(179, 319);
            Cancella.Name = "Cancella";
            Cancella.Size = new Size(95, 23);
            Cancella.TabIndex = 11;
            Cancella.Text = "Cancella";
            Cancella.UseVisualStyleBackColor = true;
            Cancella.Click += Cancella_Click;
            // 
            // Modifica
            // 
            Modifica.Location = new Point(46, 365);
            Modifica.Name = "Modifica";
            Modifica.Size = new Size(95, 23);
            Modifica.TabIndex = 12;
            Modifica.Text = "Modifica";
            Modifica.UseVisualStyleBackColor = true;
            Modifica.Click += Modifica_Click;
            // 
            // Copia
            // 
            Copia.Location = new Point(179, 365);
            Copia.Name = "Copia";
            Copia.Size = new Size(95, 23);
            Copia.TabIndex = 13;
            Copia.Text = "Copia";
            Copia.UseVisualStyleBackColor = true;
            Copia.Click += Copia_Click;
            // 
            // Svuota
            // 
            Svuota.Location = new Point(46, 394);
            Svuota.Name = "Svuota";
            Svuota.Size = new Size(228, 23);
            Svuota.TabIndex = 14;
            Svuota.Text = "Svuota archivio";
            Svuota.UseVisualStyleBackColor = true;
            Svuota.Click += Svuota_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 15;
            label6.Text = "label6";
            // 
            // maxPrezzoLab
            // 
            maxPrezzoLab.AutoSize = true;
            maxPrezzoLab.Location = new Point(401, 327);
            maxPrezzoLab.Name = "maxPrezzoLab";
            maxPrezzoLab.Size = new Size(87, 15);
            maxPrezzoLab.TabIndex = 16;
            maxPrezzoLab.Text = "Prezzo più alto:";
            // 
            // minPrezzoLab
            // 
            minPrezzoLab.AutoSize = true;
            minPrezzoLab.Location = new Point(401, 353);
            minPrezzoLab.Name = "minPrezzoLab";
            minPrezzoLab.Size = new Size(97, 15);
            minPrezzoLab.TabIndex = 17;
            minPrezzoLab.Text = "Prezzo più basso:";
            // 
            // avgPrezzoLab
            // 
            avgPrezzoLab.AutoSize = true;
            avgPrezzoLab.Location = new Point(401, 381);
            avgPrezzoLab.Name = "avgPrezzoLab";
            avgPrezzoLab.Size = new Size(95, 15);
            avgPrezzoLab.TabIndex = 18;
            avgPrezzoLab.Text = "Media dei prezzi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(539, 327);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(539, 381);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 21;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(153, 92);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(539, 353);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 23;
            // 
            // Cerca
            // 
            Cerca.Location = new Point(46, 423);
            Cerca.Name = "Cerca";
            Cerca.Size = new Size(228, 23);
            Cerca.TabIndex = 24;
            Cerca.Text = "Cerca piattaforma";
            Cerca.UseVisualStyleBackColor = true;
            Cerca.Click += Cerca_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(280, 423);
            Reset.Name = "Reset";
            Reset.Size = new Size(100, 23);
            Reset.TabIndex = 25;
            Reset.Text = "Reset ricerca";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reset);
            Controls.Add(Cerca);
            Controls.Add(label8);
            Controls.Add(monthCalendar1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(avgPrezzoLab);
            Controls.Add(minPrezzoLab);
            Controls.Add(maxPrezzoLab);
            Controls.Add(label6);
            Controls.Add(Svuota);
            Controls.Add(Copia);
            Controls.Add(Modifica);
            Controls.Add(Cancella);
            Controls.Add(Inserisci);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Button Inserisci;
        private Button Cancella;
        private Button Modifica;
        private Button Copia;
        private Button Svuota;
        private Label label6;
        private Label maxPrezzoLab;
        private Label minPrezzoLab;
        private Label avgPrezzoLab;
        private Label label7;
        private Label label9;
        private MonthCalendar monthCalendar1;
        private Label label8;
        private Button Cerca;
        private Button Reset;
    }
}