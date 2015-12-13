using HRM.DAL.Entities;
using HRM.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.BLL.Services
{
    public class StatusService
    {
        private readonly StatusRepository statusRepository;
        public StatusService(StatusRepository statusRepository)
        {
            this.statusRepository = statusRepository;
        }

        public IEnumerable<StatusType> GetAll()
        {
            return this.statusRepository.GetAll();
        }
    }
}
