namespace RPG_Abstraido.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, 
                    int HealtPoint, int ManaPoint, int Damage)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.ManaPoint = ManaPoint;
            this.Damage = Damage;

        }

        public Hero()
        {

        }
        public string Name;
        public int Level;
        public string HeroType;
        public int HealthPoint;
        public int ManaPoint;
        public int Damage;

        public override string ToString()
        {
            return this.Name + " Lv.[" + this.Level + "] " + this.HeroType + " HP:" +
            this.HealthPoint + " MP:" + this.ManaPoint + " Dano:" +this.Damage;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou";
        }
    }
}