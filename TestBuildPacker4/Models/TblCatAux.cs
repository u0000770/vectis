using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblCatAux
    {
        public TblCatAux()
        {
            TblLot = new HashSet<TblLot>();
        }

        public int CatAuxId { get; set; }
        public int CatAuxAuctionId { get; set; }
        public string CatAuxTitle { get; set; }
        public string CatAuxDesc { get; set; }
        public DateTime CatAuxCreateDate { get; set; }
        public int CatAuxWho { get; set; }
        public bool CatAuxImported { get; set; }
        public bool CatAuxRemoved { get; set; }

        public ICollection<TblLot> TblLot { get; set; }
    }
}
