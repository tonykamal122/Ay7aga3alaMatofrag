using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalLibraryMangementSystemDAL.Entities.Enums;

namespace DigitalLibraryMangementSystemDAL.Entities
{
    public class Member : BaseEntity
    {
        //Name - Title
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime MembershipDate { get; set; }
        public MemberStatus Status { get; set; }
        #region Relationships
            
        #endregion
    }
}