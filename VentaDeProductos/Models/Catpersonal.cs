using System;
using System.Collections.Generic;

namespace VentaDeProductos.Models;

public partial class Catpersonal
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Cargo { get; set; } = null!;

    public virtual ICollection<Tblinventario> Tblinventarios { get; set; } = new List<Tblinventario>();
}
