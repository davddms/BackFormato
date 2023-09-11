using System.ComponentModel.DataAnnotations;

namespace BackFormato
{
    public class Formato
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        [StringLength(200)]
        public string Comments { get; set; } = string.Empty;

        public int FormatoTypeId { get; set; }

        public FormatoType? FormatoType { get; set; }
    }
}
