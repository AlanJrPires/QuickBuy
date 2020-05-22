using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        /// <summary>
        /// Um usuário pode ter ou não pedido
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
