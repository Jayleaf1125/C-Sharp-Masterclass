using System.Runtime.ConstrainedExecution;

namespace Section9
{
    class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }

        public Chair(string Color, string Material) : base(Color, Material)
        {
            DestructionSound = "ChairExplostionSound.mp3";
        }

        public void Destory()
        {
            Console.WriteLine("The {0} chair was destroyed", Color);
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
