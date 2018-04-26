using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=bdcadastro;Uid=root;Pwd=root;SslMode=none";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO CLIENTE (NOME, ENDERECO, CEP, BAIRRO, CIDADE, UF, TELEFONE) "  
                      + "VALUES ('" + txNome.Text + "', '" + txEndereco.Text + "', '"
                      + txCep.Text + "', '" + txBairro.Text
                      + "', '" + txCidade.Text + "', '" + txUf.Text + "', '"
                      + txTelefone.Text + "')";

            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM CLIENTE WHERE ID = " + txBusca.Text;

            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    Form2 fr2 = new Form2();
                    fr2.SetDados(reader[1].ToString(), reader[2].ToString());
                    fr2.Show();
                    txNome.Text = reader[1].ToString();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao buscar " + ex.ToString());
            }
            finally
            {
                con.Close();
            }



        }
    }
}
