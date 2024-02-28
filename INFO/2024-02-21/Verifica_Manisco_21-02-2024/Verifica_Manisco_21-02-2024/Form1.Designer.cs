namespace Verifica_Manisco_21_02_2024 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSpecie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStatoConservazione = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxColoreFrutti = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxColoreFiori = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AggiungiPianta = new System.Windows.Forms.Button();
            this.ControllaFioritura = new System.Windows.Forms.Button();
            this.RimuoviPianta = new System.Windows.Forms.Button();
            this.ModificaPianta = new System.Windows.Forms.Button();
            this.labelMese = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specie della pianta:";
            // 
            // comboBoxSpecie
            // 
            this.comboBoxSpecie.FormattingEnabled = true;
            this.comboBoxSpecie.Items.AddRange(new object[] {
            "Palma nana",
            "Orchide di Branciforti"});
            this.comboBoxSpecie.Location = new System.Drawing.Point(220, 36);
            this.comboBoxSpecie.Name = "comboBoxSpecie";
            this.comboBoxSpecie.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSpecie.TabIndex = 1;
            this.comboBoxSpecie.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpecie_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codice (8 caratteri):";
            // 
            // textBoxCodice
            // 
            this.textBoxCodice.Location = new System.Drawing.Point(220, 83);
            this.textBoxCodice.Name = "textBoxCodice";
            this.textBoxCodice.Size = new System.Drawing.Size(151, 27);
            this.textBoxCodice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stato di conservazione:";
            // 
            // comboBoxStatoConservazione
            // 
            this.comboBoxStatoConservazione.FormattingEnabled = true;
            this.comboBoxStatoConservazione.Items.AddRange(new object[] {
            "Estinto",
            "Minacciato",
            "Basso rischio",
            "Non valutato"});
            this.comboBoxStatoConservazione.Location = new System.Drawing.Point(220, 129);
            this.comboBoxStatoConservazione.Name = "comboBoxStatoConservazione";
            this.comboBoxStatoConservazione.Size = new System.Drawing.Size(151, 28);
            this.comboBoxStatoConservazione.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Colore dei frutti: ";
            // 
            // comboBoxColoreFrutti
            // 
            this.comboBoxColoreFrutti.Enabled = false;
            this.comboBoxColoreFrutti.FormattingEnabled = true;
            this.comboBoxColoreFrutti.Items.AddRange(new object[] {
            "Verde",
            "Giallo/Rosso",
            "Marrone"});
            this.comboBoxColoreFrutti.Location = new System.Drawing.Point(220, 174);
            this.comboBoxColoreFrutti.Name = "comboBoxColoreFrutti";
            this.comboBoxColoreFrutti.Size = new System.Drawing.Size(151, 28);
            this.comboBoxColoreFrutti.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Colore dei fiori:";
            // 
            // comboBoxColoreFiori
            // 
            this.comboBoxColoreFiori.Enabled = false;
            this.comboBoxColoreFiori.FormattingEnabled = true;
            this.comboBoxColoreFiori.Items.AddRange(new object[] {
            "Apocromatica",
            "Viola"});
            this.comboBoxColoreFiori.Location = new System.Drawing.Point(220, 216);
            this.comboBoxColoreFiori.Name = "comboBoxColoreFiori";
            this.comboBoxColoreFiori.Size = new System.Drawing.Size(151, 28);
            this.comboBoxColoreFiori.TabIndex = 9;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(77, 245);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(458, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(553, 284);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AggiungiPianta
            // 
            this.AggiungiPianta.Location = new System.Drawing.Point(458, 326);
            this.AggiungiPianta.Name = "AggiungiPianta";
            this.AggiungiPianta.Size = new System.Drawing.Size(144, 57);
            this.AggiungiPianta.TabIndex = 12;
            this.AggiungiPianta.Text = "Aggiungi pianta";
            this.AggiungiPianta.UseVisualStyleBackColor = true;
            this.AggiungiPianta.Click += new System.EventHandler(this.AggiungiPianta_Click);
            // 
            // ControllaFioritura
            // 
            this.ControllaFioritura.Location = new System.Drawing.Point(867, 326);
            this.ControllaFioritura.Name = "ControllaFioritura";
            this.ControllaFioritura.Size = new System.Drawing.Size(144, 57);
            this.ControllaFioritura.TabIndex = 13;
            this.ControllaFioritura.Text = "Controlla fioritura";
            this.ControllaFioritura.UseVisualStyleBackColor = true;
            this.ControllaFioritura.Click += new System.EventHandler(this.ControllaFioritura_Click);
            // 
            // RimuoviPianta
            // 
            this.RimuoviPianta.Location = new System.Drawing.Point(458, 389);
            this.RimuoviPianta.Name = "RimuoviPianta";
            this.RimuoviPianta.Size = new System.Drawing.Size(144, 57);
            this.RimuoviPianta.TabIndex = 14;
            this.RimuoviPianta.Text = "Rimuovi pianta";
            this.RimuoviPianta.UseVisualStyleBackColor = true;
            this.RimuoviPianta.Click += new System.EventHandler(this.RimuoviPianta_Click);
            // 
            // ModificaPianta
            // 
            this.ModificaPianta.Location = new System.Drawing.Point(867, 388);
            this.ModificaPianta.Name = "ModificaPianta";
            this.ModificaPianta.Size = new System.Drawing.Size(144, 57);
            this.ModificaPianta.TabIndex = 15;
            this.ModificaPianta.Text = "Modifica pianta";
            this.ModificaPianta.UseVisualStyleBackColor = true;
            this.ModificaPianta.Click += new System.EventHandler(this.ModificaPianta_Click);
            // 
            // labelMese
            // 
            this.labelMese.AutoSize = true;
            this.labelMese.Location = new System.Drawing.Point(504, 13);
            this.labelMese.Name = "labelMese";
            this.labelMese.Size = new System.Drawing.Size(0, 20);
            this.labelMese.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 457);
            this.Controls.Add(this.labelMese);
            this.Controls.Add(this.ModificaPianta);
            this.Controls.Add(this.RimuoviPianta);
            this.Controls.Add(this.ControllaFioritura);
            this.Controls.Add(this.AggiungiPianta);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBoxColoreFiori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxColoreFrutti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxStatoConservazione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCodice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSpecie);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxSpecie;
        private Label label2;
        private TextBox textBoxCodice;
        private Label label3;
        private ComboBox comboBoxStatoConservazione;
        private Label label4;
        private ComboBox comboBoxColoreFrutti;
        private Label label5;
        private ComboBox comboBoxColoreFiori;
        private MonthCalendar monthCalendar1;
        private ListBox listBox1;
        private Button AggiungiPianta;
        private Button ControllaFioritura;
        private Button RimuoviPianta;
        private Button ModificaPianta;
        private Label labelMese;
    }
}