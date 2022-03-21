namespace RenameField.Core
{
    public class JobRecord
    {
        private string _title;
        private string _company;

        public JobRecord(Job job)
        {
            Title = job.Title;
            Company = job.Company;
        }

        public string Title
        {
            get => _title;
            set { _title = value; }
        }

        public string Company
        {
            get => _company;
            set { _company = value; }
        }
    }
}