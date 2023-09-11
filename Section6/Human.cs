namespace Section6
{
    class Human
    {
        private string firstName { get; set; }
        private string lastName;
        private string eyeColor;
        private int age;
        private string job;

        public Human()
        {
            Console.WriteLine("Human Object has been created");
        }

        public Human(string firstName, string lastName, string eyeColor, int age, string job)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
            this.job = job;
        }

        public Human(string firstName, string lastName, string eyeColor, string job)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.job = job;
        }

                public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

                public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public void Introduction()
        {
            Console.WriteLine(
                "My name is {0} {1}. I am {2} years old. I work as a {3}",
                firstName,
                lastName,
                age,
                job
            );
        }

        public void sayEyeColor()
        {
            Console.WriteLine("{0} {1} has the eye color of {2}", firstName, lastName, eyeColor);
        }

        public void sayAge()
        {
            if (age == 0)
            {
                Console.WriteLine("Not born yet");
            }
            else
            {
                Console.WriteLine("I am {0} years old", age);
            }
        }

        public void sayName()
        {
            try
            {
                Console.WriteLine(lastName.GetType());
            }
            catch (System.Exception error)
            {
                Console.WriteLine("Error: {0}", error.Message);
            }
            Console.WriteLine("----------");
            Console.WriteLine(" My name is {0} {1}", firstName, lastName);
        }
    }
}
