using System;
using System.Collections.Generic;

namespace VentaDeProductos.Models;

public partial class Tblinventario
{
    public int Id { get; set; }

    public DateTime FechaAlta { get; set; }

    public int Idproducto { get; set; }

    public int Idpersonal { get; set; }

    public string TipoMovimiento { get; set; } = null!;

    public int Cantidad { get; set; }

    public virtual Catpersonal IdpersonalNavigation { get; set; } = null!;

    public virtual Catproducto IdproductoNavigation { get; set; } = null!;
}
