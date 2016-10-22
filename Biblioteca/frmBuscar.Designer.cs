namespace Biblioteca
{
    partial class frmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.btnBusc = new System.Windows.Forms.Button();
            this.dtgvCliente = new System.Windows.Forms.DataGridView();
            this.txtBusc = new System.Windows.Forms.TextBox();
            this.grBus = new System.Windows.Forms.GroupBox();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.rdbCod = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCliente)).BeginInit();
            this.grBus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBusc
            // 
            this.btnBusc.Location = new System.Drawing.Point(256, 96);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(75, 23);
            this.btnBusc.TabIndex = 9;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click_1);
            // 
            // dtgvCliente
            // 
            this.dtgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCliente.Location = new System.Drawing.Point(34, 137);
            this.dtgvCliente.Name = "dtgvCliente";
            this.dtgvCliente.Size = new System.Drawing.Size(517, 147);
            this.dtgvCliente.TabIndex = 8;
            this.dtgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCliente_CellContentClick);
            // 
            // txtBusc
            // 
            this.txtBusc.Location = new System.Drawing.Point(247, 57);
            this.txtBusc.Name = "txtBusc";
            this.txtBusc.Size = new System.Drawing.Size(170, 20);
            this.txtBusc.TabIndex = 7;
            // 
            // grBus
            // 
            this.grBus.Controls.Add(this.rdbNome);
            this.grBus.Controls.Add(this.rdbCod);
            this.grBus.Controls.Add(this.rdbTodos);
            this.grBus.Location = new System.Drawing.Point(28, 31);
            this.grBus.Name = "grBus";
            this.grBus.Size = new System.Drawing.Size(200, 100);
            this.grBus.TabIndex = 5;
            this.grBus.TabStop = false;
            this.grBus.Text = "Pesquisar Clientes:";
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(6, 43);
            this.rdbNome.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(72, 17);
            this.rdbNome.TabIndex = 3;
            this.rdbNome.Text = "Por Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            this.rdbNome.CheckedChanged += new System.EventHandler(this.rdbNome_CheckedChanged);
            // 
            // rdbCod
            // 
            this.rdbCod.AutoSize = true;
            this.rdbCod.Location = new System.Drawing.Point(6, 65);
            this.rdbCod.Name = "rdbCod";
            this.rdbCod.Size = new System.Drawing.Size(106, 17);
            this.rdbCod.TabIndex = 1;
            this.rdbCod.TabStop = true;
            this.rdbCod.Text = "Codigo de barra :";
            this.rdbCod.UseVisualStyleBackColor = true;
            this.rdbCod.CheckedChanged += new System.EventHandler(this.rdbCod_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(6, 19);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(58, 17);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos:";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(253, 22);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(0, 13);
            this.lblTexto.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(342, 96);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 307);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnBusc);
            this.Controls.Add(this.dtgvCliente);
            this.Controls.Add(this.txtBusc);
            this.Controls.Add(this.grBus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCliente)).EndInit();
            this.grBus.ResumeLayout(false);
            this.grBus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusc;
        private System.Windows.Forms.DataGridView dtgvCliente;
        private System.Windows.Forms.TextBox txtBusc;
        private System.Windows.Forms.GroupBox grBus;
        private System.Windows.Forms.RadioButton rdbCod;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnSair;
    }
}