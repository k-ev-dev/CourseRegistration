namespace CourseRegistration.Domain {
    public class CourseRegistration {

        public Guid CourseId { get; set; }
        public bool CourseRegistrationOpen { get; set; }

        public DateTime RegistrationStartDate { get; set; }
        public DateTime RegistrationEndDate { get; set; }

        public List<RegistrationState> RegistrationState { get; set; }

    }
}