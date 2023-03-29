using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroLibros
{
    public partial class VerRegistro : Form
    {




        public void SetDataGridViewData(DataGridView dataGridView)
        {
            // Copiar los datos del DataGridView del primer formulario al DataGridView del segundo formulario
            this.dgvRegistros.Rows.Clear();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                this.dgvRegistros.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value);
            }
        }


        public VerRegistro()
        {
            InitializeComponent();

        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        


        private void VerRegistro_Load(object sender, EventArgs e)
        {
          
        }
    }



}

