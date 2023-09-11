using System.ComponentModel.DataAnnotations;

namespace BackFormato
{
    public class FormatoType
    {
        
        public int FormatoTypeId { get; set; } 
        public int MyProperty { get; set; }

        [StringLength(20)]
        public string FormatoName { get; set; } = string.Empty;

    }
}
