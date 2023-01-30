var numbers  = new List<int>(){1,2,3,4,5,6,7,8,9,10,10};

//task2
  // System.Console.WriteLine("Sum");
  // System.Console.WriteLine(numbers.Sum());

//Task3
//   System.Console.WriteLine("closestNumber");
//   int target = Convert.ToInt32(Console.ReadLine());
//   var closestNumber = numbers.OrderBy(x => Math.Abs(x - target)).First();
// Console.WriteLine(closestNumber);

// Task4
//   System.Console.WriteLine("3smallest");  
//   var result = (from num in numbers
//                 orderby num ascending
//                 select num).Take(3);
//   foreach (int number in result)
//     Console.Write(number + " ");
// Console.WriteLine();
//task5
//   System.Console.WriteLine("Average");
// var average = numbers.Average();
//   System.Console.WriteLine(average);
//
//

//  Task6
System.Console.WriteLine("largest3");

  var largest = (from num in numbers
                orderby num descending 
                select num).Distinct().Take(3);
var larg = (from nums in largest orderby nums select nums);
System.Console.WriteLine();
  foreach (int n in larg)
    Console.Write(n + " ");

// Task7
System.Console.WriteLine();

System.Console.WriteLine("Square");

  var square = numbers.Select(x=> x*x);
  foreach (var item in square)
  {
    System.Console.WriteLine(item);
  }

  // Task8
System.Console.WriteLine("Cube");

  var cube = numbers.Select(x=> x*x*x);
  foreach (var item in cube)
  {
    System.Console.WriteLine(item);
  }


//task9

int nun = 10,start =1,cnt=1;
var list = new List<int>();
while (cnt <= nun)
{
  list.Add(start);
  cnt++;
  start += 2;
}

Console.WriteLine(string.Join(',',list));

//task10

int num2 = 10,start2 =2,cnt2=1;
var list2 = new List<int>();
while (cnt <= num2)
{
  list.Add(start2);
  cnt2++;
  start2 += 2;
}

Console.WriteLine(string.Join(',',list2));



    // Task11

  var odd = numbers.Where(x => x % 2 == 0);
  foreach (var item in odd)
  {
    System.Console.WriteLine(item);
  }

  //    Task12
  int x;
  x = Convert.ToInt32(Console.ReadLine());
  int[] number2 = new int[x];
  for (int i = 0; i < x; i++)
  {
    number2[i] = Convert.ToInt32(Console.ReadLine());
  }

  var oddIndex = number2.Where(x => x % 2 != 0).OrderBy(x => Array.IndexOf(number2,x));
  foreach (var item in oddIndex)
  {
    System.Console.WriteLine(item);
  }

    // Task13

  var oddsquare = numbers.Where(x => x % 2 != 0).Select(x=> x*x);
  foreach (var item in oddsquare)
  {
    System.Console.WriteLine(item);
  }


      // Task14

  var evensquare = numbers.Where(x => x % 2 == 0).Select(x=> x*x);
  foreach (var item in evensquare)
  {
    System.Console.WriteLine(item);
  }

      // Task15

  var oddCube = numbers.Where(x => x % 2 != 0).Select(x=> x*x*x);
  foreach (var item in oddCube)
  {
    System.Console.WriteLine(item);
  }