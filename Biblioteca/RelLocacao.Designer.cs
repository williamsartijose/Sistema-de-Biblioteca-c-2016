namespace Biblioteca
{
    partial class RelLocacao
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
            this.BIBLIOTECADataSet = new Biblioteca.BIBLIOTECADataSet();
            this.LocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LocacaoTableAdapter = new Biblioteca.BIBLIOTECADataSetTableAdapters.LocacaoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BIBLIOTECADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BIBLIOTECADataSet
            // 
            this.BIBLIOTECADataSet.DataSetName = "BIBLIOTECADataSet";
            this.BIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LocacaoBindingSource
            // 
            this.LocacaoBindingSource.DataMember = "Locacao";
            this.LocacaoBindingSource.DataSource = this.BIBLIOTECADataSet;
            // 
            // LocacaoTableAdapter
            // 
            this.LocacaoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LocacaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca.RelLoc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(630, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // RelLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelLocacao";
            this.Text = "RelLocacao";
            this.Load += new System.EventHandler(this.RelLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BIBLIOTECADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BIBLIOTECADataSet BIBLIOTECADataSet;
        private System.Windows.Forms.BindingSource LocacaoBindingSource;
        private BIBLIOTECADataSetTableAdapters.LocacaoTableAdapter LocacaoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}