using System;
using System.Collections.Generic;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application!");
            for (; ; )
            {
                Console.WriteLine("With whom you want to work? Students(1) or Aspirants(2)? To exit input 3");
                int selection1 = Input.Select1Input();
                if (selection1 == 1)
                {
                    Console.WriteLine("vi mojete vvodit info o studentax s pomowyu specialnix klucey po kotorim v posleduyuwem smojete nayti informaciyu o nujnom studente");
                    Dictionary<char, Student> stu = new Dictionary<char, Student>();
                    Console.WriteLine("informaciyu o skolkix studentax vi xotite vvesti?");
                    int stunums = Input.AmountsInput();
                    for (int i = 0; i < stunums; i++)
                    {
                        Console.WriteLine("vvedite klucevoye znacenie!");
                        char a = Convert.ToChar(Console.ReadLine());
                        stu.Add(a, new Student() { Surname = Input.SurnameInput(), Course = Input.CourseInput(), StudentsRecordBook = Input.RecordsInput() });
                    }
                    foreach (KeyValuePair<char, Student> keyVal in stu)
                    {
                        Console.WriteLine("kluc: " + keyVal.Key + " - " + "Surname: " + keyVal.Value.Surname + " - " + "Course: " + keyVal.Value.Course + " - " + "Records book: " + keyVal.Value.StudentsRecordBook);
                    }

                    Console.WriteLine("If you want to udalit studenta iz spiska po klucu input 1, but if you want to exit input 2.");
                    int selection2 = Input.Select2Input();
                    if (selection2 == 1)
                    {
                        for (; ; )
                        {
                            foreach (KeyValuePair<char, Student> keyVal in stu)
                            {
                                Console.WriteLine("kluc: " + keyVal.Key + " - " + "Surname: " + keyVal.Value.Surname + " - " + "Course: " + keyVal.Value.Course + " - " + "Records book: " + keyVal.Value.StudentsRecordBook);
                            }
                            Console.WriteLine("koqo vi xotite udalit? vvedite kluc!");
                            char b = Convert.ToChar(Console.ReadLine());
                            stu.Remove(b);
                            foreach (KeyValuePair<char, Student> keyVal in stu)
                            {
                                Console.WriteLine("kluc: " + keyVal.Key + " - " + "Surname: " + keyVal.Value.Surname + " - " + "Course: " + keyVal.Value.Course + " - " + "Records book: " + keyVal.Value.StudentsRecordBook);
                            }
                            Console.WriteLine("esli xotite udalit ewe koqoto najmite 1, esli xotite viyti najmite 2.");
                            selection2 = Input.Select2Input();
                            if (selection2 == 1)
                                continue;
                            else
                                break;
                        }
                        break;
                    }
                    else
                        continue;
                }
                else if (selection1 == 2)
                {

                    Console.WriteLine("vi mojete vvodit info o studentax s pomowyu specialnix klucey po kotorim v posleduyuwem smojete nayti informaciyu o nujnom studente");
                    Dictionary<char, Aspirant> asp = new Dictionary<char, Aspirant>();
                    Console.WriteLine("informaciyu o skolkix studentax vi xotite vvesti?");
                    int aspnums = Input.AmountsInput();
                    for (int i = 0; i < aspnums; i++)
                    {
                        Console.WriteLine("vvedite klucevoye znacenie!");
                        char a = Convert.ToChar(Console.ReadLine());
                        asp.Add(a, new Aspirant() { Surname = Input.SurnameInput(), Course = Input.CourseInput(), StudentsRecordBook = Input.RecordsInput(), Topic = Input.TopicInput() });
                    }
                    foreach (KeyValuePair<char, Aspirant> keyVal in asp)
                    {
                        Console.WriteLine("kluc: " + keyVal.Key + " - " + "Surname: " + keyVal.Value.Surname + " - " + "Course: " + keyVal.Value.Course + " - " + "Records book: " + keyVal.Value.StudentsRecordBook + " - " + "Topic: " + keyVal.Value.Topic);
                    }

                    Console.WriteLine("If you want to udalit aspiranta iz spiska po klucu input 1, but if you want to exit input 2.");
                    int selection2 = Input.Select2Input();
                    if (selection2 == 1)
                    {
                        for (; ; )
                        {
                            foreach (KeyValuePair<char, Aspirant> keyVal in asp)
                            {
                                Console.WriteLine("kluc: " + keyVal.Key + " - " + "Surname: " + keyVal.Value.Surname + " - " + "Course: " + keyVal.Value.Course + " - " + "Records book: " + keyVal.Value.StudentsRecordBook + " - " + "Topic: " + keyVal.Value.Topic);
                            }
                            Console.WriteLine("koqo vi xotite udalit? vvedite kluc!");
                            char b = Convert.ToChar(Console.ReadLine());
                            asp.Remove(b);
                            foreach (KeyValuePair<char, Aspirant> keyVal in asp)
                            {
                                Console.WriteLine("kluc: " + keyVal.Key + " - " + "Surname: " + keyVal.Value.Surname + " - " + "Course: " + keyVal.Value.Course + " - " + "Records book: " + keyVal.Value.StudentsRecordBook + " - " + "Topic: " + keyVal.Value.Topic);
                            }
                            Console.WriteLine("esli xotite udalit ewe koqoto najmite 1, esli xotite viyti najmite 2.");
                            selection2 = Input.Select2Input();
                            if (selection2 == 1)
                                continue;
                            else
                                break;
                        }
                        break;
                    }
                    else
                        continue;
                }
                else
                    break;
            }

        }
    }
    abstract class People
    {
        public string Surname { get; set; }
        public int Course { get; set; }
        public int StudentsRecordBook { get; set; }
        public People() { }
    }
    class Student : People
    {
        public Student() { }
    }
    class Aspirant : People
    {
        public Aspirant() { }
        public string Topic { get; set; }
    }
    class Input //Класс Input с различными методами для ввода информации.
    {
        public static string SurnameInput()
        {
            Console.Write("Surname: ");
            string word = Console.ReadLine();
            return word;
        }
        public static string TopicInput()
        {
            Console.Write("Topic: ");
            string word = Console.ReadLine();
            return word;
        }
        public static int CourseInput()
        {
            Console.Write("Course: ");
            int nums = 0;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if (nums > 0 && nums < 5)
                    return nums;
                else
                {
                    Console.WriteLine("Введите число от 1 до 4");
                    return CourseInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return CourseInput();
            }
        }
        public static int AmountsInput()
        {
            Console.Write("Input amounts: ");
            int nums = 0;

            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if (nums > 0)
                    return nums;
                else
                {
                    Console.WriteLine("Введите положительное число!");
                    return AmountsInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return AmountsInput();
            }
        }
        public static int RecordsInput()
        {
            Console.Write("Records book: ");
            int nums = 0;

            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if (nums > 0)
                    return nums;
                else
                {
                    Console.WriteLine("Введите положительное число!");
                    return RecordsInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return RecordsInput();
            }
        }
        public static int Select1Input()
        {
            int nums = 0;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if (nums > 0 && nums < 4)
                    return nums;
                else
                {
                    Console.WriteLine("Введите число от 1 до 3");
                    return CourseInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return CourseInput();
            }
        }
        public static int Select2Input()
        {
            int nums = 0;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if (nums > 0 && nums < 3)
                    return nums;
                else
                {
                    Console.WriteLine("Введите число от 1 до 3");
                    return CourseInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return CourseInput();
            }
        }
    }
}
