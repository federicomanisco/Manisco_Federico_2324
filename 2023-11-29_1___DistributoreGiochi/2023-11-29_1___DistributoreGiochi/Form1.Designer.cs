namespace _2023_11_29_1___DistributoreGiochi
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
            this.aggiungiGioco = new System.Windows.Forms.Button();
            this.modificaGioco = new System.Windows.Forms.Button();
            this.modificaScontoLinea = new System.Windows.Forms.Button();
            this.eliminaGioco = new System.Windows.Forms.Button();
            this.eliminaGiochiLinea = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.visualizzaPrezzoLineaLB = new System.Windows.Forms.Label();
            this.eliminaLinea = new System.Windows.Forms.Button();
            this.aggiungiLinea = new System.Windows.Forms.Button();
            this.listBoxLinee = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scontoLineaNUP = new System.Windows.Forms.NumericUpDown();
            this.descrizioneLineaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeLineaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.prezzoScontatoGiocoLB = new System.Windows.Forms.Label();
            this.listBoxGiochi = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prezzoGiocoNUP = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.selezioneLineaCB = new System.Windows.Forms.ComboBox();
            this.descrizioneGiocoTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeGiocoTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.scontoTotaleLineaLB = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scontoLineaNUP)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prezzoGiocoNUP)).BeginInit();
            this.SuspendLayout();
            // 
            // aggiungiGioco
            // 
            this.aggiungiGioco.Location = new System.Drawing.Point(6, 291);
            this.aggiungiGioco.Name = "aggiungiGioco";
            this.aggiungiGioco.Size = new System.Drawing.Size(175, 64);
            this.aggiungiGioco.TabIndex = 1;
            this.aggiungiGioco.Text = "Aggiungi nuovo gioco";
            this.aggiungiGioco.UseVisualStyleBackColor = true;
            this.aggiungiGioco.Click += new System.EventHandler(this.aggiungiGioco_Click);
            // 
            // modificaGioco
            // 
            this.modificaGioco.Location = new System.Drawing.Point(187, 291);
            this.modificaGioco.Name = "modificaGioco";
            this.modificaGioco.Size = new System.Drawing.Size(175, 64);
            this.modificaGioco.TabIndex = 2;
            this.modificaGioco.Text = "Modifica gioco";
            this.modificaGioco.UseVisualStyleBackColor = true;
            this.modificaGioco.Click += new System.EventHandler(this.modificaGioco_Click);
            // 
            // modificaScontoLinea
            // 
            this.modificaScontoLinea.Location = new System.Drawing.Point(187, 282);
            this.modificaScontoLinea.Name = "modificaScontoLinea";
            this.modificaScontoLinea.Size = new System.Drawing.Size(175, 64);
            this.modificaScontoLinea.TabIndex = 3;
            this.modificaScontoLinea.Text = "Modifica sconto";
            this.modificaScontoLinea.UseVisualStyleBackColor = true;
            this.modificaScontoLinea.Click += new System.EventHandler(this.modificaScontoLinea_Click);
            // 
            // eliminaGioco
            // 
            this.eliminaGioco.Location = new System.Drawing.Point(368, 291);
            this.eliminaGioco.Name = "eliminaGioco";
            this.eliminaGioco.Size = new System.Drawing.Size(175, 64);
            this.eliminaGioco.TabIndex = 4;
            this.eliminaGioco.Text = "Elimina gioco";
            this.eliminaGioco.UseVisualStyleBackColor = true;
            this.eliminaGioco.Click += new System.EventHandler(this.eliminaGioco_Click);
            // 
            // eliminaGiochiLinea
            // 
            this.eliminaGiochiLinea.Location = new System.Drawing.Point(549, 291);
            this.eliminaGiochiLinea.Name = "eliminaGiochiLinea";
            this.eliminaGiochiLinea.Size = new System.Drawing.Size(175, 64);
            this.eliminaGiochiLinea.TabIndex = 5;
            this.eliminaGiochiLinea.Text = "Elimina giochi di una linea";
            this.eliminaGiochiLinea.UseVisualStyleBackColor = true;
            this.eliminaGiochiLinea.Click += new System.EventHandler(this.eliminaGiochiLinea_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1399, 823);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.scontoTotaleLineaLB);
            this.tabPage1.Controls.Add(this.visualizzaPrezzoLineaLB);
            this.tabPage1.Controls.Add(this.eliminaLinea);
            this.tabPage1.Controls.Add(this.aggiungiLinea);
            this.tabPage1.Controls.Add(this.listBoxLinee);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.modificaScontoLinea);
            this.tabPage1.Controls.Add(this.scontoLineaNUP);
            this.tabPage1.Controls.Add(this.descrizioneLineaTB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nomeLineaTB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1391, 790);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Creazione Linea";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // visualizzaPrezzoLineaLB
            // 
            this.visualizzaPrezzoLineaLB.AutoSize = true;
            this.visualizzaPrezzoLineaLB.Location = new System.Drawing.Point(6, 197);
            this.visualizzaPrezzoLineaLB.Name = "visualizzaPrezzoLineaLB";
            this.visualizzaPrezzoLineaLB.Size = new System.Drawing.Size(0, 20);
            this.visualizzaPrezzoLineaLB.TabIndex = 9;
            // 
            // eliminaLinea
            // 
            this.eliminaLinea.Location = new System.Drawing.Point(368, 282);
            this.eliminaLinea.Name = "eliminaLinea";
            this.eliminaLinea.Size = new System.Drawing.Size(175, 64);
            this.eliminaLinea.TabIndex = 8;
            this.eliminaLinea.Text = "Elimina linea";
            this.eliminaLinea.UseVisualStyleBackColor = true;
            this.eliminaLinea.Click += new System.EventHandler(this.eliminaLinea_Click);
            // 
            // aggiungiLinea
            // 
            this.aggiungiLinea.Location = new System.Drawing.Point(6, 282);
            this.aggiungiLinea.Name = "aggiungiLinea";
            this.aggiungiLinea.Size = new System.Drawing.Size(175, 64);
            this.aggiungiLinea.TabIndex = 7;
            this.aggiungiLinea.Text = "Aggiungi linea";
            this.aggiungiLinea.UseVisualStyleBackColor = true;
            this.aggiungiLinea.Click += new System.EventHandler(this.aggiungiLinea_Click);
            // 
            // listBoxLinee
            // 
            this.listBoxLinee.FormattingEnabled = true;
            this.listBoxLinee.ItemHeight = 20;
            this.listBoxLinee.Location = new System.Drawing.Point(588, 9);
            this.listBoxLinee.Name = "listBoxLinee";
            this.listBoxLinee.Size = new System.Drawing.Size(797, 764);
            this.listBoxLinee.TabIndex = 6;
            this.listBoxLinee.SelectedIndexChanged += new System.EventHandler(this.listBoxLinee_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Percentuale di sconto:";
            // 
            // scontoLineaNUP
            // 
            this.scontoLineaNUP.DecimalPlaces = 2;
            this.scontoLineaNUP.Location = new System.Drawing.Point(165, 149);
            this.scontoLineaNUP.Name = "scontoLineaNUP";
            this.scontoLineaNUP.Size = new System.Drawing.Size(150, 27);
            this.scontoLineaNUP.TabIndex = 4;
            // 
            // descrizioneLineaTB
            // 
            this.descrizioneLineaTB.Location = new System.Drawing.Point(137, 93);
            this.descrizioneLineaTB.Name = "descrizioneLineaTB";
            this.descrizioneLineaTB.Size = new System.Drawing.Size(334, 27);
            this.descrizioneLineaTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrizione linea:";
            // 
            // nomeLineaTB
            // 
            this.nomeLineaTB.Location = new System.Drawing.Point(101, 29);
            this.nomeLineaTB.Name = "nomeLineaTB";
            this.nomeLineaTB.Size = new System.Drawing.Size(334, 27);
            this.nomeLineaTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome linea:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.prezzoScontatoGiocoLB);
            this.tabPage2.Controls.Add(this.listBoxGiochi);
            this.tabPage2.Controls.Add(this.eliminaGiochiLinea);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.eliminaGioco);
            this.tabPage2.Controls.Add(this.prezzoGiocoNUP);
            this.tabPage2.Controls.Add(this.modificaGioco);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.aggiungiGioco);
            this.tabPage2.Controls.Add(this.selezioneLineaCB);
            this.tabPage2.Controls.Add(this.descrizioneGiocoTB);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.nomeGiocoTB);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1391, 790);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inserimento Gioco";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // prezzoScontatoGiocoLB
            // 
            this.prezzoScontatoGiocoLB.AutoSize = true;
            this.prezzoScontatoGiocoLB.Location = new System.Drawing.Point(6, 220);
            this.prezzoScontatoGiocoLB.Name = "prezzoScontatoGiocoLB";
            this.prezzoScontatoGiocoLB.Size = new System.Drawing.Size(0, 20);
            this.prezzoScontatoGiocoLB.TabIndex = 13;
            // 
            // listBoxGiochi
            // 
            this.listBoxGiochi.FormattingEnabled = true;
            this.listBoxGiochi.ItemHeight = 20;
            this.listBoxGiochi.Location = new System.Drawing.Point(730, 0);
            this.listBoxGiochi.Name = "listBoxGiochi";
            this.listBoxGiochi.Size = new System.Drawing.Size(655, 784);
            this.listBoxGiochi.TabIndex = 12;
            this.listBoxGiochi.SelectedIndexChanged += new System.EventHandler(this.listBoxGiochi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Prezzo:";
            // 
            // prezzoGiocoNUP
            // 
            this.prezzoGiocoNUP.DecimalPlaces = 2;
            this.prezzoGiocoNUP.Location = new System.Drawing.Point(68, 181);
            this.prezzoGiocoNUP.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.prezzoGiocoNUP.Name = "prezzoGiocoNUP";
            this.prezzoGiocoNUP.Size = new System.Drawing.Size(150, 27);
            this.prezzoGiocoNUP.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Linea:";
            // 
            // selezioneLineaCB
            // 
            this.selezioneLineaCB.FormattingEnabled = true;
            this.selezioneLineaCB.Location = new System.Drawing.Point(59, 124);
            this.selezioneLineaCB.Name = "selezioneLineaCB";
            this.selezioneLineaCB.Size = new System.Drawing.Size(151, 28);
            this.selezioneLineaCB.TabIndex = 8;
            // 
            // descrizioneGiocoTB
            // 
            this.descrizioneGiocoTB.Location = new System.Drawing.Point(143, 73);
            this.descrizioneGiocoTB.Name = "descrizioneGiocoTB";
            this.descrizioneGiocoTB.Size = new System.Drawing.Size(334, 27);
            this.descrizioneGiocoTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Descrizione gioco:";
            // 
            // nomeGiocoTB
            // 
            this.nomeGiocoTB.Location = new System.Drawing.Point(107, 23);
            this.nomeGiocoTB.Name = "nomeGiocoTB";
            this.nomeGiocoTB.Size = new System.Drawing.Size(334, 27);
            this.nomeGiocoTB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome gioco:";
            // 
            // scontoTotaleLineaLB
            // 
            this.scontoTotaleLineaLB.AutoSize = true;
            this.scontoTotaleLineaLB.Location = new System.Drawing.Point(6, 228);
            this.scontoTotaleLineaLB.Name = "scontoTotaleLineaLB";
            this.scontoTotaleLineaLB.Size = new System.Drawing.Size(0, 20);
            this.scontoTotaleLineaLB.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 840);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scontoLineaNUP)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prezzoGiocoNUP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button aggiungiGioco;
        private Button modificaGioco;
        private Button modificaScontoLinea;
        private Button eliminaGioco;
        private Button eliminaGiochiLinea;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label3;
        private NumericUpDown scontoLineaNUP;
        private TextBox descrizioneLineaTB;
        private Label label2;
        private TextBox nomeLineaTB;
        private Label label1;
        private TabPage tabPage2;
        private Button aggiungiLinea;
        private ListBox listBoxLinee;
        private Label label5;
        private TextBox nomeGiocoTB;
        private Label label4;
        private TextBox descrizioneGiocoTB;
        private Label label7;
        private NumericUpDown prezzoGiocoNUP;
        private Label label6;
        private ComboBox selezioneLineaCB;
        private ListBox listBoxGiochi;
        private Button eliminaLinea;
        private Label visualizzaPrezzoLineaLB;
        private Label prezzoScontatoGiocoLB;
        private Label scontoTotaleLineaLB;
    }
}