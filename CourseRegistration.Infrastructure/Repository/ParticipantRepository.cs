using CourseRegistration.Domain;
using CourseRegistration.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.Repository
{
    internal class ParticipantRepository : IParticipantRepository {

        private readonly DataContext context;

        public Task AddAsync(Participant participant) {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid idParticipant) {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Participant>> GetAllAsync() {
            throw new NotImplementedException();
        }

        public Task<Participant> GetByIdAsync(Guid idParticipant) {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Participant>> GetByName(string name) {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Participant participant) {
            throw new NotImplementedException();
        }
    }
}
