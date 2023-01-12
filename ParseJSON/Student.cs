using System.Collections.Generic;

namespace ParseJSON
{
    class Student 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public List<string> Hobbies { get; set; }
        public Gender gender { get; set; }

        public override string ToString()
        {
            return $"Student Data {{\n\tId: {Id}, \n\tName: {Name}, \n\tDegree: {Degree} \n\tHobbies: {{\n\t{string.Join(", " ,Hobbies.ToArray())}\n\t}} \n\t{gender.ToString()}\n}}";
        }
    }

    class Gender 
    {
        public bool IsTrans { get; set; }
        public bool IsMale { get; set; }
        public bool IsFemale { get; set; }

        public override string ToString()
        {
            return $"Gender: {{\n\tIsTrans: {IsTrans}, \n\tIsMale: {IsMale}, \n\tIsFemale: {IsFemale}\n\t}}";
        }
    }
   
}
