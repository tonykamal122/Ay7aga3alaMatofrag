using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalLibraryMangementSystemDAL.Entities.Enums;

namespace DigitalLibraryMangementSystemDAL.Entities
{
    public class Loan : BaseEntity
    {
        //Ignore Title
        public DateTime LoanDate { get; set; }
        public LoanStatus Status { get; set; }
        #region Relationships
        #region Loan - Fine
        public Fine? Fine { get; set; }
        #endregion
        #endregion
    }
}