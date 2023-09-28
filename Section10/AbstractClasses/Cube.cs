namespace Section10
{
    class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double Length) {
            this.Name = "Cube";
            this.Length = Length;
        }

        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("This {0} has a length of {1}. The volume of this {0} is {2}", Name, Length, Volume());
        }
    }
}