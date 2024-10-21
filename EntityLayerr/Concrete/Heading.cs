using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concrete
{
    public class Heading
    {
        public int HeadingID { get; set; }
        public string HeadingNmae { get; set; }
        public DateTime HeadingDate { get; set; }

        public int CategoryID { get; set; } //ilişkili tablonun anahtar sütunuyula aynı isimde olmalı
        public virtual Category Category { get; set; } 

        public ICollection <Content> Contents { get; set; }
    }
}
