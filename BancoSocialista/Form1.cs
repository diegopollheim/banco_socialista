using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoSocialista
{
    public partial class Form1 : Form
    {
        double saldo = 10000;
        double valorSaque;
        double valorDeposito;

        Random gerador = new Random();

        string[] historico = new string[10];
        string[] senha = new string[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChamarSenha_Click(object sender, EventArgs e)
        {
            telaSaldo.Clear();
            senhasGeradas.Clear();
            elementoValor.Clear();
            elementoValor.Focus();

            if (senha[0] != null)
            {
                telaSenha.Text = senha[0];
                senha[0] = null;

                for (int i = 0; i < senha.Length; i++)
                {
                    if (i < senha.Length - 1)
                    {
                        senha[i] = senha[i + 1];
                    }
                    else
                    {
                        senha[i] = null;
                    }
                }

                for (int i = 0; i < senha.Length; i++)
                {
                    if (senha[i] != null)
                    {
                        senhasGeradas.Text += senha[i] + " ";
                    }
                }
            }
            else
            {
                MessageBox.Show("Gere uma senha primeiro!", "Opa");
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            telaSaldo.Clear();
            senhasGeradas.Clear();

            var letraGerada = GeradorDeLetra();

            for (int i = 0; i < senha.Length; i++)
            {
                if (senha[i] == null)
                {
                    senha[i] = letraGerada + gerador.Next(1, 100);
                    break;
                }
            }

            for (int i = 0; i < senha.Length; i++)
            {
                if (senha[i] != null)
                {
                    senhasGeradas.Text += senha[i] + " ";
                }
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            telaSaldo.Clear();

            if (telaSenha.Text != "")
            {
                if (String.IsNullOrWhiteSpace(elementoValor.Text))
                {
                    MessageBox.Show("Informe um valor pra Saque");
                    elementoValor.Focus();
                }

                if (elementoValor.Text != "")
                {
                    valorSaque = Double.Parse(elementoValor.Text);
                }

                if (saldo > 0 && valorSaque > 0 && valorSaque <= saldo)
                {
                    saldo -= valorSaque;

                    for (int i = 0; i < historico.Length; i++)
                    {
                        if (historico[historico.Length - 1] != null)
                        {
                            for (int r = 0; r < historico.Length; r++)
                            {
                                /* ESSE FOR VERIFICA SE A ULTIMA POSICAO DO HISTORICO
                                 * ESTA PREENCHIDA MOVE TODAS ELAS PARA FRENTE ELIMINANDO 
                                 * A MAIS ANTIGA DEIXANDO A ULTIMA LIVRE PARA RECEBER NOVAS INFORMACOES.
                                 */
                                if (r < historico.Length - 1)
                                {
                                    historico[r] = historico[r + 1];
                                }
                                else
                                {
                                    historico[r] = null;
                                }
                            }
                        }

                        if (historico[i] == null)
                        {
                            historico[i] = telaSenha.Text + "            Saque         - " + valorSaque.ToString("C");
                            break;                  
                        }
                    }
                    valorSaque = 0;
                    MessageBox.Show("Saque Realizado com Sucesso!");
                }

                if (valorSaque > saldo)
                {
                    MessageBox.Show("Consulte o seu gerente para liberaração do cheque especial !", "Saldo Insuficiente");
                    elementoValor.Clear();
                    elementoValor.Focus();
                }
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            telaSaldo.Clear();

            if (telaSenha.Text != "")
            {

                if (String.IsNullOrWhiteSpace(elementoValor.Text))
                {
                    MessageBox.Show("Informe um valor pra Depósito");
                    elementoValor.Focus();
                }

                if (elementoValor.Text != "")
                {
                    valorDeposito = double.Parse(elementoValor.Text);
                }

                if (valorDeposito > 0)
                {
                    saldo += valorDeposito;

                    for (int i = 0; i < historico.Length; i++)
                    {

                        if (historico[historico.Length - 1] != null)
                        {
                            for (int r = 0; r < historico.Length; r++)
                            {
                                if (r < historico.Length - 1)
                                {
                                    historico[r] = historico[r + 1];
                                }
                                else
                                {
                                    historico[r] = null;
                                }
                            }
                        }

                        if (historico[i] == null)
                        {
                            historico[i] = telaSenha.Text + "         Depósito         " + valorDeposito.ToString("C");
                            break;
                        }
                    }
                    valorDeposito = 0;
                    MessageBox.Show("Depósito Realizado com Sucesso!");
                }
            }
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            telaSaldo.Text = saldo.ToString("C");
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            telaSaldo.Clear();
            elementoValor.Clear();
            listaHistorico.Items.Clear();


            for (int i = 0; i < historico.Length; i++)
            {
                if (historico[i] != null)
                {
                    listaHistorico.Items.Add(Environment.NewLine + historico.ElementAt(i));
                }
            }
        }
        private string GeradorDeLetra()
        {
            string[] letras = new string[] { "A", "B", "C", "D", "E" };

            return letras[gerador.Next(0, 5)];
        }
    }
}
