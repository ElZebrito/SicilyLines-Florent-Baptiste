namespace SicilyLines
{
    partial class Insertion
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdTraversee = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHeure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDateTraversee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIdBateau = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Traversée";
            // 
            // tbIdTraversee
            // 
            this.tbIdTraversee.Location = new System.Drawing.Point(157, 76);
            this.tbIdTraversee.Name = "tbIdTraversee";
            this.tbIdTraversee.Size = new System.Drawing.Size(100, 22);
            this.tbIdTraversee.TabIndex = 1;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(95, 376);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(130, 61);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Bateau";
            // 
            // tbHeure
            // 
            this.tbHeure.Location = new System.Drawing.Point(157, 298);
            this.tbHeure.Name = "tbHeure";
            this.tbHeure.Size = new System.Drawing.Size(100, 22);
            this.tbHeure.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Heure Traversée";
            // 
            // tbDateTraversee
            // 
            this.tbDateTraversee.Location = new System.Drawing.Point(157, 223);
            this.tbDateTraversee.Name = "tbDateTraversee";
            this.tbDateTraversee.Size = new System.Drawing.Size(100, 22);
            this.tbDateTraversee.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Traversée";
            // 
            // cbIdBateau
            // 
            this.cbIdBateau.FormattingEnabled = true;
            this.cbIdBateau.Location = new System.Drawing.Point(157, 151);
            this.cbIdBateau.Name = "cbIdBateau";
            this.cbIdBateau.Size = new System.Drawing.Size(100, 24);
            this.cbIdBateau.TabIndex = 9;
            // 
            // Insertion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 499);
            this.Controls.Add(this.cbIdBateau);
            this.Controls.Add(this.tbHeure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDateTraversee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.tbIdTraversee);
            this.Controls.Add(this.label1);
            this.Name = "Insertion";
            this.Text = "Insertion";
            this.Load += new System.EventHandler(this.Insertion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdTraversee;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHeure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDateTraversee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIdBateau;
    }
}