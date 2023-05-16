namespace CourseRegistration.Domain {
    public class RegistrationFlow {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool CourseRegistrationOpen { get; set; }

        public DateTime RegistrationStartDate { get; set; }
        public DateTime RegistrationEndDate { get; set; }

        public ICollection<FlowState> FlowStates { get; set; }

        public Guid ExternalCourseId { get; set; }
    }
}