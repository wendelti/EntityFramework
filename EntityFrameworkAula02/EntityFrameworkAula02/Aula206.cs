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

                var alunos = from s in context.Students
                             select s;

                var alunosRetornados = alunos.ToArray();

                foreach(var aluno in alunosRetornados)
                {
                    Console.WriteLine(aluno.StudentName);
                }

                context.Students.Add(new Student() { StudentName = "Joao 123" });
                context.SaveChanges();

                Console.WriteLine("-");
                
                foreach (var aluno in alunosRetornados)
                {
                    Console.WriteLine(aluno.StudentName);
                }


            }

        }

    }
}
