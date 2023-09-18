namespace Section9 {
    class Employee {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employee(string Name, string FirstName, int Salary) {
            this.Name = Name;
            this.FirstName = FirstName;
            this.Salary = Salary;
        }

        public virtual void Work() {
            Console.WriteLine("I'm working");
        }

        public void Pause() {
            Console.WriteLine("I'm on break");
        }

        public override string ToString() {
            return String.Format("My name is {0}. My salary is {1}. I;m an employee", Name, Salary);
        }
    }
}