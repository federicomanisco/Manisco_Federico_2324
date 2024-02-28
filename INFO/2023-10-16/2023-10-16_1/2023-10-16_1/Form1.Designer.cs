namespace _2023_10_16_1 {
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
            Inserisci = new Button();
            Cancella = new Button();
            label1 = new Label();
            NumeroTel = new TextBox();
            ListaNumeri = new ListBox();
            SuspendLayout();
            // 
            // Inserisci
            // 
            Inserisci.Location = new Point(84, 63);
            Inserisci.Name = "Inserisci";
            Inserisci.Size = new Size(182, 89);
            Inserisci.TabIndex = 0;
            Inserisci.Text = "Aggiungi Numero";
            Inserisci.UseVisualStyleBackColor = true;
            Inserisci.Click += Inserisci_Click;
            // 
            // Cancella
            // 
            Cancella.Location = new Point(84, 171);
            Cancella.Name = "Cancella";
            Cancella.Size = new Size(182, 89);
            Cancella.TabIndex = 1;
            Cancella.Text = "Rimuovi Numero";
            Cancella.UseVisualStyleBackColor = true;
            Cancella.Click += Cancella_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 100);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 2;
            label1.Text = "Inserisci numero di telefono";
            // 
            // NumeroTel
            // 
            NumeroTel.Location = new Point(453, 97);
            NumeroTel.Name = "NumeroTel";
            NumeroTel.Size = new Size(153, 23);
            NumeroTel.TabIndex = 3;
            // 
            // ListaNumeri
            // 
            ListaNumeri.FormattingEnabled = true;
            ListaNumeri.ItemHeight = 15;
            ListaNumeri.Location = new Point(453, 171);
            ListaNumeri.Name = "ListaNumeri";
            ListaNumeri.Size = new Size(153, 274);
            ListaNumeri.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListaNumeri);
            Controls.Add(NumeroTel);
            Controls.Add(label1);
            Controls.Add(Cancella);
            Controls.Add(Inserisci);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Inserisci;
        private Button Cancella;
        private Label label1;
        private TextBox NumeroTel;
        private ListBox ListaNumeri;
    }
}