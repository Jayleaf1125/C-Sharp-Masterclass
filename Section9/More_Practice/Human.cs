namespace Section9
{
    class Human : Creature
    {
        public override int HP { get; set; }
        public override int MP { get; set; }
        public override Dictionary<string, int> Skills { get; set; }
        public override string Affinity { get; set; }

        public Human(string Name)
            : base(Name)
        {
            this.HP = new Random().Next(25, 50);
            this.MP = new Random().Next(15, 35);
            this.Skills = new Dictionary<string, int>()
            {
                { "Punch", 5 },
                { "Kick", 7 },
                { "Slash", 9 },
            };
            this.Affinity = "Fire";
        }

        public override void Introduction()
        {
            Console.WriteLine(
                "My name is {0}, I am from the human kingdom. We have a natural affinity to {1}",
                Name,
                Affinity
            );
        }

        public override void CheckStats() {
            Console.WriteLine(@"
Name {0}
HP: {1}
MP: {2}
Affinity: {3}
", Name, HP, MP, Affinity);
        }
    }
}
