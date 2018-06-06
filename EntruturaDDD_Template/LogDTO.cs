using System;
using System.Collections.Generic;
using System.Text;

namespace EntruturaDDD_Template.Cross.DTO
{
    public class LogDTO : EntityDTO, IEntityDTO
    {
        public string Descricao { get; set; }
    }
}
