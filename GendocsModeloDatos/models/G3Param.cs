using System;
using System.Collections.Generic;

namespace GendocsModeloDatos.models
{
    public partial class G3Param
    {
        public string NP{ get; set; }
        public string VP{ get; set; }
        public bool? VPbool { get; set; }
        public int? VPlng { get; set; }
        public decimal? VPcur { get; set; }
        public string VPmemo { get; set; }
        public DateTime VPfecha { get; set; }
        public DateTime FModificado { get; set; }
        public int TipoDato{ get; set; }
    }
}
