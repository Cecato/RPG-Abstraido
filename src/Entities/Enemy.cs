namespace RPG_Abstraido.src.Entities
{
    public class Enemy
    {
        public Enemy(string Name, int Level, int HealthPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HealthPoint = HealthPoint;
        }

        public string Name;
        public int Level;
        public int HealthPoint;

        public override string ToString()
        {
            return this.Name + " Lv.[" + this.Level + "] HP:"+
            this.HealthPoint;
        }

        public string Attack( int damage)
        {
            return this.Name + " Atacou e causou "+damage+" de dano";
        }
    }
}