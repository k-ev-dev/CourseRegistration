using CourseRegistration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.InterfaceRepository {
    public interface IFlowRepository {
        public bool Add(Guid stateId, RegistrationFlow flow);
        public IReadOnlyList<RegistrationFlow> GetAll();
        public RegistrationFlow GetById(Guid idFlow);
        public IReadOnlyList<RegistrationFlow> GetByName(string name);
        public bool Update(RegistrationFlow flow);
        public bool Delete(Guid idFlow); 
    }
}
