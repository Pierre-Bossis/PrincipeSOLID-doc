﻿using PrincipeS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principe.I
{
    public interface IWriteRepository
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}
