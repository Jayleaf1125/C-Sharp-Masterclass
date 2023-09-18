using System.Threading;

namespace Section9
{
    class VideoPost : Post
    {
        public string VideoURL { get; set; }
        public int Length { get; set; }
        protected bool IsPlaying { get; set; }
        protected int CurrentDuration = 0;
        Timer timer;

        public VideoPost() { }

        public VideoPost(
            string Title,
            string SendByUsername,
            bool IsPublic,
            string VideoURL,
            int Length
        )
        {
            this.ID = GetNextID();
            this.Title = Title;
            this.SendByUsername = SendByUsername;
            this.IsPublic = IsPublic;
            this.VideoURL = VideoURL;
            this.Length = Length;
        }

        public override string ToString()
        {
            return String.Format(
                "{0} - {1} - by {2}. ({3}) is {4} minutes long",
                this.ID,
                this.Title,
                this.SendByUsername,
                this.VideoURL,
                this.Length
            );
        }

        public void Play()
        {
            if (!IsPlaying)
            {
                this.IsPlaying = true;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void TimerCallback(Object o)
        {
            if (CurrentDuration < Length)
            {
                CurrentDuration += 1;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Video at {0} seconds", CurrentDuration);
                Console.ForegroundColor = ConsoleColor.White;
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (IsPlaying)
            {
                this.IsPlaying = false;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Stopped at {0} seconds", CurrentDuration);
                Console.ForegroundColor = ConsoleColor.White;
                CurrentDuration = 0;
                timer.Dispose();
            }
        }
    }
}
