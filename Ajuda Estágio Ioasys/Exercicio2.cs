using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todas_as_Estruturas_de_Dados;

namespace Ajuda_Estágio_Ioasys
{
    class Exercicio2
    {
        public static void Principal()
        {
            ArvoreBinariaABB arvore1 = new ArvoreBinariaABB();
            arvore1.Inserir(new Auxiliar(43));
            arvore1.Inserir(new Auxiliar(12));
            arvore1.Inserir(new Auxiliar(63));
            arvore1.Inserir(new Auxiliar(99));
            arvore1.Inserir(new Auxiliar(9));
            arvore1.Inserir(new Auxiliar(34));
            arvore1.Inserir(new Auxiliar(64));

            ArvoreBinariaABB arvore2 = new ArvoreBinariaABB();
            arvore2.Inserir(new Auxiliar(43));
            arvore2.Inserir(new Auxiliar(12));
            arvore2.Inserir(new Auxiliar(63));
            arvore2.Inserir(new Auxiliar(99));
            arvore2.Inserir(new Auxiliar(9));
            arvore2.Inserir(new Auxiliar(34));
            arvore2.Inserir(new Auxiliar(64));

            Console.WriteLine(questao2(arvore1, arvore2));
        }

        #region Resposta 2
        public static string questao2(ArvoreBinariaABB arvore1, ArvoreBinariaABB arvore2) //Resposta Exercicio 2
        {
            if (arvore1.Equals(arvore2))
                return "IGUAIS";
            else
                return "DIFERENTES";
        }
        #endregion
    }
}
