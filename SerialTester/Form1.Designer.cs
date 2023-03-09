namespace SerialTester
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
            this.components = new System.ComponentModel.Container();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.cbPorta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.txtBoxRecebe = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cbBitsDados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbParidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBitsParada = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblEstabiliza = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPesoBruto = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(1075, 110);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(162, 48);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(1267, 110);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(162, 48);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // cbPorta
            // 
            this.cbPorta.FormattingEnabled = true;
            this.cbPorta.Location = new System.Drawing.Point(135, 42);
            this.cbPorta.Name = "cbPorta";
            this.cbPorta.Size = new System.Drawing.Size(228, 33);
            this.cbPorta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Porta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud";
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "4800",
            "9600"});
            this.cbBaud.Location = new System.Drawing.Point(135, 133);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(228, 33);
            this.cbBaud.TabIndex = 5;
            // 
            // txtBoxRecebe
            // 
            this.txtBoxRecebe.Location = new System.Drawing.Point(12, 231);
            this.txtBoxRecebe.Multiline = true;
            this.txtBoxRecebe.Name = "txtBoxRecebe";
            this.txtBoxRecebe.Size = new System.Drawing.Size(906, 545);
            this.txtBoxRecebe.TabIndex = 6;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cbBitsDados
            // 
            this.cbBitsDados.FormattingEnabled = true;
            this.cbBitsDados.Items.AddRange(new object[] {
            "1",
            "7",
            "8"});
            this.cbBitsDados.Location = new System.Drawing.Point(634, 133);
            this.cbBitsDados.Name = "cbBitsDados";
            this.cbBitsDados.Size = new System.Drawing.Size(228, 33);
            this.cbBitsDados.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bits de Dados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Paridade";
            // 
            // cbParidade
            // 
            this.cbParidade.FormattingEnabled = true;
            this.cbParidade.Location = new System.Drawing.Point(634, 42);
            this.cbParidade.Name = "cbParidade";
            this.cbParidade.Size = new System.Drawing.Size(228, 33);
            this.cbParidade.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(901, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bits de Parada";
            // 
            // cbBitsParada
            // 
            this.cbBitsParada.FormattingEnabled = true;
            this.cbBitsParada.Location = new System.Drawing.Point(1075, 42);
            this.cbBitsParada.Name = "cbBitsParada";
            this.cbBitsParada.Size = new System.Drawing.Size(228, 33);
            this.cbBitsParada.TabIndex = 11;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(767, 799);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(151, 48);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblEstabiliza
            // 
            this.lblEstabiliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstabiliza.Location = new System.Drawing.Point(1405, 213);
            this.lblEstabiliza.Name = "lblEstabiliza";
            this.lblEstabiliza.Size = new System.Drawing.Size(286, 72);
            this.lblEstabiliza.TabIndex = 17;
            this.lblEstabiliza.Text = "- - -";
            this.lblEstabiliza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstabiliza.UseMnemonic = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(1568, 110);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(162, 48);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.Location = new System.Drawing.Point(1075, 319);
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.Size = new System.Drawing.Size(159, 31);
            this.txtPesoBruto.TabIndex = 19;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(993, 322);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(61, 25);
            this.lblPeso.TabIndex = 20;
            this.lblPeso.Text = "Peso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1742, 915);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtPesoBruto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblEstabiliza);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBitsParada);
            this.Controls.Add(this.cbBitsDados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbParidade);
            this.Controls.Add(this.txtBoxRecebe);
            this.Controls.Add(this.cbBaud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPorta);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.ComboBox cbPorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.TextBox txtBoxRecebe;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbBitsDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbParidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBitsParada;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblEstabiliza;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtPesoBruto;
        private System.Windows.Forms.Label lblPeso;
    }
}

