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
    public partial class FrmRVehiculo : Form
    {
        public FrmRVehiculo()
        {
            InitializeComponent();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DTVehiculos.Vehiculo' Puede moverla o quitarla según sea necesario.
            this.VehiculoTableAdapter.Fill(this.DTVehiculos.Vehiculo);

            this.reportViewer1.RefreshReport();
        }
    }
}
