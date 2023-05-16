using CourseRegistration.Domain;
using CourseRegistration.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.Repository
{
    public class RegistrationStateRepository : IRegistrationStateRepository {

        public readonly DataContext context;

        public bool Add(Guid participantId, Guid flowId, RegistrationState state) {
            throw new NotImplementedException();
        }

        public bool Delete(Guid idState) {
            throw new NotImplementedException();
        }

        public IReadOnlyList<RegistrationState> GetAll() {
            throw new NotImplementedException();
        }

        public RegistrationState GetById(Guid idState) {
            throw new NotImplementedException();
        }

        public IReadOnlyList<RegistrationState> GetByName(string name) {
            throw new NotImplementedException();
        }

        public bool Update(RegistrationState state) {
            throw new NotImplementedException();
        }
    }
}
