using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Domain {
    public class RegistrationState {

        public bool RegistrationOpen { get; set; }
        public int VacantPositionCount { get; set; }

        private List<Participant> participants;
        public List<Participant> Participants {

            get {
                if(this.participants == null) 
                    return new List<Participant>();
                else
                    return this.participants;
            }

            set {
                participants = value;
            }

        }
    }
}
