namespace Section9
{
    interface IStats
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int ManaPoints { get; set; }
        public int StaminaPoints { get; set; }

        void ReadStats();
    }
}
