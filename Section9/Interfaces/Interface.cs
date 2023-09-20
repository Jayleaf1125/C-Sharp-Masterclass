namespace Section9
{
    class Ticket : IEquatable<Ticket> {
        public int DurationHours { get; set; }

        public Ticket(int DurationHours) {
            this.DurationHours = DurationHours;
        }

        public bool Equals(Ticket other) {
            return this.DurationHours == other.DurationHours;
        }
    }
}