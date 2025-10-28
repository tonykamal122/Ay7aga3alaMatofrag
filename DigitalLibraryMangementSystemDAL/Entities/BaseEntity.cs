using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLibraryMangementSystemDAL.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

    }
}