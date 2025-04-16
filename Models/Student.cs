using System;
using System.Collections.Generic;

namespace WebApp5BySaugat.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Marks { get; set; }
}
