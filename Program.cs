using ConsoleApp5;

internal class Program
{
    private static void Main(string[] args)
    {
        List<User>lst = new List<User>() { 
        new User{id=1,UserName="yousef",password="123"},
        new User{id=2,UserName="joe",password ="12"},
        
        };
        Console.WriteLine("Enter UserName Please: ");
        var user_name = Console.ReadLine();
        Console.WriteLine("Enter Password Please: ");
        var password = Console.ReadLine();
        bool flag = false;
        foreach (var item in lst)
        {
            if(item.UserName == user_name && item.password == password)
            {
                flag = true; break;
            }

        }
        if (flag)
        {
            Console.WriteLine($"Your UserName Is  : {user_name}");
            List<Employee>emps = new List<Employee>() { 
            new Employee{id=1,name="joeee",age=21,hiredate=DateTime.Now,salary=1000,isActive=false }
            };
            int choice;
            re_ask: {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("Note: Choose the number of the operation please for example (1,2,3)!!");
                Console.WriteLine("\n1) Print all employees");
                Console.WriteLine("2) Add new employee");
                Console.WriteLine("3) Exit\n");
                Console.WriteLine("-----------------------------\n");
                choice = int.Parse(Console.ReadLine());
            }
            if(choice == 3)
            {
                Console.WriteLine("Good Bye...");
                Environment.Exit(1);
            }
            if (choice == 1)
            {
                Console.WriteLine("id\tname\tage\thire_date\tsalary\tstatus");
                foreach (var item in emps)
                {
                    Console.WriteLine($"{item.id}\t{item.name}\t{item.age}\t{item.hiredate.ToShortDateString()}\t{item.salary}\t{(item.isActive==true?"Active":"Not-Active")}");
                }
                goto re_ask;
            }
            else
            {
                Console.Write("How many new employees do you want to add? :");
                 var num = int.Parse(Console.ReadLine());
                for (int i = 0; i < num; i++)
                {
                   
                    Console.WriteLine("id :");
                    var id = int.Parse(Console.ReadLine());
                    Console.WriteLine("name :");

                    var nam = Console.ReadLine();
                    Console.WriteLine("age :");
                    var age = int.Parse(Console.ReadLine());
                    var hd = DateTime.Now;
                    Console.WriteLine("salary :");
                    var salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Status : true or false");
                    var status = Console.ReadLine();
                    emps.Add(new Employee { id = id, name = nam, age = age, hiredate = hd, salary = salary,isActive=(status=="true"?true:false) });
                }
                goto re_ask;
            }
        }
        else
        {
            Console.WriteLine("UserName Or Password Is Worng !!!");
        }

    }
}