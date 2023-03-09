using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace SerialTester
{
    public partial class Form1 : Form
    {
        string rxString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarComs();
            atualizaBaud();
            cbBitsDados.SelectedText = "8";
            paridadeMetodo();
            bitsParadaMetodo();
            btnDesconectar.Enabled = false;
            lblEstabiliza.ForeColor = Color.Yellow;
        }

        private void atualizarComs()
        {
            cbPorta.Items.Clear();
            try
            {
                foreach(string str in SerialPort.GetPortNames())
                {
                    cbPorta.Items.Add(str);
                }
                cbPorta.SelectedIndex= 0;
            }
            catch(Exception ex) {
                MessageBox.Show("Nao existem disp. validos conectados");
            }
        }

        private void atualizaBaud()
        {
            cbPorta.Items.Clear();
            cbBaud.SelectedIndex = 0;
        }

        private void paridadeMetodo()
        {
            int i = 0;
            cbParidade.Items.Clear();
            foreach (string str in Enum.GetNames(typeof(Parity)))
            {
                cbParidade.Items.Add(str);
                if (str == "None")
                {
                    cbParidade.SelectedIndex = i;
                }
                i++;
            }
        }

        private void bitsParadaMetodo()
        {
            int i = 0;
            cbBitsParada.Items.Clear();
            foreach (string str in Enum.GetNames(typeof(StopBits)))
            {
                cbBitsParada.Items.Add(str);
                if (str == "One")
                {
                    cbBitsParada.SelectedIndex = i;
                }
                i++;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            serialPort1.PortName= cbPorta.Text;
            serialPort1.BaudRate = Int32.Parse(cbBaud.Text);
            serialPort1.Parity = (Parity)cbParidade.SelectedIndex;
            serialPort1.DataBits = Int32.Parse(cbBitsDados.Text);
            serialPort1.StopBits = (StopBits)cbBitsParada.SelectedIndex;
            try
            {
                serialPort1.Open();
                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nao foi possivel abrir a conexao com a porta selecionada.");
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = true;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = serialPort1.BytesToRead;
            byte[] buffer = new byte[bytes];
            //rxString = serialPort1.ReadExisting();

            rxString = serialPort1.Read(buffer, 0, bytes).ToString();
            rxString = Encoding.ASCII.GetString(buffer);
            this.Invoke(new EventHandler(dadoRecebido)); //invoca outra thread para escrever o dado no form

        }

        private void dadoRecebido(object sender, EventArgs e)
        {
            //?3p`000180000000
            //txtBoxRecebe.Text = rxString;
            txtBoxRecebe.AppendText(rxString); // aqui ta adicionando na caixa com append apenas
            if (rxString.Contains("p") || rxString.Contains("P"))
            {
                int indexInterr = rxString.IndexOf("?");
                string nString = rxString.Remove(indexInterr, 4);
                int number = Int32.Parse(nString);

                txtPesoBruto.Text = number.ToString("F", CultureInfo.InvariantCulture);
                rxString = "";
                nString = "";

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxRecebe.Text = "";           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                serialPort1.Dispose();
            }
            Application.Exit();
        }
        

    }
}
