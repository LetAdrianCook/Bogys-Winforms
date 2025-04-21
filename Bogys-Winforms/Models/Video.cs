using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Models
{
    public class Video
    {
        public int ID { get; set; }
        public string VideoTitle { get; set; }
        public string VideoCategory { get; set; }
        public string VideoInCount { get; set; }
        public string VideoOutCount { get; set; }
        public DateTime VideoAdded { get; set; }
    }
}
