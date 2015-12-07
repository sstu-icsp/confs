﻿using Client.Entities;
using Client.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Client.DAL
{
    public class ConfsContext : DbContext
    {
        public ConfsContext() : base("ConfsContext") { 
        }

        public DbSet<NewsModel> News { get; set; }
        public DbSet<ConferenceModel> Conferences { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ParicipationModel> Paricipations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        internal static ConfsContext Create()
        {
            return new ConfsContext();
        }
    }
}