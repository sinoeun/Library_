﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_CSharp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibrarySystemEntities : DbContext
    {
        public LibrarySystemEntities()
            : base("name=LibrarySystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<BookDetail> BookDetails { get; set; }
        public virtual DbSet<BookPrice> BookPrices { get; set; }
        public virtual DbSet<BookStock> BookStocks { get; set; }
        public virtual DbSet<BookStockDetail> BookStockDetails { get; set; }
        public virtual DbSet<BookWesteReport> BookWesteReports { get; set; }
        public virtual DbSet<Borrow> Borrows { get; set; }
        public virtual DbSet<BorrowDetail> BorrowDetails { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Guste> Gustes { get; set; }
        public virtual DbSet<Languge> Languges { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Return> Returns { get; set; }
        public virtual DbSet<ReturnDetail> ReturnDetails { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
    }
}