﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankingApplication_Tutorial
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class banking_dbEntities : DbContext
    {
        public banking_dbEntities()
            : base("name=banking_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin_Table> Admin_Table { get; set; }
        public virtual DbSet<debit> debits { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<FD> FDs { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<userAccount> userAccounts { get; set; }
        public virtual DbSet<userTable> userTables { get; set; }
    }
}
