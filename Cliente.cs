﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraOnline
{
  public class Cliente
  {
    public string Nombre { get; set; }

    public Cliente(string name) 
    {
      Nombre = name;
    }
  }
}
