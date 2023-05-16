using CourseRegistration.Domain;
using CourseRegistration.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.Repository
{
    internal class FlowRepository : IFlowRepository {

        private readonly DataContext context;

        public Task AddAsync(RegistrationFlow flow) {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid idFlow) {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<RegistrationFlow>> GetAllAsync() {
            throw new NotImplementedException();
        }

        public Task<RegistrationFlow> GetByIdAsync(Guid flow) {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<RegistrationFlow>> GetByName(string name) {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(RegistrationFlow flow) {
            throw new NotImplementedException();
        }
    }
}
