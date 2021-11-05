
namespace ReportViewer.Reportes
{
    partial class FrmRVehiculo
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DTVehiculos = new ReportViewer.Reportes.DTVehiculos();
            this.VehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VehiculoTableAdapter = new ReportViewer.Reportes.DTVehiculosTableAdapters.VehiculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DTVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VehiculoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportViewer.Reportes.ReportVehiculos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DTVehiculos
            // 
            this.DTVehiculos.DataSetName = "DTVehiculos";
            this.DTVehiculos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VehiculoBindingSource
            // 
            this.VehiculoBindingSource.DataMember = "Vehiculo";
            this.VehiculoBindingSource.DataSource = this.DTVehiculos;
            // 
            // VehiculoTableAdapter
            // 
            this.VehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmVehiculo";
            this.Text = "Frm";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VehiculoBindingSource;
        private DTVehiculos DTVehiculos;
        private DTVehiculosTableAdapters.VehiculoTableAdapter VehiculoTableAdapter;
    }
}