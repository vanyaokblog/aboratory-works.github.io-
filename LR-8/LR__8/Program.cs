using System;
using System.Collections.Generic;


namespace LR__8
{

    public class Student { 
        
       public List<string> names = new List<string>();
       public List<string> surnames = new List<string>();
       public List<string> patronymics = new List<string>();
       public List<int> ages = new List<int>();
       public List<string> depts = new List<string>();
       public List<string> job_titles = new List<string>();

        public void addName(string name) {
            names.Add(name);
        }

        public void addSurname(string surname)
        {
            surnames.Add(surname);
        }

        public void addPatronymic(string patronymic)
        {
            patronymics.Add(patronymic);
        }

        public void addAge(int age)
        {
            ages.Add(age);
        }

        public void addDept(string dept)
        {
            depts.Add(dept);
        }

        public void addJob_Title(string job_title)
        {
            job_titles.Add(job_title);
        }

    }

    public class Dept {
        public List<string> names_dept = new List<string>() { "Веб-разработка", "Разработка ПО", "Разработка игр", "Разработка операционных систем" };
        public List<string> names_manager = new List<string>();
        public List<int> value_workers = new List<int>() { };
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            Student student = new Student();
            Dept dept_item = new Dept();

            string cmd, name, surname, patronymic, dept, job_title;
            int num = 0, age, num_for_depts = 0, ask_num, num2 = 0, count_workers = 0, value_workers_web = 0, value_workers_po = 0, value_workers_games = 0, value_workers_os = 0;

            List<string> depts_name = new List<string>() {"Веб-разработка", "Разработка ПО", "Разработка игр", "Разработка операционных систем" };
            List<string> job_titles_name = new List<string>() { "Junior", "Middle", "Senior", "TeamLead"};

