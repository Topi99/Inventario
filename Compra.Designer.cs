namespace Inventario
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.btnCompra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(97, 105);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCompra.TabIndex = 1;
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.btnCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompra.BackgroundImage")));
            this.btnCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Location = new System.Drawing.Point(17, 166);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(249, 62);
            this.btnCompra.TabIndex = 11;
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.label1);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.Button btnCompra;
    }
}