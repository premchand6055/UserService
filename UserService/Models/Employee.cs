using System;
using System.Collections.Generic;

namespace UserService.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? ManagerId { get; set; }

    public DateTime? HireDate { get; set; }

    public string? JobTitle { get; set; }

    public string? Department { get; set; }

    public virtual ICollection<Salary> Salaries { get; set; } = new List<Salary>();

    public virtual User? User { get; set; }
}
