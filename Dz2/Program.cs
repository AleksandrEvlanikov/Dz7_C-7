
int[,] array = new int[3,4] {
   {1, 2, 3, 4},
   {2, 3, 4, 5},
   {3, 4, 5, 7}
};
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " \t");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
 int target = Convert.ToInt32(Console.ReadLine());
 int target1 = Convert.ToInt32(Console.ReadLine());
 
      if (target > 3 && target1 > 4 )
       Console.WriteLine("такого числа нет");
       else
       {
         object c = array.GetValue( target, target1);
         Console.WriteLine(c + "");
       }
       
   
   


 







// int [,] number = new int [3,4] 
// {
//    {1, 4, 7, 2},
//    {5, 9, 2, 3},
//    {8, 4, 2, 4}
// };
// bool isFound = false;
// Console.WriteLine("Введите 2 индекса");
// int target = Convert.ToInt32(Console.ReadLine());
// int target1 = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < number.GetLength(0) && isFound == false; i++)
//  {
//  for (int j = 0; j < number.GetLength(1); j++)
//  {
//    Console.Write(number[i,j]);
//    Console.WriteLine();
//    if (number[i,j] == target)
//    if (number[i,j] == target1)
//    {
//       isFound = true;
//       break;
//    }
//  Console.WriteLine(number[i,j]);
//  }
//  }
 








//     Console.Write(number[i,j] + " ");
//     Console.WriteLine();
 
//  } 
// bool isFound = false;
//   int target = Convert.ToInt32(Console.ReadLine());
//   int target1 = Convert.ToInt32(Console.ReadLine());

//   for (int i = 0; i < number.GetLength(0) && isFound == false; i++)
//   {
//    for(int j = 0; j < number.GetLength(1) && isFound == false; j++)
//    {
      
//       if(number[i,j] == false )
//       {
//       isFound = true;
//       break;
//       }
      
//       else
//       {
//          Console.WriteLine(number[target,target1]);
         
//       }
//    } 
//   }
  
 

//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());

//  if(a > number[3,4] && b > number[3,4])

//  Console.WriteLine("такого числа нет");
//  else
//  {
   
//    Console.WriteLine(a + " " + b);
//  }


 