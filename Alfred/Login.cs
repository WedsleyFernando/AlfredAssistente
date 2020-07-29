using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Alfred
{
    public partial class Login : Form
    {
        // alterar as variaveis de conexao 
        private MySqlConnection minhaConexao = new MySqlConnection("server = localhost; user id = root; password=;database=alfred");
        public Login()
        {
            InitializeComponent();
            try
            {
                minhaConexao.Open();
            }
            catch (MySqlException minhaException)
            {
                MessageBox.Show("Erro de banco de dados");
                Console.WriteLine(minhaException);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                minhaConexao.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    int i = 0;
                    minhaConexao.Open();
                    MySqlCommand cmd = minhaConexao.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select nome, nomefonomico from usuario where nome = '" + textBox1.Text + "' and senha = sha1('" + textBox2.Text + "')";


                    cmd.ExecuteNonQuery();


                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (i == 0)
                    {
                        MessageBox.Show("Login ou Senha Incorretos!");
                    }
                    else
                    {
                        this.Hide();
                        Form1 novaform = new Form1();
                        novaform.Show();
                    }



                }
                catch (MySqlException minhaException)
                {
                    MessageBox.Show("Erro no Banco de Dados");
                    MessageBox.Show(minhaException.ToString());
                }
                finally
                {
                    minhaConexao.Close();
                }
            }
        }
    }
}