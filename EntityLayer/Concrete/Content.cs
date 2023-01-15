using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content : IEntity
    {
        [Key]
        public int ContentId { get; set; }

        [StringLength(1000)]
        public string ContentText { get; set; }

        public DateTime ContentDate { get; set; }

        // Heading
        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

        //Author
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
