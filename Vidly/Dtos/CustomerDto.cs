using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;
using static Vidly.Models.Min18YearsIfMember;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Min18YearsIfMemberDto]
        public DateTime? Bitrhdate { get; set; }
        
        public byte MembershipTypeId { get; set; }
        //public MembershipType MembershipType { get; set; }
    }
}