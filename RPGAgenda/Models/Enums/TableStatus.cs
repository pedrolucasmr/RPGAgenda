using System.ComponentModel;

namespace RPGAgenda.Models.Enums
{
    public enum TableStatus
    {
        [Description("active")]
        Active,
        
        [Description("inactive")]
        Inactive,
        
        [Description("")]
        Undefined
    }
}