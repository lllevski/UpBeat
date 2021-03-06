﻿using System;
using System.Linq;
using System.Collections.Generic;
using Bytes2you.Validation;
using UpBeat.Data.Contracts;
using UpBeat.Data.Models.Contracts;
using UpBeat.Services.Contracts;

namespace UpBeat.Services.Abstracts
{
    public abstract class DataService<T>: IDataService<T>
        where T : class, IDeletable, IAuditable
    {
        public DataService(IGenericRepository<T> dataRepository)
        {
            Guard.WhenArgument(dataRepository, "DataRepository").IsNull().Throw();

            this.Data = dataRepository;
        }

        public IGenericRepository<T> Data { get; private set; }

        public IEnumerable<T> GetAll()
        {
            return this.Data.All.ToList();
        }
    }
}
