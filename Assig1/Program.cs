    using System;

 namespace Assig1
    {
        class Program


        {
            public static int Selection()
            {
                string userValue = "";
                bool MySelection = false;



                while (MySelection == false)
                {
                    Console.WriteLine("1 = Get Length");
                    Console.WriteLine("2 = Change Length");
                    Console.WriteLine("3 = Get Width");
                    Console.WriteLine("4 = Change Width");
                    Console.WriteLine("5 = Perform Perimeter");
                    Console.WriteLine("6 = Perform Area");
                    
                    Console.WriteLine("7 = Exit\n");



                    Console.WriteLine("Please select an option, by entering a number:\n");
                    userValue = Console.ReadLine();



                    if (userValue != "1" &&
                        userValue != "2" &&
                        userValue != "3" &&
                        userValue != "4" &&
                        userValue != "5" &&
                        userValue != "6" &&
                         userValue != "7")
                    {
                        Console.WriteLine("That's not a valid menu option, please try again:\n");
                    }
                    else
                    {
                        MySelection = true;
                    }
                }



                Console.WriteLine();
                return Convert.ToInt32(userValue);
            }



            public static int Validate(string chosenNumber)
            {
                int aNumber = 1;
                bool isValid = false;



                while (isValid == false)
                {
                    Console.WriteLine($"Please enter the {chosenNumber}:");
                    string userValue = Console.ReadLine();
                    Console.WriteLine();



                    bool result = int.TryParse(userValue, out aNumber);



                    if (result == false)
                    {
                        Console.WriteLine("That's not a valid input please, please try again.\n");
                    }



                    else
                    {
                        isValid = true;
                        Console.WriteLine($"Your {chosenNumber} has been changed to: {aNumber}.\n");
                    }
                }



                return aNumber;
            }




            static void Main(string[] args)
            {
                //Rectangle R = new Rectangle();
                bool validrectSelect = false;
                string calcSelection;
                int selection;

            int length = 3;
            int width = 4;



            //    //length = Math.Round((random.NextDouble() * 500), 2);
            //    //width = Math.Round((random.NextDouble() * 500), 2);



            Console.WriteLine($"Your random numbers are {length} and {width}.\n");
            Rectangle R = new Rectangle(length, width);

            //while (validrectSelect == false)

            //    {
            //    //    Console.WriteLine("1 = Use random numbers between 0 and 501 for your calculation\n");
            //    //    Console.WriteLine("2 = Provide your own numbers\n");
                   
            //    Console.WriteLine("Choose a menu item to begin:");
            //       calcSelection = Selection().ToString();
            //       Console.WriteLine();



            //    //    if (calcSelection != "1" && calcSelection != "2")
            //    //    {
            //    //        Console.WriteLine("That's not a valid selection, please try again.\n");
            //    //    }
            //    //    else if (int.Parse(calcSelection) == 1)
            //    //    {
            //        validrectSelect = true;
            //    //        Random random = new Random();
                      
                
            //    //    int length=0;
            //    //    int width=0;



            //    ////    //length = Math.Round((random.NextDouble() * 500), 2);
            //    ////    //width = Math.Round((random.NextDouble() * 500), 2);



            //    //       Console.WriteLine($"Your random numbers are {length} and {width}.\n");
            //    //       Rectangle customRect = new Rectangle (length, width);
            //    //        R = customRect;



            //    //    }
            //    //    else if (int.Parse(calcSelection) == 2)
            //    //    {
            //    //    validrectSelect = true;



            //    //    int length;
            //    //    int width;


            //    //    length = Validate("length");
            //    //        width = Validate("width");



            //    //        Console.WriteLine($"Your custom numbers are {length} and {width}.\n");
            //    //        Rectangle customCalc = new Rectangle(length, width);
            //    //        R = customCalc;
            //    //    }
            //    }




                selection = 0;



                while (selection != 7)
                {
                    int result;

                selection = Selection();

                switch (selection)
                    {
                        case 1:
                            Console.WriteLine($"Length is: {R.GetLength()}\n");
                            break;
                        case 2:
                            result = Validate("length");
                            R.SetLength(result);
                            break;
                        case 3:
                            Console.WriteLine($"Width is: {R.GetWidth()}\n");
                            break;
                        case 4:
                            result = Validate("width");
                            R.SetWidth(result);
                            break;
                        case 5:
                            Console.WriteLine($"The result of {R.GetLength()} & {R.GetWidth()} is: {R.GetPerimeter()}\n");
                            break;
                        case 6:
                            Console.WriteLine($"The result of {R.GetLength()} & {R.GetWidth()} is: {R.GetArea()}\n");
                            break;
                         default:
                            break;
                    }

                    //selection = Selection();

                }

            }
        }
    }

