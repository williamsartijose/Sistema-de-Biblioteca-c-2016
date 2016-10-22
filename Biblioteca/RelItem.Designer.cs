namespace Biblioteca
{
    partial class RelItem
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
            this.BIBLIOTECADataSet = new Biblioteca.BIBLIOTECADataSet();
            this.Itens_LocacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Itens_LocacaoTableAdapter = new Biblioteca.BIBLIOTECADataSetTableAdapters.Itens_LocacaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BIBLIOTECADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Itens_LocacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Itens_LocacaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca.RelItem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(589, 282);
            this.reportViewer1.TabIndex = 0;
            // 
            // BIBLIOTECADataSet
            // 
            this.BIBLIOTECADataSet.DataSetName = "BIBLIOTECADataSet";
            this.BIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Itens_LocacaoBindingSource
            // 
            this.Itens_LocacaoBindingSource.DataMember = "Itens_Locacao";
            this.Itens_LocacaoBindingSource.DataSource = this.BIBLIOTECADataSet;
            // 
            // Itens_LocacaoTableAdapter
            // 
            this.Itens_LocacaoTableAdapter.ClearBeforeFill = true;
            // 
            // RelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 282);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelItem";
            this.Text = "RelItem";
            this.Load += new System.EventHandler(this.RelItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BIBLIOTECADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Itens_LocacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Itens_LocacaoBindingSource;
        private BIBLIOTECADataSet BIBLIOTECADataSet;
        private BIBLIOTECADataSetTableAdapters.Itens_LocacaoTableAdapter Itens_LocacaoTableAdapter;
    }
}