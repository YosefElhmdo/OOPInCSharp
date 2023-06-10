using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_Indexer
{
    public class Department
    {
        public Department(int id, string depName)
        {
            Id = id;
            this.depName = depName;
            employees = new List<Employee>();
        }
        public int Id { get; set; }
        public string depName { get; set; }

        public Employee this[int index]
        {
            get { return employees[index]; }
            set { employees[index] = value; }
        }
        public Employee this[string name]
        {
            get
            {
                foreach (Employee item in employees)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }
                }
                return null;
            }
            set
            {
                int index = 0;
                foreach (Employee item in employees)
                {
                    if (item.Name == name)
                    {
                        break;
                    }
                    index++;
                }
                employees[index] = value;
            }
        }
        public Employee GetEmployeebyIndex(int index)
        {
            return employees[index];
        }
        public void SetEmployeebyIndex(int index, Employee newemployee)
        {
            employees[index] = newemployee;
        }
        public List<Employee> employees { get; set; }
    }
}
