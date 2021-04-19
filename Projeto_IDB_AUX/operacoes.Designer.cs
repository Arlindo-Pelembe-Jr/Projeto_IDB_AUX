namespace Projeto_IDB_AUX
{
    partial class operacoes
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
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_fornecedor = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 480);
            this.panel1.TabIndex = 0;
            // 
            // btn_produtos
            // 
            this.btn_produtos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_produtos.Location = new System.Drawing.Point(-16, 24);
            this.btn_produtos.Margin = new System.Windows.Forms.Padding(15, 24, 15, 24);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(548, 86);
            this.btn_produtos.TabIndex = 7;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.UseVisualStyleBackColor = true;
            this.btn_produtos.Click += new System.EventHandler(this.btn_produtos_Click);
            // 
            // btn_fornecedor
            // 
            this.btn_fornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fornecedor.Location = new System.Drawing.Point(-16, 142);
            this.btn_fornecedor.Margin = new System.Windows.Forms.Padding(15, 24, 15, 24);
            this.btn_fornecedor.Name = "btn_fornecedor";
            this.btn_fornecedor.Size = new System.Drawing.Size(548, 86);
            this.btn_fornecedor.TabIndex = 6;
            this.btn_fornecedor.Text = "Fornecedor";
            this.btn_fornecedor.UseVisualStyleBackColor = true;
            this.btn_fornecedor.Click += new System.EventHandler(this.btn_fornecedor_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cliente.Location = new System.Drawing.Point(-38, 276);
            this.btn_cliente.Margin = new System.Windows.Forms.Padding(15, 24, 15, 24);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(560, 86);
            this.btn_cliente.TabIndex = 5;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 47);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 47);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_fornecedor);
            this.panel4.Controls.Add(this.btn_produtos);
            this.panel4.Controls.Add(this.btn_cliente);
            this.panel4.Location = new System.Drawing.Point(166, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(511, 374);
            this.panel4.TabIndex = 8;
            // 
            // operacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(816, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "operacoes";
            this.Text = "operacoes";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_fornecedor;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}