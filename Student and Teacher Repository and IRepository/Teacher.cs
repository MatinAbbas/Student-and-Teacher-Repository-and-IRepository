using System.Collections.Generic;
using System.Xml.Linq;

namespace Student_and_Teacher_Repository_and_IRepository
{ 





    public class Teacher : Entity
{
    public string ?FirstName { get; private set; }
    public string ?LastName { get; private set; }
    //private List<Skill> _skills = new List<Skill>();
    // public IReadOnlyList<Skill> Skills => _skills.AsReadOnly();

    private Teacher()
    {
        //For ef
        FirstName = null;
        LastName = null;

    }

    //private void ValidateSkills(List<Skill> skills)
    //{
    //    if (skills == null)
    //        throw new ArgumentNullException(nameof(skills));
    //    if (skills.GroupBy(skill => skill.Id).Any(x => x.Count() > 1))
    //        throw new ArgumentException(nameof(skills) + " has repetitive skill");
    //}

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

    public Teacher(string firstName, string lastName)
    {
        // TODO validate with saeed
        ValidateFirstName(firstName);
        ValidateLastName(lastName);

        FirstName = firstName;
        LastName = lastName;
    }

    public void Update(string firstName, string lastName)
    {
        ValidateFirstName(firstName);
        ValidateLastName(lastName);
        // TODO validate with saeed
        FirstName = firstName;
        LastName = lastName;
    }

    //public void AddSkill(Skill skill)
    //{
    //    if (_skills.Contains(skill))
    //        return;

    //    _skills.Add(skill);
    //}

    //public void RemoveSkill(Skill skill)
    //{
    //    _skills.Remove(skill);
    //}

} }

