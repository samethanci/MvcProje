using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact : IEntity
    {
        [Key]
        public int ContactId { get; set; }

        [StringLength(200)]
        public string ContactUserFullName { get; set; }

        [StringLength(50)]
        public string ContactMail { get; set; }

        [StringLength(100)]
        public string ContactSubject { get; set; }

        public string ContactMessage { get; set; }

    }
}
