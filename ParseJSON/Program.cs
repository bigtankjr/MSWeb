using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ParseJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() 
            {
                Id=1,
                Name="Balaji",
                Degree="MCA",
                Hobbies = new List<string>() 
                {
                    "Reading",
                    "Playing Games"
                },
                gender = new Gender 
                {
                    IsMale = true,
                    IsFemale = false,
                    IsTrans = false
                }
                
            };
            var filePath = @"C:\Temp\student.json";

            var studentString = JsonConvert.SerializeObject(student);
            File.WriteAllText(filePath, studentString);

            studentString = string.Empty;

            studentString = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<Student>(studentString);

            Console.WriteLine(result.ToString());
            
        }
    }
}
