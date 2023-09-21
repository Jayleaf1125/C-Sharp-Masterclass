namespace Section9
{
    class Player : IStats, ISkills
    {
        public string Name {get; set;}
        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        public int StaminaPoints { get; set; }
        public Dictionary<string, int> Skills { get; set; }

        public Player() {
            Name = "Jason Padilla";
            HealthPoints = new Random().Next(1, 25);
            ManaPoints = new Random().Next(5, 15);
            StaminaPoints = 100;

            Skills = new Dictionary<string, int>();
            Skills.Add("Punch", 5);
            Skills.Add("Slash", 7);
            Skills.Add("FireBall", 12);
        }

        public void ReadStats()
        {
            Console.WriteLine(
                "Name: {0} | HP: {1} | MP: {2} | SP: {3}",
                Name,
                HealthPoints,
                ManaPoints,
                StaminaPoints
            );
        }

        public void ReadSkills()
        {
            for (int i = 0; i < Skills.Count; i++)
            {
                string SkillName = Skills.ElementAt(i).Key;
                int SkillDamage = Skills.ElementAt(i).Value;

                Console.WriteLine("Name: {0} | Damage: {1}", SkillName, SkillDamage);
            }
        }
    }
}
