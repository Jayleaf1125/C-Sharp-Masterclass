namespace Section10 {
    class Car {
        protected int HP { get; set; }
        protected string Color { get; set; }

        public Car() {}
        public Car(int HP, string Color) {
            this.HP = HP;
            this.Color = Color;
        }

        public virtual void ShowDetails() {
            Console.WriteLine("HP: {0} | Color: {1}", HP, Color);
        }
        public virtual void Repair() {
            Console.WriteLine("Car was repaired");
        }
    }
}