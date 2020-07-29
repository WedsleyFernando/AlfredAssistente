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
    public partial class adicionarComando : Form
    {
        private MySqlConnection minhaConexao = new MySqlConnection("server = localhost; user id = root; password=;database=alfred");

        public adicionarComando()
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
                try
                {
     
                    minhaConexao.Open();
                    MySqlCommand cmd = minhaConexao.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into comandos (nome_comando, comando, resposta) values ('" + txtNomeDoComando.Text + "', '" + txtComando.Text + "','" + txtResposta.Text + "')";

                    cmd.ExecuteNonQuery();

                  
                    MessageBox.Show("Comando Adicionado Com Sucesso!");
                    



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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 novaform = new Form1();
            novaform.Show();
        }
    }
    }
        
    

