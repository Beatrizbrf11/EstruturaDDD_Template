using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Domain.Entities
{
    public class Log : Entity , IEntity
    {
        public string Detalhe { get; set; }
    }
}
