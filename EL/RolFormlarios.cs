﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class RolFormlarios
    {  
        public int IdRolFormulario { get; set; }
        public int IdRol { get; set; }
        public int IdFormulario { get; set; }
        public int IdUsuarioRegistra { get; set; }
        public int FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public int FechaActualizacion { get; set; }
    }
}
