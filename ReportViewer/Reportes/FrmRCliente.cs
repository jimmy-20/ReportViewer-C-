using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportViewer.Reportes
{
    public partial class FrmRCliente : Form
    {
        public FrmRCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSClientes.Cliente' Puede moverla o quitarla según sea necesario.
            this.ClienteTableAdapter.Fill(this.DSClientes.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
