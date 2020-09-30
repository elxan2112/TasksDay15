using System;
using System.Collections.Generic;


namespace Test8
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
                    Console.WriteLine("We have a student with surname Aliyev!");//students
                    LinkedList<Student> stu = new LinkedList<Student>();
                    LinkedListNode<Student> ali = stu.AddLast(new Student() { Surname = "Aliyev", Course = 2, StudentsRecordBook = 1324 });
                    Console.WriteLine("Input info about first student.");
                    Console.WriteLine("Input Surname, Course and Student record book");
                    stu.AddFirst(new Student() { Surname = Input.SurnameInput(), Course = Input.CourseInput(), StudentsRecordBook = Input.NumsInput() });
                    Console.WriteLine("Input info about last student");
                    stu.AddLast(new Student() { Surname = Input.SurnameInput(), Course = Input.CourseInput(), StudentsRecordBook = Input.NumsInput() });
                    Console.WriteLine("If you want to take info about all students input 1, but if you want to exit input 2.");
                    int selection2 = Input.Select2Input();
                    if (selection2 == 1)
                    {
                        foreach (Student p in stu)
                        {
                            Console.Write("Surname: ");
                            Console.Write($"{p.Surname};  ");
                            Console.Write("Course: ");
                            Console.Write($"{p.Course};  ");
                            Console.Write("Student record book: ");
                            Console.WriteLine($"{p.StudentsRecordBook};  ");
                        }
                        Console.WriteLine("If you want to know surname student who come after Aliyev input 1,\nif you want to know surname student who come before Aliyev input 2,\nbut if you want to exit input 3.");
                        selection2 = Input.Select1Input();
                        if (selection2 == 1)
                        {
                            Console.WriteLine(ali.Next.Value.Surname);
                        }
                        if (selection2 == 2)
                        {
                            Console.WriteLine(ali.Previous.Value.Surname);
                        }
                        else
                            continue;
                    }
                    else
                        continue;
                }
                else if (selection1 == 2)
                {
                    Console.WriteLine("We have aspirant with surname Akhmedov");
                    LinkedList<Aspirant> asp = new LinkedList<Aspirant>();
                    LinkedListNode<Aspirant> axi = asp.AddLast(new Aspirant() { Surname = "Akhmedov", Course = 3, StudentsRecordBook = 4321, Topic = "Measuring" });
                    Console.WriteLine("Input info about first aspirant.");
                    Console.WriteLine("Input Surname, Course, Student record book and Topic");
                    asp.AddFirst(new Aspirant() { Surname = Input.SurnameInput(), Course = Input.CourseInput(), StudentsRecordBook = Input.NumsInput(), Topic = Input.TopicInput() });
                    Console.WriteLine("Input info about last aspirant");
                    asp.AddLast(new Aspirant() { Surname = Input.SurnameInput(), Course = Input.CourseInput(), StudentsRecordBook = Input.NumsInput(), Topic = Input.TopicInput() });
                    Console.WriteLine("If you want to take info about all aspirants input 1, but if you want to exit input 2.");
                    int selection2 = Input.Select2Input();
                    if (selection2 == 1)
                    {
                        foreach (Aspirant p in asp)
                        {
                            Console.Write("Surname: ");
                            Console.Write($"{p.Surname};  ");
                            Console.Write("Course: ");
                            Console.Write($"{p.Course};  ");
                            Console.Write("Student record book: ");
                            Console.Write($"{p.StudentsRecordBook};  ");
                            Console.Write("Topic: ");
                            Console.WriteLine($"{p.Topic}");
                        }
                        Console.WriteLine("If you want to know surname aspirant who come after Akhmedov input 1,\nif you want to know surname aspirant who come before Akhmedov input 2,\nbut if you want to exit input 3.");
                        selection2 = Input.Select1Input();
                        if (selection2 == 1)
                        {
                            Console.WriteLine(axi.Next.Value.Surname);
                        }
                        if (selection2 == 2)
                        {
                            Console.WriteLine(axi.Previous.Value.Surname);
                        }
                        else
                            continue;
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
    class Input
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
        public static int NumsInput()
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
                    return NumsInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return NumsInput();
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
