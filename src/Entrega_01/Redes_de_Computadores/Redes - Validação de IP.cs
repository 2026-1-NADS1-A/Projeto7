using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PI.REDES_Douglas_Erik_Gustavo_Vinicius_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            // Pega o IP da máquina local
            string ipMaquina = Dns.GetHostEntry(Dns.GetHostName())
                                  .AddressList
                                  .FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?
                                  .ToString() ?? "0.0.0.0";

            // Começa com o valor atual do TextBox
            string ipText = Ipdigitado.Text?.Trim() ?? string.Empty;

            while (true)
            {
                // Valida formato do IP
                if (!IPAddress.TryParse(ipText, out _))
                {
                    MessageBox.Show("IP inválido. Tente novamente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ipText = Interaction.InputBox("Digite um endereço IP válido:", "Entrada de IP", ipText);
                    if (string.IsNullOrWhiteSpace(ipText))
                        return; // Usuário cancelou ou deixou vazio
                    ipText = ipText.Trim();
                    continue;
                }

                // Compara com o IP da máquina
                if (ipText == ipMaquina)
                {
                    MessageBox.Show($"✔ IP correto! Acesso liberado.\nIP: {ipText}", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Ipdigitado.Text = ipText;
                    break;
                }
                else
                {
                    MessageBox.Show($"❌ IP não corresponde à máquina.\nIP digitado: {ipText}\nTente novamente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ipText = Interaction.InputBox("Digite o IP da máquina:", "Entrada de IP", ipText);
                    if (string.IsNullOrWhiteSpace(ipText))
                        return;
                    ipText = ipText.Trim();
                    continue;
                }
            }
        }
    }
}
