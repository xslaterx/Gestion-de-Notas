using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDGestion;
using CapaDatos;
using DBGestion;


namespace CapaEscolar
{
    public class CN_Asignatura
    {
       private CD_Asignatura odjcd_asignatura = new CD_Asignatura();


        public List<Asignatura> Listar()
        {
            return odjcd_asignatura.Listar();
        }
        
    }
}
