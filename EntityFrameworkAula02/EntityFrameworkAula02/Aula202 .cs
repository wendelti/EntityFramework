using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAula02
{
    class Aula202
    {

        public static void ExecutarCodigo()
        {

            List<string> nomes = new List<string>();
            nomes.Add("Pedro");
            nomes.Add("Paula");
            nomes.Add("João");
            nomes.Add("Maria");
            nomes.Add("Jose");

            var nomesComQuatroLetras =
              from nomeQuatro in nomes
              where nomeQuatro.Length == 4
              select nomeQuatro;

            foreach (string nome in nomesComQuatroLetras)
            {
                Console.WriteLine(nome);
            }


        }

    }
}
