namespace PEscritorio
{
    partial class ticketbueno
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
            this.tICKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPinturaJuarezDataSet = new PEscritorio.BDPinturaJuarezDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tICKETTableAdapter = new PEscritorio.BDPinturaJuarezDataSetTableAdapters.TICKETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tICKETBindingSource
            // 
            this.tICKETBindingSource.DataMember = "TICKET";
            this.tICKETBindingSource.DataSource = this.bDPinturaJuarezDataSet;
            this.tICKETBindingSource.CurrentChanged += new System.EventHandler(this.tICKETBindingSource_CurrentChanged);
            // 
            // bDPinturaJuarezDataSet
            // 
            this.bDPinturaJuarezDataSet.DataSetName = "BDPinturaJuarezDataSet";
            this.bDPinturaJuarezDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tICKETBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PEscritorio.TICK1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(764, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // tICKETTableAdapter
            // 
            this.tICKETTableAdapter.ClearBeforeFill = true;
            // 
            // ticketbueno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 492);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ticketbueno";
            this.Text = "ticketbueno";
            this.Load += new System.EventHandler(this.ticketbueno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tICKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPinturaJuarezDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tICKETBindingSource;
        private BDPinturaJuarezDataSet bDPinturaJuarezDataSet;
        private BDPinturaJuarezDataSetTableAdapters.TICKETTableAdapter tICKETTableAdapter;
    }
}