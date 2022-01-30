namespace RPG_Abstraido.src.Entities
{
    public class DarkWizard : Hero
    {
        public DarkWizard(string Name, int Level, string HeroType, 
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
            return this.Name + " Atacou com magica";
        }

        public string Attack( int Bonus)
        {
            if( Bonus > 7)
            {
                return this.Name + 
                " Lançou Super Magia de dano"+ 
                " elevada com bonus de " + 
                Bonus;
            }
            else if( Bonus > 3)
            {
                return this.Name + 
                " Lançou Magia media de dano "+
                " com bonus de " + 
                Bonus;
            }
            else
            {
                return Attack();
            }
        }
    }
}