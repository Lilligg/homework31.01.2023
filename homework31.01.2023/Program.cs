// See https://aka.ms/new-console-template for more information

using homework31._01._2023;
using System.Runtime.InteropServices;

string[] names = {"Пенси", "Драко", "Тео", "Блейз", "Гермиона"};
User user = new User();
Random rand = new Random();
for (int i = 0; i < names.Length; i++)
{
    user.name = names[i];
    user.age = rand.Next(0, 100);
    user.Print();
}