using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAula02
{
    class Aula207
    {

        public static void ExecutarCodigo()
        {

            using (var context = new SchoolDBEntities())
            {

                var aluno = context.Students.First();
                Console.WriteLine(aluno.StudentName);

                Console.WriteLine(context.Entry(aluno).State);

                Console.WriteLine("Favor, preencha o novo nome deste aluno:");

                aluno.StudentName = Console.ReadLine();

                Console.WriteLine(context.Entry(aluno).State);

                context.SaveChanges();

                Console.WriteLine(context.Entry(aluno).State);

                aluno = context.Students.First();
                Console.WriteLine(aluno.StudentName);



            }


        }

    }
}
