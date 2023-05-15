using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Domain {
    public class FlowParticipant {

        public Guid ParticipantId { get; set; }
        public Guid StateId { get; set; }
        public Participant Participant { get; set; }
        public RegistrationState RegistrationState { get; set; }

    }
}
