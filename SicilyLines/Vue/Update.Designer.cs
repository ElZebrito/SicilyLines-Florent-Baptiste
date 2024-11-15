namespace SicilyLines
{
    partial class Update
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
            this.tbTraversee = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbBateau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHeure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Traversee";
            // 
            // tbTraversee
            // 
            this.tbTraversee.Location = new System.Drawing.Point(146, 74);
            this.tbTraversee.Name = "tbTraversee";
            this.tbTraversee.Size = new System.Drawing.Size(100, 22);
            this.tbTraversee.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Valider la modification";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbBateau
            // 
            this.tbBateau.Location = new System.Drawing.Point(146, 129);
            this.tbBateau.Name = "tbBateau";
            this.tbBateau.Size = new System.Drawing.Size(100, 22);
            this.tbBateau.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Bateau";
            // 
            // tbHeure
            // 
            this.tbHeure.Location = new System.Drawing.Point(146, 239);
            this.tbHeure.Name = "tbHeure";
            this.tbHeure.Size = new System.Drawing.Size(100, 22);
            this.tbHeure.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Heure";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(146, 184);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 22);
            this.tbDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Traversee";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 427);
            this.Controls.Add(this.tbHeure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBateau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTraversee);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTraversee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbBateau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHeure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label4;
    }
}