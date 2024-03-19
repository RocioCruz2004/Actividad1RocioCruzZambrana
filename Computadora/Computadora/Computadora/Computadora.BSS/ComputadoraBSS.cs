using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computadora.MODELOS;
using Computadora.DAL;
using System.Data;

namespace Computadora.BSS
{
    public class ComputadoraBSS
    {
        ComputadoraDAL dal = new ComputadoraDAL();
        public DataTable ListarComputadorasBss()
        {
            return dal.ListarComputadorasDal();
        }
    }
}
