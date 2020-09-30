using System;
using System.Collections;

namespace Test_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //at first we are creating lists of aspirants and students and obyavlyayem classes.
            ArrayList stulist = new ArrayList();
            ArrayList asplist = new ArrayList();
            Student stu = new Student();
            Aspirant asp = new Aspirant();
            Console.WriteLine("Welcome to my application!");
            for (; ; )
            {
                Console.WriteLine("With whom you want to work? Students(1) or Aspirants(2)? To exit input 3");//little menu
                int selection1 = Input.Select1Input();
                if (selection1 == 1)  //work with students
                {
                    Console.WriteLine("Do you want to update list(1) or add new students(2)?");
                    int selection2 = Input.Select1Input();
                    if (selection2 == 1)//clear list
                    {
                        stulist.Clear();
                        Console.WriteLine("About how many students do you want to enter information?");
                        int amount = Input.AmountsInput();
                        for (int i = 0; i < amount; i++)
                        {
                            stu.Surname = Input.SurnameInput();
                            stu.Course = Input.CourseInput();
                            stu.StudentsRecordBook = Input.RecordsInput();
                            string surname = stu.Surname;
                            int course = stu.Course;
                            int srb = stu.StudentsRecordBook;
                            stulist.AddRange(new string[] { $"Surname: {surname}, Course: {course}, Records book: {srb}" });
                        }
                        Console.WriteLine("If you want to take information about all students input 1. If you want to continue work input 2. if you want to exit input 3.");
                        selection1 = Input.Select1Input();
                        if (selection1 == 1)
                        {
                            foreach (object st in stulist)
                            {
                                Console.WriteLine(st);
                            }
                            Console.WriteLine("Do you want to continue(1) or exit(2)?");
                            selection2 = Input.Select2Input();
                            if (selection2 == 1)
                                continue;
                            else
                                break;
                        }
                        else if (selection1 == 2)
                            continue;
                        else
                            break;
                    }
                    else//continue work with the existing list
                    {
                        Console.WriteLine("About how many students do you want to enter information?");
                        int amount = Input.AmountsInput();
                        for (int i = 0; i < amount; i++)
                        {
                            stu.Surname = Input.SurnameInput();
                            stu.Course = Input.CourseInput();
                            stu.StudentsRecordBook = Input.RecordsInput();
                            string surname = stu.Surname;
                            int course = stu.Course;
                            int srb = stu.StudentsRecordBook;
                            stulist.AddRange(new string[] { $"Surname: {surname}, Course: {course}, Records book: {srb}" });
                        }
                        Console.WriteLine("If you want to take information about all students input 1. If you want to continue work input 2. if you want to exit input 3.");
                        selection1 = Input.Select1Input();
                        if (selection1 == 1)
                        {
                            foreach (object st in stulist)
                            {
                                Console.WriteLine(st);
                            }
                            Console.WriteLine("Do you want to continue(1) or exit(2)?");
                            selection2 = Input.Select2Input();
                            if (selection2 == 1)
                                continue;
                            else
                                break;
                        }
                        else if (selection2 == 2)
                            continue;
                        else
                            break;
                    }
                }
                if (selection1 == 2)  //work with aspirants
                {
                    Console.WriteLine("Do you want to update list(1) or add new students(2)?");
                    int selection2 = Input.Select1Input();
                    if (selection2 == 1)  //clear list
                    {
                        asplist.Clear();
                        Console.WriteLine("About how many aspirants do you want to enter information");
                        int amount = Input.AmountsInput();
                        for (int i = 0; i < amount; i++)
                        {
                            asp.Surname = Input.SurnameInput();
                            asp.Course = Input.CourseInput();
                            asp.StudentsRecordBook = Input.RecordsInput();
                            asp.Topic = Input.TopicInput();
                            string surname = asp.Surname;
                            int course = asp.Course;
                            int srb = asp.StudentsRecordBook;
                            string top = asp.Topic;
                            asplist.AddRange(new string[] { $"Surname: {surname}, Course: {course}, Records book: {srb}, Topic: {top}" });
                        }
                        Console.WriteLine("If you want to take information about all aspirants input 1. If you want to continue work input 2. if you want to exit input 3.");
                        selection1 = Input.Select1Input();
                        if (selection1 == 1)
                        {
                            foreach (object aspi in asplist)
                            {
                                Console.WriteLine(aspi);
                            }
                            Console.WriteLine("Do you want to continue(1) or exit(2)?");
                            selection2 = Input.Select2Input();
                            if (selection2 == 1)
                                continue;
                            else
                                break;
                        }
                        else if (selection1 == 2)
                            continue;
                        else
                            break;
                    }
                    else  //continue work with the existing list
                    {
                        Console.WriteLine("About how many aspirants do you want to enter information");
                        int amount = Input.AmountsInput();
                        for (int i = 0; i < amount; i++)
                        {
                            asp.Surname = Input.SurnameInput();
                            asp.Course = Input.CourseInput();
                            asp.StudentsRecordBook = Input.RecordsInput();
                            asp.Topic = Input.TopicInput();
                            string surname = asp.Surname;
                            int course = asp.Course;
                            int srb = asp.StudentsRecordBook;
                            string top = asp.Topic;
                            asplist.AddRange(new string[] { $"Surname: {surname}, Course: {course}, Records book: {srb}, Topic: {top}" });
                        }
                        Console.WriteLine("If you want to take information about all aspirants input 1. If you want to continue work input 2. if you want to exit input 3.");
                        selection1 = Input.Select1Input();
                        if (selection1 == 1)
                        {
                            foreach (object aspi in asplist)
                            {
                                Console.WriteLine(aspi);
                            }
                            Console.WriteLine("Do you want to continue(1) or exit(2)?");
                            selection2 = Input.Select2Input();
                            if (selection2 == 1)
                                continue;
                            else
                                break;
                        }
                        else if (selection1 == 2)
                            continue;
                        else
                            break;
                    }
                }
                else
                    break;
            }
        }
    }
    abstract class People //абстрактный класс People от которого происходять классы Student и Aspirant.
    {
        public string Surname { get; set; }
        public int Course { get; set; }
        public int StudentsRecordBook { get; set; }
        public People() { }
    }
    class Student : People //класс Student который образован от абстрактного класса People.
    {
        public Student() { }
    }
    class Aspirant : People //класс Aspirant который образован от абстрактного класса People.
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