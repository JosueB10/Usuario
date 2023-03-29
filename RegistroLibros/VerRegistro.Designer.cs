namespace RegistroLibros
{
    partial class VerRegistro
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
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.Tit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tit,
            this.ISBN,
            this.A,
            this.Edit,
            this.NPag});
            this.dgvRegistros.Location = new System.Drawing.Point(22, 162);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowTemplate.Height = 25;
            this.dgvRegistros.Size = new System.Drawing.Size(548, 162);
            this.dgvRegistros.TabIndex = 0;
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            // 
            // Tit
            // 
            this.Tit.HeaderText = "Titulo";
            this.Tit.Name = "Tit";
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
            // NPag
            // 
            this.NPag.HeaderText = "N Paginas";
            this.NPag.Name = "NPag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(162, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de libros";
            // 
            // VerRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRegistros);
            this.Name = "VerRegistro";
            this.Text = "VerRegistro";
            this.Load += new System.EventHandler(this.VerRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dgvRegistros;
        private DataGridViewTextBoxColumn Tit;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn A;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn NPag;
        private Label label1;
    }
}