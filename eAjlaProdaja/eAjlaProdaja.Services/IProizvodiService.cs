using eAjlaProdaja.Model; //ukljucujemo jer trebamo dohvatiti podatke iz modela
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAjlaProdaja.Services
{
  public interface IProizvodiService
  {
    IList<Proizvodi> Get(); //metoda da bismo dohvatili proizvode
  }
}
