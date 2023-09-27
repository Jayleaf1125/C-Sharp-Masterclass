namespace Section10
{
    class Lamo : Car {
        public string Model { get; set; }
        public Lamo(int HP, string Color, string Model):base(HP, Color) {
            this.Model = Model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("HP: {0} | Color: {1} | Model: {2}", HP, Color, Model);
        }

        public override void Repair()
        {
            Console.WriteLine("Lamo was repaird");
        }
    }
}