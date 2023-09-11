namespace ArrayLearning
{
    class ArrayLearn {
        public static void DefaultValue()
        {
            int value = 5, count = 3;
            var array = new bool[count].Select(_ => value).ToArray();

            // Console.WriteLine(array);
            foreach (var number  in array)
                Console.Write("{0}, ", number);
        } 

        public static void EmptyArray()
        {
            
        }
        public static void SingleDimensionalArray()
        {

        }
        public static void MultidimensionalArray()
        {

        }
        public static void JaggedArray()
        {

        }
    }
}