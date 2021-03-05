using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();

            students.Add(163, "Arif");
            students.Add(120, "Yusuf");
            students.Add(150, "Harun");
            students.Add(556, "Emre");


            students.ToList();
        }
    }
}
