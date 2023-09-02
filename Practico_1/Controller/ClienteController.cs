using Practico_1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_1.Controller
{
    public class ClienteController : BaseController
    {
        public List<Cliente> ObtenerListaClientes()
        {
            return datos.Clientes;
        }

        public void AgregarCliente(Cliente cliente)
        {
            if (datos.Clientes.Any(c => c.Rut == cliente.Rut))
                throw new InvalidOperationException("El RUT ya existe en la lista.");

             datos.Clientes.Add(cliente);
        }

        public void ActualizarCliente(int index, Cliente cliente)
        {
            Cliente clienteExistente = datos.Clientes[index];
            {
                clienteExistente.Rut = cliente.Rut;
                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.EsEmpresa = cliente.EsEmpresa;
                clienteExistente.Telefono = cliente.Telefono;
                clienteExistente.Direccion = cliente.Direccion;
                clienteExistente.FechaRegistro = cliente.FechaRegistro;
                clienteExistente.CantidadFacturas = cliente.CantidadFacturas;
                clienteExistente.NumeroUltimaFactura = cliente.NumeroUltimaFactura;
                clienteExistente.MontoUltimaFactura = cliente.MontoUltimaFactura;
            }
        }

        public void EliminarCliente(int index)
        {
            datos.Clientes.RemoveAt(index);
            
        }

        
    }

}
