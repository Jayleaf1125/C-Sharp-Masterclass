namespace FunClass
{
    class Person 
    {
        public string name;
        public string occupation;
        public int age;

        public Person(string Name, string Occupation, int Age)
        {
            name = Name;
            occupation = Occupation;
            age = Age;
        }

        public void Introduction()
        {
            Console.WriteLine(String.Format("My name is {0} and I work as a {1}. I am {2} years old", name, occupation, age));
        }
    }
}