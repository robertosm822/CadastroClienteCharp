using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using PizzariaSys.Dominio;
using System.ComponentModel.DataAnnotations;

namespace PizzariaSys.Web.ViewModel
{
    //inicio da classe
    public class ClienteViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage=" * Campo Obrigatório")]
        public string Nome{ get; set; }
        public string Logradouro { get; set; }

        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Za-z0-9]*\d+[A-Za-z0-9]*$", ErrorMessage="Digite somente números.")]
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }

        public ClienteViewModel() { 
        
        }

        //metodos
        public ClienteViewModel(ClienteViewModel cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            Logradouro = cliente.Logradouro;
            Numero = cliente.Numero;
            Bairro = cliente.Bairro;
            Telefone = cliente.Telefone;
        }
    }
    

}