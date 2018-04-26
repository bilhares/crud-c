namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.txId = new System.Windows.Forms.TextBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txEndereco = new System.Windows.Forms.TextBox();
            this.txCep = new System.Windows.Forms.TextBox();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.txCidade = new System.Windows.Forms.TextBox();
            this.txUf = new System.Windows.Forms.TextBox();
            this.txTelefone = new System.Windows.Forms.TextBox();
            this.txBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "gravar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(12, 41);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(63, 20);
            this.txId.TabIndex = 1;
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(98, 41);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(210, 20);
            this.txNome.TabIndex = 2;
            // 
            // txEndereco
            // 
            this.txEndereco.Location = new System.Drawing.Point(325, 41);
            this.txEndereco.Name = "txEndereco";
            this.txEndereco.Size = new System.Drawing.Size(210, 20);
            this.txEndereco.TabIndex = 3;
            // 
            // txCep
            // 
            this.txCep.Location = new System.Drawing.Point(12, 79);
            this.txCep.Name = "txCep";
            this.txCep.Size = new System.Drawing.Size(117, 20);
            this.txCep.TabIndex = 4;
            // 
            // txBairro
            // 
            this.txBairro.Location = new System.Drawing.Point(143, 79);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(151, 20);
            this.txBairro.TabIndex = 5;
            // 
            // txCidade
            // 
            this.txCidade.Location = new System.Drawing.Point(308, 79);
            this.txCidade.Name = "txCidade";
            this.txCidade.Size = new System.Drawing.Size(151, 20);
            this.txCidade.TabIndex = 6;
            // 
            // txUf
            // 
            this.txUf.Location = new System.Drawing.Point(465, 79);
            this.txUf.Name = "txUf";
            this.txUf.Size = new System.Drawing.Size(58, 20);
            this.txUf.TabIndex = 7;
            // 
            // txTelefone
            // 
            this.txTelefone.Location = new System.Drawing.Point(12, 121);
            this.txTelefone.Name = "txTelefone";
            this.txTelefone.Size = new System.Drawing.Size(151, 20);
            this.txTelefone.TabIndex = 8;
            // 
            // txBusca
            // 
            this.txBusca.Location = new System.Drawing.Point(159, 13);
            this.txBusca.Name = "txBusca";
            this.txBusca.Size = new System.Drawing.Size(100, 20);
            this.txBusca.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "buscar";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(265, 10);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 11;
            this.btBuscar.Text = "buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 176);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBusca);
            this.Controls.Add(this.txTelefone);
            this.Controls.Add(this.txUf);
            this.Controls.Add(this.txCidade);
            this.Controls.Add(this.txBairro);
            this.Controls.Add(this.txCep);
            this.Controls.Add(this.txEndereco);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txEndereco;
        private System.Windows.Forms.TextBox txCep;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.TextBox txCidade;
        private System.Windows.Forms.TextBox txUf;
        private System.Windows.Forms.TextBox txTelefone;
        private System.Windows.Forms.TextBox txBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscar;
    }
}

