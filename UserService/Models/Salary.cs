using System;
using System.Collections.Generic;

namespace UserService.Models;

public partial class Salary
{
    public int SalaryId { get; set; }

    public int? EmployeeId { get; set; }

    public decimal? SalaryAmount { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Employee? Employee { get; set; }
}
