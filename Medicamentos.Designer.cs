namespace Inventario
{
    partial class Medicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamentos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCons = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.txtFechCad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.lblFechCad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lbtxtClass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCons
            // 
            this.lblCons.AutoSize = true;
            this.lblCons.Location = new System.Drawing.Point(12, 230);
            this.lblCons.Name = "lblCons";
            this.lblCons.Size = new System.Drawing.Size(44, 13);
            this.lblCons.TabIndex = 0;
            this.lblCons.Text = "Nombre";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(81, 227);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(367, 20);
            this.txtConsulta.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.regresarToolStripMenuItem,
            this.ingresarToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(210)))));
            this.archivoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripMenuItem,
            this.idToolStripMenuItem,
            this.clasificacionToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.nombreToolStripMenuItem.Text = "Nombre";
            this.nombreToolStripMenuItem.Click += new System.EventHandler(this.nombreToolStripMenuItem_Click);
            // 
            // idToolStripMenuItem
            // 
            this.idToolStripMenuItem.Name = "idToolStripMenuItem";
            this.idToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.idToolStripMenuItem.Text = "Id";
            this.idToolStripMenuItem.Click += new System.EventHandler(this.idToolStripMenuItem_Click);
            // 
            // clasificacionToolStripMenuItem
            // 
            this.clasificacionToolStripMenuItem.Name = "clasificacionToolStripMenuItem";
            this.clasificacionToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.clasificacionToolStripMenuItem.Text = "Clasificación";
            this.clasificacionToolStripMenuItem.Click += new System.EventHandler(this.clasificacionToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.regresarToolStripMenuItem_Click);
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ingresarToolStripMenuItem.Text = "Actualizar";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(210)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(481, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 73);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 167);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.cbClass);
            this.groupBox1.Controls.Add(this.txtFechCad);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCant);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txt);
            this.groupBox1.Controls.Add(this.lblFechCad);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lbtxtClass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos Medicamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "(dd/mm/aaaa)";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Tabletas",
            "Cápsula",
            "Suspensión",
            "Polvo Esteril",
            "Crema"});
            this.cbTipo.Location = new System.Drawing.Point(281, 86);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(99, 21);
            this.cbTipo.TabIndex = 5;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Items.AddRange(new object[] {
            "NEUROLOGÍA",
            "CARDIOVASCULAR"});
            this.cbClass.Location = new System.Drawing.Point(119, 56);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(100, 21);
            this.cbClass.TabIndex = 2;
            // 
            // txtFechCad
            // 
            this.txtFechCad.Location = new System.Drawing.Point(119, 83);
            this.txtFechCad.Name = "txtFechCad";
            this.txtFechCad.Size = new System.Drawing.Size(100, 20);
            this.txtFechCad.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(280, 57);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(280, 31);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(246, 86);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(28, 13);
            this.txt.TabIndex = 5;
            this.txt.Text = "Tipo";
            // 
            // lblFechCad
            // 
            this.lblFechCad.AutoSize = true;
            this.lblFechCad.Location = new System.Drawing.Point(25, 86);
            this.lblFechCad.Name = "lblFechCad";
            this.lblFechCad.Size = new System.Drawing.Size(88, 13);
            this.lblFechCad.TabIndex = 4;
            this.lblFechCad.Text = "FechaCaducidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(239, 60);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lbtxtClass
            // 
            this.lbtxtClass.AutoSize = true;
            this.lbtxtClass.Location = new System.Drawing.Point(47, 60);
            this.lbtxtClass.Name = "lbtxtClass";
            this.lbtxtClass.Size = new System.Drawing.Size(66, 13);
            this.lbtxtClass.TabIndex = 2;
            this.lbtxtClass.Text = "Clasificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(210)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(481, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 72);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(210)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(562, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 73);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(210)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(562, 95);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 73);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(66)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(56)))), ((int)(((byte)(44)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(649, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 73);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(210)))), ((int)(((byte)(84)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(481, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(249, 62);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnComprar
            // 
            this.btnComprar.AccessibleDescription = "";
            this.btnComprar.AccessibleName = "";
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(128)))), ((int)(((byte)(210)))));
            this.btnComprar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComprar.BackgroundImage")));
            this.btnComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Location = new System.Drawing.Point(649, 174);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(81, 73);
            this.btnComprar.TabIndex = 11;
            this.btnComprar.Tag = "";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(778, 430);
            this.ControlBox = false;
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lblCons);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(50)))), ((int)(((byte)(57)))));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(794, 469);
            this.MinimumSize = new System.Drawing.Size(794, 469);
            this.Name = "Medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCons;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificacionToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFechCad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label lblFechCad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lbtxtClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnComprar;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}