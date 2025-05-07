using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Models
{
    public class Rent
    {
        public int ID { get; set; }
        public int UserID  { get; set; }
        public int VideoID { get; set; }
        public string CustomerName { get; set; }
        public string VideoTitle { get; set; }
        public string VideoCategory { get; set; }
        public int RentDays { get; set; }
        public float OverdueFee { get; set; }
        public string Status { get; set; } 
        public DateOnly RentDate { get; set; }
        public DateOnly ReturnDate { get; set; }
    }
}
