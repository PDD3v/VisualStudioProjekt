using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1DB.Models
{
    public partial class Osoby
    {
        public string DaneDoWyswitlenia =>
            $"{Imie} {Nazwisko} {Wzrost} {DataUr?.ToString("dd-MM-yyyy")}";
    }
}
