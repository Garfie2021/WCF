using static System.Net.Mime.MediaTypeNames;

namespace CoreWCFService1.Model
{
    public class TableA
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string? ValueString { get; set; }
        public DateTime? ValueDate { get; set; }
    }

}
