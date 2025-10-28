using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLibraryMangementSystemDAL.Entities
{
    public class MemberLoans
    {
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        
        #region Relationships
        
        #region Book - Loan - Members (Ternary RS)
        public int BookId { get; set; }
        public int LoanId { get; set; }
        public int MemberId { get; set; }
        #endregion
            
        #endregion
    }
}