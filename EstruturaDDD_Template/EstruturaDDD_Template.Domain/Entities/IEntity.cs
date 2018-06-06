using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Domain.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        string CreatedBy { get; set; }
        DateTime? CreatedOn { get; set; }
        string UpdatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
        bool Active { get; set; }
    }
}
