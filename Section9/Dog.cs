namespace Section9
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string Name, int Age) : base(Name, Age)
        {
            this.IsHappy = true;
        }

        public override void Eat() {
            base.Eat();
        }

        public override void MakeSound() {
            Console.WriteLine("Wuff!");
        }

        public override void Play() {
            if (IsHappy) {
                base.Play();
            } else {
                Console.WriteLine("{0} is not happy, so {0} will not play", Name);
            }
        }

        public void MakeUnHappy() {
            IsHappy = false;
        }

        public void MakeHappy() {
            IsHappy = true;
        }


    }
}
