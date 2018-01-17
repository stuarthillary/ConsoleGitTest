namespace ConsoleGitTest
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = "Worker" + firstName;
            LastName = lastName;
        }

        public bool IsManager { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string NickName { get; set; }

        public bool IsJester { get; set; }
    }
}
