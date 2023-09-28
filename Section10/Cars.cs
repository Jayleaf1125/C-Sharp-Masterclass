namespace Section10 {
    class Car {
        protected int HP { get; set; }
        protected string Color { get; set; }
        // Has a Relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner) {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo() {
            Console.WriteLine("ID: {0} | Owner: {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        public Car() {}
        public Car(int HP, string Color) {
            this.HP = HP;
            this.Color = Color;
        }

        public virtual void ShowDetails() {
            Console.WriteLine("HP: {0} | Color: {1}", HP, Color);
        }
        public virtual void Repair() {
            Console.WriteLine("Car was repaired");
        }
    }
}