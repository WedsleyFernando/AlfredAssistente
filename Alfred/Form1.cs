using Microsoft.Speech.Recognition;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

//Para A fala Do alfred e necessario o System.Speech


namespace Alfred
{
    public partial class Form1 : Form
    {
        private MySqlConnection minhaConexao = new MySqlConnection("server = localhost; user id = root; password=;database=alfred");


        private SpeechRecognitionEngine engine; //Engine de reconhecimento
        private float volume;
        private bool iniciou = false;
        string palavr = "\"ola Alfred\"";



        public Form1()
        {
            InitializeComponent();
            try
            {
                minhaConexao.Open();
                string cmd = "select id_comando,comando,resposta from comandos";
                MySqlCommand comando = new MySqlCommand(cmd, minhaConexao);
                MySqlDataReader dr = comando.ExecuteReader();
                

                while (dr.Read())
                {
                    
                    palavr +=",\"" + dr["comando"].ToString()+"\"";
                    
                }

                minhaConexao.Close();
               
            }
            catch (MySqlException minhaException)
            {
                MessageBox.Show(minhaException.ToString());
            }
            finally
            {
                LoadSpeech();
                minhaConexao.Close();
            }
        }


        private void LoadSpeech()
        {
            try
            {
                engine = new SpeechRecognitionEngine(); //instancia
                engine.SetInputToDefaultAudioDevice(); //define microfone padrao como entrada
                string[] palavras = new string[100];
                palavras = palavr.Split(',');
                //Carrega Gramatica
                engine.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(palavras))));//Carrega uma Gramatica
               
                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec);//Chama Metodo quando Reconhece
                engine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(nivelAudio);//Controle o nivel de Audio




                engine.RecognizeAsync(RecognizeMode.Multiple); //inicia o Reconhecimento

                if (iniciou == false)
                {
                    Fala.falar("Estou Carregando Os Arquivos .");
                    iniciou = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um Erro no LoadSpeech: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        //Método que é chamado quando algo é reconhecido
        private void rec(object s, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "ola Alfred")
            {
                Fala.falar("Olá");
            }
            try
            {
                minhaConexao.Open();
                string cmd = "select resposta from comandos where comando = '"+e.Result.Text+"'";
                MySqlCommand comando = new MySqlCommand(cmd, minhaConexao);
                MySqlDataReader dr = comando.ExecuteReader();


                dr.Read();
                
                string resposta = dr["resposta"].ToString();

                Fala.falar(resposta);
               

            }
            catch
            {
                
            }
            finally
            {
                
                minhaConexao.Close();
            }
        }


        private void nivelAudio(Object s, AudioLevelUpdatedEventArgs e)
        {
            this.progressBar1.BackColor = Color.Black;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = e.AudioLevel;
            volume = e.AudioLevel;

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adicionarComando novaform = new adicionarComando();
            novaform.Show();
        }


    }
}
