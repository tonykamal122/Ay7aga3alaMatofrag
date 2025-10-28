using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLibraryMangementSystemDAL.Entities
{
    public class Book : BaseEntity
    {
        public int Price { get; set; }
        public int PublicationYear { get; set; }
        public int AvailableCopies { get; set; }
        public int TotalCopies { get; set; }
        #region RelationShips

        #region Cat - Book
        public int CategoryId { get; set; }
        public Category BookCategory { get; set; } = null!;
        #endregion

        #region Author - Book
        public int AuthorId { get; set; }
        public Author BookAuthor { get; set; } = null!;
        #endregion

        #endregion

    }
}