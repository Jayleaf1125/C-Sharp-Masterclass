using SimpleProject2;

namespace SimpleProject2
{
    class CreatingObjects
    {
        List<Creation> storage = new List<Creation>();

        public void Run()
        {
            while (true)
            {
                Console.Write("What do you want to do: ");
                string userCommandInput = Console.ReadLine();

                switch (userCommandInput)
                {
                    case "create":
                        Console.WriteLine("Create Selected");
                        Console.Write("What is the name of this object: ");
                        string userNameInput = Console.ReadLine();
                        var newObj = new Creation(userNameInput);
                        storage.Add(newObj);
                        break;
                    case "display":
                        foreach (Creation createObj in storage)
                        {
                            createObj.DisplayInformation();
                        }
                        break;
                    case "end":
                        return;
                }
            }
        }
    }
}
