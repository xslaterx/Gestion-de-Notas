﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using BDGestion;

namespace CapaEscolar
{
    public class CN_Usuario
    {
        private CD_Usuario odjcd_usuario = new CD_Usuario();


        public List <Usuario> Listar()
        {
            return odjcd_usuario.Listar();
        }
    }
}
