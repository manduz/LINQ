using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SelectMany(), her eleman için bir alt koleksiyon döndüren bir projeksiyon uygular ve bu alt koleksiyonları tek bir düz liste halinde birleştirir. Bu metot, genellikle iç içe koleksiyonlarla çalışırken kullanışlıdır.
            List<Employee> list = new List<Employee>();
            list.Add(new Employee
            {
                ID = 1,
                Departments = new List<Department>()
                { 
                    new Department 
                    {
                        Name = "Marketing"
                    },
                    new Department
                    {
                        Name ="Sales"
                    }

                }
            });
            list.Add(new Employee
            {
                ID = 2,
                Departments = new List<Department>()
                {
                    new Department
                    {
                        Name = "Marketing2"
                    },
                    new Department
                    {
                        Name ="Sales2"
                    }

                }
            });
            list.Add(new Employee
            {
                ID = 3,
                Departments = new List<Department>()
                {
                    new Department
                    {
                        Name = "Marketing3"
                    },
                    new Department
                    {
                        Name ="Sales3"
                    }

                }
            });

           var result =  list.SelectMany(x => x.Departments);
            foreach (var x in result)
            {
                Console.WriteLine(x.Name);
            }
            Console.ReadLine();
        }

        public class Employee
        {
            public int ID { get; set; }
            public List<Department> Departments { get; set; }
        }
        public class Department
        {
            public string Name { get; set; }
        }

    }
}
