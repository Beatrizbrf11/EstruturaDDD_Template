using EntruturaDDD_Template.Cross.DTO;
using EstruturaDDD_Template.Domain.Entities;
using EstruturaDDD_Template.Domain.Interface.Repository;
using EstruturaDDD_Template.Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstruturaDDD_Template.Domain.Service
{
    public class LogService : BaseService<Log,LogDTO> , ILogService
    {
        private readonly ILogRepository _repository;

        public LogService(ILogRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
