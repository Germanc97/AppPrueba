using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppPrueba.Models;

namespace AppPrueba.Services.Database
{
    public interface IUsuarioDataBase<T> : IServiceDataBase<T> where T : class, new()
    {
        Task InsertWithChildrenAsync(UsuarioModel item);

        Task<List<T>> GetAllItemsWithChildrenAsync();

        Task<List<T>> ConsultaPorIdentificacion(string numero);
    }
}
