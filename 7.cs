using System;

namespace ConsoleApp25
{
    class Employee
    {
        public string name; //Имя
        public string surname; //Фамилия
        public static string dateOfHire; //Дата найма
        public OperateCost operationCost;// Должность


        public Employee(string name, string surname, string dateOfHire, OperateCost opCost)
        {
            this.name = name;
            this.surname = surname;
            Employee.dateOfHire = dateOfHire;
            this.operationCost = opCost;

        }
        //Коэффициент повышения вознаграждения в зависимости от даты найма, в днях
        public static double DiscoverGrade(string dateOfHire)
        {
            double dateValueForGrade = (DateTime.Now - DateTime.Parse(dateOfHire)).TotalDays;

            if (dateValueForGrade >= 1825 && dateValueForGrade < 3650)
                return 1.1;
            else if (dateValueForGrade >= 3650)
                return 1.25;
            else
                return 1.5;
        }

    }
    abstract class OperateCost
    {
        public double salary;
        public double tax;

        public abstract void ApplyBonus(double bonus, double grade);
        public abstract void ApplyTax();
    }

    class Pourman : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (10000 + 2 * bonus) * grade;
        }

        public override void ApplyTax()
        {
            tax = salary * 0.34;
        }
    }

    class Creator : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (100000 + 5 * bonus) * grade;
        }
        public override void ApplyTax()
        {
            tax = salary * 0.34;
        }
    }

    class Superman : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (350000 + 10 * bonus) * grade;
        }
        public override void ApplyTax()
        {
            tax = salary * 0.2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OperateCost oc = new Creator();
            Employee emp = new Employee("Vlad", "Marseniuk", "08.02.2001", oc);
            double grade = Employee.DiscoverGrade("08.02.2001");
            Console.WriteLine("Name: {0}, Surname: {1}, Date of Hire: {2}, Positoin: {3}", emp.name, emp.surname, Employee.dateOfHire, emp.operationCost);
            oc.ApplyBonus(25000, grade);
            oc.ApplyTax();
            Console.WriteLine("Salary: {0}, Tax: {1}", emp.operationCost.salary, emp.operationCost.tax);
            Console.ReadKey();
        }
    }
}