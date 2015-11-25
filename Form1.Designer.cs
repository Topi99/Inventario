namespace Inventario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosVariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quejasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.contactarToolStripMenuItem,
            this.quejasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentosToolStripMenuItem,
            this.clasificaciónToolStripMenuItem,
            this.productosVariosToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // medicamentosToolStripMenuItem
            // 
            this.medicamentosToolStripMenuItem.Name = "medicamentosToolStripMenuItem";
            this.medicamentosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";
            // 
            // clasificaciónToolStripMenuItem
            // 
            this.clasificaciónToolStripMenuItem.Name = "clasificaciónToolStripMenuItem";
            this.clasificaciónToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clasificaciónToolStripMenuItem.Text = "Clasificación";
            // 
            // productosVariosToolStripMenuItem
            // 
            this.productosVariosToolStripMenuItem.Name = "productosVariosToolStripMenuItem";
            this.productosVariosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.productosVariosToolStripMenuItem.Text = "Productos Varios";
            // 
            // contactarToolStripMenuItem
            // 
            this.contactarToolStripMenuItem.Name = "contactarToolStripMenuItem";
            this.contactarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.contactarToolStripMenuItem.Text = "Contactar";
            this.contactarToolStripMenuItem.Click += new System.EventHandler(this.contactarToolStripMenuItem_Click);
            // 
            // quejasToolStripMenuItem
            // 
            this.quejasToolStripMenuItem.Name = "quejasToolStripMenuItem";
            this.quejasToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.quejasToolStripMenuItem.Text = "Quejas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(219, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inventario de Farmacia";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(102, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Medicamentos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(328, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clasificaciones";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(211, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Productos Varios";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(25)))), ((int)(((byte)(14)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(238, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(532, 269);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosVariosToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem contactarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quejasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

