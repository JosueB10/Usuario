using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RegistroLibros.Registro;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistroLibros
{
    public partial class CreandoArchivo : Form
    {
        

        public void clean() 
        {
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtEditorial.Text = string.Empty;
            txtPaginas.Text = string.Empty;




        }




        RegistroSerializable registro = null;
        string jsonString;
        string fileName = "Registro.json";
        public CreandoArchivo()
        {
            InitializeComponent();
            txtTitulo.KeyPress += new KeyPressEventHandler(txtTitulo_KeyPress);
            txtAutor.KeyPress += new KeyPressEventHandler(txtAutor_KeyPress);
            txtEditorial.KeyPress += new KeyPressEventHandler(txtEditorial_KeyPress);
        }

        //Este metodo es para que en el campo #paginas no ingresen letras
        private void txtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        string titulo, codigo, autor, editorial;
        int nPaginas;

        private void btnVerRegistro_Click(object sender, EventArgs e)
        {

            VerRegistro form2 = new VerRegistro();

            // llamar al método "SetDataGridViewData" del segundo formulario y pasar el objeto DataGridView del primer formulario como parámetro
            form2.SetDataGridViewData(dgvLibreria);

            // mostrar el segundo formulario
            form2.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Titulo = txtTitulo.Text;
            string ISBN = txtCodigo.Text;
            string Autor = txtAutor.Text;
            string Editorial = txtEditorial.Text;
            string Paginas = txtPaginas.Text;

            if (!string.IsNullOrEmpty(txtTitulo.Text) &&
                !string.IsNullOrEmpty(txtCodigo.Text) &&
                !string.IsNullOrEmpty(txtAutor.Text) &&
                !string.IsNullOrEmpty(txtEditorial.Text)&&
                !string.IsNullOrEmpty(txtPaginas.Text))

            {
                dgvLibreria.Rows.Add(Titulo, ISBN, Autor, Editorial, Paginas);
                clean();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            

        }

        private void CreandoArchivo_Load(object sender, EventArgs e)
        {
            dgvLibreria.AllowUserToAddRows = false;
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEditorial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPaginas_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPaginas.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Por favor solo ingrese numeros.");
                txtPaginas.Text = txtPaginas.Text.Remove(txtPaginas.Text.Length - 1);
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEditorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = titulo;
            txtCodigo.Text = codigo;
            txtAutor.Text = autor;
            txtEditorial.Text = editorial;
            txtPaginas.Text = Convert.ToString(nPaginas);

            if (txtAutor.Text == "" || txtCodigo.Text == "" ||
                txtTitulo.Text == "" || txtEditorial.Text == "" || txtPaginas.Text == "")
            {
                MessageBox.Show("Rellene todos los espacios", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            registro = new RegistroSerializable(titulo, codigo, autor, editorial, nPaginas);
            jsonString = JsonSerializer.Serialize(registro);
            File.WriteAllText(fileName, jsonString);
        }

        //No le muevas pq se borra el diseño de nuevo 
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
