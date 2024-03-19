using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computadora.MODELOS;

namespace Computadora.DAL
{
    public class ComputadoraDAL
    {
        public DataTable ListarComputadorasDal()
        {
            string consulta = "SELECT * FROM COMPUTADORA";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
