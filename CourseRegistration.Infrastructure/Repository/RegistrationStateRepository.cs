using CourseRegistration.Domain;
using CourseRegistration.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.Repository
{
    internal class RegistrationStateRepository : IRegistrationStateRepository {

        private readonly DataContext context;

        public Task AddAsync(RegistrationState state) {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid idState) {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<RegistrationState>> GetAllAsync() {
            throw new NotImplementedException();
        }

        public Task<RegistrationState> GetByIdAsync(Guid idState) {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<RegistrationState>> GetByName(string name) {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(RegistrationState state) {
            throw new NotImplementedException();
        }
    }
}
