namespace SimpleProject2 {
    class Creation {
        static public int Id { get; set; } = 0;
        public string Name {get; set; }
        public string Description {get; set; }

        private string[] RandomDescSelection = { "Lorem ipsum dolor sit amet, consectetur adipiscing elit", "sed do eiusmod tempor", "incididunt ut labore", "et dolore magna aliqua."};

        public Creation(string Name) {
            int ran = new Random().Next(0, RandomDescSelection.Length);

            Id++;
            this.Name = Name;

            this.Description = RandomDescSelection[ran];
        }

        public void DisplayInformation() {
            Console.WriteLine("ID: {0} | Name: {1} | Description: {2}", Id, Name, Description);
        }
    }
}