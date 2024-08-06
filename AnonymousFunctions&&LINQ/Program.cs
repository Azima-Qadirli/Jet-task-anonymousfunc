using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System;
using System.Security.Cryptography;
using System.Threading.Channels;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using AnonymousFunctions__LINQ;
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    public delegate int MathOperationHandler(int num1, int num2);
    static void Main(string[] args)
    {
        //MathOperationHandler handler = Sum;
        //var result = handler.Invoke(5, 10);
        //Console.WriteLine(result);

        //handler = Subtract;
        //Console.WriteLine(handler(5, 10));


        //var SumLambda = (int num1, int num2) =>
        //{
        //    return num1 + num2;

        //};//Lambda function

        //var SubtractLambda = (int num1, int num2) =>
        //{
        //    return num1 - num2;
        //};



        //Func<int, int, int> handler = SumLambda;
        //Console.WriteLine(handler.Invoke(2, 4));

        //Func<int,int,int>hand=(num1,num2)=>num1+num2;//Anonymous function
        //MathOperationHandler handler = (int num1, int num2) => num1 * num2;

        //HandleMathDelegate(handler, 2, 5);


        //Task1
        //int[] numbers = { 23, 4, 8, 11, 6, 57, 18, 9 };
        //List<int> greater = new();
        //foreach (var number in numbers)
        //{
        //    if (number > 10)
        //    {
        //        greater.Add(number);
        //    }
        //}

        //Query
        //var queryGreaterList = (from number in numbers
        //            where number>10
        //            select number).ToList();
        //foreach (var number in queryGreaterList)
        //{
        //    Console.WriteLine(number);
        //}

        //Console.WriteLine("-----");
        ////LINQ API
        //var LINQGreaterList = numbers.Where(number => number > 10).ToList();
        //foreach (var number in LINQGreaterList)
        //{
        //    Console.WriteLine(number);
        //}

        //Task2
        //List<int> list = new() { 23, 4, 8, 4, 23, 11, 6, 57,4,4 };
        //SortedDictionary<int,int>CountNumbers= new SortedDictionary<int,int>();
        //foreach (var number in list)
        //{
        //    if (CountNumbers.ContainsKey(number))
        //    {
        //        CountNumbers[number]++;
        //    }
        //    else
        //    {

        //        CountNumbers[number] = 1;
        //    }

        //}
        //foreach (KeyValuePair<int,int> number in CountNumbers)
        //{
        //    Console.WriteLine($"key:{number.Key}  Value:{number.Value}");
        //}


        //LINQ API
        //var dict = list.GroupBy(i => i).Select(number => new
        //{

        //    key = number.Key,
        //    value = number
        //});
        //foreach (var element in dict)
        //{
        //    Console.WriteLine($"Key:{element.key} Value:{element.value}");
        //}



        //var dict1 = list.GroupBy(element=>element).Select(element => new  { reqem=element.Key,say=element.Count() });

        //foreach (var element in dict1)
        //{
        //    Console.WriteLine($"Reqem;{element.reqem} Say: {element.say}");
        //}




        //IEnumerable,IQueryable--IQueryable sql-de olan sorgudur, IEnumerable ise sql-den gelib ram-da saxlanilan datadir.IQueryable ToList edende IEnumerable-ye cevrilir.


        //List<int> numbers = new() { 2, 4, 5, 1, 8, 96, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        //numbers.Where(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);

        //foreach(int num in evenNumbers)
        //{
        //    Console.WriteLine(num);
        //}



        //List<int> numbers = new() { 2, 4, 5, 6, 2, 6, 9, 7, 1, 9 };

        //var evenNumbers = numbers.Where(x=>x%2==0).ToList();

        //foreach(int number in evenNumbers)
        //{
        //    Console.WriteLine(number);
        //}

        //numbers.Where(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);

        //numbers.OrderBy(x=>x).ToList().ForEach(Console.WriteLine);

        //numbers.OrderByDescending(x=>x).ToList().ForEach(Console.WriteLine);


        //bool result=numbers.All(x=>x.Equals(4));
        //Console.WriteLine(result);

        //result=numbers.Any(x=>x.Equals(4));
        //Console.WriteLine(result);
        //numbers.Contains(4);

        //Console.WriteLine(numbers.Average());

        //Console.WriteLine(numbers.Where(x=>x==20).First());//serte uygun deyer tapmasa exception atir
        // Console.WriteLine(numbers.Where(x=>x==20).FirstOrDefault());//eger serte uygun tapmadisa,hemin deyerin default deyerini menimsedir.

        //Console.WriteLine(numbers.Where(x => x == 4).Single());//eger hemin serte uygun eded yoxdusa ve ya 1 deneden coxdusa exception atir.
        //Console.WriteLine(numbers.Where(x => x == 4).SingleOrDefault());//eger hemin serte uygun eded yoxdusa ddefault deyeri qaytarir, yox eger 1deneden coxdusa single kimi exception atir.

        // Console.WriteLine(numbers.Sum());

        //numbers.Skip(15).Take(10).ToList().ForEach(Console.WriteLine);


        //Projecting a list of a string to their lengths(Easy).

        //List<string> names = new() { "Azima", "Yusif", "Nijat" };

        //names.Select(name => new
        //{
        //    Name=name,
        //    Length=name.Length
        //}).ToList().ForEach(name =>
        //{
        //    Console.WriteLine($"Name;{name.Name} Length:{name.Length}");
        //});

        //Skipping elements while a condition is true and then taking the rest (Easy) 

        //List<int> number = new() { 1, 2, 4, 5, 8, 7, 6 };
        //numbers.SkipWhile(x=>x%2==0).ToList().ForEach(Console.WriteLine);

        //Console.WriteLine("-------");

        //List<int> number1 = new() { 1, 2, 4, 5, 8, 7, 6 };
        //numbers.TakeWhile(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);


        //       TASK 1)Basic LINQ Query

        //Task: Use LINQ to select all even numbers from a list of integers.

        List<int> numbers = new() { 1, 5, 4, 8, 9, 2, 3, 5 };

        //var EvenNumbers = numbers.Where(x => x % 2 == 0).ToList();
        //foreach (int num in EvenNumbers)
        //{
        //    Console.WriteLine(num);
        //}
        //Console.WriteLine("*****");
        //or
        //List<int> numbers1 = new() { 1, 5, 4, 8, 9, 2, 3, 5 };
        //numbers1.Where(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);


        //    TASK    2)Simple Projection

        //Task: Use LINQ to create a new list that contains the squares of all numbers in the original list.
        int[] numbers2 = { 1, 5, 4, 8, 9, 2, 3, 5 };
        //numbers2.Select(num => Math.Pow(num,2)).ToList().ForEach(Console.WriteLine);

        //or

        //List<double> SquareNumbers = new();
        //foreach(int num in numbers)
        //{
        //    SquareNumbers.Add(Math.Pow(num,2));
        //}
        //foreach(double num in SquareNumbers)
        //{
        //    Console.WriteLine(num);
        //}

        //    TASK    3)Filtering with Where Clause

        //Task: Use LINQ to select all strings from a list that start with the letter 'a'.

        List<string> Names =new() { "Azima", "Nijat", "Yusif", "Akif" };

        Names.Where(name => name.StartsWith("a", StringComparison.OrdinalIgnoreCase)).ToList().ForEach(Console.WriteLine);


        //    TASK    4)Ordering Results

        //Task: Use LINQ to sort a list of strings in alphabetical order.

        List<string> words = new() { "BackEnd", "FrontEnd", "DevOps", "AI" };
        words.OrderBy(word => word).ToList().ForEach(Console.WriteLine);



        //5)Task: Sort a list of integers in ascending order using LINQ.

        List<int> Number = new() { 1, 5, 2, 6, 48, 6, 2, 0 };

        Number.OrderBy(number=>number).ToList().ForEach(Console.WriteLine);


        //        6)Counting

        //Task: Count the number of even numbers in a list of integers using LINQ.

        List<int> number = new() { 1, 5, 4, 8, 9, 2, 3, 5 };

        Dictionary<int, int> EvenNumbers = new();

        int CountOfEvenNum = 0;
        foreach (var num in number)
        {
            if (num % 2 == 0)
            {
                CountOfEvenNum++;
            }
        }
        //Console.WriteLine($"Count of even numbers;{CountOfEvenNum}");

        //LINQ API
        List<int> number1 = new() { 1, 5, 4, 8, 9, 2, 3, 5 };

        Dictionary<int, int> EvenNumbers1 = new();

        int  EvenNumber = number1.Count(num=>num%2==0);
        //Console.WriteLine($"Count of even numbers;{EvenNumber}");


        //        7)Element Access

        //Task: Find the first string in a list of strings that starts with the letter 'b'.

        List<string> speciality = new() { "IT", "Teacher", "Banker", "Barista" };

        //speciality.Where(word=>word.StartsWith("b", StringComparison.OrdinalIgnoreCase)).ToList().ForEach(Console.WriteLine);


        Console.WriteLine("------");
        //        8)Checking for Existence

        //Task: Check if a list of integers contains any number greater than 20 using LINQ.

        //List<int> num1 = new() { 1, 5, 25, 0, 64, 2, 3, 41 };
        // num1.Where(num=>num>20).ToList().ForEach(Console.WriteLine);








        //TASK----Finding the maximum age in a list of people(Medium)
        //new Person(14);
        //new Person(15);
        //new Person(20);
        //new Person(30);

        // int MaximumAge = Person.GetPeople().Max(person => person.Age);

        //Console.WriteLine(MaximumAge);


        //TASK---Calculating the average age of people(Medium)
        //new Person(14);
        //new Person(15);
        //new Person(20);
        //new Person(30);

        //double AverageAge = Person.GetPeople().Average(person => person.Age);
        //Console.WriteLine(AverageAge);





        //TASK-Finding all people whose names start with a specific letter(Hard)

        new Person(20,"Nijat");
        new Person(20, "Azima");
        new Person(21, "Yusif");

        string letter = "N";

        var FindingPeople = Person.GetPeople().Where(person=>person.Name.StartsWith(letter, StringComparison.OrdinalIgnoreCase)).ToList();
        
        foreach (var person in FindingPeople)
        {
            Console.WriteLine(person.Name);
        }

    }

    //static void HandleMathDelegate(MathOperationHandler handler, int num1, int num2)
    //{
    //    var result = handler.Invoke(num1, num2);
    //    Console.WriteLine(result);
    //}


    //static int Sum(int num1, int num2)
    //{
    //    return num1 + num2;
    //}


    //static int Subtract( int num1,  int num2)
    //{
    //    return num1 - num2;
    //}
}


