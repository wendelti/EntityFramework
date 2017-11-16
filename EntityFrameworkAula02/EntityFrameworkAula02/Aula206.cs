using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAula02
{
    class Aula206
    {

        public static void ExecutarCodigo()
        {


            using (var context = new SchoolDBEntities())
            {

                var students = from c in context.Students select c;

                Console.WriteLine(students.Count());

                context.Students.Add(new Student() { StudentName = "Novo Estudante" });

                context.SaveChanges();

                Console.WriteLine(students.Count());


            }

        }

    }
}
