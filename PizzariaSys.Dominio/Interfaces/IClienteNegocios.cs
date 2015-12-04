using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzariaSys.AcessoDados.Interface;

namespace PizzariaSys.Dominio.Interfaces
{
    
        public interface IClienteNegocios : IRepositorio<Cliente>
        {
            IEnumerable<Cliente> ListarTodos(string param);
        }
    
}
