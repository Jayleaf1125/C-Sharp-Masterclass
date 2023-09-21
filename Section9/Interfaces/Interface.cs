using System.Collections;

namespace Section9
{
    class Ticket : IEquatable<Ticket>
    {
        public int DurationHours { get; set; }

        public Ticket(int DurationHours)
        {
            this.DurationHours = DurationHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationHours == other.DurationHours;
        }
    }

    class Bird
    {
        public string Name { get; set; }
        public bool IsNaughtyBird { get; set; }

        public Bird(string Name, bool IsNaughtyBird) {
            this.Name = Name;
            this.IsNaughtyBird = IsNaughtyBird;
        }

        public void GiveTreat(int numberOfTreats) {
            Console.WriteLine("Bird: {0} said chirp {1} time!", Name, numberOfTreats);
        }
    }

    class BirdShelter : IEnumerable<Bird> {
        public List<Bird> birds; 

        public BirdShelter() {
            birds = new List<Bird>() {
                new Bird("Jason", true),
                new Bird("Matthew", false),
                new Bird("Oscar", true),
                new Bird("Mami", false),
                new Bird("Papi", false),
                new Bird("Giovana", true),
            };
        }

        public IEnumerator<Bird> GetEnumerator()
        {
            return birds.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
