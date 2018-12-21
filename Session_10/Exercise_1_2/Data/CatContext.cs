using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Exercise_1_2
{
    public class CatContext : DbContext
    {
    public DbSet<Cat> Cats {get; set;}
    public DbSet<Order> Orders {get; set;}

    public CatContext(DbContextOptions<CatContext> catArg0) : base() {
        
    }
    }
}