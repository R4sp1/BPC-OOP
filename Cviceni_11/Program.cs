using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            VyukaClassesDataContext dc = new VyukaClassesDataContext();

            int ID = 8;
            String name = "Dan";
            String surname = "Pollman";


            if(!dc.Students.Any(x => x.Id == ID))
            {
                dc.Students.InsertOnSubmit(new Student() { Id = ID, DateOfBirth = DateTime.Today, Name = name, Surname = surname });
            }

            
            
            dc.SubmitChanges();

            var pocty = dc.ConnectedViews.OrderByDescending(p => p.PredmetKey);

            object prev = null;
            int pct = 1;

            foreach(var polozka in pocty)
            {
                if(polozka.PredmetKey == (String)prev)
                {
                    pct ++;
                }
                else if(prev != null)
                {
                    Console.WriteLine($"{prev} {pct}");
                    pct = 1;
                }
                

                prev = polozka.PredmetKey;
            }



            IEnumerable<Student> StudentiPredmetu(String predmetKlic)
            {
                return dc.Predmets.FirstOrDefault(p => p.Zkratka == predmetKlic).StudentPredmets.Select(s => s.Student);
            }

            String predmet = "BPC-KOM";
            IEnumerable<Student> students = StudentiPredmetu(predmet);
            foreach(var value in students)
            {
                Console.WriteLine(value.Name);
            }
        }
    }
}