namespace Section10 {
    class BMW : Car {
        public string Model { get; set; }
        private string Brand;
        
        public BMW(int HP, string Color, string Model):base(HP, Color) {
            this.Model = Model;
            this.Brand = "BMW";
        }

        public override void ShowDetails() {
            Console.WriteLine("HP: {0} | Color: {1} | Model: {2}", HP, Color, Model);
        }

        public override void Repair() {
            Console.WriteLine("BMW {0} has been repaired", Model);
        }
    }
}