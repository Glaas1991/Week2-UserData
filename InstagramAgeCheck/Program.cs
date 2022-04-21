using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm kontrollib kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib instagram'i kasutada;
            //kui kasutaja on noorem, kui 13 aastat, siis ta on liiga noor;

            Console.WriteLine("Palun, siesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et instagram'i kontot luua.");
            }
            else if (userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et instagram'i kontot luua.");
            }
            else
            {
                Console.WriteLine("Oledki 13, nüüd saad endale instagram'i kontot luua.");
            }
            Console.WriteLine("Kena päeva!");


        }
    }
}
