namespace Section9
{
    class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }
        public List<IDestroyable> DestroyablesNearby;

        public Car(float Speed, string Color) : base(Speed, Color) { 
            DestructionSound = "CarExplostionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy() {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            foreach (IDestroyable destroyable in DestroyablesNearby) {
                destroyable.Destory();
            }
        }
    }
}
