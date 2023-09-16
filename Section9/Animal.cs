namespace Section9
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            this.IsHungry = true;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("What animal am I to make a sound!");
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine("{0} is eating", Name);
            }
            else
            {
                Console.WriteLine("{0} is not hungry", Name);
            }
        }

        public virtual void Play()
        {
            Console.WriteLine("{0} is playing", Name);
        }
    }
}
