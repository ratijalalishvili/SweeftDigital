using SweeftDigital.Tasks;
using System;

namespace SweeftDigital
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            MyDataStructure<string> list = new MyDataStructure<string>();

            list.Add("rati");
            list.Add("nika");
            list.Add("giorgi");
            list.Add("sweeft");

            list.Update("rati", "Rati");

            list.Remove("giorgi");
            
            foreach (var item in list.ToList())
            {
               Console.WriteLine(item);
            }
        }
    }
}
