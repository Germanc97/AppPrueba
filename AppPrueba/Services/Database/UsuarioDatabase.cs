using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPrueba.Models;
using SQLiteNetExtensionsAsync.Extensions;

namespace AppPrueba.Services.Database
{
    public class UsuarioDatabase<T> : IUsuarioDataBase<T> where T : UsuarioModel, new()
    {
        public UsuarioDatabase()
        {
            App.Database.connection.CreateTableAsync<T>().Wait();
            App.Database.connection.CreateTableAsync<CarroModel>().Wait();

        }

        public Task<int> DeleteItemAsync(T item)
        {
            return App.Database.connection.DeleteAsync(item);
        }

        public Task<List<T>> GetAllItemsWithChildrenAsync()
        {
            return App.Database.connection.GetAllWithChildrenAsync<T>();
        }

        public Task<List<T>> GetItemAsync()
        {
            return App.Database.connection.Table<T>().ToListAsync();
        }

        public Task<T> GetItemAsync(int id)
        {
            return App.Database.connection.FindAsync<T>(id);
        }

        public Task<int> InsertItemAsync(T item)
        {
            return App.Database.connection.InsertAsync(item);
        }

        public async Task InsertWithChildrenAsync(UsuarioModel item)
        {
            await App.Database.connection.InsertWithChildrenAsync(item);
        }

        public Task<int> UpdateItemAsync(T item)
        {
            return App.Database.connection.UpdateAsync(item);
        }

        public Task<List<T>> ConsutltaPorIdentificacion(long numero)
        {
            return App.Database.connection.Table<T>().Where(i => i.Identificacion == numero).ToListAsync();
        }

    }
}
