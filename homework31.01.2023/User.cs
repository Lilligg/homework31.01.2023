using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework31._01._2023
{
    public class User
    {
        public string name = "Undefined";
        public int age;
        public void Print()
        {
            Console.WriteLine($"Имя {name}  Возраст {age}");
        }
    }
}
