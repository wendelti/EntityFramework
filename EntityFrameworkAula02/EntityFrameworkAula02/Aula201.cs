﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAula02
{
    class Aula201
    {

        public static void ExecutarCodigo()
        {

            //int[] numeros = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //var consultaNumeros =
            //    from num in numeros
            //    where (num % 2) == 0
            //    select num;

            //foreach (int num in consultaNumeros)
            //{
            //    Console.Write("{0,1} ", num);
            //}


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
            
            foreach(string nome in nomesComQuatroLetras)
            {
                Console.WriteLine(nome);
            }


        }

    }
}
