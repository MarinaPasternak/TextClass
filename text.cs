using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ConsoleApp1
{
    class Program
    {


        static List<String> text = new List<String>();
        abstract class Text
        {
           

            public void AddString()
            {
                String a = new String();
                Console.WriteLine("Введіть строку, яку необхідно додати у текст");
                a.Content = Console.ReadLine();
                text.Add(a);
                a.id = text.Count;
            }

            public void DelString()
            {
                Console.WriteLine("Введіть номер строки, яку необхідно видалити у тексті");
                int index = int.Parse(Console.ReadLine())-1;
                text.RemoveAt(index);
                int i = 1;
                foreach (String obj in text)
                {
                    
                        obj.id = i;
                        i++;
                        
                    
                }

            }

            public void Display()
            {
                foreach ( String obj in text)
                {
                    Console.WriteLine("Номер строки "+ obj.id + " "+ obj.Content);
                }
                Console.WriteLine("Натисніть ентер");
                Console.ReadLine();


            }

            public void DellAll()
            {
                text.Clear();
            }

            public void MaxString()
            {
                string maxContent = "";
                int NumofMax = 0;
                int lenMax = 0;
                foreach (String obj in text)
                {
                    if (obj.Content.Length > lenMax)
                    {
                        maxContent = obj.Content;
                        lenMax = obj.Content.Length;
                        NumofMax = obj.id;
                    }
   
                }
            Console.WriteLine("Найдовша строка");
            Console.WriteLine("Номер строки " + NumofMax + " " + maxContent+" Довжина "+ lenMax);
            Console.WriteLine("Натисніть ентер");
            Console.ReadLine();
            }

            public int AllChar()
            {
                int count = 0;
                foreach (String obj in text)
                {
                    count +=obj.Content.Length;
                }
                return count;
            }

            public void PersentOfNumber()
            {
                int allSymbolCount = AllChar();
                
                double countNumber = 0;
                foreach (String obj in text)
                {
                    for(int i=0;i<obj.Content.Length;i++)
                    if (char.IsNumber(obj.Content[i]))
                    {
                            countNumber++;
                    }

                }
                double persent = countNumber / allSymbolCount * 100.0;
                Console.WriteLine("Кількість символів у тексті  " + allSymbolCount);
                Console.WriteLine("Кількість цифр у тексті  " + countNumber);
                Console.WriteLine("Кількість процентів цифр у тексті  "+Math.Round(persent,2)+'%');
                Console.WriteLine("Натисніть ентер");
                Console.ReadLine();
            }


        }
        class String:Text
        {
            public string Content
            {
                get;
                set;
            }
            public int id
            {
                get;
                set;
            }
            public int CountChar
            {
                get;
                set;
            }

        }


        public static int CheckNum(string s)
        {
            bool isNumber = false;
            int countNumber = 0;
            
            while (!isNumber)
            {
                
               for (int i = 0; i < s.Length; i++){ 
                    if (char.IsNumber(s[i]))
                    {
                        countNumber++;
                    }
               }
                    if (countNumber == s.Length)
                    {
                        isNumber = true;
                    }
                    else
                    {
                        isNumber = false;
                        Console.WriteLine("Такого пункту меню немає");
                        Console.WriteLine("Введіть номер пункту меню");
                        s = Console.ReadLine();
                    }
              
            }
            int num = int.Parse(s);
            return num;
        }
        static void Main(string[] args)
        {
            String str = new String();
            Console.WriteLine("1. Додати строку");
            Console.WriteLine("2. Видалити строку");
            Console.WriteLine("3. Видалити текст");
            Console.WriteLine("4. Найдовша строка");
            Console.WriteLine("5. Кількість символів у тексті");
            Console.WriteLine("6. Кількість процентів цифр у тексті");
            Console.WriteLine("7. Показати текст");
            Console.WriteLine("0. Вихід");
            Console.WriteLine("   ");
            Console.WriteLine("Введіть номер пункту меню");
            string point = Console.ReadLine();
            int pointOfMenu = CheckNum(point);
            do
            {
                switch (pointOfMenu)
                {
                    case 1:
                        str.AddString();
                        Console.WriteLine("Введіть номер пункту меню");
                        point = "";
                        point = Console.ReadLine();
                        pointOfMenu = CheckNum(point);
                        break;
                    case 2:
                        str.DelString();
                        point = "";
                        Console.WriteLine("Введіть номер пункту меню");
                        point = Console.ReadLine();
                        pointOfMenu = CheckNum(point);
                        break;
                    case 3:
                        str.DellAll();
                        point = "";
                        Console.WriteLine("Введіть номер пункту меню");
                        point = Console.ReadLine();
                        pointOfMenu = CheckNum(point);
                        break;
                    case 4:
                        str.MaxString();
                        point = "";
                        Console.WriteLine("Введіть номер пункту меню");
                        point = Console.ReadLine();
                        pointOfMenu = CheckNum(point);
                        break;
                    case 5:
                        int num = str.AllChar();
                        point = "";
                        Console.WriteLine(num);
                        Console.WriteLine("Введіть номер пункту меню");
                        point = Console.ReadLine();
                        pointOfMenu = CheckNum(point);
                        break;
                    case 6:
                        str.PersentOfNumber();
                        point = "";
                        Console.WriteLine("Введіть номер пункту меню");
                        point = Console.ReadLine();
                        pointOfMenu = CheckNum(point);
                        break;
                    case 7:
                        str.Display();
                        point = "";
                        Console.WriteLine("Введіть номер пункту меню");
                        point = Console.ReadLine();
                        pointOfMenu = CheckNum(point);
                        break;
                    default:
                        Console.WriteLine("Такого пункту меню немає");
                        Console.WriteLine("Введіть номер пункту меню");
                        point = Console.ReadLine();
                        pointOfMenu = CheckNum(point);
                        break;
                }
            }
            while (pointOfMenu != 0);
            {
                Console.ReadLine();
            }
            
            
            }
    }
}
