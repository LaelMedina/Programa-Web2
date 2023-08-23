using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace programs.Models;
public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Age { get; set; }
    public string? Gender { get; set; }
    public string? Grade { get; set; }
    public string? Calification { get; set; }

}
