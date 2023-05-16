using CourseRegistration.Domain;
using CourseRegistration.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Infrastructure.Repository
{
    public class ParticipantRepository : IParticipantRepository {

        private readonly DataContext context;

        public bool Add(Guid stateId, Participant participant) {
            try {
                Participant tmp = context.Participants.Find(participant.Id);
                if (tmp != null)
                    throw new Exception("this object exists");

                var stateEntity = context.RegistrationStates.Where(a => a.Id == stateId).FirstOrDefault();

                var flowParticipant = new FlowParticipant() {
                    Participant = participant,
                    RegistrationState = stateEntity
                };

                context.Add(flowParticipant);

                context.Add(participant);

                context.SaveChanges();
                return true;
            }
            catch { 
                
                return false; 
            }
        }

        public bool Delete(Guid idParticipant) {
            try {
                var participant = GetById(idParticipant);
                context.Remove(participant);
                context.SaveChanges();
                return true;
            } catch { 

                return false; 
            }
        }

        public IReadOnlyList<Participant> GetAll() {
            return context.Participants.ToList();
        }

        public Participant GetById(Guid idParticipant) {
            Participant participant = context.Participants.Find(idParticipant);
            if (participant != null)
                throw new Exception("this object exists");

            return participant;
        }

        public IReadOnlyList<Participant> GetByName(string name) {
            var participants = context.Participants.Where(a => a.Name == name);
            return participants.ToList();
        }

        public bool Update(Participant participant) {
            try {
                context.Update(participant);
                context.SaveChanges();
                return true;
            }
            catch {

                return false;
            }
        }
    }
}
