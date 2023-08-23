using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace programs.Models;
public class Song
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Author { get; set; }
    public string? Release { get; set; }
    public string? Genre { get; set; }
    public string? Poster { get; set; }
    public string? Lyrics { get; set; }

}
