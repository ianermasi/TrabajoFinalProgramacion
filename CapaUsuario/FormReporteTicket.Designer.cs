namespace CapaUsuario
{
    partial class FormReporteTicket
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
            this.RVTicket = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSTicket = new CapaUsuario.DSTicket();
            this.DTTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTTicketTableAdapter = new CapaUsuario.DSTicketTableAdapters.DTTicketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTTicketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RVTicket
            // 
            this.RVTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSTicketReporte";
            reportDataSource1.Value = this.DTTicketBindingSource;
            this.RVTicket.LocalReport.DataSources.Add(reportDataSource1);
            this.RVTicket.LocalReport.ReportEmbeddedResource = "CapaUsuario.ReporteTicket.rdlc";
            this.RVTicket.Location = new System.Drawing.Point(0, 0);
            this.RVTicket.Name = "RVTicket";
            this.RVTicket.Size = new System.Drawing.Size(942, 638);
            this.RVTicket.TabIndex = 0;
            // 
            // DSTicket
            // 
            this.DSTicket.DataSetName = "DSTicket";
            this.DSTicket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DTTicketBindingSource
            // 
            this.DTTicketBindingSource.DataMember = "DTTicket";
            this.DTTicketBindingSource.DataSource = this.DSTicket;
            // 
            // DTTicketTableAdapter
            // 
            this.DTTicketTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 638);
            this.Controls.Add(this.RVTicket);
            this.Name = "FormReporteTicket";
            this.Text = "FormReporteTicket";
            this.Load += new System.EventHandler(this.FormReporteTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTTicketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVTicket;
        private System.Windows.Forms.BindingSource DTTicketBindingSource;
        private DSTicket DSTicket;
        private DSTicketTableAdapters.DTTicketTableAdapter DTTicketTableAdapter;
    }
}