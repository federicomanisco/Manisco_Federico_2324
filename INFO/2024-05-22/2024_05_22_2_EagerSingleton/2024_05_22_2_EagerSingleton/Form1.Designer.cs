namespace _2024_05_22_2_EagerSingleton {
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
            Log = new ListBox();
            ServerList = new ListBox();
            Avvia = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            SuspendLayout();
            // 
            // Log
            // 
            Log.FormattingEnabled = true;
            Log.ItemHeight = 20;
            Log.Location = new Point(12, 12);
            Log.Name = "Log";
            Log.Size = new Size(377, 264);
            Log.TabIndex = 0;
            // 
            // ServerList
            // 
            ServerList.FormattingEnabled = true;
            ServerList.ItemHeight = 20;
            ServerList.Location = new Point(395, 12);
            ServerList.Name = "ServerList";
            ServerList.Size = new Size(393, 424);
            ServerList.TabIndex = 1;
            // 
            // Avvia
            // 
            Avvia.Location = new Point(12, 385);
            Avvia.Name = "Avvia";
            Avvia.Size = new Size(121, 51);
            Avvia.TabIndex = 2;
            Avvia.Text = "Avvia simulazione";
            Avvia.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(184, 284);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(43, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 284);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 4;
            label1.Text = "Numero di produttori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 314);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 6;
            label2.Text = "Numero di consumatori";
            label2.Click += this.label2_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(184, 312);
            numericUpDown2.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(43, 27);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(322, 312);
            numericUpDown3.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(67, 27);
            numericUpDown3.TabIndex = 8;
            numericUpDown3.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(322, 284);
            numericUpDown4.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(67, 27);
            numericUpDown4.TabIndex = 7;
            numericUpDown4.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 284);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 9;
            label3.Text = "Delay (ms)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 314);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 10;
            label4.Text = "Delay (ms)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown4);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(Avvia);
            Controls.Add(ServerList);
            Controls.Add(Log);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Log;
        private ListBox ServerList;
        private Button Avvia;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label3;
        private Label label4;
    }
}
