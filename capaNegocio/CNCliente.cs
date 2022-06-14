﻿using System;
using System.Windows.Forms;
//Uso de la capa entidad
using capaEntidad;
namespace capaNegocio
{
    public class CNCliente
    {
        public bool ValidarDatos(CECliente cliente)
        {
            bool resultado = true;
            //En caso de que el nombre o apellido esten vacios , se desplegara un mensaje 
            if (cliente.Nombre == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El nombre es Obligatorio");
            }

            if (cliente.Apellido == string.Empty)
            {
                resultado = false;
                MessageBox.Show("El apellido es Obligatorio");
            }

            if (cliente.Foto == null)
            {
                resultado = false;
                MessageBox.Show("La Foto es Obligatorio");
            }

            return resultado;
        }



    }
}