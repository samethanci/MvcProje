using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }

        [StringLength(100)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }


        // Category
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        // Content
        public ICollection<Content> Contents { get; set; }


        // Author
        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
