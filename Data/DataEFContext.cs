﻿using Microsoft.EntityFrameworkCore;
using Rieltor.Data.Entities;

namespace Rieltor.Data
{
    public class DataEFContext : DbContext
    {
        public DataEFContext(DbContextOptions<DataEFContext> options)
           : base(options) { }

        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<RieltorEntity> Rieltors { get; set; }
        public DbSet<TypesOfObjectsEntity> TypesOfObjects { get; set; }
        public DbSet<ObjectEntity> Objects { get; set; }

        public DbSet<PhotoObjectEntity> PhotoObjectEntities { get; set; }

        public DbSet<DistrictEntity> DistrictEntities { get; set; }

    }
}
