using ReportViewer.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportViewer
{
    public partial class FrmPrincipal : Form
    {
        private FrmRVehiculo ReportVehiculo;
        private FrmRCliente ReportCliente;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mniRCliente_Click(object sender, EventArgs e)
        {
            if (ReportCliente == null)
            {
                ReportCliente = new FrmRCliente();
                ReportCliente.MdiParent = this;
            }

            ReportCliente.Show();
        }

        private void mniRVehiculo_Click(object sender, EventArgs e)
        {
            if (ReportVehiculo == null)
            {
                ReportVehiculo = new FrmRVehiculo();
                ReportVehiculo.MdiParent = this;
            }

            ReportVehiculo.Show();
        }
    }
}