            while (true) {

                write_cmd();

                void write_cmd() {

                    System.Console.WriteLine("Введите команду: ");
                    cmd = Console.ReadLine();

                    if (cmd.ToLower() == "добавить сотрудника")
                    {
                        count_workers += 1;
                        num = count_workers;
                        num2 += 1;
                        

                        System.Console.WriteLine("Введите имя сотрудника: ");
                        name = System.Console.ReadLine();
                        System.Console.WriteLine();
                        student.addName(name);

                        System.Console.WriteLine("Введите фамилию сотрудника: ");
                        surname = System.Console.ReadLine();
                        System.Console.WriteLine();
                        student.addSurname(surname);

                        System.Console.WriteLine("Введите отчество сотрудника: ");
                        patronymic = System.Console.ReadLine();
                        System.Console.WriteLine();
                        student.addPatronymic(patronymic);

                        System.Console.WriteLine("Введите возраст сотрудника: ");
                        age = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine();
                        student.addAge(age);

                        System.Console.WriteLine("Введите отдел разработки сотрудника: ");
                        dept = System.Console.ReadLine();

                        num_for_depts = 0;
                        foreach (string names in depts_name) {
                            


                            if (names.ToLower() == dept.ToLower())
                            {
                                num_for_depts -= 1;
                                
                                System.Console.WriteLine();
                                student.addDept(names);
                                break;

                            }
                            else {
                                num_for_depts += 1;
                                if (num_for_depts == 4) {
                                    System.Console.WriteLine("Такого отдела разработки не существует. Его можно дописать при вводе команды 'Изменить сотрудника' ");
                                }
       
                            }
                            
  
                        }

                        System.Console.WriteLine();

                        System.Console.WriteLine("Введите должность сотрудника: ");
                        job_title = System.Console.ReadLine();
                        num_for_depts = 0;
                        foreach (string names in job_titles_name)
                        {
                            if (names.ToLower() == job_title.ToLower())
                            {
                                num_for_depts -= 1;
                                System.Console.WriteLine();
                                student.addJob_Title(names);
                                
                                break;
                            }
                            else {
                                num_for_depts += 1;
                                if (num_for_depts == 4)
                                {
                                    
                                    System.Console.WriteLine("Такой должности не существует. Ее можно дописать при вводе команды 'Изменить сотрудника' ");
                                }
                                
   
                            }

                        }

                        System.Console.WriteLine($"Сотрудник под номером {num} создан.");


                    }

                    if (cmd.ToLower() == "изменить сотрудника") {
                        num_for_depts = 0;
                        System.Console.WriteLine($"Сейчас создано {count_workers} сотрудника/сотрудников. Выберите номер сотрудника, которого хотите поменять: ");
                        ask_num = int.Parse(System.Console.ReadLine());

                        if (ask_num > count_workers)
                        {
                            System.Console.WriteLine("Сотрудника с таким номером не существует.");
                        }
                        else {
                            System.Console.WriteLine($"Введите имя для сотрудника под номером {ask_num}");
                            name = System.Console.ReadLine();
                            student.names[ask_num-1] = name;

                            System.Console.WriteLine($"Введите фамилию для сотрудника под номером {ask_num}");
                            surname = System.Console.ReadLine();
                            student.surnames[ask_num-1] = surname;

                            System.Console.WriteLine($"Введите отчество для сотрудника под номером {ask_num}");
                            patronymic = System.Console.ReadLine();
                            student.patronymics[ask_num-1] = patronymic;

                            System.Console.WriteLine($"Введите возраст для сотрудника под номером {ask_num}");
                            age = int.Parse(System.Console.ReadLine());
                            student.ages[ask_num-1] = age;

                            System.Console.WriteLine($"Введите отдел разработки для сотрудника под номером {ask_num}");

                            dept = System.Console.ReadLine();
                            num_for_depts = 0;
                            foreach (string names in depts_name) {
                            


                                if (names.ToLower() == dept.ToLower())
                                {
                                    num_for_depts -= 1;
                                    break;

                                }
                                else {
                                    num_for_depts += 1;
                                    if (num_for_depts == 4) {
                                        System.Console.WriteLine("Такого отдела разработки не существует. Его можно дописать при вводе команды 'Изменить сотрудника' ");
                                    }
       
                                }
                            
  
                            }
                            
                            student.depts[ask_num-1] = dept;



                            System.Console.WriteLine($"Введите должность для сотрудника под номером {ask_num}");

                            job_title = System.Console.ReadLine();
                            num_for_depts = 0;
                            foreach (string names in job_titles_name)
                            {



                                if (names.ToLower() == job_title.ToLower())
                                {
                                    num_for_depts -= 1;
                                    student.job_titles[ask_num - 1] = names;
                                    break;

                                }
                                else
                                {
                                    
                                    num_for_depts += 1;
                                    if (num_for_depts == 4)
                                    {
                                        System.Console.WriteLine("Такой должности не существует. Ее можно дописать при вводе команды 'Изменить сотрудника' ");
                                    }

                                }


                            }

                            
                        }

                    }



                    if (cmd.ToLower() == "поменять название отдела") {
                        num_for_depts = 0;
                        System.Console.WriteLine("Введите название отдела, который хотите заменить: ");
                        string ask_name_dept = System.Console.ReadLine();
                        System.Console.WriteLine();

                        System.Console.WriteLine("Введите название для нового отдела: ");
                        string new_dept = System.Console.ReadLine();
                        foreach (string names in depts_name)
                        {



                            if (names.ToLower() == ask_name_dept.ToLower())
                            {
                                if (num_for_depts == 0)
                                {
                                    depts_name[num_for_depts] = new_dept;
                                    student.depts[num_for_depts] = new_dept;
                                    dept_item.names_dept[num_for_depts] = new_dept;


                                }
                                else {
                                    depts_name[num_for_depts - 1] = new_dept;
                                    student.depts[num_for_depts-1] = new_dept;
                                    dept_item.names_dept[num_for_depts-1] = new_dept;
                                }
                                
                                
                                break;

                            }
                            else
                            {
                                num_for_depts += 1;
                                if (num_for_depts == 4)
                                {
                                    System.Console.WriteLine("Такого отдела разработки не существует. Его можно дописать при вводе команды 'Изменить сотрудника' ");
                                }

                            }


                        }
                    }





                        if (cmd.ToLower() == "информация о каждом сотруднике") {
                        num = count_workers;
                        num2 = count_workers;
                        int num3 = count_workers;
                        System.Console.WriteLine();
                        System.Console.WriteLine("====================================================================");
                        System.Console.WriteLine();
                        

                        for (int i = 0; i <= num3-1; i++)
                        {
                            System.Console.WriteLine($"Сотрудник номер {num}");
                            System.Console.WriteLine($"- Имя: {student.names[num2-1]}");
                            System.Console.WriteLine();
                            System.Console.WriteLine($"- Фамилия: {student.surnames[num2-1]}");
                            System.Console.WriteLine();
                            System.Console.WriteLine($"- Отчество: {student.patronymics[num2-1]}");
                            System.Console.WriteLine();
                            System.Console.WriteLine($"- Возраст: {student.ages[num2-1]}");
                            System.Console.WriteLine();
                            System.Console.WriteLine($"- Отдел разработки: {student.depts[num2 - 1]}");
                            System.Console.WriteLine();
                            System.Console.WriteLine($"- Должность: {student.job_titles[num2 - 1]}");
                            System.Console.WriteLine();

                            num2 -= 1;
                            num -= 1;
                        System.Console.WriteLine();
                        System.Console.WriteLine("====================================================================");
                        }
                    }

                }
                
            }
        }
    }
}
