using namespace_Indexer;

Department dep = new Department(1, "IT");
dep.employees.Add(new Employee(1, "Ahmad", 300));
dep.employees.Add(new Employee(2, "Ahmad", 200));
dep.employees.Add(new Employee(3, "Ahmad", 100));
dep.employees.Add(new Employee(4, "slah", 50));
dep.employees.Add(new Employee(5, "Ahmad", 10));

Employee emp = dep.GetEmployeebyIndex(1);
emp.printData();
dep.SetEmployeebyIndex(1, new Employee(11, "khaled", 200));
Employee emp1 = dep.GetEmployeebyIndex(1);
emp1.printData();

Employee emp2 = dep[0];
emp2.printData();
dep[0] = new Employee(1, "Sameer", 55);
dep[0].printData();
Console.WriteLine("__________-");
dep["slah"].printData();
dep["slah"] = new Employee(1, "Yazen", 555);
dep["Yazen"].printData();
