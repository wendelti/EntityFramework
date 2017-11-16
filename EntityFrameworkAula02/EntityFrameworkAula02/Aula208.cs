using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAula02
{
    class Aula208
    {

        public static void ExecutarCodigo()
        {

            using (var context = new SchoolDBEntities())
            {

                var aluno = context.Students.First();


                Console.WriteLine(aluno.StudentName);
                Console.WriteLine(context.Entry(aluno).State);

                context.Students.Remove(aluno);

                Console.WriteLine(context.Entry(aluno).State);

                context.SaveChanges();

                Console.WriteLine(context.Entry(aluno).State);



            }

        }

    }
}
