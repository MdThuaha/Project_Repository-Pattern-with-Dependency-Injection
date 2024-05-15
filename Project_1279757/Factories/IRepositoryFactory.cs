﻿using Project_1279757.Models;
using Project_1279757.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279757.Factories
{
    public interface IRepositoryFactory
    {
        IRepository<T> CreateRepository<T>() where T : BaseEntity;
    }
}