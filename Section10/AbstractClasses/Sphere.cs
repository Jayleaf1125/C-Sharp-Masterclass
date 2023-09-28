namespace Section10
{
    class Sphere : Shape {
        public double Radius { get; set; }

        public Sphere(double Radius) {
            this.Name = "Sphere";
            this.Radius = Radius;
        }

        public override double Volume()
        {
            return Math.Floor(Math.PI * (Math.Pow(Radius, 3)) * 4 / 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("This is a {0}. The Radius of this {0} is {1}. The Volume of this {0} is {2}", Name, Radius, Volume());
        }
    }
}