using System;
using System.Collections.Generic;

namespace GendocsForms.models
{
    public partial class GdEnviosEmail
    {
        public int IdEnvioEmail { get; set; }
        public DateTime? Ahora { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Asunto { get; set; }
        public string Body { get; set; }
        public string Firma { get; set; }
        public string Adjuntos { get; set; }
        public int? IdProyecto { get; set; }
        public int? IdDoc { get; set; }
        public string User { get; set; }
        public string EntryId { get; set; }
    }
}
