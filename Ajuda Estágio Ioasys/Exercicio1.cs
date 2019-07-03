using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ajuda_Estágio_Ioasys
{
    class Exercicio1
    {
        static void teste()
        {
            int tamanho = 15;

            int[] vetorTeste = CriarVetor(tamanho);
            int[] vetorResultado = CriarVetorResultado(vetorTeste/*, out long tempo*/);

            ImprimirVetor(vetorTeste);
            ImprimirVetor(vetorResultado);

            //Console.WriteLine("milissegundos: " + tempo);

            //Fim
            Console.ReadKey();
        }

        static void ImprimirVetor(int[] vetor)
        {
            StringBuilder auxImpressao = new StringBuilder();

            for (int pos = 0; pos < vetor.Length; pos++)
            {
                if (vetor[pos] != int.MinValue)
                    auxImpressao.Append(vetor[pos] + " ");
            }
            Console.WriteLine(auxImpressao.ToString());
        }
        static int[] CriarVetor(int tamanho)
        {
            int[] vetor = new int[tamanho];
            Random random = new Random();

            for (int pos = 0; pos < tamanho; pos++)
            {
                vetor[pos] = random.Next(tamanho / 2);
            }

            return vetor;
        }

        static int[] CriarVetorResultado(int[] vetor, out long tempo)
        {
            Stopwatch teste = new Stopwatch();
            int[] vetorResultado = new int[vetor.Length];

            //Inicializando primeira coluna
            for (int pos = 0; pos < vetor.Length; pos++)
                vetorResultado[pos] = int.MinValue;

            teste.Start();

            for (int pos = 0; pos < vetor.Length; pos++)
            {
                for (int i = 0; i <= pos; i++)
                {
                    if (vetor[pos] == vetorResultado[i])
                        break;
                    else if (vetorResultado[i] == int.MinValue)
                    {
                        vetorResultado[i] = vetor[pos];
                        break;
                    }
                }
            }
            teste.Stop();
            Console.WriteLine(teste.ElapsedMilliseconds);
            tempo = teste.ElapsedMilliseconds;

            return vetorResultado;
        }
        static int[] CriarVetorResultado(int[] vetorBase) //Resposta Exercicio 1
        {
            int[] vetorResultado = new int[vetorBase.Length];

            //Inicializando os valores de forma que int.MinValue seja a referência para uma posição vazia
            for (int pos = 0; pos < vetorBase.Length; pos++)
                vetorResultado[pos] = int.MinValue;

            //Inserindo valores no vetorResultado, conforme solicitado no enunciado
            for (int posVetorBase = 0; posVetorBase < vetorBase.Length; posVetorBase++) //Percorre o vetorBase
            {
                for (int posVetorResultado = 0; posVetorResultado < posVetorBase + 1; posVetorResultado++) //Percorre o VetorResultado
                {
                    if (vetorBase[posVetorBase] == vetorResultado[posVetorResultado])
                    {
                        //caso esse número esteja em alguma posição anterior, ou seja, duplicado, não iremos inserí-lo no vetorResultado
                        break;
                    }
                    else if (vetorResultado[posVetorResultado] == int.MinValue)
                    {
                        //Caso encontremos uma posição vazia, sabemos que o respectivo número não está duplicado e podemos inserí-lo no vetorResultado
                        vetorResultado[posVetorResultado] = vetorBase[posVetorBase];
                        break;
                    }
                }
            }

            return vetorResultado;
        }
    }
}
