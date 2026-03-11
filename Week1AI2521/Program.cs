// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("John green");

//string name = "Musharraf";
//int age = 25;
//bool isSkyBlue = true;
//double valueOfPi = 3.14;

//Console.WriteLine(name);

//Console.WriteLine("What is your name?");
//string username = Console.ReadLine(); // "John"
//Console.WriteLine($"Your name is {username}");

//Console.WriteLine("What is your age? ");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"You are {age} years old");
//int i = 0;
//while (i < 5)
//{
//    Console.WriteLine($"Value of i is {i}");
//    i++;
//}

//for(int j = 0; j < 5; j++)
//{
//    Console.WriteLine($"Value of j is {j}");
//}

//int userinput = -1;
//int sum = 0;

//while( userinput != 0)
//{
//    Console.WriteLine("Enter number : ");
//    userinput = Convert.ToInt32(Console.ReadLine());
//    if(userinput < 0)
//    {
//        continue;
//    }
//    else
//    {
//        sum+=userinput;
//    }
//}

//Console.WriteLine($"Sum is {sum}");


//int[] array1 = new int[5];

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Enter a number :");
//    array1[i] = Convert.ToInt32(Console.ReadLine());
//}

//foreach(int i in array1)
//{
//    Console.WriteLine(i);
//}

//int[] marks = new int[5];

//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Enter marks for student {i + 1}");
//    marks[i] = Convert.ToInt32(Console.ReadLine());
//}

//int highest = marks[0];
//double sum = 0;
//foreach(int mark in marks)
//{
//    sum+= mark;
//    if(mark > highest)
//    {
//        highest = mark;
//    }
//}

//Console.WriteLine($"Highest mark : {highest}");
//Console.WriteLine($"Average : {sum / marks.Length}");


//List<int> numbers = new List<int>([1,2,3,5]);

//numbers.Add(6);
//numbers.Insert(3, 4);
//numbers.Remove(6);
//numbers.RemoveAt(1);

//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}



using Week1AI2521;




//Author a1 = new Author("John Green",50, "American");

//Console.WriteLine($"Author name : {a1.name}");
//Console.WriteLine($"Author age : {a1.age}");
//Console.WriteLine($"Author nationality : {a1.nationality}");

//Book b1 = new Book("The Fault in Our Stars", 123456, a1);


//Console.WriteLine(b1.bookAuthor.name);

Customer c1 = new Customer("Musharraf", 25, false);
Customer c2 = new Customer("Ali", 20, true);
Customer c3 = new Customer("Sara", 17, false);

BankAccount b1 = new BankAccount("123456789", 1000, c1);
BankAccount b2 = new BankAccount("987654321", 1500, c2);
BankAccount b3 = new BankAccount("456789123", 700, c3);

b3.Withdraw(800);