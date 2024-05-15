namespace _2024_05_15_VerificaRecupero {
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SalvaFrasi = new System.Windows.Forms.Button();
            this.TrovaDuplicati = new System.Windows.Forms.Button();
            this.Esci = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selezionare la nazionalità dell\'autore";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(406, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 384);
            this.listBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aforismi";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 122);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(227, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Visualizza solo frasi divertenti";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SalvaFrasi
            // 
            this.SalvaFrasi.Location = new System.Drawing.Point(152, 162);
            this.SalvaFrasi.Name = "SalvaFrasi";
            this.SalvaFrasi.Size = new System.Drawing.Size(109, 66);
            this.SalvaFrasi.TabIndex = 6;
            this.SalvaFrasi.Text = "Salva Queste Frasi";
            this.SalvaFrasi.UseVisualStyleBackColor = true;
            this.SalvaFrasi.Click += new System.EventHandler(this.SalvaFrasi_Click);
            // 
            // TrovaDuplicati
            // 
            this.TrovaDuplicati.Location = new System.Drawing.Point(12, 162);
            this.TrovaDuplicati.Name = "TrovaDuplicati";
            this.TrovaDuplicati.Size = new System.Drawing.Size(109, 66);
            this.TrovaDuplicati.TabIndex = 7;
            this.TrovaDuplicati.Text = "Trova duplicati";
            this.TrovaDuplicati.UseVisualStyleBackColor = true;
            this.TrovaDuplicati.Click += new System.EventHandler(this.TrovaDuplicati_Click);
            // 
            // Esci
            // 
            this.Esci.Location = new System.Drawing.Point(12, 369);
            this.Esci.Name = "Esci";
            this.Esci.Size = new System.Drawing.Size(109, 66);
            this.Esci.TabIndex = 8;
            this.Esci.Text = "Esci";
            this.Esci.UseVisualStyleBackColor = true;
            this.Esci.Click += new System.EventHandler(this.Esci_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(292, 162);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(109, 66);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Esci);
            this.Controls.Add(this.TrovaDuplicati);
            this.Controls.Add(this.SalvaFrasi);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private CheckBox checkBox1;
        private Button SalvaFrasi;
        private Button TrovaDuplicati;
        private Button Esci;
        private Button Reset;
    }
}