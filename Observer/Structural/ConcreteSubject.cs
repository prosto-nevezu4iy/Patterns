namespace Observer.Structural
{
    public class ConcreteSubject : Subject
    {
        private string subjectState;
        // Gets or sets subject state
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}
