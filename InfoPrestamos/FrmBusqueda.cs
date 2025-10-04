using InfoPrestamos.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace InfoPrestamos
{
    public partial class FrmBusqueda : Form
    {
        public int Id { get; set; }
        public Persona Persona  { get; set; }
        public object Lst { get; set; }
        List< Persona>personas;
        public FrmBusqueda()
        {
            InitializeComponent();
        }
        private void FrmBusqueda_Load(object sender, EventArgs e)
        {
            var properties =Persona.GetType().GetProperties().Select(x => new
            {
                Id = 0,
                Nombre = x.Name
            }).ToList();

           Helper. Utilities.Cmb(cmbProperty, properties);
            personas = (List<Persona>)Lst;
            dgBusqueda.DataSource = personas ;
        }
        private void dgBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                Id = int.Parse(dataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
                Close();
            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (dgBusqueda.CurrentRow != null)
            {
                Id = int.Parse(dgBusqueda.CurrentRow.Cells["id"].Value.ToString());
            }
            Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbProperty.Text))
            {
                return;
            }
            //dgBusqueda.DataSource =Helper. Utilities .  GetPersonas(personaViews,cmbProperty .Text , txtSearch.Text);
        
        }
        private void cmbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
        }
    }
}
