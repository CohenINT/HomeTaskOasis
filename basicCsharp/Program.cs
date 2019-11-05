using System;
using System.Collections.Generic;
using System.Text;

namespace basicCsharp
{

    

    class Program
    {


        public static List<string> Possibilities(string word)
        {

            Dictionary<string,char > _morseAlphabetDictionary;
            _morseAlphabetDictionary = new Dictionary<string,char >()
                                   {
                                       {".-",'A'},
                                       {"-..",'D'},
                                       {".",'E'},
                                       { "--.",'G'},
                                       {"..",'I'},
                                       { "-.-",'K'},
                                       { "--",'M'},
                                       { "-.",'N'},
                                       { "---",'O'},
                                       { ".-.",'R'},
                                       {"...",'S'},
                                       { "-",'T'},
                                       { "..-",'U'},
                                       { ".--",'W'}
                                   };



            List<string> result = new List<string>();



            switch (word)
            {
                case "?.":
                    result.Add("I");
                    result.Add("N");
                    break;


                case "?":
                    result.Add("E");
                    result.Add("T");

                    break;


                case ".?":
                    result.Add("I");
                    result.Add("A");

                    break;


                case "?-?":

                    result.Add("W");
                    result.Add("R");
                    result.Add("O");
                    result.Add("G");
                    break;



                case "?-":
                    result.Add("A");
                    result.Add("M");
                    break;


                case "-?":
                    result.Add("N");
                    result.Add("M");
                    break;

                case "??":
                    result.Add("I");
                    result.Add("A");
                    result.Add("N");
                    result.Add("M");

                    break;


                case ".??":
                    result.Add("S");
                    result.Add("U");
                    result.Add("R");

                    break;


                case "?..":
                    result.Add("S");
                    result.Add("D");
                    break;



                case "?.?":
                    result.Add("S");
                    result.Add("U");
                    result.Add("D");
                    result.Add("K");


                    break;




                case "-?.":
                    result.Add("D");
                    result.Add("G");
                    break;



                case ".?-":
                    result.Add("U");
                    result.Add("W");
                    break;



                case "-??":
                    result.Add("D");
                    result.Add("K");
                    result.Add("G");
                    result.Add("O");
                    break;

                case "?.-":
                    result.Add("U");
                    result.Add("K");
                    break;


                case "?-.":
                    result.Add("R");
                    result.Add("g");
                    break;


                default:
                    //In case of the "word" variable is a direct combination of a letter, then insert it into the result array
                    if (_morseAlphabetDictionary.ContainsKey(word))
                    {
                        result.Add(_morseAlphabetDictionary[word].ToString());
                    }

                    break;
            }

            return result;

        }





        static void Main()
        {
       
            List<string> arr1 = Possibilities("?-");

            //Displaying
            Console.Write("[");
            foreach (string item in arr1)
            {
              
                Console.Write("'"+item+"',");
                
            }
            Console.Write("]");
            Console.WriteLine();


        }

        


    }
}
