using System;
using System.Collections.Generic;

namespace Projekt1DB.Models;

public partial class Osoby
{
    public int Id { get; set; }

    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }

    public int? Wzrost { get; set; }

    public decimal? Waga { get; set; }

    public DateTime? DataUr { get; set; }
}
