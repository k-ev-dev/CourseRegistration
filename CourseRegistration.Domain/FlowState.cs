using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Domain {
    public class FlowState {

        public Guid FlowId { get; set; }
        public Guid StateId { get; set; }
        public RegistrationState RegistrationState { get; set; }
        public RegistrationFlow RegistrationFlow { get; set; }

    }
}
