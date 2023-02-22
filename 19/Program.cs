//Напишите программу, которая принимает на вход пятизначное число и проверяет,является оно палиндромом.
Console.WriteLine("Введите пятизначное число : ");
int number = int.Parse(Console.ReadLine());
if(number>=10000 &&  number <=99999)
{
      if((number% 10 == number/10000) && (number/1000)%10==(number%100)/10)
      {
      Console.WriteLine($"{number}-> число является палиндромом");
      }
      else 
      {
      Console.WriteLine($"{number}-> число не является палиндромом");
      };
}     
else  Console.WriteLine("Не является пятизначным числом ");


 



