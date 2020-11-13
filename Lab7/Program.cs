using System;
using System.Linq;
using System.Collections.Generic;

namespace HMW
{
    public class Employee
    {
        public int ID;
        public string LastName;
        public int DepartmentID;

        public Employee(int id, string lastName, int departmentID) => (ID, LastName, DepartmentID) = (id, lastName, departmentID);

        public override string ToString() => $"(ID = {ID}; LastName = {LastName}; DepartmentID = {DepartmentID})";
    }

    public class Department
    {
        public int ID;
        public string Name;

        public Department(int id, string name) => (ID, Name) = (id, name);

        public override string ToString() => $"(ID = {ID}; Name = {Name})";
    }

    public class Employment
    {
        public int EmployeeID;
        public int DepartmentID;

        public Employment(int employeeID, int departmentID) => (EmployeeID, DepartmentID) = (employeeID, departmentID);
    }

    public class Program
    {
        private static readonly List<Employee> s_employees = new List<Employee>()
        {
            new Employee(0, "Иванов", 0),
            new Employee(1, "Петров", 0),
            new Employee(2, "Сидоров", 0),
            new Employee(3, "Семёнов", 1),
            new Employee(4, "Сергеев", 1),
        };

        private static readonly List<Department> s_departments = new List<Department>()
        {
            new Department(1, "Бухгалтерия"),
            new Department(0, "Логистика"),
        };

        private static readonly List<Employment> s_employments = new List<Employment>()
        {
            new Employment(0, 1),
            new Employment(0, 0),
            new Employment(1, 1),
            new Employment(2, 0),
            new Employment(2, 1),
            new Employment(3, 0),
            new Employment(4, 1),
        };

        private static void SortByDepartment()
        {
            Console.WriteLine("Cписок всех сотрудников и отделов, отсортированный по отделам:");
            var departments = from department in s_departments
                              orderby department.ID ascending
                              select department;

            foreach (var department in departments)
            {
                Console.WriteLine($"\tОтдел: {department}");

                var employees = from employee in s_employees
                                where employee.DepartmentID == department.ID
                                select employee;

                foreach (var employee in employees)
                    Console.WriteLine($"\t\t{employee}");
            }
        }

        private static void EmployeesFirstChar(char firstCharacter)
        {
            Console.WriteLine($"Список всех сотрудников, чья фамилия начинается на: {firstCharacter}");

            var employees = from employee in s_employees
                            where employee.LastName[0] == firstCharacter
                            select employee;

            foreach (var employee in employees)
                Console.WriteLine("\t" + employee);
        }

        private static void DepartmentsWithNumbers()
        {
            Console.WriteLine("Список всех отделов и количество сотрудников в каждом отделе");
            foreach (var department in s_departments)
            {
                Console.Write($"\t{department} : ");

                var employees = from employee in s_employees
                                where employee.DepartmentID == department.ID
                                select employee;

                Console.WriteLine(employees.Count());
            }
        }

        private static void DepartmentsAllFirstChar(char firstChar)
        {
            Console.WriteLine($"Cписок отделов, в которых у всех сотрудников фамилия начинается с буквы {firstChar}");
            foreach (var department in s_departments)
            {
                var employees = from employee in s_employees
                                where employee.DepartmentID == department.ID
                                select employee;
                if (employees.All(employee => employee.LastName[0] == firstChar))
                    Console.WriteLine($"\t{department}");
            }
        }
        private static void DepartmentsAnyFirstChar(char firstChar)
        {
            Console.WriteLine($"Cписок отделов, в которых хотя бы у одного сотрудника фамилия начинается с буквы {firstChar}");
            foreach (var department in s_departments)
            {
                var employees = from employee in s_employees
                                where employee.DepartmentID == department.ID
                                select employee;
                if (employees.Any(employee => employee.LastName[0] == firstChar))
                    Console.WriteLine($"\t{department}");
            }
        }

        private static void FullListMtoM()
        {
            Console.WriteLine("Список всех отделов и список сотрудников в каждом отделе (связь много-ко-многим)");
            foreach (var department in s_departments)
            {
                Console.WriteLine($"\t{department}:");

                var employees = from employment in s_employments
                                from employee in s_employees
                                where employment.DepartmentID == department.ID && employment.EmployeeID == employee.ID
                                select employee;

                foreach (var employee in employees)
                    Console.WriteLine($"\t\t{employee}");
            }
        }

        private static void DepartmentsWithNumbersMtoM()
        {
            Console.WriteLine("Список всех отделов и количество сотрудников в каждом отделе (связь много-ко-многим)");
            foreach (var department in s_departments)
            {
                Console.Write($"\t{department}: ");

                var employees = from employment in s_employments
                                from employee in s_employees
                                where employment.DepartmentID == department.ID && employment.EmployeeID == employee.ID
                                select employee;

                Console.WriteLine(employees.Count());
            }
        }

        public static void Main()
        {
            SortByDepartment();
            EmployeesFirstChar('С');
            DepartmentsWithNumbers();
            DepartmentsAllFirstChar('С');
            DepartmentsAnyFirstChar('С');
            FullListMtoM();
            DepartmentsWithNumbersMtoM();
        }
    }
}
