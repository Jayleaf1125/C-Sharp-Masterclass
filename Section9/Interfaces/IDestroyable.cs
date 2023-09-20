namespace Section9 {
    interface IDestroyable 
    {
        // property to store the audio file of the destruction sound
        string DestructionSound { get; set; }
        // method to destory an object
        void Destory() {}
    }
}