namespace Projeto_IDB_AUX
{
    partial class Pedido_e_Requisicao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_gerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ped_dia_de_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nr_requisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_gere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_requisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 148);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frescos da Mary";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 440);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 440);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.cod_cliente,
            this.cod_gerente,
            this.ped_quantidade,
            this.ped_data,
            this.ped_dia_de_entrega});
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(586, 241);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pedidos";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(595, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(605, 440);
            this.panel4.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr_requisicao,
            this.cod_gere,
            this.cod_produto,
            this.data_requisicao});
            this.dataGridView2.Location = new System.Drawing.Point(3, 81);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(602, 241);
            this.dataGridView2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Requisicao";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "pedido_cod";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // cod_cliente
            // 
            this.cod_cliente.DataPropertyName = "cod_cliente";
            this.cod_cliente.HeaderText = "Codigo Cliente";
            this.cod_cliente.Name = "cod_cliente";
            this.cod_cliente.ReadOnly = true;
            // 
            // cod_gerente
            // 
            this.cod_gerente.DataPropertyName = "cod_gerente";
            this.cod_gerente.HeaderText = "Codigo Gerente";
            this.cod_gerente.Name = "cod_gerente";
            this.cod_gerente.ReadOnly = true;
            // 
            // ped_quantidade
            // 
            this.ped_quantidade.DataPropertyName = "ped_quantidade";
            this.ped_quantidade.HeaderText = "Quantidade";
            this.ped_quantidade.Name = "ped_quantidade";
            this.ped_quantidade.ReadOnly = true;
            // 
            // ped_data
            // 
            this.ped_data.DataPropertyName = "ped_data";
            this.ped_data.HeaderText = "Data Pedido";
            this.ped_data.Name = "ped_data";
            this.ped_data.ReadOnly = true;
            // 
            // ped_dia_de_entrega
            // 
            this.ped_dia_de_entrega.DataPropertyName = "ped_dia_de_entrega";
            this.ped_dia_de_entrega.HeaderText = "Data Entrega";
            this.ped_dia_de_entrega.Name = "ped_dia_de_entrega";
            this.ped_dia_de_entrega.ReadOnly = true;
            // 
            // nr_requisicao
            // 
            this.nr_requisicao.DataPropertyName = "nr_requisicao";
            this.nr_requisicao.HeaderText = "Nr Requisicao";
            this.nr_requisicao.Name = "nr_requisicao";
            this.nr_requisicao.ReadOnly = true;
            // 
            // cod_gere
            // 
            this.cod_gere.DataPropertyName = "cod_gerente";
            this.cod_gere.HeaderText = "Codigo Gerente";
            this.cod_gere.Name = "cod_gere";
            this.cod_gere.ReadOnly = true;
            // 
            // cod_produto
            // 
            this.cod_produto.DataPropertyName = "cod_produto";
            this.cod_produto.HeaderText = "Codigo Produto";
            this.cod_produto.Name = "cod_produto";
            this.cod_produto.ReadOnly = true;
            // 
            // data_requisicao
            // 
            this.data_requisicao.DataPropertyName = "data_requisicao";
            this.data_requisicao.HeaderText = "Data Requisicao";
            this.data_requisicao.Name = "data_requisicao";
            this.data_requisicao.ReadOnly = true;
            // 
            // Pedido_e_Requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pedido_e_Requisicao";
            this.Text = "Pedido_e_Requisicao";
            this.Load += new System.EventHandler(this.Pedido_e_Requisicao_Load);
            this.Shown += new System.EventHandler(this.Pedido_e_Requisicao_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_requisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_gere;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_requisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_gerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn ped_dia_de_entrega;
    }
}