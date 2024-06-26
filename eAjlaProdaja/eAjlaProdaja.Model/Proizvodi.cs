using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAjlaProdaja.Model
{
  public partial class Proizvodi
  {
    public int ProizvodID { get; set; }
    public string Naziv { get; set; }
    public string Sifra { get; set; }
    public decimal Cijena { get; set; }
    public int VrstaID { get; set; }
    public int JedinicaMjereID { get; set; }
    public byte[] Slika { get; set; }
    public byte[] SlikaThumb { get; set; }
    public bool? Status { get; set; }
    public string StateMachine { get; set; }
  }
}
