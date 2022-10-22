namespace TesteAutomacao
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
            this.btnCleanTxt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExibirResultado = new System.Windows.Forms.Button();
            this.exibir_navegador = new System.Windows.Forms.CheckBox();
            this.txtLog = new System.Windows.Forms.ListBox();
            this.painel = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.one = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.two = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCleanTxt
            // 
            this.btnCleanTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCleanTxt.Location = new System.Drawing.Point(277, 608);
            this.btnCleanTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCleanTxt.Name = "btnCleanTxt";
            this.btnCleanTxt.Size = new System.Drawing.Size(228, 54);
            this.btnCleanTxt.TabIndex = 0;
            this.btnCleanTxt.Text = "Limpar histórico";
            this.btnCleanTxt.UseVisualStyleBackColor = true;
            this.btnCleanTxt.Click += new System.EventHandler(this.btnCleanTxt_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(531, 608);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Extrair Informações";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExibirResultado
            // 
            this.btnExibirResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExibirResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExibirResultado.Location = new System.Drawing.Point(29, 608);
            this.btnExibirResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExibirResultado.Name = "btnExibirResultado";
            this.btnExibirResultado.Size = new System.Drawing.Size(228, 54);
            this.btnExibirResultado.TabIndex = 2;
            this.btnExibirResultado.Text = "Exibir resultado dos jogos";
            this.btnExibirResultado.UseVisualStyleBackColor = true;
            this.btnExibirResultado.Click += new System.EventHandler(this.btnExibirResultado_Click);
            // 
            // exibir_navegador
            // 
            this.exibir_navegador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exibir_navegador.AutoSize = true;
            this.exibir_navegador.Checked = true;
            this.exibir_navegador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exibir_navegador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exibir_navegador.Location = new System.Drawing.Point(29, 566);
            this.exibir_navegador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exibir_navegador.Name = "exibir_navegador";
            this.exibir_navegador.Size = new System.Drawing.Size(222, 24);
            this.exibir_navegador.TabIndex = 3;
            this.exibir_navegador.Text = "Manter Navegador Oculto";
            this.exibir_navegador.UseVisualStyleBackColor = true;
            this.exibir_navegador.CheckedChanged += new System.EventHandler(this.exibir_navegador_CheckedChanged);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.FormattingEnabled = true;
            this.txtLog.ItemHeight = 16;
            this.txtLog.Location = new System.Drawing.Point(29, 16);
            this.txtLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(800, 52);
            this.txtLog.TabIndex = 4;
            this.txtLog.SelectedIndexChanged += new System.EventHandler(this.txtLog_SelectedIndexChanged);
            // 
            // painel
            // 
            this.painel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.hour,
            this.time,
            this.one,
            this.exe,
            this.two});
            this.painel.HideSelection = false;
            this.painel.Location = new System.Drawing.Point(29, 70);
            this.painel.Margin = new System.Windows.Forms.Padding(4);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(800, 488);
            this.painel.TabIndex = 5;
            this.painel.UseCompatibleStateImageBehavior = false;
            // 
            // date
            // 
            this.date.Text = "Data";
            this.date.Width = 150;
            // 
            // hour
            // 
            this.hour.Text = "Hora";
            this.hour.Width = 70;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 120;
            // 
            // one
            // 
            this.one.Text = "1";
            this.one.Width = 50;
            // 
            // exe
            // 
            this.exe.Text = "X";
            this.exe.Width = 50;
            // 
            // two
            // 
            this.two.Text = "2";
            this.two.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 711);
            this.Controls.Add(this.painel);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.exibir_navegador);
            this.Controls.Add(this.btnExibirResultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCleanTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Resultado dos jogos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCleanTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExibirResultado;
        private System.Windows.Forms.CheckBox exibir_navegador;
        private System.Windows.Forms.ListBox txtLog;
        private System.Windows.Forms.ListView painel;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader hour;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader one;
        private System.Windows.Forms.ColumnHeader exe;
        private System.Windows.Forms.ColumnHeader two;
    }
}

