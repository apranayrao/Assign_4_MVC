using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assign_4_MVC_Active_Cloud_Site.Models
{


    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { }

        public DbSet<Products> Products { get; set; }
    }
    public class Rootobject
    {
        public Meta meta { get; set; }
        public Result[] results { get; set; }
    }

    public class Meta
    {
        
        public string disclaimer { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string terms { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string license { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string last_updated { get; set; }
        
    }
    public class Consumer
    {
        public string age { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string age_unit { get; set; }
    }

    public class Result
    {
        public Products[] products { get; set; }
    }

    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string name_brand { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string industry_name { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string industry_code { get; set; }
    }

    public class Reactions
    {
        [Column(TypeName = "nvarchar(200)")]
        public string reactions { get; set; }
    }

    public class Outcomes
    {
        [Column(TypeName = "nvarchar(200)")]
        public string outcomes { get; set; }
    }
}
