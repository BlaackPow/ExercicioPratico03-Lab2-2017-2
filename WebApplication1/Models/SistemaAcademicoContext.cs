using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SistemaAcademicoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SistemaAcademicoContext() : base("name=SistemaAcademicoContext")
        {
        }

        public System.Data.Entity.DbSet<WebApplication1.Models.Curso> Cursoes { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Professor> Professors { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Endereco> Enderecoes { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Estudante> Estudantes { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.NivelEnsino> NivelEnsinoes { get; set; }
    }
}
