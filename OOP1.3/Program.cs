using System;

namespace OOP1._3
{
    class Program
    {
        class Zoomagazin
        {
            public string jivotnoe;
            public string pol;
            public string Im9;
            public int Cena;
            internal int kolvo;
        }
        static void Main(string[] args)
        {
            {
                Zoomagazin clas = new Zoomagazin();

                Console.Write("Введите животное: ");
                clas.jivotnoe = Convert.ToString(Console.ReadLine());

                Console.Write("Введите пол животного: ");
                clas.pol = Convert.ToString(Console.ReadLine());

                Console.Write("Введите имя животного: ");
                clas.Im9 = Convert.ToString(Console.ReadLine());

                Console.Write("Введите цену животного: ");
                clas.Cena = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите кол-во животных: ");
                clas.kolvo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("_____________________________");
                Console.WriteLine(clas.jivotnoe + " " + clas.pol + " " + clas.Im9 + " " + clas.Cena + " " + clas.kolvo);
                Console.ReadLine();
            }
        }
    }
}
