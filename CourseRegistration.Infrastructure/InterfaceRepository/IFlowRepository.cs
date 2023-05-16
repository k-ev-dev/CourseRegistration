using CourseRegistration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.InterfaceRepository {
    internal interface IFlowRepository {
        public Task AddAsync(RegistrationFlow flow);
        public Task<IReadOnlyList<RegistrationFlow>> GetAllAsync();
        public Task<RegistrationFlow> GetByIdAsync(Guid flow);
        public Task<IReadOnlyList<RegistrationFlow>> GetByName(string name);
        public Task UpdateAsync(RegistrationFlow flow);
        public Task DeleteAsync(Guid idFlow);
    }
}
