using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAula02
{
    class Aula204
    {

        public static void ExecutarCodigo()
        {

            using (var context = new SchoolDBEntities())
            {


                //var nomes = (
                //    from s in context.Students
                //    select s.StudentName
                //    ).Concat(
                //    from t in context.Teachers
                //    select t.TeacherName);

                //foreach(string nome in nomes)
                //{
                //    Console.WriteLine(nome);
                //}


                //IEnumerable<Student> estudantes = context.Students;
                //var estudantes = from s in context.Students
                //                select new { Nome = s.StudentName, Cidade = s.StudentAddress.City };

                //foreach(var e in estudantes)
                //{

                //    Console.Write(e.Nome);
                //    Console.Write(" - ");
                //    Console.WriteLine(e.Cidade);

                //}

                int[] numeros = { 1, 2, 3 };

                var exponencial = from n in numeros
                                   select n * n;

                foreach(int exp in exponencial)
                {
                    Console.WriteLine(exp);
                }


            }



        }

    }
}
