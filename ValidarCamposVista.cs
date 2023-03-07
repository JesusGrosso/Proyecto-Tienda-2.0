﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tienda_2._0
{
    static class ValidarCamposVista
    {
        public static Boolean validarCampo(string dato, string tipo)
        {
            switch(tipo)
            {
                case "int":
                    try
                    {
                        Convert.ToInt32(dato);
                        return true;
                    }
                    catch(Exception)
                    {
                        return false;
                    }
                case "float":
                    try
                    {
                        Convert.ToSingle(dato);
                        return true;
                    }
                    catch(Exception)
                    {
                        return false;
                    }
                case "string":
                    if (dato.Trim() != ""){
                        try
                        {
                            Convert.ToString(dato.Trim());
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                default:
                    {
                        return false;
                    }

                  


            }
        }
    }
}
