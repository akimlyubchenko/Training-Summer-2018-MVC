namespace Gal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Path
    {
        public int Id { get; set; }

        public string SmallPath { get; set; }

        public string FullPath { get; set; }
    }
}
