using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajuda_Estágio_Ioasys
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Exercicio3.ValidarSequencia("({[]}())"));
            //Fim
            Console.ReadKey();
        }
    }

    #region Resposta 1
    static int[] CriarVetorResultado(int[] vetorBase)
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
    #endregion

    #region Resposta 2
    public static string questao2(ArvoreBinariaABB arvore1, ArvoreBinariaABB arvore2)
    {
        if (arvore1.Equals(arvore2))
            return "IGUAIS";
        else
            return "DIFERENTES";
    }

    class ArvoreBinariaABB
    {
        //Classe Nodo que possui os seguintes atributos:
        //  - MeuDado -> interface que pode ser usada pra inserirmos vários tipos de objetos sem que seja necessário criar várias classes.
        //  - Esquerda -> ponteiro
        //  - Direita -> ponteiro

        //Classe ArvoreBinariaABB que possui o seguinte atributo:
        //  - Raiz -> Objeto do tipo Nodo
        //  Também possui os métodos básicos (inserir, buscar, imprimir e remover). Toda a classe se encontra no link 
        //  https://github.com/SenaGust/Todas-as-Estruturas-de-Dados/blob/master/Todas%20as%20Estruturas%20de%20Dados/ArvoreBinariaABB.cs

        public override bool Equals(object obj)
        {
            //Fica pública, facilitando seu uso fora da classe
            ArvoreBinariaABB NovaArvoreBinariaABB = (ArvoreBinariaABB)obj;
            return VerificaIgualdadeRecursivo(this.Raiz, NovaArvoreBinariaABB.Raiz); //chamamos um método que verifica a igualdade de forma recursiva
        }
        private bool VerificaIgualdadeRecursivo(Nodo raizA, Nodo raizB)
        {
            //Base ou condição de parada (caso tiver alguma ou ambas as raízes nulas)
            if (raizA == null)
            {
                if (raizB == null)
                    return true;
                else
                    return false;
            }
            else if (raizB == null)
            {
                if (raizA == null)
                    return true;
                else
                    return false;
            }

            //"fórmula" recursiva usada para saber se as duas árvores são iguais
            if (raizA.Equals(raizB)) //São iguais, continuar...
            {
                return VerificaIgualdadeRecursivo(raizA.Direita, raizB.Direita) && VerificaIgualdadeRecursivo(raizA.Esquerda, raizB.Esquerda);
            }
            else //Não são iguais, retornar false
                return false;
        }
    }

    #endregion

    #region Resposta 3
    class Exercicio3
    {
        public static bool ValidarSequencia(string sequencia)
        {
            //A implementação é baseada na Notação Polonesa ou notação de prefixo. 
            //Recebemos a string com os parênteses e vamos inserindo ou retirando (depende do símbolo que se encontra no topo da pilha) da pilha cada um do símbolos.
            Stack<char> pilha = new Stack<char>(); //Pilha nativa do C#

            for (int pos = 0; pos < sequencia.Length; pos++) //Percorremos toda a string
            {
                if (pilha.Count == 0)
                {
                    //Caso a pilha esteja vazia, inserimos o parênteses
                    pilha.Push(sequencia[pos]);
                }
                else
                {
                    //Senão, verificamos se o símbolo que se encontra no topo da pilha complementa o símbolo que vamos inserir
                    //Complementar: Quando formam os pares, exemplo "( e )" ou "[ e ]" ou "{ e }". De forma que o primeiro sempre seja um "abre" parênteses
                    char caracterTopoPilha = pilha.Peek();

                    if (ComplementaParenteses(caracterTopoPilha, sequencia[pos]))
                        pilha.Pop(); //se complementa, retiramos o símbolo que se encontra no topo da pilha
                    else
                        pilha.Push(sequencia[pos]); //se não complementa, inseremos o símbolo na pilha
                }
            }

            return (pilha.Count == 0); //Se a pilha estiver vazia, todos os parênteses se complementam. Logo, a string é válida.
        }

        static bool ComplementaParenteses(char caracterA, char caracterB)
        {
            return (caracterA == '(' && caracterB == ')' || caracterA == '{' && caracterB == '}' || caracterA == '[' && caracterB == ']');
        }
    }
    #endregion
}
