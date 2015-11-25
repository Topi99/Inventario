namespace Inventario
{
    partial class email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(email));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "e-mail";
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(101, 65);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(165, 20);
            this.txtEMail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(101, 91);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(165, 20);
            this.txtPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mensaje";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(101, 151);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(165, 108);
            this.txtMsg.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.Location = new System.Drawing.Point(285, 27);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(89, 68);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Servidor";
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Items.AddRange(new object[] {
            "Gmail",
            "Hotmail"});
            this.cbServer.Location = new System.Drawing.Point(101, 27);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(165, 21);
            this.cbServer.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Asunto";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(101, 117);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(165, 20);
            this.txtAsunto.TabIndex = 12;
            // 
            // email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 438);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.label1);
            this.Name = "email";
            this.Text = "email";
            this.Load += new System.EventHandler(this.email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnviar;
        public System.Windows.Forms.TextBox txtEMail;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAsunto;
    }
}