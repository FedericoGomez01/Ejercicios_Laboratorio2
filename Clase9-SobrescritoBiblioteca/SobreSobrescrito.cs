using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9_SobrescritoBiblioteca
{
    public class SobreSobrescrito : Sobrescrito
    {
        public override string MiPropiedad
        {
            get
            {
                return base.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
