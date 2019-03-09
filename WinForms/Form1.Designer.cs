namespace WinForms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlfabeto = new System.Windows.Forms.TextBox();
            this.btnAlfabeto = new System.Windows.Forms.Button();
            this.Alfabeto = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RegrasDeProducao = new System.Windows.Forms.DataGridView();
            this.De = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegrasDeProducao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Alfabeto);
            this.groupBox1.Controls.Add(this.txtAlfabeto);
            this.groupBox1.Controls.Add(this.btnAlfabeto);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 254);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alfabeto";
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(45, 153);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(95, 20);
            this.txtAlfabeto.TabIndex = 6;
            // 
            // btnAlfabeto
            // 
            this.btnAlfabeto.Location = new System.Drawing.Point(45, 179);
            this.btnAlfabeto.Name = "btnAlfabeto";
            this.btnAlfabeto.Size = new System.Drawing.Size(95, 22);
            this.btnAlfabeto.TabIndex = 6;
            this.btnAlfabeto.Text = "Adicionar";
            this.btnAlfabeto.UseVisualStyleBackColor = true;
            this.btnAlfabeto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alfabeto
            // 
            this.Alfabeto.Location = new System.Drawing.Point(6, 19);
            this.Alfabeto.Name = "Alfabeto";
            this.Alfabeto.Size = new System.Drawing.Size(134, 115);
            this.Alfabeto.TabIndex = 6;
            this.Alfabeto.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RegrasDeProducao);
            this.groupBox2.Location = new System.Drawing.Point(183, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 254);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Regras de Produção";
            // 
            // RegrasDeProducao
            // 
            this.RegrasDeProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegrasDeProducao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.De,
            this.Para});
            this.RegrasDeProducao.Location = new System.Drawing.Point(6, 19);
            this.RegrasDeProducao.Name = "RegrasDeProducao";
            this.RegrasDeProducao.ShowCellErrors = false;
            this.RegrasDeProducao.ShowCellToolTips = false;
            this.RegrasDeProducao.ShowEditingIcon = false;
            this.RegrasDeProducao.ShowRowErrors = false;
            this.RegrasDeProducao.Size = new System.Drawing.Size(244, 229);
            this.RegrasDeProducao.TabIndex = 12;
            // 
            // De
            // 
            this.De.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.De.HeaderText = "De";
            this.De.Name = "De";
            // 
            // Para
            // 
            this.Para.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Para.HeaderText = "Para";
            this.Para.Name = "Para";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegrasDeProducao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAlfabeto;
        private System.Windows.Forms.Button btnAlfabeto;
        private System.Windows.Forms.ListView Alfabeto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView RegrasDeProducao;
        private System.Windows.Forms.DataGridViewTextBoxColumn De;
        private System.Windows.Forms.DataGridViewTextBoxColumn Para;
    }
}

