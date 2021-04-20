using MySql.Data.MySqlClient;
using Projeto_IDB_AUX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercearia_PCSHARP_MZ
{
    class SGBD_Produto
    {

        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost; port=3306; username=root; password=admin; database=db_frescos_mary";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection" + ex.Message);
            }
            return con;
        }

       public static void AddProduto(Produto_Model prd)
        {
            string sql = "INSERT INTO produto VALUES (NULL,@Categoria,@Nome,@Preco)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = prd.Nome;
            cmd.Parameters.Add("@Categoria", MySqlDbType.VarChar).Value = prd.Categoria;
            cmd.Parameters.Add("@Preco", MySqlDbType.Double).Value = prd.Preco;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Adicionado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Produto nao inserido" + ex.Message);
            }
            con.Close();
        }
        public static void AddGerente(Gerente gerente)
        {
            string sql = "INSERT INTO gerente VALUES (NULL,@Nome,@Telefone,@Email)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = gerente.Nome;
            cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = gerente.Telefone;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = gerente.Email;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Gerente Adicionado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gerente nao inserido" + ex.Message);
            }
            con.Close();
        }
        public static void AddFornecedor(Fornecedor_Model fornecedor)
        {
            string sql = "INSERT INTO fornecedor VALUES (NULL,@Nome,@Bairro,@Avenida,@Telefone,@Email)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = fornecedor.Nome;
            cmd.Parameters.Add("@Bairro", MySqlDbType.VarChar).Value = fornecedor.Bairro;
            cmd.Parameters.Add("@Avenida", MySqlDbType.VarChar).Value = fornecedor.Avenida;
            cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = fornecedor.Telefone;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = fornecedor.Email;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Adicionado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fornecedor nao inserido" + ex.Message);
            }
            con.Close();
        }
        public static void AddCliente(Cliente_Model fornecedor)
        {
            string sql = "INSERT INTO cliente VALUES (NULL,@Nome,@Bairro,@Avenida,@Telefone,@Email)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = fornecedor.Nome;
            cmd.Parameters.Add("@Bairro", MySqlDbType.VarChar).Value = fornecedor.Bairro;
            cmd.Parameters.Add("@Avenida", MySqlDbType.VarChar).Value = fornecedor.Avenida;
            cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = fornecedor.Telefone;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = fornecedor.Email;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Adicionado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cliente nao inserido" + ex.Message);
            }
            con.Close();
        }
        public static void AddGerenteSenha(Gerente gerente)
        {
            string sql = "INSERT INTO gerente VALUES (NULL,@Senha,@CodGerente)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = gerente.Nome;
            cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = gerente.Telefone;
            cmd.Parameters.Add("@Email", MySqlDbType.Double).Value = gerente.Email;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Gerente Adicionado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gerente nao inserido" + ex.Message);
            }
            con.Close();
        }
        public static void AddRequisicao(requisicao_model req)
        {
            string data = DateTime.Today.Year.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString();
            string sql = "INSERT INTO requisicao VALUES (NULL,@cod_gerente,@cod_produto,@dia)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cod_gerente", MySqlDbType.VarChar).Value = req.Cod_gerente;
            cmd.Parameters.Add("@cod_produto", MySqlDbType.VarChar).Value = req.Cod_produto;
            cmd.Parameters.Add("@dia", MySqlDbType.VarChar).Value = data;

            //cmd.Parameters.Add("@Email", MySqlDbType.Double).Value = gerente.Email;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Requisito Adicionado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Requisito nao inserido" + ex.Message);
            }
            con.Close();
        }
        public static void AddPedido(pedido_model ped)
        {
            string data = DateTime.Today.Year.ToString()+"/"+ DateTime.Today.Month.ToString()+"/"+ DateTime.Today.Day.ToString();

            string sql = "INSERT INTO pedido VALUES (NULL,@cod_cliente,@cod_gerente,@quantidade,@dia,@data)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cod_cliente", MySqlDbType.VarChar).Value = ped.Cod_cliente;

            cmd.Parameters.Add("@cod_gerente", MySqlDbType.VarChar).Value = ped.Cod_gerente;
            cmd.Parameters.Add("@quantidade", MySqlDbType.VarChar).Value = ped.Quantidade;
            cmd.Parameters.Add("@dia", MySqlDbType.VarChar).Value = data;
            cmd.Parameters.Add("@data", MySqlDbType.VarChar).Value = ped.Data_entrega;

            //cmd.Parameters.Add("@Email", MySqlDbType.Double).Value = gerente.Email;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido Adicionado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pedido nao inserido" + ex.Message);
            }
            con.Close();
        }
        public static void AddFornecimento(Fornecimento_Model fornecimento)
        {
            string data = DateTime.Today.Year.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString();

            string sql = "INSERT INTO fornecimento VALUES (@cod_forn,@cod_prod,@quantidade)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cod_prod", MySqlDbType.VarChar).Value =fornecimento.Cod_prod;

            cmd.Parameters.Add("@cod_forn", MySqlDbType.VarChar).Value = fornecimento.Cod_forn;
            cmd.Parameters.Add("@quantidade", MySqlDbType.VarChar).Value = fornecimento.Quantidade;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecimento Adicionado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fornecimento nao inserido" + ex.Message);
            }
            con.Close();
        }
        public static void ActualizarProduto(Produto_Model prd,string id)
        {
            string sql = "UPDATE produto SET prod_nome = @Nome, prod_preco_unitario= @Preco WHERE produto_cod = @Id ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.Int16).Value = id;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = prd.Nome;
            cmd.Parameters.Add("@Preco", MySqlDbType.Int16).Value = prd.Preco;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Actualizado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Produto nao actualizado" + ex.Message);
            }
            con.Close();
        }
        public static void ActualizarFornecedor(Fornecedor_Model fornecedor, string id)
        {
            string sql = "UPDATE fornecedor SET forn_nome=@Nome,forn_bairro=@Bairro,forn_avenida=@Avenida,forn_telefone=@Telefone,forn_email=@Email WHERE fornecedor_cod = @Id ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;

            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = fornecedor.Nome;
            cmd.Parameters.Add("@Bairro", MySqlDbType.VarChar).Value = fornecedor.Bairro;
            cmd.Parameters.Add("@Avenida", MySqlDbType.VarChar).Value = fornecedor.Avenida;
            cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = fornecedor.Telefone;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = fornecedor.Email;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Actualizado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fornecedor nao actualizado" + ex.Message);
            }
            con.Close();
        }
        public static void ActualizarCliente(Cliente_Model fornecedor, string id)
        {
            string sql = "UPDATE fornecedor SET forn_nome=@Nome,forn_bairro=@Bairro,forn_avenida=@Avenida,forn_telefone=@Telefone,forn_email=@Email WHERE fornecedor_cod = @Id ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = fornecedor.Nome;
            cmd.Parameters.Add("@Bairro", MySqlDbType.VarChar).Value = fornecedor.Bairro;
            cmd.Parameters.Add("@Avenida", MySqlDbType.VarChar).Value = fornecedor.Avenida;
            cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar).Value = fornecedor.Telefone;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = fornecedor.Email;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Actualizado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cliente nao actualizado" + ex.Message);
            }
            con.Close();
        }

        public static void Deletar(string id)
        {
            string sql = "DELETE FROM produto WHERE produto_cod= @Id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Deletado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Produto nao deletado" + ex.Message);
            }
            con.Close();
        }
        public static void DeletarForncedor(string id)
        {
            string sql = "DELETE FROM fornecedor WHERE fornecedor_cod= @Id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Deletado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Fornecedor nao deletado" + ex.Message);
            }
            con.Close();
        }
        public static void DeletarRequisicao(string id)
        {
            string sql = "DELETE FROM requisicao WHERE nr_requisicao= @Id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Requisicao Deletada");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Requisicao nao deletada" + ex.Message);
            }
            con.Close();
        }
        public static void DeletarPedido(string id)
        {
            string sql = "DELETE FROM pedido WHERE pedido_cod= @Id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pedido Deletado");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Pedido nao deletado" + ex.Message);
            }
            con.Close();
        }
        public static void mostrarEProcurar(string query, DataGridView dvg)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
           dvg.DataSource = tbl;
            con.Close();
        }

    }
}
