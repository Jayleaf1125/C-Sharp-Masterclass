namespace Section6
{
    class Wizard
    {
        string FirstName;
        string LastName;
        string Magic;
        string Spell = "Fire Ball";

        public Wizard(string firstName, string lastName, string magic)
        {
            FirstName = firstName;
            LastName = lastName;
            Magic = magic;
        }

        public void Action()
        {
            Console.WriteLine("{0} {1} use {2}", FirstName, LastName, Magic);
        }
    }
}
