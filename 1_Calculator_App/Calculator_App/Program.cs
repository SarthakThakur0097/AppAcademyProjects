using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App

{
    enum ArgumentType
    {
        String,
        Number,
        DateTime,
        TimeSpan
    }

    enum OperatorType
    {
        Addition,
        Multiplication,
        Division,
        Subtraction
    }

    class Program
    {
        static void Main(string[] args)
        {
            int ifInt;
            string ifString;
            DateTime ifDateTime;
            TimeSpan ifTimeSpan;




            Console.WriteLine("Welcome to the Calculator App!");
            Console.WriteLine("Press CTRL+C if you would like to exit");
          
            while (true)
            {

                var firstArg = GetArgument("\nEnter your first Argument\n");
                ArgumentType argOneType = GetArgumentType(firstArg);

                Console.WriteLine("Enter your operator type\n");
                ConsoleKeyInfo key = Console.ReadKey();
                char operatorC = char.ToUpper(key.KeyChar);
                while(!((operatorC) == '+' || (operatorC) == '-' || (operatorC) == '*' || (operatorC) == '/') )
                {
                    Console.WriteLine("\nEnter your operator type\n");
                     key = Console.ReadKey();
                     operatorC = (key.KeyChar);

                }
                OperatorType finalOperator = GetOperatorType(operatorC);

                var secondArg = GetArgument("\nEnter your second Argument\n");
                ArgumentType argTwoType = GetArgumentType(secondArg);

                if (argOneType == ArgumentType.String && argTwoType == ArgumentType.String)
                {
                    string finalString;
                    switch (finalOperator)
                    {
                        case OperatorType.Addition:
                            finalString = firstArg + secondArg;
                            Console.WriteLine(finalString);
                            break;

                        case OperatorType.Division:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");
                            break;

                        case OperatorType.Multiplication:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");

                            break;

                        case OperatorType.Subtraction:
                            finalString = secondArg.Replace(firstArg, "");
                            Console.WriteLine(finalString);

                            break;
                    }
                }
                else if((argOneType == ArgumentType.TimeSpan && argTwoType == ArgumentType.DateTime) || argOneType == ArgumentType.DateTime && argTwoType == ArgumentType.TimeSpan)
                {
                    DateTime d1 = DateTime.Parse(firstArg);
                    TimeSpan d2 = TimeSpan.Parse(secondArg);
                    DateTime finalDateTime;

                    switch (finalOperator)
                    {

                        case OperatorType.Addition:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");
                            break;

                        case OperatorType.Division:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");
                            break;

                        case OperatorType.Multiplication:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");

                            break;

                        case OperatorType.Subtraction:

                            finalDateTime = d1 - d2;
                            Console.WriteLine(finalDateTime);
                            break;
                    }
                }
                else if (argOneType == ArgumentType.DateTime && argTwoType == ArgumentType.DateTime)

                {
                    DateTime d1 = DateTime.Parse(firstArg);
                    DateTime d2 = DateTime.Parse(secondArg);
                    TimeSpan finalDateTime;

                    switch (finalOperator)
                    {

                        case OperatorType.Addition:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");
                            break;

                        case OperatorType.Division:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");
                            break;

                        case OperatorType.Multiplication:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");

                            break;

                        case OperatorType.Subtraction:

                            finalDateTime = d1 - d2;
                            Console.WriteLine(finalDateTime);
                            break;
                    }
                }
                else if (argOneType == ArgumentType.String && argTwoType == ArgumentType.Number)
                {
                    int finalSecond = int.Parse(secondArg);
                    string finalString = "";
                    switch (finalOperator)
                    {

                        case OperatorType.Addition:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");
                            break;

                        case OperatorType.Division:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");
                            break;

                        case OperatorType.Multiplication:
                            for (int i = 0; i < finalSecond; i++)
                            {
                                finalString += firstArg;
                            }
                            Console.WriteLine(finalString);
                            break;

                        case OperatorType.Subtraction:
                            Console.WriteLine("Sorry this operation isn't supported with these two types, Heres what are:\nStandard mathematics for numerical arguments\nString + String => Concatenation of strings\nString - String => Remove characters in first string found in second string\nDate/Time - Date/Time => Time Span\nDate/Time +/- Time span => Date/Time\nString * Number => String repeated that number of times\n");

                            break;
                    }
                }

                else if (argOneType == ArgumentType.Number && argTwoType == ArgumentType.Number)
                {
                    int finalFirst = int.Parse(firstArg);
                    int finalSecond = int.Parse(secondArg);

                    switch (finalOperator)
                    {

                        case OperatorType.Addition:
                            Console.WriteLine(finalFirst + finalSecond);

                            break;

                        case OperatorType.Division:
                            Console.WriteLine(finalFirst / finalSecond);

                            break;

                        case OperatorType.Multiplication:
                            Console.WriteLine(finalFirst * finalSecond);


                            break;

                        case OperatorType.Subtraction:
                            Console.WriteLine(finalFirst - finalSecond);


                            break;
                    }

                }

                Console.WriteLine("Press CTRL+C if you would like to exit\n");


            }

                
            }
            static OperatorType GetOperatorType(char argument)
            {
            OperatorType typeToCheck = OperatorType.Addition;
                if (argument == '+')
                {
                    return typeToCheck;
                }
                else if (argument == '-')
                {
                    typeToCheck = OperatorType.Subtraction;
                }
                else if (argument == '*')
                {
                    typeToCheck = OperatorType.Multiplication;
                }
                else if (argument == '/')
                {
                    typeToCheck = OperatorType.Division;
                }

                return typeToCheck;
            }
            static ArgumentType GetArgumentType(string argument)
            {
                ArgumentType typeToCheck = ArgumentType.String;
                int intVal;
                DateTime dateTimeVal;
                TimeSpan timeSpanVal;

                bool isInt = int.TryParse(argument, out intVal);
                bool isDateTimeVal = DateTime.TryParse(argument, out dateTimeVal);
                bool isTimeSpan = TimeSpan.TryParse(argument, out timeSpanVal);

                if (isInt)
                {
                    

                    typeToCheck = ArgumentType.Number;
                }
                    else if (isTimeSpan)
            {

                typeToCheck = ArgumentType.TimeSpan;

            }
            else if (isDateTimeVal)
                {
                    
                    typeToCheck = ArgumentType.DateTime;
                }
              

                else
                {
             
                    return typeToCheck;


                }




                return typeToCheck;
            }


            static string GetArgument(string message)
            {
                string userVal = "";


            Console.WriteLine(message);
            userVal = Console.ReadLine();
                while (true)
                {


                    if (userVal.Length >= 1)
                    {
                        //ArgumentType = GetArgumentType(userVal);
                        return userVal;
                    }
                    else
                    {
                        Console.WriteLine(message);
                        userVal = Console.ReadLine();

                    }

                }

            }
        
    }
}
