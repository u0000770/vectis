using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestBuildPacker4.Models
{
    public class TblCatSection
    {
        public TblCatSection()
        {
            TblLot = new HashSet<TblLot>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CatSectionId { get; set; }
        public string Heading { get; set; }
        public string SubHeading1 { get; set; }
        public string SubHeading2 { get; set; }
        public string AdditionalComments { get; set; }

        public ICollection<TblLot> TblLot { get; set; }
    }
}
