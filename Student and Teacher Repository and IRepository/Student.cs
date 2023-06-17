
using System.Collections.Generic;
using System.Xml.Linq;
namespace Student_and_Teacher_Repository_and_IRepository
{
    public class Student :Entity

    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }



        private Student()
        {

            FirstName = null;
            LastName = null;

        }



        private void ValidateLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException(nameof(lastName));
            if (lastName.Length > 133) throw new ArgumentException("");
        }

        private void ValidateFirstName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentNullException(nameof(fullName));
            if (fullName.Length > 133) throw new ArgumentException("");
        }

        public Student(string firstName, string lastName)
        {

            ValidateFirstName(firstName);
            ValidateLastName(lastName);
            FirstName = firstName;
            LastName = lastName;

        }

        public void Update(string firstName, string lastName)
        {
            ValidateFirstName(firstName);
            ValidateLastName(lastName);
            FirstName = firstName;
            LastName = lastName;
        }


    }
}
        
    

