namespace Section9
{
    class Trainee : Employee {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee(string Name, string FirstName, int Salary, int WorkingHours, int SchoolHours):base(Name, FirstName, Salary) {
            this.WorkingHours = WorkingHours;
            this.SchoolHours = SchoolHours;
        }

        public void Learn() {}
        public override void Work() {
            Console.WriteLine("I work as an AMT on a 747");
        }

        public override string ToString() {
            return String.Format("My name is {0}. My salary is {1}. I'm a trainee, I work for {2} hours and go to school for {3} hours", Name, Salary, WorkingHours, SchoolHours);
        }
    }   
}