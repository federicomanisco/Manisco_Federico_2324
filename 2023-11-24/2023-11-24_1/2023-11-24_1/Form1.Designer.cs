namespace _2023_11_24_1 {
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
            c1c1 = new Button();
            c1c2 = new Button();
            c1c3 = new Button();
            c5c1 = new Button();
            c7c2 = new Button();
            c3c3 = new Button();
            c1 = new Label();
            c2 = new Label();
            c3 = new Label();
            tot = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // c1c1
            // 
            c1c1.Location = new Point(12, 12);
            c1c1.Name = "c1c1";
            c1c1.Size = new Size(176, 40);
            c1c1.TabIndex = 0;
            c1c1.Text = "Compra 1 (Cassa 1)";
            c1c1.UseVisualStyleBackColor = true;
            c1c1.Click += c1c1_Click;
            // 
            // c1c2
            // 
            c1c2.Location = new Point(217, 12);
            c1c2.Name = "c1c2";
            c1c2.Size = new Size(176, 40);
            c1c2.TabIndex = 1;
            c1c2.Text = "Compra 1 (Cassa 2)";
            c1c2.UseVisualStyleBackColor = true;
            c1c2.Click += c1c2_Click;
            // 
            // c1c3
            // 
            c1c3.Location = new Point(419, 12);
            c1c3.Name = "c1c3";
            c1c3.Size = new Size(176, 40);
            c1c3.TabIndex = 2;
            c1c3.Text = "Compra 1 (Cassa 3)";
            c1c3.UseVisualStyleBackColor = true;
            c1c3.Click += c1c3_Click;
            // 
            // c5c1
            // 
            c5c1.Location = new Point(12, 58);
            c5c1.Name = "c5c1";
            c5c1.Size = new Size(176, 40);
            c5c1.TabIndex = 3;
            c5c1.Text = "Compra 5 (Cassa 1)";
            c5c1.UseVisualStyleBackColor = true;
            c5c1.Click += c5c1_Click;
            // 
            // c7c2
            // 
            c7c2.Location = new Point(217, 58);
            c7c2.Name = "c7c2";
            c7c2.Size = new Size(176, 40);
            c7c2.TabIndex = 4;
            c7c2.Text = "Compra 7 (Cassa 2)";
            c7c2.UseVisualStyleBackColor = true;
            c7c2.Click += c7c2_Click;
            // 
            // c3c3
            // 
            c3c3.Location = new Point(419, 58);
            c3c3.Name = "c3c3";
            c3c3.Size = new Size(176, 40);
            c3c3.TabIndex = 5;
            c3c3.Text = "Compra 3 (Cassa 3)";
            c3c3.UseVisualStyleBackColor = true;
            c3c3.Click += c3c3_Click;
            // 
            // c1
            // 
            c1.AutoSize = true;
            c1.Location = new Point(12, 122);
            c1.Name = "c1";
            c1.Size = new Size(143, 15);
            c1.TabIndex = 6;
            c1.Text = "Biglietti venduti (Cassa 1):";
            // 
            // c2
            // 
            c2.AutoSize = true;
            c2.Location = new Point(217, 122);
            c2.Name = "c2";
            c2.Size = new Size(143, 15);
            c2.TabIndex = 7;
            c2.Text = "Biglietti venduti (Cassa 2):";
            // 
            // c3
            // 
            c3.AutoSize = true;
            c3.Location = new Point(419, 122);
            c3.Name = "c3";
            c3.Size = new Size(143, 15);
            c3.TabIndex = 8;
            c3.Text = "Biglietti venduti (Cassa 3):";
            // 
            // tot
            // 
            tot.AutoSize = true;
            tot.Location = new Point(217, 211);
            tot.Name = "tot";
            tot.Size = new Size(127, 15);
            tot.TabIndex = 9;
            tot.Text = "Totale biglietti venduti:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 122);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 10;
            label1.Text = "000/100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 122);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 11;
            label2.Text = "000/100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(557, 122);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 12;
            label3.Text = "000/100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(340, 211);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 13;
            label4.Text = "000/250";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tot);
            Controls.Add(c3);
            Controls.Add(c2);
            Controls.Add(c1);
            Controls.Add(c3c3);
            Controls.Add(c7c2);
            Controls.Add(c5c1);
            Controls.Add(c1c3);
            Controls.Add(c1c2);
            Controls.Add(c1c1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button c1c1;
        private Button c1c2;
        private Button c1c3;
        private Button c5c1;
        private Button c7c2;
        private Button c3c3;
        private Label c1;
        private Label c2;
        private Label c3;
        private Label tot;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}