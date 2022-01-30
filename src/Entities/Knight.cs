namespace RPG_Abstraido.src.Entities
{
    public class Knight : Hero
    {
        public Knight( string Name, int Level, string HeroType, 
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
            return this.Name + " Atacou com a espada";
        }

        public string Attack( int Critical)
        {
            if( Critical > 5 )
            {
                return this.Name + " Atacou com a espada com dano critico";
            }
            else
            {
                return Attack();
            }
        }
    }
}