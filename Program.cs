using RPG_Abstraido.src.Entities;

namespace RPGAbstraido
{
    class Program
    {
        static void Main(string[] args)
        {         
            Knight knight = new Knight("Arus", 25, "Knight", 100, 0, 20);
            Wizard wizard = new Wizard("Jennica", 23, "Wizard", 20, 100, 25);
            Ninja ninja = new Ninja("Gustavo", 20, "Ninja", 50, 0, 25);
            DarkWizard darkWizard = new DarkWizard("Antenor", 23, "Dark Wizard", 25, 105, 20);

            Enemy enemy = new Enemy("Gu", 99, 500);

            Console.WriteLine("Heros");
            Console.WriteLine(wizard);
            Console.WriteLine(knight);
            Console.WriteLine(ninja);
            Console.WriteLine(darkWizard);

            Console.WriteLine("\nEnimigo");
            Console.WriteLine(enemy);

            Random random = new Random();
            int heroAction, enemyAction;
            int herosDamage = knight.Damage + wizard.Damage + darkWizard.Damage + ninja.Damage;

            Console.WriteLine("\nPressione Enter para iniciar a batalha...");
            Console.ReadKey();
        
            
           do
           {
               heroAction = random.Next(0,10);
               enemyAction = random.Next(10,25);

                Console.WriteLine(wizard.Attack(heroAction));
                Console.WriteLine(knight.Attack(heroAction));
                Console.WriteLine(ninja.Attack(heroAction));
                Console.WriteLine(darkWizard.Attack(heroAction));

                enemy.HealthPoint = enemy.HealthPoint - (herosDamage + heroAction * 4);

                Console.WriteLine(enemy.Attack(enemyAction));
                
                if( wizard.HealthPoint > 0)
                {
                    wizard.HealthPoint -= enemyAction;
                }
                else if( darkWizard.HealthPoint > 0)
                {
                    darkWizard.HealthPoint -= enemyAction;
                }
                else if( ninja.HealthPoint > 0)
                {
                    ninja.HealthPoint -= enemyAction;
                }
                else
                {
                    knight.HealthPoint -= enemyAction;
                }

                Console.WriteLine("Enter para continuar...\n");
                Console.ReadKey();

                Console.WriteLine("Heros");
                Console.WriteLine(wizard);
                Console.WriteLine(knight);
                Console.WriteLine(ninja);
                Console.WriteLine(darkWizard);

                Console.WriteLine("\nEnimigo");
                Console.WriteLine(enemy);

                Console.WriteLine("Enter para continuar...\n");
                Console.ReadKey();

            }while( enemy.HealthPoint > 0);
            
            

        }

    }

}
            