namespace Section9 {
    class Cat : Animal {
        public Cat(string Name, int Age):base(Name, Age) {}

        public override void MakeSound() {
            Console.WriteLine("Purrr!");
        }

        public override void Eat() {
            base.Eat();
        }

        public override void Play() {
            base.Play();
        }
    }
}