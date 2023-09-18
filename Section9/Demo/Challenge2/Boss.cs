namespace Section9
{
    class Boss : Employee {
        protected string CompanyCar { get; set; }

        public Boss(string Name, string FirstName, int Salary, string CompanyCar):base(Name, FirstName, Salary) {
            this.Salary = Salary;
        }

        public void Lead() {
            Console.WriteLine("I am currently leading a project in Aerodyamics");
        }

        public override string ToString() {
            return String.Format("My name is {0}. My salary is {1}. I'm a boss and I drive {2}", Name, Salary, CompanyCar);
        }
    }
}