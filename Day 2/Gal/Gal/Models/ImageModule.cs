namespace Gal.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ImageModule : DbContext
    {
        public ImageModule()
            : base("name=ImageModule")
        {
        }

        public virtual DbSet<Path> Paths { get; set; }
    }
}
