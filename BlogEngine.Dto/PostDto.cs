using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Dto
{
    public class PostDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int NumComments { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }
        public string AbsoluteLink { get; set; }
    }
}
