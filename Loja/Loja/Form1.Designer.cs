namespace Loja
{
    partial class Form1
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
            this.ProductList = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.txtrep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOpercao
            // 
            this.lblOpercao.AutoSize = true;
            this.lblOpercao.BackColor = System.Drawing.SystemColors.Window;
            this.lblOpercao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpercao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOpercao.Location = new System.Drawing.Point(255, 9);
            this.lblOpercao.Name = "lblOpercao";
            this.lblOpercao.Size = new System.Drawing.Size(236, 30);
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
            this.button1.Location = new System.Drawing.Point(1021, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 175;
            this.button1.Text = "Pedidos Reposição";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductList
            // 
            this.ProductList.Location = new System.Drawing.Point(13, 74);
            this.ProductList.Multiline = true;
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(1121, 477);
            this.ProductList.TabIndex = 176;
            this.ProductList.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 177;
            this.button2.Text = "Produto Maior Lucro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 178;
            this.button3.Text = "Produto Maior Faturamento";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 179;
            this.button4.Text = "Unidade mais vendida";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(629, 45);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 180;
            this.button5.Text = "Faturamento Liquido";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(837, 45);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 23);
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
            this.txtrep.Location = new System.Drawing.Point(260, 190);
            this.txtrep.Multiline = true;
            this.txtrep.Name = "txtrep";
            this.txtrep.Size = new System.Drawing.Size(79, 25);
            this.txtrep.TabIndex = 182;
            this.txtrep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja.Properties.Resources._69036_gestao_de_vendas_utilizando_o_g_suite_para_vender_mais_1144x563;
            this.ClientSize = new System.Drawing.Size(1146, 563);
            this.Controls.Add(this.txtrep);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOpercao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Label lblOpercao;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ProductList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txtrep;
    }
}

