using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Domain {
    public class Participant {

        public Guid AccountId { get; set; }
        public bool IsActive { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

    }
}
