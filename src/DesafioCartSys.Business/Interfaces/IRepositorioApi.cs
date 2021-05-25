﻿using DesafioCartSys.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DesafioCartSys.Business.Interfaces
{
    public interface IRepositorioApi<TEntity> : IDisposable where TEntity : Entidade
    {
        Task Adicionar(TEntity entidade);

        Task<TEntity> ObterPorId(Guid id);

        Task<List<TEntity>> ObterTodos();

        Task Atualizar(TEntity entidade);

        Task Remover(Guid id);

        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();
    }
}
