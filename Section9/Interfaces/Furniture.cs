namespace Section9 {
    class Furniture {

        protected string Color { get; set; }
        protected string Material { get; set; }

        public Furniture(string Color, string Material) {
            this.Color = Color;
            this.Material = Material;
        }
    }
}