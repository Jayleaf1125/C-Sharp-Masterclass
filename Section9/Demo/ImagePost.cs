namespace Section9 {
    class ImagePost : Post {
        public string ImageURL { get; set; }

        public ImagePost() {
            this.ImageURL = "https://LoremImage.com/Random";
        }
        public ImagePost(string Title, string SendByUsername, string ImageURL, bool IsPublic) {
            // Inherited from Post
            this.ID = GetNextID();
            this.Title = Title;
            this.SendByUsername = SendByUsername;
            this.IsPublic = IsPublic;
            // Unquie Property to ImagePost class
            this.ImageURL = ImageURL;
        }

        public override string ToString()  {
            return String.Format("{0} - {1} ({2}) - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}