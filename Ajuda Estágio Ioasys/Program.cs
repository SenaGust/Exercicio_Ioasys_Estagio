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
            Exercicio3.Principal();
            //Fim
            Console.ReadKey();
        }

        #region Resposta 1
        //static int[] CriarVetorResultado(int[] vetorBase)
        //{
        //    int[] vetorResultado = new int[vetorBase.Length];

        //    //Inicializando os valores de forma que int.MinValue seja a referência para uma posição vazia
        //    for (int pos = 0; pos < vetorBase.Length; pos++)
        //        vetorResultado[pos] = int.MinValue;

        //    //Inserindo valores no vetorResultado, conforme solicitado no enunciado
        //    for (int posVetorBase = 0; posVetorBase < vetorBase.Length; posVetorBase++) //Percorre o vetorBase
        //    {
        //        for (int posVetorResultado = 0; posVetorResultado < posVetorBase + 1; posVetorResultado++) //Percorre o VetorResultado
        //        {
        //            if (vetorBase[posVetorBase] == vetorResultado[posVetorResultado])
        //            {
        //                //caso esse número esteja em alguma posição anterior, ou seja, duplicado, não iremos inserí-lo no vetorResultado
        //                break;
        //            }
        //            else if (vetorResultado[posVetorResultado] == int.MinValue)
        //            {
        //                //Caso encontremos uma posição vazia, sabemos que o respectivo número não está duplicado e podemos inserí-lo no vetorResultado
        //                vetorResultado[posVetorResultado] = vetorBase[posVetorBase];
        //                break;
        //            }
        //        }
        //    }

        //    return vetorResultado;
        //}
        #endregion

        #region Resposta 2
        //public static string questao2(ArvoreBinariaABB arvore1, ArvoreBinariaABB arvore2)
        //{
        //    if (arvore1.Equals(arvore2))
        //        return "IGUAIS";
        //    else
        //        return "DIFERENTES";
        //}

        //class ArvoreBinariaABB
        //{
        //    public override bool Equals(object obj)
        //    {
        //        ArvoreBinariaABB NovaArvoreBinariaABB = (ArvoreBinariaABB)obj;
        //        return VerificaIgualdadeRecursivo(this.Raiz, NovaArvoreBinariaABB.Raiz);
        //    }
        //    private bool VerificaIgualdadeRecursivo(Nodo raizA, Nodo raizB)
        //    {
        //        //Base ou condição de parada (caso tiver alguma ou ambas as raízes nulas)
        //        if (raizA == null)
        //        {
        //            if (raizB == null)
        //                return true;
        //            else
        //                return false;
        //        }
        //        else if (raizB == null)
        //        {
        //            if (raizA == null)
        //                return true;
        //            else
        //                return false;
        //        }

        //        //"formula"
        //        if (raizA.Equals(raizB)) //São iguais, continuar...
        //        {
        //            return VerificaIgualdadeRecursivo(raizA.Direita, raizB.Direita) && VerificaIgualdadeRecursivo(raizA.Esquerda, raizB.Esquerda);
        //        }
        //        else //Não são iguais, retornar false
        //            return false;
        //    }
        //}

        #endregion

        #region Resposta 3
        //class Exercicio3
        //{
        //    public static void Principal()
        //    {
        //        string sequencia0 = "[[]]";
        //        string sequencia1 = "][][";
        //        string sequencia2 = "({)}";
        //        Console.WriteLine(sequencia0 + " => " + ValidarSequencia(sequencia0));
        //        Console.WriteLine(sequencia1 + " => " + ValidarSequencia(sequencia1));
        //        Console.WriteLine(sequencia2 + " => " + ValidarSequencia(sequencia2));
        //    }

        //    static bool ValidarSequencia(string sequencia)
        //    {
        //        Pilha pilha = new Pilha();

        //        for (int pos = 0; pos < sequencia.Length; pos++)
        //        {
        //            if (pilha.Vazia())
        //            {
        //                pilha.Empilhar(new Caracter(sequencia[pos]));
        //            }
        //            else
        //            {
        //                Caracter caracterTopoPilha = (Caracter)pilha.ConsultarTopo();

        //                if (ComplementaParenteses(caracterTopoPilha.Letra, sequencia[pos]))
        //                    pilha.Desempilhar(); //completar, retira
        //                else
        //                    pilha.Empilhar(new Caracter(sequencia[pos])); //senão, insere
        //            }
        //        }

        //        return pilha.Vazia(); //Se a pilha estiver vazia, todos os parentesês se complementam
        //    }

        //    static bool ComplementaParenteses(char caracterA, char caracterB)
        //    {
        //        return (caracterA == '(' && caracterB == ')' || caracterA == '{' && caracterB == '}' || caracterA == '[' && caracterB == ']');
        //    }
        //}

        //class Caracter : IDado
        //{
        //    public char Letra { get; set; }

        //    public Caracter(char Letra)
        //    {
        //        this.Letra = Letra;
        //    }
        //}
        #endregion
    }

}
