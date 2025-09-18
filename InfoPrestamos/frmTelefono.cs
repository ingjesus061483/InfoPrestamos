using Factory;
using Helper;
using Helper.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transporte;
using Transporte.View;

namespace InfoPrestamos
{
    public partial class frmTelefono : Form
    {
        public  List<TelefonoView> Telefonos { get; set; }
        public PersonaView  Cliente { get; set; }
        int id;
        TelefonoDTO telefonoDTO;
       
        TelefonoHelp TelefonoHelp;
        TelefonoTransporte TelefonoTransporte;
        TipoTelefonoHelp tipoTelefonoHelp;
        public frmTelefono(TipoTelefonoHelp _tipoTelefonoHelp,TelefonoHelp _telefonoHelp,TelefonoTransporte _telefonoTransporte   )        
        {
            TelefonoHelp = _telefonoHelp;          
            tipoTelefonoHelp = _tipoTelefonoHelp;
            TelefonoTransporte = _telefonoTransporte;
            InitializeComponent();           
           TelefonoTransporte .bindindList .ListChanged += BindTelefonos_ListChanged;      
        }

        private void BindTelefonos_ListChanged(object sender, ListChangedEventArgs e)
        {
            dgTelefono.DataSource = TelefonoTransporte .bindindList ;
        }
        void Nuevo()
        {
            id = 0;
            txtNumeroTelefonico.Clear();
            cmbTipoTelefono.SelectedIndex = -1;
            TelefonoTransporte.CargarDatos(Telefonos);
            txtNumeroTelefonico.Focus();            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNumeroTelefonico.Text ))
            {
                Utilities.GetMessage("", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(cmbTipoTelefono.SelectedIndex==-1)
            {
                Utilities.GetMessage("", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            telefonoDTO = new TelefonoDTO
            {
                ClienteId = Cliente != null ? Cliente.Id : 0,
                NumeroTelefonico = txtNumeroTelefonico.Text,
                TipoTelefonoId = int.Parse(cmbTipoTelefono.SelectedValue.ToString())
            };
            if (Cliente != null)
            {
                if (id == 0)
                {

                    TelefonoHelp.Guardar(telefonoDTO);
                }
                else
                {
                    TelefonoHelp.Actualizar(id, telefonoDTO );
                }
                Telefonos = TelefonoTransporte.GetList(Cliente.Id);
                Nuevo();
                return;
            }
            if (id == 0)
            {
                id = Telefonos.Count == 0 ? 1 : Telefonos.Last().Id + 1;
            }
            TelefonoView telefono = Telefonos.Where(x => x.Id ==id).FirstOrDefault();
              
            if (telefono == null)
            {
                telefono = new TelefonoView
                {
                    Id =id,
                    ClienteId = Cliente != null ? Cliente.Id : 0,
                    NumeroTelefonico = txtNumeroTelefonico.Text,
                    TipoTelefono = cmbTipoTelefono.Text,
                    TipoTelefonoId = int.Parse(cmbTipoTelefono.SelectedValue.ToString())
                };
                id++;
                Telefonos.Add(telefono);
            }
            else
            {
                telefono.ClienteId = Cliente != null ? Cliente.Id : 0;
                telefono.NumeroTelefonico = txtNumeroTelefonico.Text;
                telefono.TipoTelefono = cmbTipoTelefono.Text;
                telefono.TipoTelefonoId = int.Parse(cmbTipoTelefono.SelectedValue.ToString());                
            }
            Nuevo();        
        }
        /*void CargarTelefono()
        {
            bindTelefonos.Clear();
            foreach (TelefonoView telefonoView in Telefonos)
            {
                bindTelefonos.Add(telefonoView);
            }
        }*/
        private void frmTelefono_Load(object sender, EventArgs e)
        {
            id = 0;
            if(Cliente==null)      
            {
                if (Telefonos != null)
                { 
                    if(Telefonos .Count!=0&& Telefonos.FirstOrDefault() .ClienteId !=0)
                    {
                        Telefonos.Clear();
                    }
                }
                Telefonos = new List<TelefonoView>();
            }
            else 
            {                
                Telefonos = TelefonoTransporte.GetList(Cliente .Id  );
            }
            Nuevo();
            Utilities.Cmb(cmbTipoTelefono, tipoTelefonoHelp.TEntity.ToList());

        }

        private void dgTelefono_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            string NumeroTelefonico = dgTelefono.Rows[e.RowIndex].Cells["NumeroTelefonico"].Value.ToString();
            id = int.Parse(dgTelefono.Rows[e.RowIndex].Cells["Colid"].Value.ToString());
            switch (col)
            {
                case 0:
                    {
                        var telefono = Telefonos.Where(c => c.NumeroTelefonico.Contains(NumeroTelefonico)).FirstOrDefault();
                        if(telefono!=null)
                        {
            
                            txtNumeroTelefonico.Text = telefono.NumeroTelefonico;
                            cmbTipoTelefono.SelectedValue = telefono.TipoTelefonoId;
                        }
                        break;
                    }
                case 1:
                    {
                        DialogResult result = MessageBox.Show("Desea eliminar este registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (Cliente != null)
                            {
                                TelefonoHelp.Eliminar(id);
                            }
                            else
                            {
                                var telefono = Telefonos.Where(c => c.NumeroTelefonico.Contains(NumeroTelefonico)).FirstOrDefault();
                                Telefonos.Remove(telefono);                               
                            }
                            Nuevo();
                        }
                        break;
                    }

            }
            

        }
    }
}
