namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Adres = new System.Windows.Forms.TextBox();
            this.Wiadomosci = new System.Windows.Forms.TextBox();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.button_wyslij = new System.Windows.Forms.Button();
            this.PortNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(15, 7);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(347, 20);
            this.Adres.TabIndex = 0;
            // 
            // Wiadomosci
            // 
            this.Wiadomosci.Location = new System.Drawing.Point(15, 33);
            this.Wiadomosci.Multiline = true;
            this.Wiadomosci.Name = "Wiadomosci";
            this.Wiadomosci.Size = new System.Drawing.Size(736, 84);
            this.Wiadomosci.TabIndex = 1;
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(15, 123);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(736, 95);
            this.info_o_polaczeniu.TabIndex = 2;
            // 
            // button_wyslij
            // 
            this.button_wyslij.Location = new System.Drawing.Point(352, 253);
            this.button_wyslij.Name = "button_wyslij";
            this.button_wyslij.Size = new System.Drawing.Size(117, 51);
            this.button_wyslij.TabIndex = 3;
            this.button_wyslij.Text = "Wyślij";
            this.button_wyslij.UseVisualStyleBackColor = true;
            this.button_wyslij.Click += new System.EventHandler(this.button_wyslij_Click);
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(395, 6);
            this.PortNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(355, 20);
            this.PortNumber.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 351);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.button_wyslij);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.Wiadomosci);
            this.Controls.Add(this.Adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox Wiadomosci;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.Button button_wyslij;
        private System.Windows.Forms.NumericUpDown PortNumber;
    }
}

