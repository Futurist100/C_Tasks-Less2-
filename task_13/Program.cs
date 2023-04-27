// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



int number;

Console.WriteLine("Введите число ");

number = Convert.ToInt32(Console.ReadLine());

int digit = number%10;

int control = number/100;

int control1 = number/1000;

if (control == 0)
   
   { 
     Console.WriteLine("Третьей цифры нет ");
   }
else
    
    {
      if (control1 != 0)
      
      {
        Console.WriteLine($"Третья цифра равна {control%10}");
      }
      
      else
       
       {
        Console.WriteLine($"Третья цифра равна {number%10}");
       }
      }
      