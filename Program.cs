using RPG_Abstraido.src.Entities;

namespace RPGAbstraido
{
    class Program
    {
        static void Main(string[] args)
        {         
            Knight knight = new Knight("Arus", 25, "Knight", 100, 20);
            Wizard wizard = new Wizard("Jennica", 23, "Wizard", 20, 100);

            Console.WriteLine(wizard);
            Console.WriteLine(knight);
        }
    }

}
            