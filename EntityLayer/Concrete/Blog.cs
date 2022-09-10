using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public bool BlogStatus { get; set; }
        public string BlogSummery { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogDateTime { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        //yorumlar ve kategorilere dair ilişkiler daha sonra eklenecek...
    }
}
