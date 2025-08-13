using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
  static void Main(String[] args)
  {
    //WriteLine Methods
    /* Console.WriteLine("Hello World!");
     Console.WriteLine("I am learning C#");
     Console.WriteLine("It is  awesome");
     Console.WriteLine(3 + 3);*/

    //Write Methods
    /* Console.Write("Hello World !");
     Console.Write("I will print on the same line");*/

    //Variables-{String}
    /*  string name = "John";
      Console.WriteLine(name);*/
    //Example
    /*  string greeting = "hello world \n";
      string name = "john";
      string message;
       message = greeting + name;
      Console.WriteLine(message);*/

    /* int myNum = 15;
     Console.WriteLine(myNum);*/

    //OR
    /* int myNum;
     myNum = 15;
     Console.WriteLine(myNum);*/
    //Example
    /* int number = 42;
     Console.WriteLine(number);
     int sum = number + 10;
     Console.WriteLine(sum);
     int updatenumber = 100;
     Console.WriteLine(updatenumber);*/



    //{double}
    /* double myDoubleNum = 19.99;
       Console.WriteLine(myDoubleNum);*/
    //Example
    /* double price = 19.99 ;
     double tempreture = -3.5;
     double scientificValue = 6.023456;
     double radius = 5.5;
     double area = Math.PI * radius * radius;
     Console.WriteLine(price);
     Console.WriteLine(tempreture);
     Console.WriteLine(scientificValue);
     Console.WriteLine(area);*/

    /*double a = 0.1;
    double b = 0.2;
    double sum = a + b;
    Console.WriteLine(sum);*/

    //{char}
    /* char myLetter = 'D';
     Console.WriteLine(myLetter);*/
    //Example
    /*char myChar = 'A';
    Console.WriteLine(myChar);
    char ch1 = 'a';
    Console.WriteLine(ch1);
    char ch3 = '\x0061';  // 'a'
    Console.WriteLine(ch3);
    char ch4 = (char)97;  // 'a'
    Console.WriteLine(ch4);
    char letter = 'B';
    Console.WriteLine(letter);
    char digit = '7';
    Console.WriteLine(digit);
    char lower = 'c';
    Console.WriteLine(lower);
    char newLine = '\n';
    char tab = '\t';
    char backslash = '\\';
    char singleQuote = '\'';
    Console.WriteLine(newLine);
    Console.WriteLine(tab);
    Console.WriteLine(backslash);
    Console.WriteLine(singleQuote);*/


    //{Bool}
    /*bool myBool = true;
    Console.WriteLine(myBool);*/
    //Example
    /* int x = 10;
     int y = 20;
     bool isXGreaterThanY = x > y; 
        Console.WriteLine($"Is x greater than y? {isXGreaterThanY}");*/

    //Display variables {1}
    /* string name = "John";
     Console.WriteLine("Hello"+ name  );*/
    //{2}
    /*string firstName = "John";
    string lastName = "Doe";
    string fullName = firstName + lastName;
    Console.WriteLine(fullName);*/
    //{3}
    /*int x = 5;
    int y = 6;
    Console.WriteLine(x + y);*/

    //Multiple variables {1}
    /* int x = 5, y = 6, z = 50;
     Console.WriteLine(x + y + z);*/
    //{2}
    /* int x, y, z;
     x = y = z = 50;
     Console.WriteLine(x + y + z);*/

    //Integer types -Int 
    /*  int myNum = 100000;
      Console.WriteLine(myNum);*/
    //long
    /*long myNum = 15000000L;
    Console.WriteLine(myNum);*/

    //Floting types - Float
    /* float myNum = 5.75F;
     Console.WriteLine(myNum);*/
    //double
    /*double myNum = 19.99D;
    Console.WriteLine(myNum);*/

    //Scientific Numbers
    /* float f1 = 35e3F;
     double d1 = 12D;
     Console.WriteLine(f1);
     Console.WriteLine(d1);*/

    //Type Casting
    //Implicity-{Example}
    /* int myInt = 9;
     double myDouble = myInt;
     Console.WriteLine(myInt);
     Console.WriteLine(myDouble);*/
    //Explicit-}{Example}
    /* double myDouble = 9.78;
     int myInt = (int)myDouble;
     Console.WriteLine(myDouble);
     Console.WriteLine(myInt);*/

    //Type Conversion Method-{Example}
    /*int myInt = 10;
    double myDouble = 5.25;
    bool myBool = true;
    Console.WriteLine(Convert.ToString(myInt));
    Console.WriteLine(Convert.ToDouble(myInt));
    Console.WriteLine(Convert.ToInt32(myDouble));
    Console.WriteLine(Convert.ToInt64(myInt));
    Console.WriteLine(Convert.ToString(myBool));*/

    //User Input - {Example 1}
    /*Console.WriteLine("Enter username");
    string userName = Console.ReadLine();
    Console.WriteLine("Username is" + userName);*/
    //{Example 2}-Error
    /*Console.WriteLine("Enter your age");
    int age = Console.ReadLine();
    Console.WriteLine("your age is" + age);*/
    //not error
    /* Console.WriteLine("Enter your age");
     int age = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Your age is" + age);*/

    //OPERATORS-{Example 1}
    /*int x = 100 + 50;
    Console.WriteLine(x);*/

    //{Example 2}

    /*int sum1 = 100 + 50;
    int sum2 = sum1 + 250;
    int sum3 = sum2 + sum2;
    Console.WriteLine(sum1);
    Console.WriteLine(sum2);
    Console.WriteLine(sum3);*/

    //Arithmetic Operators
    /* int x = 45;
     x++;
    x--;
     int y = 15;
     Console.WriteLine(x + y); //Addition
     Console.WriteLine(x - y); //Subtraction
     Console.WriteLine(x * y); //Multiplication
     Console.WriteLine(x / y); //Division
     Console.WriteLine(x % y); //Modulus
    Console.WriteLine(x); //Increment
     Console.WriteLine(x); //Decrement*/

    //Assignment Operator {Example}
    /* int x = 10;
     // x += 5; //Addition
     //x -= 3;  //subtraction
     //x *= 3; //multiplication
     //  x /= 3; //division
     // x %= 3; //modulus
     // x &= 3; //bitwise and
     //x |= 3; //bitwise or
     //  x ^= 3; //bitwise xor
     // x >>= 3; //right shift
    // x <<= 3; //left shift
     Console.WriteLine(x);*/

    //Comparision Operator-{Example}
    /* int x = 5;
     int y = 3;
     Console.WriteLine(x == y); //equal to
     Console.WriteLine(x != y); //not equal
     Console.WriteLine(x > y); //greater than
     Console.WriteLine(x < y); //less than
     Console.WriteLine(x >= y); //greater than and equal to
     Console.WriteLine(x <= y);*/ //less than and equal to


    //Logical Operators -{Example}
    /* int x = 5;
     Console.WriteLine(x > 3 && x < 10);     // logical and
     Console.WriteLine(x > 5 || x < 4);       //logical or
      Console.WriteLine(!(x > 3 && x < 10));*/  //logical not

    //Math tools {Example}
    //Math.Max
    /* Console.WriteLine(Math.Max(5, 10));
     //Math.Min
     Console.WriteLine(Math.Min(5, 10));
     //Math.Sqrt
     Console.WriteLine(Math.Sqrt(64));
     //Math.Abs
     Console.WriteLine(Math.Abs(-4));
     //Math.Round
     Console.WriteLine(Math.Round(9.99));*/

    //STRING -{EXAMPLE}
    /* string greeting = "Hello";
     Console.WriteLine(greeting);
     string greeting2 = "Nice to meet you";
     Console.WriteLine(greeting2);
     //STRING LENGTH
     string txt = "ABCDEFGHI";
     Console.WriteLine("The length of the txt string " + txt.Length);*/
    //OTHER METHODS-{TOUPPERCASE}
    /* string txt = "Hello World!";
     Console.WriteLine(txt.ToUpper());
     Console.WriteLine(txt.ToLower());*/
    //STRING CONCATENATION {Example 1}
    /* string firstName = "John";
     string lastName = "Doe";
     //string name = firstName + lastName;
     string name = string.Concat(firstName, lastName);
     Console.WriteLine(name);
     //{Example 2}
     string x = "10";
     string y = "20";
     // string z = x + y;
     string z = string.Concat(x, y);
     Console.WriteLine(z);*/
    //STRING INTERPOLATION -{EXAMPLE}
    /*  string firstName = "John";
      string lastName = "Doe";
      string name = $"My full name is  {firstName}  {lastName}";
      Console.WriteLine(name);
      //ACESS STRING {EXAMPLE 1}
      string myString = "Hello";
      Console.WriteLine(myString[0]);
      Console.WriteLine(myString[1]);
      //{EXAMPLE 2} SPECIFIC METHOD
      Console.WriteLine(myString.IndexOf("e"));*/
    //LOCATION 
    /* string name = "John Doe";
     int charPos = name.IndexOf("D");
     string lastName = name.Substring(charPos);
     Console.WriteLine(lastName);*/

    //SPECIAL CHARACTER
    //{\"- double quotes}
    // string txt = "we are the so-called\" vikings \" from the north";
    //{\'- single quotes}
    // string txt = "It\'s alright";
    //{\\- backslash}
    // string txt = "The character \\ is called backslash";
    //{\n- new line}
    //string txt = "Hello\nWorld";
    //{\t- new tab}
    // string txt = "Hello\t World";
    //{\b- backspace}
    // string txt = "hel\b lo World";
    //Console.WriteLine(txt);


    //BOOLEANS EXAMPLE
    /*  bool isCSharpFun = true;
      bool isFishTasty = false;
      Console.WriteLine(isCSharpFun);
      Console.WriteLine(isFishTasty);
      //COMPARISION OPERATOR{>}
      int x = 10;
      int y = 15;
      Console.WriteLine(x > y);
      //Or
      // Console.WriteLine(10 > 15);*/
    //EQUAL TO {==}
    /*int x = 10;
    Console.WriteLine(x == 10);
    //or
    //Console.WriteLine(10 == 15);
    //EQUAL TO GREATER THAN{>=}
    int myAge = 25;
    int votinAge = 18;
    Console.WriteLine(myAge >= votinAge);*/

    //IF STATEMENTG{EXAMPLE}
    /*if (20 > 18)
    {
      Console.WriteLine("20 is greater than 18");
    }
    //{2}
    int x = 20;
    int y = 18;
    if (x > y)
    {
      Console.WriteLine("x is greater than y");
    }
    //{3}
    int age = 18;
    if (age >= 18)
    {
      Console.WriteLine("you are an adult");
    }
    //{4}
    int Score = 85;
    if (Score > 90)
    {
      Console.WriteLine("Excellent");
    }
    if (Score > 75)
    {
      Console.WriteLine("good job");
    }
    if (Score > 50)
    {
      Console.WriteLine("you passes");
   }*/

    // ELSE STATEMENT{1}
    /* int tempreature = 20;
     if (tempreature > 18)
     {
       Console.WriteLine("good day");
     }
     else
     {
       Console.WriteLine("bad day");
     }
     //{2}
     int score = 75;
     if (score >= 90)
     {
       Console.WriteLine("grade A");
     }
     else
     {
       Console.WriteLine("grade B");
     }*/
    //IF ELSE IS STATEMENT {1}
    /*int score = 75;
    if (score >= 90)
    {
      Console.WriteLine("grade A");
    }
    else if (score >= 80)
    {
      Console.WriteLine("grade B");
    }
    else if (score >= 70)
    {
      Console.WriteLine("grade C");
    }
    else
    {
      Console.WriteLine("fail");
    }*/

    //Example - to check if a number is positive or negative
    /* int x = Convert.ToInt32(Console.ReadLine());
     if (x > 0)
     {
       Console.WriteLine("it is a positive number");
     }
     else if (x < 0)
     {
       Console.WriteLine("it is negative number");
     }
     else
     {
       Console.WriteLine("zero");
     }*/
    // program even or odd
    /* int x = Convert.ToInt32(Console.ReadLine());
     if (x % 2 == 0)
     {
       Console.WriteLine("it is a even number");
     }
     else 
     {
       Console.WriteLine("it is odd number");
     }*/

    //eligible to vote
    /* int age = Convert.ToInt32(Console.ReadLine());
     if (age > 18)
     {
       Console.WriteLine("it is eligible for vote");
     }
     else
     {
       Console.WriteLine("it is not eligible for vote ");
     }*/
    //largest two numbers
    /* Console.Write("print the first num1");
     int num1 = Convert.ToInt32(Console.ReadLine());
     Console.Write("print the second num2");
     int num2 = Convert.ToInt32(Console.ReadLine());
     if (num1 > num2)
     {
       Console.WriteLine( " largest num1 = " +num1);
     }
     else if (num2 > num1)
     {
       Console.WriteLine(" largest num2 = " +num2);
     }
     else
     {
       Console.WriteLine(num1 = num2);
     }*/
    //check character value ia a vowel or constant
    /*Console.Write("print the alphabet value");
    char ch = Convert.ToChar(Console.ReadLine().ToLower());
    if (char.IsLetter(ch))
    {
      if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
      {
        Console.WriteLine("it is a vowel alphabet");
      }
      else
      {
        Console.WriteLine("it is a constant value");
      }
    }*/

    // program  find the grade of a student 
    /* Console.Write("print the number");
     int x = Convert.ToInt32(Console.ReadLine());

     if (x >= 90)
     {
       Console.WriteLine("Grade A");
     }
     if (x >= 90)
     {
       Console.WriteLine("Grade B");
     }
     else if (x >= 80)
     {
       Console.WriteLine("Grade C");
     }
     else if (x >= 70)
     {
       Console.WriteLine("Grade C");
     }
     else if (x >= 60)
     {
       Console.WriteLine("Grade D");
     }
     else
     {
       Console.WriteLine("Fail");
      }*/

    //print three largest number
    /* Console.Write("Enter the first number");
     int a = Convert.ToInt32(Console.ReadLine());

     Console.Write("Enter the second number");
     int b = Convert.ToInt32(Console.ReadLine());

     Console.Write("Enter the third number");
     int c = Convert.ToInt32(Console.ReadLine());

     if (a > b && a > c)
     {
       Console.WriteLine(" Largest A");
     }
     else if (b > c && b > a)
     {
       Console.WriteLine("Largest B");
     }
     else
     {
       Console.WriteLine("Largest C");
     }*/

    //temprature condition in celsius
    /* Console.Write("Enter tempreature in celsius");
     int temp = Convert.ToInt32(Console.ReadLine());

     string description;
     if (temp >= 0 && temp <= 20)
     {
       description = "Freezing";
     }
     else if (temp >= 21 && temp <= 40)
     {
       description = "Cold";
     }
     else if (temp >= 41 && temp <= 60)
     {
       description = "Warm";
     }
     else
     {
       description = "hot";
     }
     Console.WriteLine("Temperature description:" + description);*/

    //Leap Year
    /*Console.Write("Enter the number of n");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x % 4 == 0)
    {
      Console.WriteLine("it is a leap year");
    }
    else
    {
      Console.WriteLine("It is not a leap year");
    }*/
    //day of the week
    /* Console.Write("enter the number of n");
     int x = Convert.ToInt32(Console.ReadLine());

     string description;
     if (x == 1)
     {
       description = "Sunday";
     }
     else if (x == 2)
     {
       description = "Monday";
     }
     else if (x == 3)
     {
       description = "Tuesday";
     }
     else if (x == 4)
     {
       description = "Wednesday";
     }
     else if (x == 5)
     {
       description = "Thrusday";
     }
     else if (x == 6)
     {
       description = "Friday";
     }
     else
     {
       description = "Saturday";
     }
     Console.WriteLine("The day of week is " + description);*/

    // electricity bills usage in base usage slab
    /* Console.Write("Enter the electricity usage in units(KWh)");
     int units = Convert.ToInt32(Console.ReadLine());

     double billAmount = 0;
     if (units <= 100)
     {
       billAmount = units * 1.5;
     }
     else if (units <= 200)
     {
       billAmount = (100 * 1.5) + (units - 200) * 2.5;
     }
     else if (units <= 300)
     {
       billAmount = (100 * 1.5) + (100 * 2.5) + (units - 300) * 4.0;
     }
     else if (units <= 400)
     {
       billAmount = (100 * 1.5) + (100 * 2.5) + (100 * 4.0) + (units - 400) * 6.0;
     }
     Console.WriteLine("Electricity bill for {0} units is ₹ {1} " + units, billAmount);*/

    //assign salary grade based on salary amount
    /*Console.Write("Enter the salary amount");
    double salary = Convert.ToDouble(Console.ReadLine());

    string grade;
    if (salary >= 100000)
    {
      grade = "A (Excellent)";
    }
    else if (salary >= 75000)
    {
      grade = "B (Very Good)";
    }
    else if (salary >= 50000)
    {
      grade = "C (Good)";
    }
    else if (salary >= 30000)
    {
      grade = "D (Average)";
    }
    else
    {
      grade = "Below Average";
    }
    Console.WriteLine($"salary: {salary}, grade: {grade}");*/

    //print season based on the month number
    /*Console.Write("Enter the month number(1-12)");
    int month = Convert.ToInt32(Console.ReadLine());

    string season;
    if (month == 12 || month == 1 || month == 2)
    {
      season = "winter month";
    }
    else if (month >= 3 && month <= 5)
    {
      season = "spring month";
    }
    else if (month >= 6 && month <= 8)
    {
      season = "summer month";
    }
    else if (month >= 9 && month <= 11)
    {
      season = "autumn month";
    }
    else
    {
      season = "Invalid month";
    }
    Console.WriteLine($"Season:{season}");*/

    //check range number
    /* Console.Write("Enter the value of num");
     int num = Convert.ToInt32(Console.ReadLine());

     if (num < 0)
     {
       Console.WriteLine("Negative");
     }
     else if (num == 0)
     {
       Console.WriteLine("Zero");
     }
     else if (num >= 1 && num <= 10)
     {
       Console.WriteLine("Between numbers 1 to 10");
     }
     else if (num >= 11 && num <= 100)
     {
       Console.WriteLine("Between numbers 11 to 100");
     }
     else if (num >= 100)
     {
       Console.WriteLine("More than 100");
     }
     else
     {
       Console.WriteLine("Invalid numbers");
     }*/

    //calculate simple income tax for different slabs
    /* Console.Write("Enter the value of income");
     double income = Convert.ToDouble(Console.ReadLine());

     double tax = 0;
     if (income <= 2500000)
     {
       tax = 0;
     }
     else if (income <= 5000000)
     {
       tax = (income - 2500000) * 0.05;
     }
     else if (income <= 1000000)
     {
       tax = (2500000 * 0.05) + (income - 5000000) * 0.20;
     }
     else
     {
       tax = (2500000 * 0.05) + (5000000 * 0.20) + (income - 1000000) * 0.30;
     }
     Console.WriteLine($"your income tax is ₹{tax}");*/

    //identify the quadrant of a point in the cartesion plane
    /* Console.Write("Enter the value of x");
     int x = Convert.ToInt32(Console.ReadLine());

     Console.Write("Enter the value of y");
     int y = Convert.ToInt32(Console.ReadLine());

     if (x > 0 && y > 0)
     {
       Console.WriteLine("it is a 1st quadrant");
     }
     else if (x < 0 && y > 0)
     {
       Console.WriteLine("it is a 2nd quadrant");
     }
     else if (x < 0 && y < 0)
     {
       Console.WriteLine("it is a 3rd quadrant");
     }
     else if (x > 0 && y < 0)
     {
       Console.WriteLine("its is a 4th quadrant");
     }
     else if (x == 0 && y == 0)
     {
       Console.WriteLine("it is origin");
     }
     else if (x == 0)
     {
       Console.WriteLine("lies on the x-axis");
     }
     else if (y == 0)
     {
       Console.WriteLine("lies on the y-axis");
     }
     else
     {
       Console.WriteLine("Invalid point");
     }*/

    // check a triangle based on side length

    /* Console.Write("Enter sidec 1");
     int a = Convert.ToInt32(Console.ReadLine());

     Console.Write("Enter side 2");
     int b = Convert.ToInt32(Console.ReadLine());

     Console.Write("Enter side 3");
     int c = Convert.ToInt32(Console.ReadLine());

     if (a + b > c && a + c > b && b + c > a)
     {
       if (a == b && b == c && c == a)
       {
         Console.WriteLine("it is equilateral triangle");
       }
       else if (a == b || b == c || a == c)
       {
         Console.WriteLine("it is a isosceles triangle");
       }
       else
       {
         Console.WriteLine("it is a scalene triangle");
       }
     }*/

    //time mangement system in a day
    /*Console.Write("Enter the hour");
    int hour = Convert.ToInt32(Console.ReadLine());

    if (hour >= 5 && hour < 12) {
      Console.WriteLine("Good Morning");
    }
    else if (hour >= 12 && hour < 17) {
      Console.WriteLine("Good Afternoon");
    }
    else if (hour >= 17 && hour < 21) {
      Console.WriteLine("Good Evening");
    }
    else {
      Console.WriteLine("Good Night");
    }*/

    //SWITCH STATEMENT {EXAMPLE} - use the case , break, default 
    /* Console.Write("Enter the day");
     int day = Convert.ToInt32(Console.ReadLine());

     switch (day)
     {
       case 1: Console.WriteLine("Monday"); break;
       case 2: Console.WriteLine("Tuesday"); break;
       case 3: Console.WriteLine("Wednesday"); break;
       case 4: Console.WriteLine("Thrusday"); break;
       case 5: Console.WriteLine("Friday"); break;
       case 6: Console.WriteLine("Saturday"); break;
       case 7: Console.WriteLine("Sunday"); break;
       default: Console.WriteLine("Invalid Day"); break;

     }*/

    //WHILE LOOP -{EXAMPLE}
    //simple example
    /* int i = 0;
     while (i < 5)
     {
       Console.WriteLine("i is: " + i);
       i++;
     }*/
    //while loop with break
    /* int i = 0;
     while (true)
     {
       Console.WriteLine("i is: " + i);
       if (i == 5)
         break;
       i++;
     }*/
    // user input until valid with while loop
    /* string input = " ";
     while (input != "yes")
     {
       Console.WriteLine("Type 'yes' to continue");
       input = Console.ReadLine();
     }
     Console.WriteLine("Thanks");*/

    //DO-WHILE LOOP -{EXAMPLE}
    /* int count = 1;
     do
     {
       Console.WriteLine("count is: " + count);
       count++;
     }
     while (count <= 5);*/
    //user input validation do while
    /* string input;
     do
     {
       Console.Write("Enter 'yes' to continue");
       input = Console.ReadLine();
     }
     while (input != "yes");*/
    //do while with break
    /*int num = 1;
    do
    {
      Console.WriteLine(num);
      if (num == 0)
      {
        break;
      }
      num++;
    }
    while (num <= 5);*/

    //FOR LOOP - {EXAMPLE}
    //simple example
    /*for (int i = 1; i <= 5; i++)
    {
      Console.WriteLine(i);
    }*/
    //reverse loop
    /* for (int i = 7; i >= 6; i--)
     {
       Console.WriteLine(i);
     }*/
    // loop with custom step
    /*  for (int i = 1; i <= 10; i += 2)
      {
        Console.WriteLine(i);
      }*/
    //nested loops
    /* for (int row = 1; row <= 3; row++)
     {
       for (int col = 1; col <= 3; col++)
       {
         Console.Write($"({row}, {col})");
       }
       Console.WriteLine();
     }*/
    //FOR EACH LOOP -{EXAMPLE}
    //looping through an array
    /*string[] fruits = { "Apple", "Banana", "Cherry" };
    foreach (string fruit in fruits)
    {
      Console.WriteLine(fruit);
    } */
    //looping through a list
    /* List<int> numbers = new List<int> { 10, 20, 30 };
     foreach (int num in numbers)
     {
       Console.WriteLine(num * 2);
     }*/

    //BREAK STATEMENT IN LOOPS
    //for loop
    /*for (int i = 0; i < 10; i++)
    {
      if (i == 5)
      {
        break;
      }
      Console.WriteLine(i);
    }*/
    //while loop
    /* int counter = 0;
     while (true)
     {
       Console.WriteLine("counter: " + counter);
       counter++;
       if (counter == 5)
       {
         Console.WriteLine("Breaking the loop");
         break;
       }
     }*/
    //do-while loop
    /* int i = 0;
     do
     {
       Console.WriteLine("Iteration: " + i);
       i++;
       if (i > 5)
       {
         Console.WriteLine("breaking the loop");
         break;
       }
     }
     while (i < 10);
     Console.WriteLine("Loop finished");*/
    //list do while
    /*  List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };
      string target = "Charlie";
      bool found = false;
      do
      {
        foreach (string name in names)
        {
          Console.WriteLine("Checkin: " + name);
          if (name == target)
          {
            Console.WriteLine("found: " + name);
            found = true;
            break;
          }
        }
      }
      while (false);
      if (!found)
      {
        Console.WriteLine("target: " );
      }*/

    //ARRAY- ONE DIMENSIONAL ARRAY
    //simple\
    /*Console.Write("Enter the value of i");
    int i = Convert.ToInt32(Console.ReadLine());
    int[] ages = new int[3];
    ages[0] = 25;
    ages[1] = 30;
    ages[2] = 35;
    Console.WriteLine(ages [i] );*/
    //for loop
    /* string[] colors = { "Red", "Green", "Blue" };
     for (int i = 0; i < colors.Length; i++)
     {
       Console.WriteLine(i);
     }
    //Foreach loop
    foreach (string color in colors)
    {
      Console.WriteLine(color);
    }*/
    //changing array elements
    /*  int[] numbers = { 10, 20, 30, 40 };
      numbers[2] = 99;
      Console.WriteLine(numbers[2]);*/
    //array length -1
    /* int[] numbers = { 5, 10, 15, 20, 25 };
     Console.WriteLine(numbers.Length);*/
    //2
    /*  string[] fruits = { "Apple", "Banana", "Cherry" };
      double[] prices = { 1.99, 2.49, 3.75, 4.10 };
      Console.WriteLine("Numbers of fruits " +fruits.Length );
      Console.WriteLine("Numbers of prices " + prices.Length);*/
    //using a short array - 3
    /*  short[] scores = new short[5];
      scores[0] = 120;
      scores[1] = -300;
      scores[2] = 32676;
      scores[3] = -32768;
      scores[4] = 0;
      foreach (short score in scores)
      {
        Console.WriteLine(score);
      }*/

    //MULTIDIMENSIONAL ARRAY- 2D AARAY
    //simple
    /*  int[,] matrix = new int[3, 2];
      matrix[0, 0] = 1;
      matrix[0, 1] = 2;
      matrix[1, 0] = 3;
      matrix[1, 1] = 4;
      matrix[2, 0] = 5;
      matrix[2, 1] = 6;
      Console.WriteLine(matrix[1, 1]);*/
    //example 3D aaray
    /* int[,,] cube = new int[2, 2, 2];

     cube[0, 0, 0] = 10;
     cube[1, 1, 1] = 20;
     Console.WriteLine(cube[1, 1, 1]);*/
    //acess element-2D
    /*int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
    for (int i = 0; i <numbers.Length ; i++)
{
    Console.WriteLine(i); 
}*/
    //change
    int[,] matrix = {
  {1,2,3},
  {4,5,6},
  {7,8,9},
};
    matrix[1, 2] = 99;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write(matrix[i, j] + "\t");
      }
      Console.WriteLine();
    }
  }
}
    
