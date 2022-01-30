using RPG_Abstraido.src.Entities;

namespace RPGAbstraido
{
    class Program
    {
        static void Main(string[] args)
        {         
            Wizard wizard = new Wizard("Jennica", 23, "Wizard");
            Console.WriteLine(wizard.Attack());
        }
    }

}
            