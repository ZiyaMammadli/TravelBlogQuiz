using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBlog.Core.Entities;

public class Blog:BaseEntity
{
    public string Title { get; set; }
    public string Desc { get; set; }
    public string ImageUrl { get; set; }

}

