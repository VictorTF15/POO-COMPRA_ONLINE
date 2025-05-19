using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraOnline
{
  public class Compra
  {
    public Cliente Cliente { get; set; }
    public double Total { get; set; }
    public bool PagoExitoso { get; set; }

    public Compra(Cliente cliente, double total)
    {
      Cliente = cliente;
      Total = total;
    }

    public string ProcesarPago() 
    {
      Random random = new Random();
      PagoExitoso = random.Next(0, 2) == 1;


      if (PagoExitoso)
        return $"Compra realizada por {Cliente.Nombre}. Total: {Total}";
      else
        return $"Error en el pago. Intente con otro método.";
    }



  }
}
