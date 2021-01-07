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

        public static SQLiteConnection ConexaoAberta()
        {
            if (sqlite_conn.State == System.Data.ConnectionState.Closed)
            {
                sqlite_conn.Open();
                return sqlite_conn;
            } else
            {
                return sqlite_conn;
            }
        }

        // Métodos para cheques
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

        public static void DeletarCheque(int idCheque)
        {
            try
            {
                using (var cmd = new SQLiteCommand(CriarConexao()))
                {
                    cmd.CommandText = "DELETE FROM cheques_recebidos WHERE id_cheque_recebido = @idCheque";
                    cmd.Parameters.AddWithValue("@idCheque", idCheque);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.Message + ", contate imediatamente o administrador do sistema.");
            }
        }

        public static void ModificarCheque(int idCheque, int codigoBanco, int codigoAgencia, int numeroCheque, int numeroConta, String bomPara, Decimal valor)
        {
            try
            {
                using (var cmd = new SQLiteCommand(CriarConexao()))
                {
                    cmd.CommandText = "UPDATE cheques_recebidos SET codigo_banco=@codigobanco, codigo_agencia=@codigoagencia, numero_cheque=@numerocheque, numero_conta=@numeroconta, bom_para=@datadopara, valor=@valor WHERE id_cheque_recebido=@Id";
                    cmd.Parameters.AddWithValue("@Id", idCheque);
                    cmd.Parameters.AddWithValue("@codigobanco", codigoBanco);
                    cmd.Parameters.AddWithValue("@codigoagencia", codigoAgencia);
                    cmd.Parameters.AddWithValue("@numerocheque", numeroCheque);
                    cmd.Parameters.AddWithValue("@numeroconta", numeroConta);
                    cmd.Parameters.AddWithValue("@datadopara", bomPara);
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.ExecuteNonQuery();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.Message + ", contate imediatamente o administrador do sistema.");
            }
        }

        public static DataTable GetCheque(int idCheque)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT codigo_banco, codigo_agencia, numero_cheque, numero_conta, bom_para FROM cheques_recebidos WHERE id_cheque_recebido = " + idCheque;
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
        // Fim Métodos de cheques

        // Métodos de relação entre cheque e receita

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

        public static void DeletarRelacaoChequeReceita(int idReceita, int idCheque)
        {
            try
            {
                using (var cmd = new SQLiteCommand(CriarConexao()))
                {
                    cmd.CommandText = "DELETE FROM relacao_cheque_receita WHERE id_receita = @idReceita AND id_cheque = @idCheque";
                    cmd.Parameters.AddWithValue("@idReceita", idReceita);
                    cmd.Parameters.AddWithValue("@idCheque", idCheque);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.Message + ", contate imediatamente o administrador do sistema.");
            }
        }

        public static int GetChequeDaReceita(int idReceita)
        {
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT id_cheque FROM relacao_cheque_receita WHERE id_receita = " + idReceita;
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
        // Fim Métodos de relação entre cheque e receita

        // Métodos de planos e categorias

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

        public static DataTable GetPlanoDeContasReceitas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT codigo_receita, nome_receita FROM plano_de_contas_receitas WHERE ativo = 1";
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
        // Fim Métodos de planos e categorias

        // Métodos para recebimento
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
        public static DataTable BuscarReceitas(DateTime periodoInicial, DateTime periodoFinal, String descricao, int codigoPlanoDeContas)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT rec.id_receita id, data_emissao data, descricao_receita descricao, tdp.descricao metodo_de_pagamento, " +
                        "valor_receita valor, pdcr.nome_receita categoria FROM receitas rec INNER JOIN plano_de_contas_receitas pdcr on pdcr.codigo_receita = rec.categoria_receita " +
                        "INNER JOIN tipo_de_pagamento tdp on tdp.codigo_tipo_pagamento = rec.metodo_pagamento " +
                        "WHERE data_emissao BETWEEN date(@periodoInicial) AND date(@periodoFinal) AND descricao_receita LIKE @descricao AND categoria_receita = @codigoPlanoDeContas";
                    da = new SQLiteDataAdapter(cmd.CommandText, CriarConexao());
                    da.SelectCommand.Parameters.AddWithValue("@periodoInicial", periodoInicial.ToString("yyyy-MM-dd"));
                    da.SelectCommand.Parameters.AddWithValue("@periodoFinal", periodoFinal.ToString("yyyy-MM-dd"));
                    da.SelectCommand.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
                    da.SelectCommand.Parameters.AddWithValue("@codigoPlanoDeContas", codigoPlanoDeContas);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.Message + ", contate imediatamente o administrador do sistema.");
                return null;
            }
        }
        public static DataTable BuscarTodasReceitas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT rec.id_receita id, data_emissao data, descricao_receita descrição, tdp.descricao metodo_de_pagamento, " +
                        "valor_receita valor, pdcr.nome_receita categoria FROM receitas rec INNER JOIN plano_de_contas_receitas pdcr on pdcr.codigo_receita = rec.categoria_receita " +
                        "INNER JOIN tipo_de_pagamento tdp on tdp.codigo_tipo_pagamento = rec.metodo_pagamento";

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
        public static void DeletarReceita(int idReceita)
        {
            try
            {
                using (var cmd = new SQLiteCommand(CriarConexao()))
                {
                    cmd.CommandText = "DELETE FROM receitas WHERE id_receita = @Id";
                    cmd.Parameters.AddWithValue("@Id", idReceita);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.Message + ", contate imediatamente o administrador do sistema.");
            }
        }

        public static DataTable GetReceita(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT rec.id_receita id, data_emissao data, descricao_receita descrição, tdp.descricao metodo_de_pagamento, " +
                        "valor_receita valor, pdcr.nome_receita categoria FROM receitas rec INNER JOIN plano_de_contas_receitas pdcr on pdcr.codigo_receita = rec.categoria_receita " +
                        "INNER JOIN tipo_de_pagamento tdp on tdp.codigo_tipo_pagamento = rec.metodo_pagamento WHERE id_receita=@id";
                    da = new SQLiteDataAdapter(cmd.CommandText, CriarConexao());
                    da.SelectCommand.Parameters.AddWithValue("@id", id);
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


        public static void ModificarReceita(int idReceita, String descricao, int metodoDePagamento, Decimal valorReceita, int categoriaReceita)
        {
            try
            {
                using (var cmd = new SQLiteCommand(CriarConexao()))
                {
                        cmd.CommandText = "UPDATE receitas SET descricao_receita=@descricao, metodo_pagamento=@metodo_pagamento, valor_receita=@valorreceita, categoria_receita=@categoria WHERE id_receita=@Id";
                        cmd.Parameters.AddWithValue("@Id", idReceita);
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@metodo_pagamento", metodoDePagamento);
                        cmd.Parameters.AddWithValue("@valorreceita", valorReceita);
                        cmd.Parameters.AddWithValue("@categoria", categoriaReceita);
                        cmd.ExecuteNonQuery();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.Message + ", contate imediatamente o administrador do sistema.");
            }
        }
        // Fim Métodos para recebimento

        // Métodos de despesa
        public static void LancarDespesa(String dataDeVencimento, String descricaoDaDespesa, int metodoDePagamento, Decimal valor, int categoriaDespesa)
        {
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO despesas(data_emissao, data_vencimento, descricao_despesa, metodo_pagamento, valor_despesa, categoria_despesa) values (@data_emissao, @data_vencimento, @descricao_despesa, @metodo_pagamento, @valor_despesa, @categoria_despesa)";
                    cmd.Parameters.AddWithValue("@data_emissao", DateTime.Now.ToString("yyyy'-'MM'-'dd"));
                    cmd.Parameters.AddWithValue("@data_vencimento", dataDeVencimento);
                    cmd.Parameters.AddWithValue("@descricao_despesa", descricaoDaDespesa);
                    cmd.Parameters.AddWithValue("@metodo_pagamento", metodoDePagamento);
                    cmd.Parameters.AddWithValue("@valor_despesa", valor);
                    cmd.Parameters.AddWithValue("@categoria_despesa", categoriaDespesa);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.ErrorCode + ", contate imediatamente o administrador do sistema.");
            }
        }
        public static void ModificarDespesa(int idDespesa, String dataDeVencimento, String descricaoDaDespesa, int metodoDePagamento, Decimal valor, int categoriaDespesa, bool foiPago)
        {
            try
            {
                using (var cmd = new SQLiteCommand(CriarConexao()))
                {
                    cmd.CommandText = "UPDATE despesas SET data_vencimento=@data_vencimento, descricao_despesa=@descricao_despesa, metodo_pagamento=@metodo_pagamento, " +
                                      "valor_despesa=@valor_despesa, categoria_despesa=@categoria_despesa, foi_pago=@foi_pago WHERE id_despesa=@id_despesa";
                    cmd.Parameters.AddWithValue("@id_despesa", idDespesa);
                    cmd.Parameters.AddWithValue("@data_vencimento", dataDeVencimento);
                    cmd.Parameters.AddWithValue("@descricao_despesa", descricaoDaDespesa);
                    cmd.Parameters.AddWithValue("@metodo_pagamento", metodoDePagamento);
                    cmd.Parameters.AddWithValue("@valor_despesa", valor);
                    cmd.Parameters.AddWithValue("@categoria_despesa", categoriaDespesa);
                    cmd.Parameters.AddWithValue("@foi_pago", foiPago);
                    cmd.ExecuteNonQuery();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.Message + ", contate imediatamente o administrador do sistema.");
            }
        }
        public static void DeletarDespesa(int idDespesa)
        {
            try
            {
                using (var cmd = new SQLiteCommand(CriarConexao()))
                {
                    cmd.CommandText = "DELETE FROM despesas WHERE id_despesa = @id";
                    cmd.Parameters.AddWithValue("@id", idDespesa);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no SQLite n° " + ex.Message + ", contate imediatamente o administrador do sistema.");
            }
        }
        public static DataTable GetTodasDespesas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT desp.id_despesa id, desp.data_emissao emissão, desp.data_vencimento vencimento, desp.descricao_despesa descrição, PDCD.nome_despesa categoria, " +
                        "tdp.descricao método_de_pagamento, desp.valor_despesa valor_original, desp.valor_pago valor_pago, desp.foi_pago pago " +
                        "FROM despesas desp INNER JOIN plano_de_contas_despesas pdcd on desp.categoria_despesa = pdcd.codigo_despesa INNER JOIN tipo_de_pagamento tdp on tdp.codigo_tipo_pagamento = desp.metodo_pagamento";
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

        public static DataTable GetDespesa(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = CriarConexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT desp.id_despesa id, desp.data_emissao emissão, desp.data_vencimento vencimento, desp.descricao_despesa descrição, PDCD.nome_despesa categoria, " +
                        "tdp.descricao método_de_pagamento, desp.valor_despesa valor_original, desp.valor_pago valor_pago, desp.foi_pago pago " +
                        "FROM despesas desp INNER JOIN plano_de_contas_despesas pdcd on desp.categoria_despesa = pdcd.codigo_despesa INNER JOIN tipo_de_pagamento tdp on tdp.codigo_tipo_pagamento = desp.metodo_pagamento " +
                        "WHERE id_despesa=@id";
                    da = new SQLiteDataAdapter(cmd.CommandText, CriarConexao());
                    da.SelectCommand.Parameters.AddWithValue("@id", id);
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
