using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsJogodaMemória
{
    public partial class Form1 : Form
    {   
        //Instanciando classe vetor
        Vetor vetImagens = new Vetor(0, 16);
        //Coloca as imagens no vetor
        string[] imagens = new string[8];
        //  Tempo do Timer
        int ticks = 61;
        //Variavel que ira contar quantas vezes foi clicado
        int cliques = 0;
        //Conta pontos
        int pontos = 0;
        //Pega o botão anterior a ser clicado
        Button anterior;
       
        string pastaImagem = "";
        public Form1()
        {
            InitializeComponent();
            pastaImagem = @"C:\Users\user\Desktop\WindowsFormsJogodaMemória\Imagens\";
            imagens[0] = "inosuke.jpg";
            imagens[1] = "nezuko.jpg";
            imagens[2] = "tanjiro.jpg";
            imagens[3] = "zenitsu.jpg";
            imagens[4] = "kyojuro.jpg";
            imagens[5] = "giyu.jpg";
            imagens[6] = "Shinobu.jpg";
            imagens[7] = "mitsuri.jpg";    
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ache as imagens em 60 segundos");
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            //Embaralha as Imagens
            for (int i = 0; i < 8; i++)
            {
                int posicao = vetImagens.sortearNumero();
                vetImagens.insereDadoNoVetor(posicao, imagens[i]);
                vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(posicao);
                
                posicao = vetImagens.sortearNumero();
                vetImagens.insereDadoNoVetor(posicao, imagens[i]);
                vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(posicao);
                
            }
            // Começa o Timer
            timer1.Start();
            //Habilita os Botões
            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;
            btn_10.Enabled = true;
            btn_11.Enabled = true;
            btn_12.Enabled = true;
            btn_13.Enabled = true;
            btn_14.Enabled = true;
            btn_15.Enabled = true;
            btn_16.Enabled = true;
            btn_Iniciar.Enabled = false;
        }
        public void Ganhou()
        {
            //Se pontos for igual a 8 o tempo para e a aplicação é resetada
            if (pontos == 8)
            {
                timer1.Stop();
                MessageBox.Show("Você Ganhou!");
                MessageBox.Show("Reiniciando Jogo")
                Application.Restart();
            }
        }
        private async void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(0));
            //seta a imagem no vetor vet_Imagens2 da classe vetor
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(0));
            cliques++;
            //Se o clique for igual a 1 o anterior recebe o próprio botão
            if (cliques == 1)
            {
                anterior = sender as Button;
            }
            //Se for igual a 2
            if (cliques == 2)
            {
                //Chama o método acertou e verifica se as imagens são iguais
                if(vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    //Chama o metodo ganhou, que verifica se pontos é igual a 8
                    Ganhou();
                }
                //Se for diferentes desvira a carta
                else
                {
                    //Espera 1 segundo para desvirar
                    await Task.Delay(1000);
                    btn_1.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }
                
            }
        }

        private async  void btn_2_Click(object sender, EventArgs e)
        {
            btn_2.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(1));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(1));
            cliques++;
            
            if (cliques == 1)
                anterior = sender as Button;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_2.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_3_Click(object sender, EventArgs e)
        {
            btn_3.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(2));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(2));
            cliques++;
            
            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_3.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_4_Click(object sender, EventArgs e)
        {
            btn_4.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(3));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(3));
            cliques++;
            
            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_4.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_5_Click(object sender, EventArgs e)
        {
            btn_5.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(4));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(4));
            cliques++;

            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_5.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_6_Click(object sender, EventArgs e)
        {
            btn_6.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(5));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(5));
            cliques++;

            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_6.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_7_Click(object sender, EventArgs e)
        {
            btn_7.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(6));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(6));
            cliques++;

            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_7.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_8_Click(object sender, EventArgs e)
        {
            btn_8.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(7));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(7));
            cliques++;

            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_8.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_9_Click(object sender, EventArgs e)
        {
            btn_9.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(8));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(8));
            cliques++;

            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_9.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_10_Click(object sender, EventArgs e)
        {
            btn_10.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(9));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(9));
            cliques++;

            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_10.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_11_Click(object sender, EventArgs e)
        {
            btn_11.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(10));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(10));
            cliques++;

            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_11.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_12_Click(object sender, EventArgs e)
        {
            btn_12.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(11));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(11));
            cliques++;

            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_12.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_13_Click(object sender, EventArgs e)
        {
            btn_13.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(12));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(12));
            cliques++;

            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_13.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_14_Click(object sender, EventArgs e)
        {
            btn_14.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(13));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(13));
            cliques++;
            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_14.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }

            }
        }

        private async void btn_15_Click(object sender, EventArgs e)
        {
            btn_15.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(14));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(14));
            cliques++;
            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_15.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }
            }
        }

        private async void btn_16_Click(object sender, EventArgs e)
        {
            btn_16.Image = Image.FromFile(pastaImagem + vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(15));
            vetImagens.setImagem(vetImagens.RetornaConteudoDoVetorPosicaoEspecifica(15));
            cliques++;
            if (cliques == 1)
                anterior = (Button)sender;
            if (cliques == 2)
            {
                if (vetImagens.acertou())
                {
                    cliques = 0;
                    pontos++;
                    Ganhou();
                }
                else
                {
                    await Task.Delay(1000);
                    btn_16.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    anterior.Image = Image.FromFile(pastaImagem + "fundo_carta.jpg");
                    cliques = 0;
                }
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            ticks--;
            label1.Text = ticks.ToString();
            if (ticks == 0)
            {
                timer1.Stop();
                MessageBox.Show("Você perdeu!");
                MessageBox.Show("Reiniciando o jogo");
                Application.Restart();
            }
        }
    }
}