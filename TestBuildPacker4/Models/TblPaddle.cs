using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblPaddle
    {
        public int PaddleId { get; set; }
        public int AuctionId { get; set; }
        public int DayNo { get; set; }
        public int ClientId { get; set; }
        public int PaddleNo { get; set; }
        public int PaddleType { get; set; }
        public bool AccountSettled { get; set; }
        public string Lots { get; set; }
        public bool Deleted { get; set; }

        public TblClient Client { get; set; }
    }
}
