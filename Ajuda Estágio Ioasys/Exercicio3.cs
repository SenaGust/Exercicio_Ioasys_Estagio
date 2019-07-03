using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todas_as_Estruturas_de_Dados;

namespace Ajuda_Estágio_Ioasys
{
    class Exercicio3
    {
        public static void Principal()
        {
            string sequencia0 = "[[]]";
            string sequencia1 = "][][";
            string sequencia2 = "({)}";
            Console.WriteLine(sequencia0 + " => " + ValidarSequencia(sequencia0));
            Console.WriteLine(sequencia1 + " => " + ValidarSequencia(sequencia1));
            Console.WriteLine(sequencia2 + " => " + ValidarSequencia(sequencia2));
        }

        static bool ValidarSequencia(string sequencia)
        {
            Pilha pilha = new Pilha();

            for (int pos = 0; pos < sequencia.Length; pos++)
            {
                if (pilha.Vazia())
                {
                    pilha.Empilhar(new Caracter(sequencia[pos]));
                }
                else
                {
                    Caracter caracterTopoPilha = (Caracter)pilha.ConsultarTopo();

                    if (ComplementaParenteses(caracterTopoPilha.Letra, sequencia[pos]))
                        pilha.Desempilhar(); //completar, retira
                    else
                        pilha.Empilhar(new Caracter(sequencia[pos])); //senão, insere
                }
            }

            return pilha.Vazia(); //Se a pilha estiver vazia, todos os parentesês se complementam
        }

        static bool ComplementaParenteses(char caracterA, char caracterB)
        {
            return (caracterA == '(' && caracterB == ')' || caracterA == '{' && caracterB == '}' || caracterA == '[' && caracterB == ']');
        }
    }

    class Caracter : IDado
    {
        public char Letra { get; set; }

        public Caracter(char Letra)
        {
            this.Letra = Letra;
        }

        string IDado.ToString()
        {
            throw new NotImplementedException();
        }

        bool IDado.Equals(object obj)
        {
            throw new NotImplementedException();
        }

        int IDado.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
