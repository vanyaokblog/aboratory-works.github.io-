using System;

namespace LR_1
{

    class worker
    {
        public string name, surname, patronymic, job_title, dept;
        public int age;

        public worker(string name, string surname, string patronymic) {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }
        public void changeAge(int age)
        {
            this.age = age;
        }

        public void changeJobTitle(string job_title)
        {
            this.job_title = job_title;
        }

        public void changeDept(string dept)
        {
            this.dept = dept;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            string ask_job_title, ask_dept, cmd;
            int ask_age, number, x;
            string[] name_dept = new string[] { "Веб-разработка", "Разработка ПО", "Разработка игр", "Разработка операционных систем" };

            worker worker1 = new worker("Артем", "Чаплыгин", "Алексеевич");
            worker worker2 = new worker("Иван", "Сотников", "Сергеевич");
            worker worker3 = new worker("Александр", "Каретин", "Александрович");


            while (true) {
                System.Console.WriteLine("Введите команду: ");
                cmd = System.Console.ReadLine();

                if (cmd.ToLower() == "изменить возраст")
                {
                    System.Console.WriteLine("Введите номер сотрудника цифрой (1, 2, 3): ");
                    number = int.Parse(System.Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            System.Console.WriteLine("Введите возраст первого сотрудника: ");
                            ask_age = int.Parse(System.Console.ReadLine());
                            worker1.changeAge(ask_age);
                            System.Console.WriteLine($"Возраст первого сотрудника: {worker1.age}");
                            break;

                        case 2:
                            System.Console.WriteLine("Введите возраст второго сотрудника: ");
                            ask_age = int.Parse(System.Console.ReadLine());
                            worker2.changeAge(ask_age);
                            System.Console.WriteLine($"Возраст второго сотрудника: {worker2.age}");
                            break;

                        case 3:
                            System.Console.WriteLine("Введите возраст третьего сотрудника: ");
                            ask_age = int.Parse(System.Console.ReadLine());
                            worker3.changeAge(ask_age);
                            System.Console.WriteLine($"Возраст третьего сотрудника: {worker3.age}");
                            break;
                    }
                }

                else if (cmd.ToLower() == "изменить должность")
                {
                    System.Console.WriteLine("Введите номер сотрудника цифрой (1, 2, 3): ");
                    number = int.Parse(System.Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            System.Console.WriteLine("Введите должность первого сотрудника: ");
                            ask_job_title = System.Console.ReadLine();
                            worker1.changeJobTitle(ask_job_title);
                            System.Console.WriteLine($"Должность первого сотрудника - {worker1.job_title}");
                            break;

                        case 2:
                            System.Console.WriteLine("Введите должность второго сотрудника: ");
                            ask_job_title = System.Console.ReadLine();
                            worker2.changeJobTitle(ask_job_title);
                            System.Console.WriteLine($"Должность второго сотрудника - {worker2.job_title}");
                            break;

                        case 3:
                            System.Console.WriteLine("Введите должность третьего сотрудника: ");
                            ask_job_title = System.Console.ReadLine();
                            worker3.changeJobTitle(ask_job_title);
                            System.Console.WriteLine($"Должность третьего сотрудника - {worker3.job_title}");
                            break;
                    }
                }

                else if (cmd.ToLower() == "изменить отдел разработки")
                {
                    System.Console.WriteLine("Введите номер сотрудника цифрой (1, 2, 3): ");
                    number = int.Parse(System.Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            System.Console.WriteLine("Введите отдел разработки первого сотрудника: ");
                            ask_dept = System.Console.ReadLine();
                            foreach (string name in name_dept)
                            {
                                if (ask_dept.ToLower() == name.ToLower()) {
                                    worker1.changeDept(name);
                                    System.Console.WriteLine($"Отдел разработки первого сотрудника - {worker1.dept}");
                                }

                               
                            }

                            break;

                        case 2:
                            System.Console.WriteLine("Введите отдел разработки второго сотрудника: ");
                            ask_dept = System.Console.ReadLine();
                            foreach (string name in name_dept)
                            {
                                if (ask_dept.ToLower() == name.ToLower())
                                {
                                    worker2.changeDept(name);
                                    System.Console.WriteLine($"Отдел разработки второго сотрудника - {worker2.dept}");
                                }

                                
                            }

                            break;


                        case 3:
                            System.Console.WriteLine("Введите отдел разработки третьего сотрудника: ");
                            ask_dept = System.Console.ReadLine();
                            foreach (string name in name_dept)
                            {
                                if (ask_dept.ToLower() == name.ToLower())
                                {
                                    worker3.changeDept(name);
                                    System.Console.WriteLine($"Отдел разработки третьего сотрудника - {worker3.dept}");
                                }

                                
                            }

                            break;
                    }
                }
                else if (cmd.ToLower() == "информация о каждом сотруднике")
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("====================================================================");
                    System.Console.WriteLine();
                    System.Console.WriteLine("Первый сотрудник:");
                    System.Console.WriteLine($"- Имя: {worker1.name}, фамилия: {worker1.surname}, отчество: {worker1.patronymic}");
                    System.Console.WriteLine($"- Возраст: {worker1.age}");
                    System.Console.WriteLine($"- Отдел: {worker1.dept}");
                    System.Console.WriteLine($"- Должность: {worker1.job_title}");
                    System.Console.WriteLine();
                    System.Console.WriteLine("Второй сотрудник:");
                    System.Console.WriteLine($"- Имя: {worker2.name}, фамилия: {worker2.surname}, отчество: {worker2.patronymic}");
                    System.Console.WriteLine($"- Возраст: {worker2.age}");
                    System.Console.WriteLine($"- Отдел: {worker2.dept}");
                    System.Console.WriteLine($"- Должность: {worker2.job_title}");
                    System.Console.WriteLine();
                    System.Console.WriteLine("Третий сотрудник:");
                    System.Console.WriteLine($"- Имя: {worker3.name}, фамилия: {worker3.surname}, отчество: {worker3.patronymic}");
                    System.Console.WriteLine($"- Возраст: {worker3.age}");
                    System.Console.WriteLine($"- Отдел: {worker3.dept}");
                    System.Console.WriteLine($"- Должность: {worker3.job_title}");
                    System.Console.WriteLine();
                    System.Console.WriteLine("====================================================================");
                    System.Console.WriteLine();
                }
            }

        }
    }
}


