namespace _2024_05_22_4_Facade {
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            listBox2 = new ListBox();
            AggiungiCarrello = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox3 = new ListBox();
            label3 = new Label();
            Ordina = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(836, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(312, 409);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(518, 29);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(312, 409);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // AggiungiCarrello
            // 
            AggiungiCarrello.Enabled = false;
            AggiungiCarrello.Location = new Point(12, 27);
            AggiungiCarrello.Name = "AggiungiCarrello";
            AggiungiCarrello.Size = new Size(500, 45);
            AggiungiCarrello.TabIndex = 2;
            AggiungiCarrello.Text = "Aggiungi al carrello";
            AggiungiCarrello.UseVisualStyleBackColor = true;
            AggiungiCarrello.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(518, 11);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Carrello";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(836, 11);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Catalogo";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(12, 222);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(500, 214);
            listBox3.TabIndex = 5;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 206);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 6;
            label3.Text = "Cronologia Ordini";
            // 
            // Ordina
            // 
            Ordina.Enabled = false;
            Ordina.Location = new Point(12, 78);
            Ordina.Name = "Ordina";
            Ordina.Size = new Size(500, 45);
            Ordina.TabIndex = 7;
            Ordina.Text = "Ordina";
            Ordina.UseVisualStyleBackColor = true;
            Ordina.Click += Ordina_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 180);
            textBox1.MaxLength = 83;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(498, 23);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 162);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 9;
            label4.Text = "Indirizzo di destinazione";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 450);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(Ordina);
            Controls.Add(label3);
            Controls.Add(listBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AggiungiCarrello);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private ListBox listBox2;
        private Button AggiungiCarrello;
        private Label label1;
        private Label label2;
        private ListBox listBox3;
        private Label label3;
        private Button Ordina;
        private TextBox textBox1;
        private Label label4;
    }
}