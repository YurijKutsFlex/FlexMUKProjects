﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestInfo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class Rep_ff286_nespressoEntities2 : DbContext
    {
        public Rep_ff286_nespressoEntities2()
            : base("name=Rep_ff286_nespressoEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<udpInfoCenter_Result> udpInfoCenter(Nullable<int> value)
        {
            var valueParameter = value.HasValue ?
                new ObjectParameter("Value", value) :
                new ObjectParameter("Value", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<udpInfoCenter_Result>("udpInfoCenter", valueParameter);
        }
    }
}
