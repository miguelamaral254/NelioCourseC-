internal class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public void IncreaseSalary(double percentual) {
        Salary += Salary * percentual / 100.0;
    }
}