using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transporte;
namespace InfoPrestamos
{
    public partial class FrmBusqueda : Form
    {
        public int Id { get; set; }
        public Transporte.View .PersonaView Persona  { get; set; }
        public object Lst { get; set; }
        List<Transporte.View . PersonaView>personaViews;
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
            Utilities.Cmb(cmbProperty, properties);
            personaViews = (List<Transporte.View .PersonaView>)Lst;
            dgBusqueda.DataSource = personaViews ;
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
            dgBusqueda.DataSource =Utilities .  GetPersonas(personaViews,cmbProperty .Text , txtSearch.Text);
        
        }
        private void cmbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
        }
    }
}
