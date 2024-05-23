namespace _2024_05_22_3_AbstractFactory {
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
            AggiungiVeicolo = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            RiparaVeicolo = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(264, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(524, 424);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // AggiungiVeicolo
            // 
            AggiungiVeicolo.Location = new Point(12, 398);
            AggiungiVeicolo.Name = "AggiungiVeicolo";
            AggiungiVeicolo.Size = new Size(246, 40);
            AggiungiVeicolo.TabIndex = 1;
            AggiungiVeicolo.Text = "Aggiungi Veicolo";
            AggiungiVeicolo.UseVisualStyleBackColor = true;
            AggiungiVeicolo.Click += AggiungiVeicolo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 17);
            textBox1.MaxLength = 25;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome del veicolo";
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += timer1_Tick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(17, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(78, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Macchina";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(17, 80);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(55, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Moto";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(118, 55);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(68, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Elettrica";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(118, 80);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(98, 19);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "Combustione";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // RiparaVeicolo
            // 
            RiparaVeicolo.Location = new Point(12, 352);
            RiparaVeicolo.Name = "RiparaVeicolo";
            RiparaVeicolo.Size = new Size(246, 40);
            RiparaVeicolo.TabIndex = 8;
            RiparaVeicolo.Text = "Ripara Veicolo";
            RiparaVeicolo.UseVisualStyleBackColor = true;
            RiparaVeicolo.Click += RiparaVeicolo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RiparaVeicolo);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(AggiungiVeicolo);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button AggiungiVeicolo;
        private TextBox textBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Button RiparaVeicolo;
    }
}