using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace CodigoVinculacaoSAT
{
    class Assinatura
    {

        private byte[] texto;
        private string assinatura;

        public Assinatura()
        {
            assinatura = "";
        }

        public void setTexto(byte[] texto)
        {
            this.texto = texto;
        }

        public string getAssinatura()
        {
            return assinatura;
        }

        public void assinar()
        {

            // To idendify the Smart Card CryptoGraphic Providers on your
            // computer, use the Microsoft Registry Editor (Regedit.exe).
            // The available Smart Card CryptoGraphic Providers are listed
            // in HKEY_LOCAL_MACHINE\Software\Microsoft\Cryptography\Defaults\Provider.

            // Create a new CspParameters object that identifies a 
            // Smart Card CryptoGraphic Provider.
            // The 1st parameter comes from HKEY_LOCAL_MACHINE\Software\Microsoft\Cryptography\Defaults\Provider Types.
            // The 2nd parameter comes from HKEY_LOCAL_MACHINE\Software\Microsoft\Cryptography\Defaults\Provider.

            //CspParameters csp = new CspParameters(1, "eToken Base Cryptographic Provider");            
            CspParameters csp = new CspParameters(1, "SafeSign Standard Cryptographic Service Provider");            
            csp.Flags = CspProviderFlags.UseDefaultKeyContainer;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);

            byte[] sig = rsa.SignData(texto, "SHA256");

            string base64sign = Convert.ToBase64String(sig);

            assinatura = base64sign;

            bool verificado = rsa.VerifyData(texto, "SHA256", sig);

            if (verificado)
                assinatura = base64sign;
            else
                assinatura = "Não foi possível validar a assinatura gerada";

            // NESSE TRECHO DE CÓDIGO FAZ A SELEÇÃO DO CERTIFICADO ANTES DE GERAR A CHAVE
            /*var certificado = selectCert(StoreName.My, StoreLocation.LocalMachine, "Sófolha Soluções Corporativas", "Selecione o certificado");

            if (certificado != null)
            {

                RSACryptoServiceProvider rsacsp = (RSACryptoServiceProvider)certificado.PrivateKey;

                CspParameters csp = new CspParameters();
                csp.KeyContainerName = rsacsp.CspKeyContainerInfo.KeyContainerName;
                csp.KeyNumber = rsacsp.CspKeyContainerInfo.KeyNumber == KeyNumber.Exchange ? 1 : 2;

                var str = "01055651";
                var s = new SecureString();
                foreach (char c in str) s.AppendChar(c);

                csp.KeyPassword = s;

                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);

                byte[] sig = rsa.SignData(texto, "SHA256");

                string base64sign = Convert.ToBase64String(sig);

                assinatura = base64sign;

                bool verificado = rsa.VerifyData(texto, "SHA256", sig);

                if (verificado)
                    assinatura = base64sign;
                else
                    assinatura = "Não foi possível validar a assinatura gerada";


            }*/
            
        }

        public X509Certificate2 selectCert(StoreName store, StoreLocation location, string windowTitle, string windowMsg)
        {

            X509Certificate2 certSelected = null;
            X509Store x509Store = new X509Store(store, location);
            x509Store.Open(OpenFlags.ReadOnly);

            X509Certificate2Collection col = x509Store.Certificates;
            X509Certificate2Collection sel = X509Certificate2UI.SelectFromCollection(col, windowTitle, windowMsg, X509SelectionFlag.SingleSelection);

            if (sel.Count > 0)
            {
                X509Certificate2Enumerator en = sel.GetEnumerator();
                en.MoveNext();
                certSelected = en.Current;
            }

            x509Store.Close();

            return certSelected;
        }

    }
}
