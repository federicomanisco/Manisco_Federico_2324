namespace _2024_04_24_Verifica {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ControllaRisposte = new System.Windows.Forms.Button();
            this.SalvaRisposta = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Successiva = new System.Windows.Forms.Button();
            this.Precedente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Inizia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 582);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ControllaRisposte);
            this.tabPage1.Controls.Add(this.SalvaRisposta);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.Successiva);
            this.tabPage1.Controls.Add(this.Precedente);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Inizia);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quiz";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ControllaRisposte
            // 
            this.ControllaRisposte.Enabled = false;
            this.ControllaRisposte.Location = new System.Drawing.Point(816, 393);
            this.ControllaRisposte.Name = "ControllaRisposte";
            this.ControllaRisposte.Size = new System.Drawing.Size(113, 46);
            this.ControllaRisposte.TabIndex = 21;
            this.ControllaRisposte.Text = "Consegna e controlla risposte";
            this.ControllaRisposte.UseVisualStyleBackColor = true;
            this.ControllaRisposte.Visible = false;
            this.ControllaRisposte.Click += new System.EventHandler(this.ControllaRisposte_Click);
            // 
            // SalvaRisposta
            // 
            this.SalvaRisposta.Enabled = false;
            this.SalvaRisposta.Location = new System.Drawing.Point(672, 392);
            this.SalvaRisposta.Name = "SalvaRisposta";
            this.SalvaRisposta.Size = new System.Drawing.Size(85, 47);
            this.SalvaRisposta.TabIndex = 20;
            this.SalvaRisposta.Text = "Salva Risposta";
            this.SalvaRisposta.UseVisualStyleBackColor = true;
            this.SalvaRisposta.Visible = false;
            this.SalvaRisposta.Click += new System.EventHandler(this.SalvaRisposta_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vero",
            "Falso"});
            this.comboBox1.Location = new System.Drawing.Point(502, 393);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Visible = false;
            // 
            // Successiva
            // 
            this.Successiva.Enabled = false;
            this.Successiva.Location = new System.Drawing.Point(672, 166);
            this.Successiva.Name = "Successiva";
            this.Successiva.Size = new System.Drawing.Size(85, 23);
            this.Successiva.TabIndex = 18;
            this.Successiva.Text = "Successiva";
            this.Successiva.UseVisualStyleBackColor = true;
            this.Successiva.Visible = false;
            this.Successiva.Click += new System.EventHandler(this.Successiva_Click);
            // 
            // Precedente
            // 
            this.Precedente.Enabled = false;
            this.Precedente.Location = new System.Drawing.Point(299, 166);
            this.Precedente.Name = "Precedente";
            this.Precedente.Size = new System.Drawing.Size(90, 23);
            this.Precedente.TabIndex = 17;
            this.Precedente.Text = "Precedente";
            this.Precedente.UseVisualStyleBackColor = true;
            this.Precedente.Visible = false;
            this.Precedente.Click += new System.EventHandler(this.Precedente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 16;
            // 
            // Inizia
            // 
            this.Inizia.Location = new System.Drawing.Point(827, 53);
            this.Inizia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Inizia.Name = "Inizia";
            this.Inizia.Size = new System.Drawing.Size(102, 33);
            this.Inizia.TabIndex = 15;
            this.Inizia.Text = "Inizia";
            this.Inizia.UseVisualStyleBackColor = true;
            this.Inizia.Click += new System.EventHandler(this.Inizia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gruppo domande:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(126, 96);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 23);
            this.numericUpDown1.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(126, 393);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 94);
            this.textBox1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(395, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tentativi Precedenti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancella tentativi precedenti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1053, 469);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 606);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button ControllaRisposte;
        private Button SalvaRisposta;
        private ComboBox comboBox1;
        private Button Successiva;
        private Button Precedente;
        private Label label2;
        private Button Inizia;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private ListBox listBox1;
        private Button button1;
    }
}