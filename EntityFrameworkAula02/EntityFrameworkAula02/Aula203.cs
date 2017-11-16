using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAula02
{
    class Aula203
    {

        public static void ExecutarCodigo()
        {
            
            using(var context = new SchoolDBEntities())
            {

                IEnumerable<Course> cursos = 
                                from c in context.Courses
                                orderby c.Teacher.TeacherName descending
                                select c;

                foreach(Course curso in cursos)
                {
                    Console.Write(curso.CourseName);
                    Console.Write("-");
                    Console.WriteLine(curso.Teacher.TeacherName);
                }


            }
                 




        }

    }
}
