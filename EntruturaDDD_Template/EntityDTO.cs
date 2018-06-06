using System;
using System.Collections.Generic;
using System.Text;

namespace EntruturaDDD_Template.Cross.DTO
{
    public class EntityDTO
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool Active { get; set; }
    }
}
