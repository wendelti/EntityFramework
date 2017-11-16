using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAula02
{
    class Aula205
    {

        public static void ExecutarCodigo()
        {
            
            using(var context = new SchoolDBEntities())
            {

                var qtdEstudantes = context.Students.Count();
                Console.WriteLine(qtdEstudantes);

                Console.WriteLine("Informe o nome do aluno:");
                var aluno = new Student();
                aluno.StudentName = Console.ReadLine();

                Console.WriteLine(context.Entry(aluno).State);

                Console.WriteLine("Aluno adicionado ao contexto");
                context.Students.Add(aluno);
                Console.WriteLine(context.Entry(aluno).State);

                context.SaveChanges();

                Console.WriteLine("Alterações salvas");
                Console.WriteLine(context.Entry(aluno).State);

                qtdEstudantes = context.Students.Count();
                Console.WriteLine(qtdEstudantes);

            }



        }

    }
}
