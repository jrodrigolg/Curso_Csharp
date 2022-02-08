using System;


namespace ExercicioPoo4 {
    internal class Employee {
        public int id { get; set; }
        public  string name { get; set; }
         public double salary { get; private set; }

        
        public Employee(int id, string name, double salary) {
        this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void IncreaseSalary(double percent) {
            this.salary += (salary * (percent/100));

        }
        public override string ToString() {
            return $"{id}, {name}, {salary:F2}";
        }


    }
}
