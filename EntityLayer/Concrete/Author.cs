using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author : IEntity
    {
        [Key]
        public int AuthorId { get; set; }


        [StringLength(50)]
        public string AuthorName { get; set; }


        [StringLength(50)]
        public string AuthorSurname { get; set; }


        [StringLength(100)]
        public string AuthorImage { get; set; }


        [StringLength(50)]
        public string AuthorMail { get; set; }


        [StringLength(20)]
        public string AuthorPassword { get; set; }


        // Heading
        public ICollection<Heading> Headings { get; set; }

        // Content
        public ICollection<Content> Contents { get; set; }
    }
}
