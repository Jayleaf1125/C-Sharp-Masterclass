namespace Section9
{
    class Electrical_Device {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public Electrical_Device(bool IsOn, string Brand)
        {
            this.IsOn = IsOn;
            this.Brand = Brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
            Console.WriteLine("Radio is on!");
        }

        public void SwitchOff()
        {
            IsOn = false;
            Console.WriteLine("Radio is off!");
        }
    }
}