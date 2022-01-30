namespace RPG_Abstraido.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HealtPoint, int ManaPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = HealthPoint;
            this.ManaPoint = ManaPoint;
        }

        public Hero()
        {

        }
        public string Name;
        public int Level;
        public string HeroType;
        public int HealthPoint;
        public int ManaPoint;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + " " +
            this.HealthPoint + " " + this.ManaPoint;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou";
        }
    }
}