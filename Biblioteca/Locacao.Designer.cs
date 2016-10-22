namespace Biblioteca
{
    partial class Locacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Locacao));
            this.bIBLIOTECADataSet = new Biblioteca.BIBLIOTECADataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Biblioteca.BIBLIOTECADataSetTableAdapters.ClienteTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnItLocGravar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnItLocNovo = new System.Windows.Forms.Button();
            this.cmbLivro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgItensLivro = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblIdItLoc = new System.Windows.Forms.Label();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdLoc = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dtgLivro = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensLivro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // bIBLIOTECADataSet
            // 
            this.bIBLIOTECADataSet.DataSetName = "BIBLIOTECADataSet";
            this.bIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bIBLIOTECADataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnItLocGravar);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnItLocNovo);
            this.panel2.Controls.Add(this.cmbLivro);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtgItensLivro);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblIdItLoc);
            this.panel2.Controls.Add(this.txtLivro);
            this.panel2.Location = new System.Drawing.Point(11, 275);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 261);
            this.panel2.TabIndex = 25;
            // 
            // btnItLocGravar
            // 
            this.btnItLocGravar.BackgroundImage = global::Biblioteca.Properties.Resources.download1;
            this.btnItLocGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItLocGravar.Enabled = false;
            this.btnItLocGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItLocGravar.Location = new System.Drawing.Point(567, 101);
            this.btnItLocGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnItLocGravar.Name = "btnItLocGravar";
            this.btnItLocGravar.Size = new System.Drawing.Size(65, 36);
            this.btnItLocGravar.TabIndex = 26;
            this.btnItLocGravar.UseVisualStyleBackColor = true;
            this.btnItLocGravar.Click += new System.EventHandler(this.btnItLocGravar_Click_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Biblioteca.Properties.Resources.sair;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(636, 101);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 36);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnItLocNovo
            // 
            this.btnItLocNovo.BackgroundImage = global::Biblioteca.Properties.Resources.Variados_0415_page_blank_add_32;
            this.btnItLocNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItLocNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItLocNovo.Location = new System.Drawing.Point(486, 101);
            this.btnItLocNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnItLocNovo.Name = "btnItLocNovo";
            this.btnItLocNovo.Size = new System.Drawing.Size(73, 36);
            this.btnItLocNovo.TabIndex = 25;
            this.btnItLocNovo.UseVisualStyleBackColor = true;
            this.btnItLocNovo.Click += new System.EventHandler(this.btnItLocNovo_Click);
            // 
            // cmbLivro
            // 
            this.cmbLivro.Enabled = false;
            this.cmbLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLivro.FormattingEnabled = true;
            this.cmbLivro.Location = new System.Drawing.Point(166, 60);
            this.cmbLivro.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLivro.Name = "cmbLivro";
            this.cmbLivro.Size = new System.Drawing.Size(246, 28);
            this.cmbLivro.TabIndex = 22;
            this.cmbLivro.SelectedIndexChanged += new System.EventHandler(this.cmbLivro_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(663, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Itens Locação ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID:";
            // 
            // dtgItensLivro
            // 
            this.dtgItensLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensLivro.Location = new System.Drawing.Point(8, 141);
            this.dtgItensLivro.Margin = new System.Windows.Forms.Padding(2);
            this.dtgItensLivro.Name = "dtgItensLivro";
            this.dtgItensLivro.RowTemplate.Height = 24;
            this.dtgItensLivro.Size = new System.Drawing.Size(750, 104);
            this.dtgItensLivro.TabIndex = 21;
            this.dtgItensLivro.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgItensLivro_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Livro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(77, 94);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 19);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblIdItLoc
            // 
            this.lblIdItLoc.AutoSize = true;
            this.lblIdItLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdItLoc.Location = new System.Drawing.Point(77, 30);
            this.lblIdItLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdItLoc.Name = "lblIdItLoc";
            this.lblIdItLoc.Size = new System.Drawing.Size(23, 20);
            this.lblIdItLoc.TabIndex = 16;
            this.lblIdItLoc.Text = "-1";
            // 
            // txtLivro
            // 
            this.txtLivro.Enabled = false;
            this.txtLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLivro.Location = new System.Drawing.Point(77, 60);
            this.txtLivro.Margin = new System.Windows.Forms.Padding(2);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(76, 26);
            this.txtLivro.TabIndex = 17;
            this.txtLivro.TextChanged += new System.EventHandler(this.txtLivro_TextChanged);
            this.txtLivro.Leave += new System.EventHandler(this.txtLivro_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BackgroundImage = global::Biblioteca.Properties.Resources.biblioteca_digital;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.lblIdLoc);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.dtgLivro);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(11, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 268);
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(696, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "LOCAÇÂO";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Enabled = false;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(202, 82);
            this.cmbCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(237, 28);
            this.cmbCliente.TabIndex = 12;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data: ";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // txtData
            // 
            this.txtData.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(93, 43);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(146, 26);
            this.txtData.TabIndex = 4;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(93, 82);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(93, 26);
            this.txtIdCliente.TabIndex = 5;
            this.txtIdCliente.Leave += new System.EventHandler(this.txtIdCliente_Leave);
            // 
            // lblIdLoc
            // 
            this.lblIdLoc.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lblIdLoc.AutoSize = true;
            this.lblIdLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoc.Location = new System.Drawing.Point(89, 8);
            this.lblIdLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdLoc.Name = "lblIdLoc";
            this.lblIdLoc.Size = new System.Drawing.Size(23, 20);
            this.lblIdLoc.TabIndex = 6;
            this.lblIdLoc.Text = "-1";
            this.lblIdLoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGravar
            // 
            this.btnGravar.BackgroundImage = global::Biblioteca.Properties.Resources.download1;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravar.Enabled = false;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(567, 110);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(65, 36);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // dtgLivro
            // 
            this.dtgLivro.AllowUserToResizeColumns = false;
            this.dtgLivro.AllowUserToResizeRows = false;
            this.dtgLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLivro.Location = new System.Drawing.Point(8, 150);
            this.dtgLivro.Margin = new System.Windows.Forms.Padding(2);
            this.dtgLivro.Name = "dtgLivro";
            this.dtgLivro.RowTemplate.Height = 24;
            this.dtgLivro.Size = new System.Drawing.Size(746, 105);
            this.dtgLivro.TabIndex = 9;
            this.dtgLivro.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgLivro_MouseDoubleClick);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::Biblioteca.Properties.Resources.sair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(636, 110);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 36);
            this.btnSair.TabIndex = 10;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::Biblioteca.Properties.Resources.Variados_0415_page_blank_add_32;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(485, 110);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(73, 36);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // Locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Locacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Locacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensLivro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLivro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgItensLivro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblIdItLoc;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgLivro;
        private System.Windows.Forms.Label lblIdLoc;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnItLocNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovo;
        private BIBLIOTECADataSet bIBLIOTECADataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BIBLIOTECADataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button btnItLocGravar;
        private System.Windows.Forms.Button button2;
    }
}