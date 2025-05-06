using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuervoBD;

public class Persona
{
    public string Id { get; set; } // RavenDB lo gestiona automáticamente si lo dejás null
    public string Dni { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaNacimiento { get; set; }

    // Campo calculado (no se persiste)
    public int Edad
    {
        get
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }
    }

    public override string ToString()
    {
        return $"{Nombre} {Apellido} ({Dni}) - {Edad} años";
    }
}

