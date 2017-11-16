using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAula02
{
    class Aula2032
    {

        public static void ExecutarCodigo()
        {
            
            using(var context = new SchoolDBEntities())
            {

                var agrupamentoDeCursos = 
                                from c in context.Courses
                                group c by c.CourseName;

                foreach(var grupoCurso in agrupamentoDeCursos)
                {

                    Console.WriteLine(grupoCurso.Key);
                    foreach(var curso in grupoCurso)
                    {
                        Console.Write("-");
                        Console.WriteLine(curso.Teacher.TeacherName);
                    }

                }


            }
                 




        }

    }
}
