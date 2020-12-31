using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Eniato
{
    class Database
    {
        public static SQLiteConnection sqlite_conn;
        public static SQLiteConnection CriarConexao()
        {


            sqlite_conn = new SQLiteConnection("Data Source=C:\\Users\\gabri\\OneDrive - alunos.utfpr.edu.br\\Eniato\\eniato-db; Version = 3;");

            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            return sqlite_conn;
        }

        public static void ConexaoAberta()
        {
            if (sqlite_conn.State == System.Data.ConnectionState.Closed)
            {
                sqlite_conn.Open();
            }
        }

        public static void LancarRecebimento(String descricaoDaReceita, int metodoDePagamento, Decimal valorDaReceita, int categoria_receita)
        {
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO receitas(data_emissao, descricao_receita, metodo_pagamento, valor_receita, categoria_receita) values (@data_emissao, @descricao_receita, @metodo_pagamento, @valor_receita, @categoria_receita)";
                    cmd.Parameters.AddWithValue("@data_emissao", DateTime.Now.ToString("yyyy'-'MM'-'dd"));
                    cmd.Parameters.AddWithValue("@descricao_receita", descricaoDaReceita);
                    cmd.Parameters.AddWithValue("@metodo_pagamento", metodoDePagamento);
                    cmd.Parameters.AddWithValue("@valor_receita", valorDaReceita);
                    cmd.Parameters.AddWithValue("@categoria_receita", categoria_receita);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.ErrorCode + ", contate imediatamente o administrador do sistema.");
            }
        }

        public static void LancarCheque(int codigoDoBanco, int codigoDaAgencia, int numeroDoCheque, int numeroDaConta, String bomPara, Decimal valor)
        {
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO cheques_recebidos(data_emissao, codigo_banco, codigo_agencia, numero_cheque, numero_conta, bom_para, valor) values (@data_emissao, @codigo_banco, @codigo_agencia, @numero_cheque, @numero_conta, @bom_para, @valor)";
                    cmd.Parameters.AddWithValue("@data_emissao", DateTime.Now.ToString("yyyy'-'MM'-'dd"));
                    cmd.Parameters.AddWithValue("@codigo_banco", codigoDoBanco);
                    cmd.Parameters.AddWithValue("@codigo_agencia", codigoDaAgencia);
                    cmd.Parameters.AddWithValue("@numero_cheque", numeroDoCheque);
                    cmd.Parameters.AddWithValue("@numero_conta", numeroDaConta);
                    cmd.Parameters.AddWithValue("@bom_para", bomPara);
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.ErrorCode + ", contate imediatamente o administrador do sistema.");
            }
        }

        public static int GetCodigoUltimoCheque()
        {
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT seq FROM sqlite_sequence WHERE name = 'cheques_recebidos'";
                    object result = cmd.ExecuteScalar();
                    result = (result == DBNull.Value) ? null : result;
                    int countDis = Convert.ToInt32(result);
                    return countDis;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.ErrorCode + ", contate imediatamente o administrador do sistema.");
                return -1;
            }
        }
        public static int GetCodigoUltimaReceita()
        {
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT seq FROM sqlite_sequence WHERE name = 'receitas'";
                    object result = cmd.ExecuteScalar();
                    result = (result == DBNull.Value) ? null : result;
                    int countDis = Convert.ToInt32(result);
                    return countDis;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.ErrorCode + ", contate imediatamente o administrador do sistema.");
                return -1;
            }
        }

        public static void LigarChequeReceita(int idChequeRecebido, int idReceita)
        {
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO relacao_cheque_receita(id_cheque, id_receita) values (@id_cheque, @id_receita)";
                    cmd.Parameters.AddWithValue("@id_cheque", idChequeRecebido);
                    cmd.Parameters.AddWithValue("@id_receita", idReceita);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.ErrorCode + ", contate imediatamente o administrador do sistema.");
            }
        }

        public static DataTable GetMetodosPagamento()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tipo_de_pagamento";
                    da = new SQLiteDataAdapter(cmd.CommandText, CriarConexao());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.ErrorCode + ", contate imediatamente o administrador do sistema.");
                return null;
            }
        }



    }
}
