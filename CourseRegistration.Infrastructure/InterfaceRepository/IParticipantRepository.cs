using CourseRegistration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.InterfaceRepository {
    internal interface IParticipantRepository {
        public Task AddAsync(Participant participant);
        public Task<IReadOnlyList<Participant>> GetAllAsync();
        public Task<Participant> GetByIdAsync(Guid idParticipant);
        public Task<IReadOnlyList<Participant>> GetByName(string name);
        public Task UpdateAsync(Participant participant);
        public Task DeleteAsync(Guid idParticipant);
    }
}
