namespace Section9 {
    // Blueprint of all Post Instances
    class Post {
        private static int currentPostId;

        protected int ID {get; set;}
        protected string Title {get; set;}
        protected string SendByUsername {get; set;}
        protected bool IsPublic {get; set;}

        // Default Constructor
        public Post() {
            this.ID = 0;
            this.Title = "My First Post";
            this.IsPublic = true;
            this.SendByUsername = "Jason Padilla";
        }

        // Instance Constructor
        public Post(string Title, bool IsPublic, string SendByUsername) {
            this.ID = GetNextID();
            this.Title = Title;
            this.IsPublic = IsPublic;
            this.SendByUsername = SendByUsername;
        }

        protected int GetNextID() {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic) {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString() {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}