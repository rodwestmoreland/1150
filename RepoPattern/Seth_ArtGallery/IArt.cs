using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seth_ArtGallery
{
    public interface IArt
    {
        string Artist { get; }
        string Title { get;  }
        decimal Value { get; set; }
        DateTime Created { get;  }

    }
}
