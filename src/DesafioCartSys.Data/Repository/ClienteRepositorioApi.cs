using DesafioCartSys.Business.Interfaces;
using DesafioCartSys.Business.Models;
using DesafioCartSys.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCartSys.Data.Repository
{
    public class ClienteRepositorioApi : RepositorioApi<Cliente> , IClienteRepositorioApi
    {
        public ClienteRepositorioApi(MeuDbContextApi context): base(context) { }

        
    }
}
