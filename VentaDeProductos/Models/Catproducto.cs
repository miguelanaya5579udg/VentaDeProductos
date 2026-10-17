using System;
using System.Collections.Generic;

namespace VentaDeProductos.Models;

public partial class Catproducto
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Tblinventario> Tblinventarios { get; set; } = new List<Tblinventario>();
}
