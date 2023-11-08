using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Documento { get; set; } = null!;

    public string Area { get; set; } = null!;
}
