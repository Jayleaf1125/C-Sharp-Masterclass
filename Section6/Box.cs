namespace Section6
{
    class Box
    {
        // Member Variable
        public int length { get; set; }
        private int width;
        public int height { get; set; }
        private int volume;
        private int frontSurface;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Volume
        {
            get { return width * length * height; }
        }

        public int FrontSurface
        {
            get { return height * width; }
        }

        public Box() { }

        public Box(int height, int width, int length)
        {
            this.height = height;
            this.width = width;
            this.length = length;
            this.volume = height * width * length;
            this.frontSurface = height * length;
        }

        public void Reset(int length, int width, int height)
        {
            this.height = height;
            this.width = width;
            this.length = length;
            this.volume = height * width * length;
            this.frontSurface = height * length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(
                "Length is {0} and height is {1} and width is {2}, so volume is {3}. With the front surface being {4}",
                length,
                height,
                width,
                volume,
                frontSurface
            );
        }
    }
}
