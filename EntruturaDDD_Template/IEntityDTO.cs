using System;

namespace EntruturaDDD_Template
{
    public interface IEntityDTO
    {
        int Id { get; set; }
        string CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        string UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
        bool Active { get; set; }
    }
}
