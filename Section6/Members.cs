using System.Diagnostics;

namespace Section6
{
    class Members
    {
        // member - private field
        private string name;
        private string jobTitle;
        private int salary = 20000;

        // member - public field
        public int age;

        // Properties
        public string JobTitle { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // public member method
        public void Introducting(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine(
                    "My name is {0}, and my job title is {1}. I'm {2} years old",
                    name,
                    jobTitle,
                    age
                );
            }
            ;
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            name = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Member is created");
        }
        // member - finalizer - destructor
        ~Members() {
            // Cleanup statements
            Console.WriteLine("Destruction of Members Object");
            Debug.Write("Destruction of Members Object");
        }
    }
}
