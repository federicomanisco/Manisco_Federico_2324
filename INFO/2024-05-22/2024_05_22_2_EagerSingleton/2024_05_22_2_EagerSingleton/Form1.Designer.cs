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
            Reset = new Button();
            numericUpDown5 = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            SuspendLayout();
            // 
            // Log
            // 
            Log.FormattingEnabled = true;
            Log.ItemHeight = 15;
            Log.Location = new Point(10, 9);
            Log.Margin = new Padding(3, 2, 3, 2);
            Log.Name = "Log";
            Log.Size = new Size(464, 199);
            Log.TabIndex = 0;
            // 
            // ServerList
            // 
            ServerList.FormattingEnabled = true;
            ServerList.ItemHeight = 15;
            ServerList.Location = new Point(480, 9);
            ServerList.Margin = new Padding(3, 2, 3, 2);
            ServerList.Name = "ServerList";
            ServerList.Size = new Size(210, 319);
            ServerList.TabIndex = 1;
            // 
            // Avvia
            // 
            Avvia.Location = new Point(10, 289);
            Avvia.Margin = new Padding(3, 2, 3, 2);
            Avvia.Name = "Avvia";
            Avvia.Size = new Size(106, 38);
            Avvia.TabIndex = 2;
            Avvia.Text = "Avvia simulazione";
            Avvia.UseVisualStyleBackColor = true;
            Avvia.Click += Avvia_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(150, 211);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(43, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 213);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 4;
            label1.Text = "Numero di produttori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 236);
            label2.Name = "label2";
            label2.Size = new Size(134, 15);
            label2.TabIndex = 6;
            label2.Text = "Numero di consumatori";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(150, 232);
            numericUpDown2.Margin = new Padding(3, 2, 3, 2);
            numericUpDown2.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(43, 23);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(415, 234);
            numericUpDown3.Margin = new Padding(3, 2, 3, 2);
            numericUpDown3.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(59, 23);
            numericUpDown3.TabIndex = 8;
            numericUpDown3.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(415, 213);
            numericUpDown4.Margin = new Padding(3, 2, 3, 2);
            numericUpDown4.Maximum = new decimal(new int[] { 350, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 70, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(59, 23);
            numericUpDown4.TabIndex = 7;
            numericUpDown4.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 213);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Delay (ms)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 236);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 10;
            label4.Text = "Delay (ms)";
            // 
            // Reset
            // 
            Reset.Location = new Point(368, 289);
            Reset.Margin = new Padding(3, 2, 3, 2);
            Reset.Name = "Reset";
            Reset.Size = new Size(106, 38);
            Reset.TabIndex = 11;
            Reset.Text = "Reset Simulazione";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(220, 262);
            numericUpDown5.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(43, 23);
            numericUpDown5.TabIndex = 12;
            numericUpDown5.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 289);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 13;
            label5.Text = "Server generati ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label5);
            Controls.Add(numericUpDown5);
            Controls.Add(Reset);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
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
        private Button Reset;
        private NumericUpDown numericUpDown5;
        private Label label5;
    }
}
