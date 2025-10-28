using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalLibraryMangementSystemDAL.Entities.Enums;

namespace DigitalLibraryMangementSystemDAL.Entities
{
    public class Fine : BaseEntity
    {
        //Ignore Title
        public int Amount { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime PaidDate  { get; set; }
        public FineStatus Status { get; set; }

        #region Relationships

        #region Fine - Loan
        public Loan Loan { get; set; } = null!;
        public int LoanId { get; set; }

        #endregion
        
        #endregion
    }
}