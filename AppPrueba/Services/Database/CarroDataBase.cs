using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPrueba.Models;
using SQLiteNetExtensionsAsync.Extensions;

namespace AppPrueba.Services.Database
{
    public class CarroDatabase<T> : ICarroDataBase<T> where T : CarroModel, new()
    {
        public CarroDatabase()
        {
            App.Database.connection.CreateTableAsync<T>().Wait();
            App.Database.connection.CreateTableAsync<CarroModel>().Wait();

        }

        public Task<int> DeleteAllItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteItemAsync(T item)
        {
            return App.Database.connection.DeleteAsync(item);
        }

        public Task<int> GetAllItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetItemAsync()
        {
            return App.Database.connection.Table<T>().ToListAsync();
        }

        public Task<T> GetItemAsync(int id)
        {
            return App.Database.connection.FindAsync<T>(id);
        }

        public Task<int> InsertAllItemsAsync(IList<T> items)
        {
            throw new NotImplementedException();
        }

        public Task InsertAllItemsWithChildrenAsync(IList<T> items)
        {
            return App.Database.connection.InsertAllWithChildrenAsync(items);

        }

        public Task<int> InsertItemAsync(T item)
        {
            return App.Database.connection.InsertAsync(item);
        }

        public Task<int> UpdateItemAsync(T item)
        {
            return App.Database.connection.UpdateAsync(item);
        }
    }
}
