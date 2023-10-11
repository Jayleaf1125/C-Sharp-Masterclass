using System.IO;

namespace Section10
{
    class TextFileManipulator {
        private string FilePath { get; set; }

        public TextFileManipulator(string FilePath) {
            this.FilePath = String.Format(@"{0}", FilePath);
        }

        public TextFileManipulator() {
            Console.WriteLine("This Text File Manipulator is not going to work properly without a proper file path");
            FilePath = "Unknown";
        }

        public void ReadAllText() {
            string text = File.ReadAllText(FilePath);
            Console.WriteLine("Text file contains the following text: {0}", text);
        }

        public void ReadAllLines() {
            string[] lines = File.ReadAllLines(FilePath);

            for(int i = 0; i < lines.Length; i++) {
                Console.WriteLine("{0}. \t {1}", i+1, lines[i]);
            }
        }

         /// <summary>
        ///     This method can be used to manipulate files outside of the inputted file path
        /// </summary>
        /// <param name="NewContents"></param>
        /// <param name="NewFilePath"></param>
        public void WriteAllLines(string[] NewContents, string NewFilePath = "Not Specified") {
            if(NewFilePath == "Not Specified") {
                File.WriteAllLines(FilePath, NewContents);
            } else {
                File.WriteAllLines(NewFilePath, NewContents);
            }

        }
    }
}