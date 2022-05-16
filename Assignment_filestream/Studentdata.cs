using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_filestream
{
    internal class Studentdata
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public decimal Grade { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Class: {Class}, Grade: {Grade}";
        }

        public static List<Studentdata> GetStudentdatas()
        {
            return new List<Studentdata>
            {
                new Studentdata { Name ="John", Age = 15, Class = "Year one", Grade = 5 },
                new Studentdata { Name ="Peter", Age = 20, Class = "Year three", Grade = 7 },
                new Studentdata { Name ="Cynthia", Age = 30, Class = "Year four", Grade = 4 },
                new Studentdata { Name ="James", Age = 25, Class = "Year two", Grade = 2 },
                new Studentdata { Name ="Ebuka", Age = 35, Class = "Year six", Grade = 3 },
                new Studentdata { Name ="Bisi", Age = 10, Class = "Year five", Grade = 6 },



            };
        }
    }
}
