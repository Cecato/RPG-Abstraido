using RPG_Abstraido.src.Entities;

namespace RPG_Abstraido.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HealthPoint, int ManaPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.ManaPoint = ManaPoint;
        }

       public override string Attack()
       {
           return this.Name + " Lançou Magia";
       }

       public string Attack( int Bonus)
       {
            if( Bonus > 6)
            {
                return this.Name + 
                " Lançou Super Magia de cura"+ 
                " elevada com bonus de " + 
                Bonus;
            }
            else
            {
                return this.Name + 
                " Lançou Magia fraca de cura "+
                " com bonus de " + 
                Bonus;
            }
       }
       
    }
}