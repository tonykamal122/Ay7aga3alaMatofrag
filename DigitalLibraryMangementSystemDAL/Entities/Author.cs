using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLibraryMangementSystemDAL.Entities
{
    public class Author : BaseEntity
    {
        //FirstName - Title
        public string LastName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        #region Relationships
        #region Author - Book
        public ICollection<Book> AuthorBooks { get; set; } = null!;
        #endregion
            
        #endregion
        
    }
}