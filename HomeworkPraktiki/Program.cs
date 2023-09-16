

//static void ShowText()
//{
//    Console.WriteLine("Hello world");
//}


//ShowText();



//static void Sum()
//{
//    Console.WriteLine(5+10);
//}


//Sum();



//static void Sum()
//{
//    int a = 5;
//    int b = 6;
//    int sum = a+ b;
//    Console.WriteLine(sum);
//}

//Sum();


//static void Sum(int num1)
//{
//    int sum = num1 + 100;

//    Console.WriteLine(sum );
//}


//int num = 100;

//Sum(num);




//static void SumOfNums (int a , int b)
//{

//    int sum = a + b;
//    Console.WriteLine(sum);


//}

//int salam1 = 50;
//int salam2 = 40;

//SumOfNums(salam1, salam2);


//static void Sum(int m)
//{

//    int sum = 0;

//    for (int i = 0; i < m; i++)
//    {
//        sum += i;               
//    }

//    Console.WriteLine(sum);
//}


//Sum(100);


////static void GetNumsOfArray(int[] numbers)
////{
////    foreach (var item in numbers)
////    {
////        Console.WriteLine(item);
////    }
////}

////int[] nums = { 1, 2, 3, 4, 5 };

////GetNumsOfArray(nums);
///


// static int GetNumber()
//{
//    int number = 200;
//    return number;

//}

//int result = GetNumber();

//if (result > 10)
//{
//    Console.WriteLine(result);
//}

//static string GetTemp( int temp)
//{
//    if (temp > 20)
//    {
//        return "Hot";
//    }
//    else
//    {
//        return "Cold";
//    }
//}


//string result = GetTemp(30);
//Console.WriteLine(result);


//static bool IsSuccess(string employeeName)
//{
//    string[] employees = { "Anna", "Jenna", "Inna" }; 

//    foreach (var employee in employees)
//    {
//        if (employee == employeeName)
//        {
//            return true;    
//        }
//    }
//    return false;

//}

//Console.WriteLine("Add employee name :");

//string name = Console.ReadLine();


//bool result = IsSuccess(name);

//if (result)
//{
//    Console.WriteLine("Ugurlu");
//}
//else
//{
//    Console.WriteLine("Ugursuz");
//}



//static int GetSumOddNumbers(int a , int b )
//{
//    int sum = 0;
//    for ( int i = a; i <= b; i++)
//    {
//        if (i % 2 != 0)
//        {


//            sum += i;
//        }
//    }

//    return sum;
//}

//int result = GetSumOddNumbers(5, 15);

//Console.WriteLine(result);


//static bool Login( string username, string password)
//{
//    if( username == "Semed111" && password == "Semed13")
//    {
//        return true;
//    }
//    return false;
//}


//Console.WriteLine("Add your username:");

//string username = Console.ReadLine();

//Console.WriteLine("Add your password:");

//string password = Console.ReadLine();   


//if (Login(username, password))
//{
//    Console.WriteLine("Login is success");
//}
//else
//{
//    Console.WriteLine("User name is wrong");
//}


//static bool Search(string studentName)
//{
//    string[] students = { "Eli", "Veli", "Merdan" };
//    foreach (string student in students)
//    {
//        if (student == studentName)
//        {
//            return true;
//        }
//    }
//    return false;
//}


//Console.WriteLine("Ad daxil edin:");

//string name  = Console.ReadLine();

//bool result = Search(name);

//if (result)
//{
//    Console.WriteLine("Name is found");
//}
//else
//{
//    Console.WriteLine("Name is not found");
//}



//static void Test()
//{
//    bool isTrue = true;
//    if (isTrue)
//    {
////        return;
////    }
////    Console.WriteLine("false");
////}

////Test();


//static void FindOddnums(int[] nums)
//{
//    foreach(var item in nums)
//    {
//        if (item % 2 == 0)
//        {
//            return;
//        }
//    }
//    Console.WriteLine("Hello P18");
//}

//FindOddnums(new int[] { 1, 2, 3, 4, 5, });
