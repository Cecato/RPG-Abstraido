namespace RPG_Abstraido.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType,
         int HealthPoint, int ManaPoint, int Damage)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.ManaPoint = ManaPoint;
            this.Damage = Damage;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com um soco";
        }

        public string Attack( int Weapon)
        {
            if( Weapon == 1)
            {
                return this.Name + " Atacou com uma espada";
            }
            else if( Weapon == 2)
            {
                return this.Name + " Atacou com uma faca";
            }
            else if( Weapon == 3)
            {
                return this.Name + " Atacou com uma shuriken";
            }
            else
            {
                return Attack();
            }
        }


    }
}