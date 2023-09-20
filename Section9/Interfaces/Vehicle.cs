using System.Reflection;

namespace Section9 {
    class Vehicle {
        protected float Speed { get; set; }
        protected string Color { get; set; }

        public Vehicle() {
            Speed = 120f;
            Color = "Black";
        }

        public Vehicle(float Speed, string Color) {
            this.Speed = Speed;
            this.Color = Color;
        }
    }
}