using System;

namespace Lesson_C_
{
    class Program
    {
        static void Main(string[] args)
        {
           // int number1 = 135
           // int number2 = 452
           // int number3 = 250 

           //System.Console.WriteLine(number1 == number2); 
           //System.Console.WriteLine(number1 > number2); 
           //System.Console.WriteLine(number3 <= number2);
           //System.Console.WriteLine(number2 > number1);
            /*
                Console.WriteLine("Sonlarni solishtirish uchun kiriting!");
                
                System.Console.Write("1-son: ");
                
                string dfg = Console.ReadLine();
                
                int a = Convert.ToInt32(dfg);
                
                System.Console.Write("2-son: ");
                
                string fgh = Console.ReadLine();
                
                int b = Convert.ToInt32(fgh);
                
                System.Console.Write("3-son: ");
                
                string jkl = Console.ReadLine();
                
                int c = Convert.ToInt32(jkl);
                
                if (a >= b && a >= c)
                {
                    System.Console.WriteLine($"Eng katta birinchi son\n \"{a}\"");
                }
                else if(b >= c && b >= a)
                {
                    System.Console.WriteLine($"Eng katta son\n \"{b}\"");
                }
                else
                {
                    System.Console.WriteLine($"Eng katta son\n \"{c}\"");
                }*/
                    
            int a; 
            int b; 
            char option; 
            
            Console.WriteLine("Salom! Ushbu dastur orqali siz istalgan sonlarni bir-biriga solishtirishingiz\nyoki qoshib va ayirish kabi amallarni bajarishingiz mumkin."); 
            Console.WriteLine("Dasturga birinchi navbatda birinchi istalgan sonni kiritasiz\nva ikkinchi istalgan sonni kiritasiz.\nAna undan keyin qanday amalni bajarishi uchun '<', '>', '/', '*', '-', '+', '%' kabi amallardan birini kiritasiz.");
            Console.Write("Birinchi istalgan sonni kiriting:  ");
            a = Convert.ToInt32(Console.ReadLine());  
            Console.Write("Ikkinchi istalgan sonni kiriting:  ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("'<', '>', '*', '/', '*', '+', '-', '%' ushbu amallardan birini kiriting:  ");
            option = Console.ReadKey().KeyChar;   
            switch (option)
            {
                case '<':
                    Console.WriteLine($" Natija: {a < b}");
                    break;
                case '>':
                    Console.WriteLine($" Natija:  {a > b} "); 
                    break;
                case '/':
                    Console.WriteLine($" Natija: {a / b} ");
                    break;
                case '*':
                    Console.WriteLine($" Natija: {a * b} "); 
                    break;
                case '+':
                    Console.WriteLine($" Natija: {a + b} ");
                    break;
                case '-':
                    Console.WriteLine($" Natija: {a - b}");
                    break;
                case '%':
                    Console.WriteLine($" Natija: {a % b}");
                    break; 
                default:
                    Console.WriteLine("Iltimos faqatqina '<', '>', '*', '/', '*', '+', '-' amallardan birini kiriting");              
                    break;   




            }
            

        }
    }
}
