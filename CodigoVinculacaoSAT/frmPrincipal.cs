using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CodigoVinculacaoSAT
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnGerarCodigo_Click(object sender, EventArgs e)
        {
            
            string cnpjAC = String.Join("", System.Text.RegularExpressions.Regex.Split(txtCNPJSofolha.Text, @"[^\d]"));
            string cnpjEC = String.Join("", System.Text.RegularExpressions.Regex.Split(txtCNPJCliente.Text, @"[^\d]"));

            if ((cnpjAC.Equals("")) || (cnpjEC.Equals("")) || (cnpjAC.Length != 14) || (cnpjEC.Length != 14))
            {
                txtCodigoVinculacao.Text = "CNPJ Inválido";
                return;
            }

            string cnpj = cnpjAC + cnpjEC;

            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            Assinatura assinatura = new Assinatura();
            assinatura.setTexto(encoding.GetBytes(cnpj));
            assinatura.assinar();

            txtCodigoVinculacao.Text = assinatura.getAssinatura();

        }        

        public bool ValidaCnpj(string cnpj)
        {

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;

            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);

        }

        private void txtCNPJSofolha_Leave(object sender, EventArgs e)
        {            

            if ((!txtCNPJSofolha.Text.Equals("")) && (!txtCNPJSofolha.Text.Equals("  .   .   /    -")))
            {

                if (!ValidaCnpj(txtCNPJSofolha.Text))
                {
                    MessageBox.Show("\"Prezado Cliente\"\n" + "CNPJ informado não é válido.", "Sófolha Soluções Corporativas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCNPJSofolha.Focus();
                    txtCNPJSofolha.SelectAll();
                    return;
                }

            }

        }

        private void txtCNPJCliente_Leave(object sender, EventArgs e)
        {

            if ((!txtCNPJCliente.Text.Equals("")) && (!txtCNPJCliente.Text.Equals("  .   .   /    -")) && (!txtCNPJCliente.Text.Equals("11.111.111/1111-11")))
            {

                if (!ValidaCnpj(txtCNPJCliente.Text))
                {
                    MessageBox.Show("\"Prezado Cliente\"\n" + "CNPJ informado não é válido.", "Sófolha Soluções Corporativas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCNPJCliente.Focus();
                    txtCNPJCliente.SelectAll();
                    return;
                }

            }

        }

        private void frmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {            

        }

    }

}
