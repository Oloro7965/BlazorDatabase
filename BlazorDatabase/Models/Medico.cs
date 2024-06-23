using System.ComponentModel.DataAnnotations;

namespace BlazorDatabase.Models
{
    public class Medico
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string especialidade { get; set; }
        public string CRM { get; set; }
    }
}
