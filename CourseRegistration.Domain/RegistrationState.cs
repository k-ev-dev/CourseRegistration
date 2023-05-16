using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Domain {
    public class RegistrationState {

        public Guid Id{ get; set; }
        public string Description { get; set; }
        public bool RegistrationOpen { get; set; }
        public int VacantPositionCount { get; set; }

        public ICollection<FlowParticipant> FlowParticipants { get; set; }
        public ICollection<FlowState> FlowStates { get; set; }

    }
}
