using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Domain {
    public class Participant {

        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        
        public ICollection<FlowParticipant> FlowParticipants { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public Guid ExternalAccountId { get; set; }
    }
}
