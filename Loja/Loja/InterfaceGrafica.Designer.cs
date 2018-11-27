namespace Loja
{
    partial class InterfaceGrafica
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
      this.lblOpercao = new System.Windows.Forms.Label();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
      this.txtrep = new System.Windows.Forms.TextBox();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.dtvReposicao = new System.Windows.Forms.DataGridView();
      this.coluna_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coluna_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coluna_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.coluna_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dtvListarProdutos = new System.Windows.Forms.DataGridView();
      this.coluna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.COLUNA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.button9 = new System.Windows.Forms.Button();
      this.button10 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtvReposicao)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtvListarProdutos)).BeginInit();
      this.SuspendLayout();
      // 
      // lblOpercao
      // 
      this.lblOpercao.AutoSize = true;
      this.lblOpercao.BackColor = System.Drawing.Color.AliceBlue;
      this.lblOpercao.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOpercao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.lblOpercao.Location = new System.Drawing.Point(442, 24);
      this.lblOpercao.Name = "lblOpercao";
      this.lblOpercao.Size = new System.Drawing.Size(355, 44);
      this.lblOpercao.TabIndex = 173;
      this.lblOpercao.Text = "Gestão de Vendas";
      this.lblOpercao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(230, 359);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(162, 106);
      this.button1.TabIndex = 175;
      this.button1.Text = "Pedidos Reposição";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(12, 207);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(162, 106);
      this.button2.TabIndex = 177;
      this.button2.Text = "Produto Maior Lucro";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.Location = new System.Drawing.Point(12, 61);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(162, 106);
      this.button3.TabIndex = 178;
      this.button3.Text = "Produto Maior Faturamento";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.Location = new System.Drawing.Point(12, 359);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(162, 106);
      this.button4.TabIndex = 179;
      this.button4.Text = "Unidade mais vendida";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button5.Location = new System.Drawing.Point(230, 207);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(162, 106);
      this.button5.TabIndex = 180;
      this.button5.Text = "Faturamento Liquido";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button6.Location = new System.Drawing.Point(230, 61);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(162, 106);
      this.button6.TabIndex = 181;
      this.button6.Text = "Faturamento Bruto";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // openFileDialog2
      // 
      this.openFileDialog2.FileName = "openFileDialog2";
      // 
      // txtrep
      // 
      this.txtrep.BackColor = System.Drawing.SystemColors.InactiveBorder;
      this.txtrep.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtrep.Location = new System.Drawing.Point(634, 244);
      this.txtrep.Multiline = true;
      this.txtrep.Name = "txtrep";
      this.txtrep.Size = new System.Drawing.Size(279, 38);
      this.txtrep.TabIndex = 182;
      this.txtrep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtrep.Visible = false;
      // 
      // button7
      // 
      this.button7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button7.Location = new System.Drawing.Point(12, 492);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(162, 106);
      this.button7.TabIndex = 183;
      this.button7.Text = "Listar Produtos";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // button8
      // 
      this.button8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button8.Location = new System.Drawing.Point(230, 492);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(162, 106);
      this.button8.TabIndex = 184;
      this.button8.Text = "Ordenar";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // dtvReposicao
      // 
      this.dtvReposicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtvReposicao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna_nome,
            this.coluna_quantidade,
            this.coluna_pedido,
            this.coluna_status});
      this.dtvReposicao.Location = new System.Drawing.Point(450, 85);
      this.dtvReposicao.Name = "dtvReposicao";
      this.dtvReposicao.Size = new System.Drawing.Size(572, 480);
      this.dtvReposicao.TabIndex = 185;
      this.dtvReposicao.Visible = false;
      // 
      // coluna_nome
      // 
      this.coluna_nome.HeaderText = "NOME";
      this.coluna_nome.Name = "coluna_nome";
      this.coluna_nome.Width = 200;
      // 
      // coluna_quantidade
      // 
      this.coluna_quantidade.HeaderText = "QUANTIDADE";
      this.coluna_quantidade.Name = "coluna_quantidade";
      // 
      // coluna_pedido
      // 
      this.coluna_pedido.HeaderText = "VALOR PEDIDO";
      this.coluna_pedido.Name = "coluna_pedido";
      this.coluna_pedido.Width = 130;
      // 
      // coluna_status
      // 
      this.coluna_status.HeaderText = "STATUS";
      this.coluna_status.Name = "coluna_status";
      // 
      // dtvListarProdutos
      // 
      this.dtvListarProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
      this.dtvListarProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtvListarProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna1,
            this.COLUNA2});
      this.dtvListarProdutos.Location = new System.Drawing.Point(450, 85);
      this.dtvListarProdutos.Name = "dtvListarProdutos";
      this.dtvListarProdutos.Size = new System.Drawing.Size(390, 480);
      this.dtvListarProdutos.TabIndex = 186;
      this.dtvListarProdutos.Visible = false;
      // 
      // coluna1
      // 
      this.coluna1.HeaderText = "NOME";
      this.coluna1.Name = "coluna1";
      this.coluna1.Width = 200;
      // 
      // COLUNA2
      // 
      this.COLUNA2.HeaderText = "VALOR";
      this.COLUNA2.Name = "COLUNA2";
      this.COLUNA2.Width = 150;
      // 
      // button9
      // 
      this.button9.Location = new System.Drawing.Point(540, 571);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(122, 23);
      this.button9.TabIndex = 187;
      this.button9.Text = "Anterior";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Visible = false;
      this.button9.Click += new System.EventHandler(this.button9_Click);
      // 
      // button10
      // 
      this.button10.Location = new System.Drawing.Point(853, 571);
      this.button10.Name = "button10";
      this.button10.Size = new System.Drawing.Size(122, 23);
      this.button10.TabIndex = 188;
      this.button10.Text = "Próximo";
      this.button10.UseVisualStyleBackColor = true;
      this.button10.Visible = false;
      this.button10.Click += new System.EventHandler(this.button10_Click);
      // 
      // InterfaceGrafica
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Loja.Properties.Resources._69036_gestao_de_vendas_utilizando_o_g_suite_para_vender_mais_1144x563;
      this.ClientSize = new System.Drawing.Size(1146, 600);
      this.Controls.Add(this.button10);
      this.Controls.Add(this.button9);
      this.Controls.Add(this.dtvListarProdutos);
      this.Controls.Add(this.dtvReposicao);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.txtrep);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lblOpercao);
      this.Name = "InterfaceGrafica";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dtvReposicao)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtvListarProdutos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpercao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txtrep;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dtvReposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_status;
        private System.Windows.Forms.DataGridView dtvListarProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUNA2;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button10;
  }
}

