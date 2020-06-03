using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transacciones
{
    interface ITransaccion
    {
        void Add();
        void Edit();
        void Delete();
        void Read();
    }
}
