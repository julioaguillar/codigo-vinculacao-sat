using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoVinculacaoSAT
{
    class ArquivoTexto
    {

        private string texto;
        private string nomeArquivo;

        public ArquivoTexto(string arquivo)
        {
            nomeArquivo = arquivo;
        }

        public string getTexto()
        {
            return texto;
        }

        public byte[] getTextoByte()
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(texto);
        }

        public void lerArquivoTexto()
        {
            texto = System.IO.File.ReadAllText(nomeArquivo);
        }

        public void gravarArquivoTexto(string conteudo, string arquivo)
        {
            System.IO.File.WriteAllText(arquivo, conteudo);
        }

    }
}
