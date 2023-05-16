using CourseRegistration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.InterfaceRepository {
    internal interface IParticipantRepository {
        public bool Add(Guid participantId, Participant participant);
        public IReadOnlyList<Participant> GetAll();
        public Participant GetById(Guid idParticipant);
        public IReadOnlyList<Participant> GetByName(string name);
        public bool Update(Participant participant);
        public bool Delete(Guid idParticipant);
    }
}
