﻿using LibraryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Repositories
{
    interface ICategoryRepository
    {
        void Add(Category category);

        List<Category> List(int page, int limit);
    }
}
