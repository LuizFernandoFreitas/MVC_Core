using System.Collections.Generic;
using System.Linq;

namespace MVCBaseLayout_Crud.Models
{
    public static class Dados
    {
        // Dados da aplicação
        private static List<Cliente> LISTA_CLIENTES = new List<Cliente>();

        public static List<Cliente> ListarClientes()
        {
            return LISTA_CLIENTES;
        }

        public static void AdicionarClientes(Cliente cliente)
        {
            // Recupera o ID disponível
            var id = 0;

            // Válida se tem clientes na lista
            if (LISTA_CLIENTES.Count > 0)
                id = LISTA_CLIENTES.Last().id + 1;

            // Associa ID ao cliente
            cliente.id = id;

            // Adiciona cliente na lista
            LISTA_CLIENTES.Add(cliente);
        }

        public static Cliente EditarCliente(int id)
        {
            // Recupera o cliente da lista
            return LISTA_CLIENTES.Where(a => a.id == id).FirstOrDefault();
        }

        public static void EditarCliente(Cliente cliente)
        {
            // Recupera o cliente da lista
            var clienteEncontrado = LISTA_CLIENTES.Where(a => a.id == cliente.id).FirstOrDefault();

            // Altera dados do cliente
            clienteEncontrado.nome = cliente.nome;
            clienteEncontrado.telefone = cliente.telefone;
        }


        public static void ExcluirCliente(int id)
        {
            // Recupera o cliente da lista
            var cliente = LISTA_CLIENTES.Where(a => a.id == id).FirstOrDefault();

            // Adiciona cliente na lista
            LISTA_CLIENTES.Remove(cliente);
        }
    }
}