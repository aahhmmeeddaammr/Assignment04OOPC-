using Assignment4OOPC_.IClonable;
using Assignment4OOPC_.Interface;
using Assignment4OOPC_.Interface03;
using Assignment4OOPC_.Question1;
using Assignment4OOPC_.Question2;
using Assignment4OOPC_.Question3;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment4OOPC_
{
    internal class Program
    {
        public static void DisplayShapeInfo(IShape shape)
        {
            shape.DisplayShapeInfo();
        }

        public static void SendMessage(INotificationService NotificationService, string TO, string content)
        {
            if (NotificationService != null && TO is not null && content is not null)
            {
                NotificationService.SendNotification(TO, content);
            }
        }

        private static void Print10NumbersFromSeries(ISeries series)
        {
            if (series == null)
                return;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current}\t");
                series.getNext();
            }
            series.Reset();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            #region Question1
            //IShape Req = new Rectangle();
            //Req.Area = 10.123f;
            //DisplayShapeInfo(Req);
            //IShape Circle = new Circle();
            //Circle.Area = 11.112344f;
            //DisplayShapeInfo(Circle); 
            #endregion

            #region Question2
            //IAuthenticationService authenticationService = new BasicAuthenticationService();
            //Console.WriteLine(authenticationService.AuthenticateUser("AhmedAmr", "1222222")); // False
            //Console.WriteLine(authenticationService.AuthenticateUser("AhmedAmr", "12345678")); // True
            //Console.WriteLine(authenticationService.AuthorizeUser("User")); // False
            //Console.WriteLine(authenticationService.AuthorizeUser("admin")); // True 
            #endregion

            #region Question3
            //INotificationService NotificationService1 = new SmsNotificationService();
            //INotificationService NotificationService2 = new EmailNotificationService();
            //INotificationService NotificationService3 = new PushNotificationService();

            //SendMessage(NotificationService1, "Ahmed Amr", "Hello from SMS");
            //SendMessage(NotificationService2, "Ayman Amr", "Hello from Email");
            //SendMessage(NotificationService3, "Mohamed Amr", "Hello from Push"); 
            #endregion

            #region Demo
            #region Example 2
            //ISeries seriesByTwo = new SeriesByTwo();
            //ISeries seriesByThree = new SeriesByThree();
            //ISeries seriesByFour = new SeriesByFour();
            //Print10NumbersFromSeries(seriesByFour);
            #endregion

            #region Implicity vs Explicity
            //Airplane airplane = new Airplane();
            ////airplane.Forward(); // error

            //IMovable airplane2 = new Airplane();
            //IFlyable airplane3 = new Airplane();

            //airplane3.Forward();
            //airplane2.Forward();
            #endregion

            #region Shallow Copy VS Deep Copy array of value type

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode}");
            //Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode}");

            #region Shallow copy
            //Arr02 = Arr01;
            //Console.WriteLine("After shallow copy");

            //Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode}");
            //Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode}");

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);
            #endregion

            #region Deep copy
            //Arr02 = (int[])Arr01.Clone();

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode}");
            //Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode}");

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);
            //Console.WriteLine($"HashCode Arr01 = {Arr01.GetHashCode}");
            //Console.WriteLine($"HashCode Arr02 = {Arr02.GetHashCode}");
            #endregion
            #endregion

            #region Shallow Copy VS Deep Copy array of ref type
            //string[] Name01 = new string[] { "omar" };
            //string[] Name02 = new string[1];

            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode}");

            #region Shallow copy
            //Name02 = Name01;
            //Console.WriteLine("After shallow copy");
            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0] = "mona";
            //Console.WriteLine("After change");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            #endregion

            #region Deep copy
            //Name02 = (string[])Name01.Clone();
            //Console.WriteLine("After shallow copy");
            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0] = "mona";
            //Console.WriteLine("After change");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            #endregion

            #endregion

            #region Shallow Copy VS Deep Copy array of ref type (StringBuilder)
            //StringBuilder[] Name01 = new StringBuilder[1];

            //Name01[0] = new StringBuilder("omar");

            //StringBuilder[] Name02 = new StringBuilder[1];

            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode}");

            #region Shallow copy
            //Name02 = Name01;
            //Console.WriteLine("After shallow copy");
            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0].Append("mona");
            //Console.WriteLine("After change");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]); 
            #endregion

            #region Deep copy
            //Name02 = (StringBuilder[])Name01.Clone();
            //Console.WriteLine("After shallow copy");
            //Console.WriteLine($"HashCode Name01 = {Name01.GetHashCode}");
            //Console.WriteLine($"HashCode Name02 = {Name02.GetHashCode}");

            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);

            //Name02[0].Append("mona");
            //Console.WriteLine("After change");
            //Console.WriteLine(Name01[0]);
            //Console.WriteLine(Name02[0]);
            #endregion

            #endregion

            #region ICloneable
            //Employee emp01 = new Employee()
            //    {
            //        Id = 1,
            //        Name = "Ali",
            //        Salary = 3000,
            //        Department = new Department() { Id = 1 , Name = "Hr" },
            //    };
            //    Employee emp02 = new Employee()
            //    {
            //        Id = 2,
            //        Name = "Ali",
            //        Salary = 5000
            //    };
            //    Console.WriteLine($"hashcode of emp01 = {emp01.GetHashCode()}");
            //    Console.WriteLine($"hashcode of emp02 = {emp02.GetHashCode()}");

            //    Employee emp03 = emp01; //shallow copy 

            //    emp03 = (Employee)emp01.Clone(); // Deep copy

            //    Console.WriteLine("After shallow copy");
            //    Console.WriteLine($"hashcode of emp01 = {emp01.GetHashCode()}");
            //    Console.WriteLine($"hashcode of emp02 = {emp02.GetHashCode()}");

            //    emp03.Department.Name = "Sales";

            //    Console.WriteLine(emp01);
            //    Console.WriteLine(emp03);
            #endregion

            #region IComparable
            //int[] Numbers = { 7, 2, 1, 6, 9, 8, 4, 3 };

            //Array.Sort(Numbers);

            //Employee[] employees =
            //{
            //    new Employee() { Id = 10, Name = "omar", Salary = 3000, Department = new Department { Id = 1, Name = "Hr" } },
            //    new Employee() { Id = 20, Name = "omar", Salary = 10000, Department = new Department { Id = 1, Name = "Hr" } },
            //    new Employee() { Id = 30, Name = "omar", Salary = 5000, Department = new Department { Id = 1, Name = "Hr" } },
            //    new Employee() { Id = 50, Name = "omar", Salary = 200, Department = new Department { Id = 1, Name = "Hr" } }
            //};
            //Array.Sort(employees);

            //foreach (var num in Numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion 
            #endregion

        }
    }
}
