using CourseRegistration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.InterfaceRepository {
    internal interface IRegistrationStateRepository {
        public Task AddAsync(RegistrationState state);
        public Task<IReadOnlyList<RegistrationState>> GetAllAsync();
        public Task<RegistrationState> GetByIdAsync(Guid idState);
        public Task<IReadOnlyList<RegistrationState>> GetByName(string name);
        public Task UpdateAsync(RegistrationState state);
        public Task DeleteAsync(Guid idState);
    }
}
