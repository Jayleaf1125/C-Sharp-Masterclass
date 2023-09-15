namespace Section9
{
    class Radio : Electrical_Device
    {

        public string Frequency { get; set; }

        public Radio(bool IsOn, string Brand, string Frequency):base(IsOn, Brand)
        {
            this.Frequency = Frequency;
        }

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }


    }
}
