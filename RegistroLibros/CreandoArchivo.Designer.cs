namespace RegistroLibros
{
    partial class CreandoArchivo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVerRegistro = new System.Windows.Forms.Button();
            this.dgvLibreria = new System.Windows.Forms.DataGridView();
            this.TIt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibreria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "R E G I S T R O   D E   L I B R O S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(89, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(200, 72);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(186, 22);
            this.txtTitulo.TabIndex = 2;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            this.txtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitulo_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(200, 115);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(186, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(89, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "ISBN";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(200, 217);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(186, 22);
            this.txtEditorial.TabIndex = 8;
            this.txtEditorial.TextChanged += new System.EventHandler(this.txtEditorial_TextChanged);
            this.txtEditorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditorial_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(89, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Editorial";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(200, 160);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(186, 22);
            this.txtAutor.TabIndex = 6;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtAutor_TextChanged);
            this.txtAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(89, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Autor";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(200, 270);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(186, 22);
            this.txtPaginas.TabIndex = 10;
            this.txtPaginas.TextChanged += new System.EventHandler(this.txtPaginas_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(89, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "N° de páginas";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 462);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(88, 25);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(396, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnVerRegistro
            // 
            this.btnVerRegistro.ForeColor = System.Drawing.Color.Black;
            this.btnVerRegistro.Location = new System.Drawing.Point(187, 462);
            this.btnVerRegistro.Name = "btnVerRegistro";
            this.btnVerRegistro.Size = new System.Drawing.Size(158, 25);
            this.btnVerRegistro.TabIndex = 14;
            this.btnVerRegistro.Text = "Ver registro en tabla";
            this.btnVerRegistro.UseVisualStyleBackColor = true;
            this.btnVerRegistro.Click += new System.EventHandler(this.btnVerRegistro_Click);
            // 
            // dgvLibreria
            // 
            this.dgvLibreria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibreria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIt,
            this.ISBN,
            this.A,
            this.Edit,
            this.NumPag});
            this.dgvLibreria.Location = new System.Drawing.Point(12, 327);
            this.dgvLibreria.Name = "dgvLibreria";
            this.dgvLibreria.RowTemplate.Height = 25;
            this.dgvLibreria.Size = new System.Drawing.Size(544, 98);
            this.dgvLibreria.TabIndex = 15;
            this.dgvLibreria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TIt
            // 
            this.TIt.HeaderText = "Titulo";
            this.TIt.Name = "TIt";
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // A
            // 
            this.A.HeaderText = "Autor";
            this.A.Name = "A";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editorial";
            this.Edit.Name = "Edit";
            // 
            // NumPag
            // 
            this.NumPag.HeaderText = "N paginas";
            this.NumPag.Name = "NumPag";
            // 
            // CreandoArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(568, 499);
            this.Controls.Add(this.dgvLibreria);
            this.Controls.Add(this.btnVerRegistro);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreandoArchivo";
            this.Text = "CreandoArchivo";
            this.Load += new System.EventHandler(this.CreandoArchivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibreria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitulo;
        private TextBox txtCodigo;
        private Label label3;
        private TextBox txtEditorial;
        private Label label4;
        private TextBox txtAutor;
        private Label label5;
        private TextBox txtPaginas;
        private Label label6;
        private Button btnRegistrar;
        private Button btnExit;
        private Button btnVerRegistro;
        public DataGridView dgvLibreria;
        private DataGridViewTextBoxColumn TIt;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn A;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn NumPag;
    }
}