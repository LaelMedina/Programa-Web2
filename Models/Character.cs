using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace programs.Models;
public class Character
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Birthday { get; set; }
    public string? Age { get; set; }
    public string? Gender { get; set; }
    public string? Occupation { get; set; }
    public string? Height { get; set; }
    public string? Weight { get; set; }
    public string? Calification { get; set; }
    public string? Affiliation { get; set; }
    public string? Poster { get; set; }
    public string? Phrase { get; set; }

    [NotMapped]

    public string[]? Images { get; set; }

}
