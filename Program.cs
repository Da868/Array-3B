using System;

namespace Array_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program Will Execute an Array that is 25 Elements");
            Console.WriteLine("__________________________________________________________");

            // Here is the automatic popluate of the array/ Size is 25 elememts
            string[] names = new string[25];

            // Strings defined in new string
            names[0] = "Element value = 1";
            names[1] = "Element value = 2";
            names[2] = "Element value = 3";
            names[3] = "Element value = 4";
            names[4] = "Element value = 5";
            names[5] = "Element value = 6";
            names[6] = "Element value = 7";
            names[7] = "Element value = 8";
            names[8] = "Element value = 9";
            names[9] = "Element value = 10";
            names[10] = "Element value = 11";
            names[11] = "Element value = 12";
            names[12] = "Element value = 13";
            names[13] = "Element value = 14";
            names[14] = "Element value = 15";
            names[15] = "Element value = 16";
            names[16] = "Element value = 17";
            names[17] = "Element value = 18";
            names[18] = "Element value = 19";
            names[19] = "Element value = 20";
            names[20] = "Element value = 21";
            names[21] = "Element value = 22";
            names[22] = "Element value = 23";
            names[23] = "Element value = 24";
            names[24] = "Element value = 25";

           

           // Iterates the elements in foreach loop
           foreach(string i in names)
            {
                Console.Write(i + "");
                Console.WriteLine("");
            }// End of foreach

            Console.WriteLine("Please Press and Key to Exit the Program....");
        }// End of Main
    }// End of Program
}// End of Namespace
