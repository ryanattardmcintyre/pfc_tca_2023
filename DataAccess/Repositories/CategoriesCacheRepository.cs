using Domain.Interfaces;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class CategoriesCacheRepository : ICategoriesRepository
    {
        private IDatabase db;
        private readonly IConfiguration _config;
        public CategoriesCacheRepository(IConfiguration config)
        {
            _config = config;
            var connectionString = config.GetConnectionString("cachedb");
            var cm = ConnectionMultiplexer.Connect(connectionString);

            db = cm.GetDatabase();
        }

        //Method has to append the new Category to a list of pre-existent categories
        //and saved in cache.  Check also for existence of that list, so if null you need to create
        //a new one
        public void AddCategory(Category c)
        {
            throw new NotImplementedException();
        }

        //Method has to get a list of Categories from Cache.  If it does not exist return an
        //empty List<Category>
        public IQueryable<Category> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
