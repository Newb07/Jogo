using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsJogodaMemória
{
    class Vetor
    {
        private string[] vet_Imagens;
        private string[] vet_Imagens2;
        int qtdeVetorImagem2 = 0;
        private int qtosElementosTemNoVetor;
        private int limiteLogico;
        private int[] verificador = new int[100];
        int quantidadeVerificador;

        // construtor
        public Vetor(int qtde, int lim)
        {
            vet_Imagens = new string[lim];
            qtosElementosTemNoVetor = qtde;
            limiteLogico = lim;
            vet_Imagens2 = new string[2];
        }

        public bool estaCheio()
        {
            return (qtosElementosTemNoVetor == limiteLogico);
        }

        public void insereDadoNoVetor(int posicao, string nomeArq)
        {
            if (!estaCheio())
            {
                qtosElementosTemNoVetor++;
                vet_Imagens[posicao] = nomeArq;
            }
        }

        public void setImagem(string nomeArq)
        {
            //seta a imagem recebida como parâmetro na posição da qtdeVetorImagem2
            vet_Imagens2[qtdeVetorImagem2] = nomeArq;
            qtdeVetorImagem2++;

        }

        public bool acertou()
        {
            //Verifica se a imagem posição [0] é igual a imagem posição [1] e retorna true
            if (vet_Imagens2[0] == vet_Imagens2[1])
            {
                vet_Imagens2[0] = null;
                vet_Imagens2[1] = null;
                qtdeVetorImagem2 = 0;
                return true;
            }
            //se não retorna false
            else
            {
                vet_Imagens2[0] = null;
                vet_Imagens2[1] = null;
                qtdeVetorImagem2 = 0;
                return false;
            }
        }
        public string RetornaConteudoDoVetorPosicaoEspecifica(int posicao)
        {
            return vet_Imagens[posicao];
        }
        
        public int sortearNumero()
        {

            int numero;
            Random random = new Random();

            inicio:
            //Numero recebe um numero random de 0 a 15
            numero = random.Next(0, 16);

            for (int k = 0; k < quantidadeVerificador; k++)
            {
                 //Verifica se no vetor ja tem o número sorteado
                 if (verificador[k] == numero)
                 {
                     //Se sim volta para o inicio   
                     goto inicio;
                 }
            }
            //O verificador recebe o número na posição de quantidadeVerificador
            verificador[quantidadeVerificador] = numero;   
            
            quantidadeVerificador++;
            return numero;
        }

    }
}
