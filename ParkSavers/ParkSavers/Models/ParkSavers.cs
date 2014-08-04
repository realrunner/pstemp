namespace ParkSavers.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    
    public class ParkSaversContext : DbContext
    {
        // Your context has been configured to use a 'Ticket' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ParkSavers.Models.Ticket' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Ticket' 
        // connection string in the application configuration file.
        public ParkSaversContext()
            : base("name=parksavers")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Product> Products { get; set; }
    }

    [Table("PRODUCTS")]
    public class Product
    {
        public long ProductID {get;set;}
        public string Description {get;set;}
        public decimal? AdultPrice {get;set;}
        public decimal? ChildPrice {get;set;}
        public string ProductCode {get;set;}
        public int ProductType {get;set;}
        public int InfoID { get; set; }
    }
}