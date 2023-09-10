﻿using System;
using System.Collections.Generic;

namespace investigadores.Models;

public partial class Investigadore
{
    public string Dni { get; set; } = null!;

    public string? Nombre { get; set; }

    public int? Facultad { get; set; }

    public virtual Facultad? FacultadNavigation { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
