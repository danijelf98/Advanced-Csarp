using System;
using System.Collections.Generic;

namespace Linq_7._SQLExample.Models.Dbo;

public partial class Animal
{
    public int Id { get; set; }

    public string? AnimalName { get; set; }

    public string? Habitat { get; set; }

    public int? LegNumber { get; set; }
}
