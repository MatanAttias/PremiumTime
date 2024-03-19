﻿using PremiumTime.DataAccess.Data;
using PremiumTime.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumTime.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private ApplicationDBContext _db;
        public ICategoryRepository Category { get; private set; }
        public UnitOfWork(ApplicationDBContext db) 
        {
            _db = db;
            Category = new CategoryRepository(_db);

        }


        public void Save()
        {
            _db.SaveChanges();
        }


    }
}