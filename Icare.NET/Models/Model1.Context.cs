﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Icare.NET.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class İcareDB : DbContext
    {
        public İcareDB()
            : base("name=İcareDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AboutU> AboutUs { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactMe> ContactMes { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Estate> Estates { get; set; }
        public virtual DbSet<EstateImage> EstateImages { get; set; }
        public virtual DbSet<EstateSpesification> EstateSpesifications { get; set; }
        public virtual DbSet<FAQ> FAQs { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<OrderHistory> OrderHistories { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PayType> PayTypes { get; set; }
        public virtual DbSet<Serviceİnfo> Serviceİnfo { get; set; }
    }
}
