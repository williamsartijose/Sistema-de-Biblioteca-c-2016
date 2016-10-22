namespace Biblioteca
{
    partial class RelLivro
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
            this.LivroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LivroTableAdapter = new Biblioteca.BIBLIOTECADataSetTableAdapters.LivroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BIBLIOTECADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LivroBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Biblioteca.RelLivro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(497, 280);
            this.reportViewer1.TabIndex = 0;
            // 
            // BIBLIOTECADataSet
            // 
            this.BIBLIOTECADataSet.DataSetName = "BIBLIOTECADataSet";
            this.BIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LivroBindingSource
            // 
            this.LivroBindingSource.DataMember = "Livro";
            this.LivroBindingSource.DataSource = this.BIBLIOTECADataSet;
            // 
            // LivroTableAdapter
            // 
            this.LivroTableAdapter.ClearBeforeFill = true;
            // 
            // RelLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 280);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelLivro";
            this.Text = "RelLivro";
            this.Load += new System.EventHandler(this.RelLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BIBLIOTECADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LivroBindingSource;
        private BIBLIOTECADataSet BIBLIOTECADataSet;
        private BIBLIOTECADataSetTableAdapters.LivroTableAdapter LivroTableAdapter;
    }
}