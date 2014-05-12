namespace Luice
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.hostTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uidTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.charTxt = new System.Windows.Forms.TextBox();
            this.authTxt = new System.Windows.Forms.TextBox();
            this.worldTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.connBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection Manager";
            // 
            // hostTxt
            // 
            this.hostTxt.Location = new System.Drawing.Point(12, 40);
            this.hostTxt.Name = "hostTxt";
            this.hostTxt.Size = new System.Drawing.Size(100, 20);
            this.hostTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Host";
            // 
            // portTxt
            // 
            this.portTxt.Location = new System.Drawing.Point(167, 40);
            this.portTxt.Name = "portTxt";
            this.portTxt.Size = new System.Drawing.Size(68, 20);
            this.portTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port";
            // 
            // uidTxt
            // 
            this.uidTxt.Location = new System.Drawing.Point(12, 84);
            this.uidTxt.Name = "uidTxt";
            this.uidTxt.Size = new System.Drawing.Size(100, 20);
            this.uidTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(164, 84);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // charTxt
            // 
            this.charTxt.Location = new System.Drawing.Point(12, 139);
            this.charTxt.Name = "charTxt";
            this.charTxt.Size = new System.Drawing.Size(76, 20);
            this.charTxt.TabIndex = 9;
            // 
            // authTxt
            // 
            this.authTxt.Location = new System.Drawing.Point(104, 139);
            this.authTxt.Name = "authTxt";
            this.authTxt.Size = new System.Drawing.Size(85, 20);
            this.authTxt.TabIndex = 10;
            // 
            // worldTxt
            // 
            this.worldTxt.Location = new System.Drawing.Point(199, 139);
            this.worldTxt.Name = "worldTxt";
            this.worldTxt.Size = new System.Drawing.Size(75, 20);
            this.worldTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Characters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Auth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "World";
            // 
            // connBtn
            // 
            this.connBtn.Location = new System.Drawing.Point(12, 163);
            this.connBtn.Name = "connBtn";
            this.connBtn.Size = new System.Drawing.Size(262, 23);
            this.connBtn.TabIndex = 15;
            this.connBtn.Text = "Connect!";
            this.connBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 198);
            this.Controls.Add(this.connBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.worldTxt);
            this.Controls.Add(this.authTxt);
            this.Controls.Add(this.charTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uidTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hostTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Luice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uidTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox charTxt;
        private System.Windows.Forms.TextBox authTxt;
        private System.Windows.Forms.TextBox worldTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button connBtn;
    }
}

