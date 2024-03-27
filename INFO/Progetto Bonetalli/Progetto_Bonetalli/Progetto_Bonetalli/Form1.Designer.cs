namespace Progetto_Bonetalli {
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
            StartButton = new Button();
            label1 = new Label();
            ResetButton = new Button();
            trackBar1 = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Enabled = false;
            StartButton.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.Location = new Point(783, 12);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(172, 81);
            StartButton.TabIndex = 0;
            StartButton.Text = "Inizia";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.EnabledChanged += StartButton_EnabledChanged;
            StartButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(782, 96);
            label1.Name = "label1";
            label1.Size = new Size(181, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleziona la casella di partenza";
            // 
            // ResetButton
            // 
            ResetButton.Enabled = false;
            ResetButton.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ResetButton.Location = new Point(783, 597);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(172, 81);
            ResetButton.TabIndex = 2;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 10;
            trackBar1.Location = new Point(783, 191);
            trackBar1.Maximum = 10000;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(172, 45);
            trackBar1.SmallChange = 50;
            trackBar1.TabIndex = 3;
            trackBar1.TickFrequency = 100;
            trackBar1.Value = 500;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(844, 173);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Delay";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(852, 230);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "0.5s";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 690);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(trackBar1);
            Controls.Add(ResetButton);
            Controls.Add(label1);
            Controls.Add(StartButton);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Progetto Bonetalli";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Label label1;
        private Button ResetButton;
        private TrackBar trackBar1;
        private Label label2;
        private Label label3;
    }
}