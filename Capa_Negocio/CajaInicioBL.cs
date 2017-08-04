﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class CajaInicioBL
    {
        CajaInicioDAO CajDAO = new CajaInicioDAO();

        public string ObtenerCodigo()
        { 
            return CajDAO.ObtenerCodigo();
        }

        public bool GuardarNuevaCajaInicio(CajaInicioEN cajaIniEN)
        {
            return CajDAO.GuardarNuevaCajaInicio(cajaIniEN);
        }

        public DataTable ObtenerListadoCajaInicio(string idEmpresa)
        {
            return CajDAO.ObtenerListadoCajaInicio(idEmpresa); 
        }

        public bool ActualizarCajaInicio(CajaInicioEN cajaIniEN)
        { 
            return CajDAO.ActualizarCajaInicio(cajaIniEN);
        }
    }
}
