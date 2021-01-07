using System;
using System.Globalization;
using System.Windows.Forms;

namespace Eniato
{
    class Util
    {
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 && n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
        public static void SoNumeros(ref TextBox txt, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public static decimal CalcularTroco(String valorTotal, String valorRecebido, String valorDesconto)
        {
            valorTotal = valorTotal.Replace(".", "");
            valorRecebido = valorRecebido.Replace(".", "");
            valorDesconto = valorDesconto.Replace(".", "");
            decimal dinheiroRetorno = decimal.Parse(valorRecebido.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) -
                    decimal.Parse(valorTotal.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) +
                    decimal.Parse(valorDesconto.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
            return dinheiroRetorno;
        }

        public static int StringParaInt(String texto)
        {
            int valorConvertido = int.Parse(texto);
            return valorConvertido;
        }

        public static DateTime StringParaData(String date)
        {
            DateTime theDate;
            DateTime.TryParseExact(date, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out theDate);
            return theDate;

        }

    }
}
