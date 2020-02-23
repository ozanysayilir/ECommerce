﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommers.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>dbContextOptions) :base(dbContextOptions)
        {


        }
        public DbSet<Entities.User>Users { get; set; }

    }
}
