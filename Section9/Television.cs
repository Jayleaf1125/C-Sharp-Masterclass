namespace Section9 {
    class Television : Electrical_Device {

        public Television(bool IsOn, string Brand):base(IsOn, Brand) {

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

        public void WatchingTelevision()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching television!");
            }
            else
            {
                Console.WriteLine("Television is off, turn it on first!");
            }
        }
    }
}