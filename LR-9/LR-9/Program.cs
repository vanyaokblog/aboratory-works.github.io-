using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Xml.Linq;


namespace LR_9
{
    class Student
    {
        public LinkedList<string> name_list = new LinkedList<string>();
        public LinkedList<string> surname_list = new LinkedList<string>();
        public LinkedList<string> patronymic_list = new LinkedList<string>();
        public LinkedList<int> age_list = new LinkedList<int>();
        public LinkedList<int> course_list = new LinkedList<int>();
        public LinkedList<string> date_list = new LinkedList<string>();
        public void AddStud(string name, string surname, string patronymic, string date, int age, int course)
        {
            if (name_list.Count == 0)
            {
                name_list.AddFirst(name);
                
            }
            else
            {
                name_list.AddLast(name);
                
            }
            if (surname_list.Count == 0)
            {
                surname_list.AddFirst(surname);
            }
            else
            {
                surname_list.AddLast(surname);
            }
            if (patronymic_list.Count == 0)
            {
                patronymic_list.AddFirst(patronymic);
            }
            else
            {
                patronymic_list.AddLast(patronymic);
            }
            if (age_list.Count == 0)
            {
                age_list.AddFirst(age);
            }
            else
            {
                age_list.AddLast(age);
            }
            if (course_list.Count == 0)
            {
                course_list.AddFirst(course);
            }
            else
            {
                course_list.AddLast(course);
            }
            if (date_list.Count == 0)
            {
                date_list.AddFirst(date);
            }
            else
            {
                date_list.AddLast(date);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string cmd, name, surname, patronymic, date;
            int age, course, value_students = 0, num, num_for = 0;
            int num2 = 0, count = 0; 
            Student student = new Student();
            while (true)
            {
                start();
                 void start() {                    
                    System.Console.WriteLine("Выберите команду (цифрой):\n1 - Добавить студента\n2 - Удалить студента\n3 - Проверка списка на пустоту\n4 - Поиск студента по фамилии, имени и отчеству\n5 - Поиск студента по возрасту\n6 - Очистка списка \n7 - Вывод всех студентов ");
                    System.Console.WriteLine();
                    cmd = System.Console.ReadLine();

                    switch (cmd)
                    {
                        case "1":
                            Console.WriteLine("Введите имя студента: ");
                            name = Console.ReadLine();
                                                                    
                            Console.WriteLine();

                            Console.WriteLine("Введите фамилию студента: ");
                            surname = Console.ReadLine();
                           
                            Console.WriteLine();

                            Console.WriteLine("Введите отчество студента: ");
                            patronymic = Console.ReadLine();
                            
                            Console.WriteLine();

                            Console.WriteLine("Введите возраст студента: ");
                            age = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine();

                            Console.WriteLine("Введите курс студента: ");
                            course = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine();

                            Console.WriteLine("Введите дату рождения (формат xx.xx.xxxx): ");
                            date = Console.ReadLine();

                            student.AddStud(name, surname, patronymic, date, age, course);
                            value_students++;

                            Console.WriteLine();

                            System.Console.WriteLine($"Студент номер {value_students} создан.");
                            System.Console.WriteLine();
                            break;

                        case "2":
                            System.Console.WriteLine($"Сейчас создано {value_students} студентов/студента");
                            System.Console.WriteLine("Выберите номер студента цифрой: ");
                            System.Console.WriteLine();
                            num = int.Parse(System.Console.ReadLine());
                            
                            if (num > value_students)
                            {
                                System.Console.WriteLine("Такого студента не существует.");
                                System.Console.WriteLine();

                            }
                            else {
                                num_for = 0;
                                foreach(string name in student.name_list)
                                {
                                    num_for++;
                                    if (num_for == num) {
                                        student.name_list.Remove(name);
                                        break;
                                    }
                                }
                                num_for = 0;
                                foreach (string surname in student.surname_list)
                                {
                                    num_for++;
                                    if (num_for == num)
                                    {
                                        student.surname_list.Remove(surname);
                                        break;
                                    }
                                }
                                num_for = 0;
                                foreach (string patronymic in student.patronymic_list)
                                {
                                    num_for++;
                                    if (num_for == num)
                                    {
                                        student.patronymic_list.Remove(patronymic);
                                        break;
                                    }
                                }
                                num_for = 0;
                                foreach (int age in student.age_list)
                                {
                                    num_for++;
                                    if (num_for == num)
                                    {
                                        student.age_list.Remove(age);
                                        break;
                                    }
                                }
                                num_for = 0;
                                foreach (int course in student.course_list)
                                {
                                    num_for++;
                                    if (num_for == num)
                                    {
                                        student.course_list.Remove(course);
                                        break;
                                    }
                                }
                                num_for = 0;
                                foreach (string date in student.date_list)
                                {
                                    num_for++;
                                    if (num_for == num)
                                    {
                                        student.date_list.Remove(date);
                                        break;
                                    }
                                }
                            }
                            value_students--;
                            System.Console.WriteLine($"Студент под номером {num} удален.");
                            System.Console.WriteLine();
                            System.Console.WriteLine($"После удаления осталось {value_students} студентов/студента");
                            System.Console.WriteLine();

                            System.Console.WriteLine(student.name_list.Count);
                            break;

                        case "7":
                            if (student.name_list.Count > 0)
                            {
                                int num3 = value_students, num5 = 1;
                                for (int i = 0; i < num3; i++)
                                {
                                    System.Console.WriteLine("========================================");//40
                                    System.Console.WriteLine($"Студент номер {num5}");
                                    foreach (string name in student.name_list)
                                    {

                                        if (num2 < value_students + 1 && num2 == i)
                                        {
                                            System.Console.WriteLine($"- Имя: {name}");

                                        }

                                        num2++;
                                    }
                                    num2 = 0;

                                    foreach (string surname in student.surname_list)
                                    {

                                        if (num2 < value_students + 1 && num2 == i)
                                        {
                                            System.Console.WriteLine($"- Фамилия: {surname}");

                                        }

                                        num2++;
                                    }
                                    num2 = 0;

                                    foreach (string patronymic in student.patronymic_list)
                                    {

                                        if (num2 < value_students + 1 && num2 == i)
                                        {
                                            System.Console.WriteLine($"- Отчество: {patronymic}");

                                        }

                                        num2++;
                                    }
                                    num2 = 0;

                                    foreach (int age in student.age_list)
                                    {

                                        if (num2 < value_students + 1 && num2 == i)
                                        {
                                            System.Console.WriteLine($"- Возраст: {age}");

                                        }

                                        num2++;
                                    }
                                    num2 = 0;

                                    foreach (int course in student.course_list)
                                    {

                                        if (num2 < value_students + 1 && num2 == i)
                                        {
                                            System.Console.WriteLine($"- Курс: {course}");

                                        }

                                        num2++;
                                    }
                                    num2 = 0;

                                    foreach (string date in student.date_list)
                                    {

                                        if (num2 < value_students + 1 && num2 == i)
                                        {
                                            System.Console.WriteLine($"- Дата рождения: {date}");

                                        }

                                        num2++;
                                    }
                                    num2 = 0;
                                    num5++;
                                }
                                System.Console.WriteLine("========================================");
                            }
                            else
                            {
                                value_students = 0;
                                System.Console.WriteLine($"Всего создано сотрудников: {value_students}");
                                System.Console.WriteLine();
                                if (value_students == 0)
                                {
                                    System.Console.WriteLine("Вывести сотрудников невозможно, недостаточное количество.");
                                    System.Console.WriteLine();
                                }
                            }
                            
                            break;

                        case "3":
                            System.Console.WriteLine();
                            System.Console.WriteLine("Проверка списков на пустоту...");
                            Thread.Sleep(1000);
                            if (student.name_list.Count > 0)
                            {
                                System.Console.WriteLine("- Список с именами не пустой");
                            }
                            else {
                                System.Console.WriteLine("- Список с именами пустой");
                            }
                            Thread.Sleep(200);
                            if (student.surname_list.Count > 0)
                            {
                                System.Console.WriteLine("- Список с фамилиями не пустой");
                            }
                            else
                            {
                                System.Console.WriteLine("- Список с фамилиями пустой");
                            }
                            Thread.Sleep(200);
                            if (student.patronymic_list.Count > 0)
                            {
                                System.Console.WriteLine("- Список с отчествами не пустой");
                            }
                            else
                            {
                                System.Console.WriteLine("- Список с отчествами пустой");
                            }
                            Thread.Sleep(200);
                            if (student.course_list.Count > 0)
                            {
                                System.Console.WriteLine("- Список с номерами курсов не пустой");
                            }
                            else
                            {
                                System.Console.WriteLine("- Список с номерами курсов пустой");
                            }
                            Thread.Sleep(200);
                            if (student.age_list.Count > 0)
                            {
                                System.Console.WriteLine("- Список с возрастами не пустой");
                            }
                            else
                            {
                                System.Console.WriteLine("- Список с возрастами пустой");
                            }
                            Thread.Sleep(200);
                            if (student.date_list.Count > 0)
                            {
                                System.Console.WriteLine("- Список с датами рождения не пустой");
                            }
                            else
                            {
                                System.Console.WriteLine("- Список с датами рождения пустой");
                            }
                            Thread.Sleep(200);
                            System.Console.WriteLine();
                            break;

                        case "4":
                            System.Console.WriteLine("Введите имя для поиска: ");
                            name = System.Console.ReadLine();
                            System.Console.WriteLine("Введите фамилию для поиска: ");
                            surname = System.Console.ReadLine();
                            System.Console.WriteLine("Введите отчество для поиска: ");
                            patronymic = System.Console.ReadLine();
                            System.Console.WriteLine("Начинается поиск студента...");
                            Thread.Sleep(1000);
                            int num6 = 1, num7 = 1, num8 = 1;
                            bool f1 = false, f2 = false, f3 = false;

                            foreach (string name2 in student.name_list) {
                                
                                if (name2 == name) {
                                    f1 = true;
                                    break;
                                }
                                num6++;

                            }
                            foreach (string surname2 in student.surname_list)
                            {
                                
                                if (surname2 == surname)
                                {
                                    f2 = true;
                                    break;
                                }
                                num7++;

                            }
                            foreach (string patronymic2 in student.patronymic_list)
                            {
                                
                                if (patronymic2 == patronymic)
                                {
                                    f3 = true;
                                    break;
                                }
                                num8++;
                            }
                            if (num6 == num7 & num6 == num8 & num7 == num8 & f1 == true & f2 == true & f3 == true)
                            {
                                System.Console.WriteLine($"Студент с таким именем, фамилией и отчеством под номером {num6}");
                            }
                            else {
                                System.Console.WriteLine("Студент с таким именем, фамилией и отчеством не найден");
                            }

                            num6 = 1; num7 = 1; num8 = 1;
                            break;

                        case "5":

                            System.Console.WriteLine("Введите возраст для поиска: ");
                            age = int.Parse(System.Console.ReadLine());
                            System.Console.WriteLine();
                            count = 0;

                            foreach (int age2 in student.age_list)
                            {
                                count++;
                                if (age == age2)
                                {
                                    System.Console.WriteLine($"Студент с таким возрастом под номером {count}");
                                    System.Console.WriteLine();
                                    Thread.Sleep(200);
                                }
                            }
                            break;

                        case "6":
                            System.Console.WriteLine("Начинается очистка списка с именами, фамилиями, отчествами, возрастами, курсами и датами рождения...");
                            Thread.Sleep(1000);
                            student.name_list.Clear();
                            System.Console.WriteLine("Список с именами очищен");
                            Thread.Sleep(200);
                            student.surname_list.Clear();
                            System.Console.WriteLine("Список с фамилиями очищен");
                            Thread.Sleep(200);
                            student.patronymic_list.Clear();
                            System.Console.WriteLine("Список с отчествами очищен");
                            Thread.Sleep(200);
                            student.course_list.Clear();
                            System.Console.WriteLine("Список с курсами очищен");
                            Thread.Sleep(200);
                            student.age_list.Clear();
                            System.Console.WriteLine("Список с возрастами очищен");
                            Thread.Sleep(200);
                            student.date_list.Clear();
                            System.Console.WriteLine("Список с датами рождения очищен");
                            Thread.Sleep(200);
                            break;
                    }
                }
            }
        }
    }
}
