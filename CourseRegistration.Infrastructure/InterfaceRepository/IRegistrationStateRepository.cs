using CourseRegistration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.InterfaceRepository {
    internal interface IRegistrationStateRepository {
        public bool Add(Guid participantId, Guid flowId, RegistrationState state);
        public IReadOnlyList<RegistrationState> GetAll();
        public RegistrationState GetById(Guid idState);
        public IReadOnlyList<RegistrationState> GetByName(string name);
        public bool Update(RegistrationState state);
        public bool Delete(Guid idState);
    }
}
