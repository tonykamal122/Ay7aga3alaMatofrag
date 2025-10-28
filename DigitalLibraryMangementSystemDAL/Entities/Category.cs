using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLibraryMangementSystemDAL.Entities
{
    public class Category : BaseEntity
    {
        public string Description { get; set; } = null!;
        #region Relationships
        #region Cat - Book
        public ICollection<Book> CategoryBooks { get; set; } = null!;
            
        #endregion
            
        #endregion
    }
}