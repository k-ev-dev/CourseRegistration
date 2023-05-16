using CourseRegistration.Domain;
using CourseRegistration.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.Repository
{
    public class FlowRepository : IFlowRepository {

        private readonly DataContext context;

        public bool Add(Guid stateId, RegistrationFlow flow) {
            throw new NotImplementedException();
        }

        public bool Delete(Guid idFlow) {
            throw new NotImplementedException();
        }

        public IReadOnlyList<RegistrationFlow> GetAll() {
            throw new NotImplementedException();
        }

        public RegistrationFlow GetById(Guid idFlow) {
            throw new NotImplementedException();
        }

        public IReadOnlyList<RegistrationFlow> GetByName(string name) {
            throw new NotImplementedException();
        }

        public bool Update(RegistrationFlow flow) {
            throw new NotImplementedException();
        }
    }
}
