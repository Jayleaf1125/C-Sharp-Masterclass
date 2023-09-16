namespace Section9
{
    class Creature
    {
        public string Name { get; set; }
        public virtual int HP { get; set; }
        public virtual int MP { get; set; }
        public virtual Dictionary<string, int> Skills { get; set; }
        public virtual string Affinity { get; set; }

        public Creature(string Name)
        {
            this.Name = Name;
        }

        public virtual void Introduction() { }
        public virtual void CheckStats() { }

        public void TakeDamage()
        {
            Random rnd = new Random();
            int damage = rnd.Next(1, 10);

            HP -= damage;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "You have take {0} damage. You now have {1} health points left.",
                damage,
                HP
            );
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Heal()
        {
            Random rnd = new Random();
            int heal = rnd.Next(1, 10);

            HP += heal;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "You have healed for {0} health points. You now have {1} health points.",
                heal,
                HP
            );
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void CheckSkills() {
            for (int i = 0; i < Skills.Count; i++) {
                KeyValuePair<string, int> keyValuePair = Skills.ElementAt(i);

                string skillName = keyValuePair.Key;
                int skillValue = keyValuePair.Value;

                Console.WriteLine("{0} : {1}", skillName, skillValue);
            }
        }
    }
}
