using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBackendServices.BLL
{
    [DataObject]
    public class FakeData
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CourseMarks> ListCourseMarks()
        {
            List<CourseMarks> result = new List<CourseMarks>();

            // TODO: Add some data
            result.Add(new CourseMarks { Number = "PROG-0101", Name = "Programming Fundamentals", ProgramId = 1, Credits = 4.5, FinalMark = 80 });
            result.Add(new CourseMarks { Number = "PROG-1508", Name = "Practical Database Fundamentals", ProgramId = 1, Credits = 4.5, FinalMark = 72 });
            result.Add(new CourseMarks { Number = "PROG-1022", Name = "Intro to Systems Analysis", ProgramId = 2, Credits = 4.5, FinalMark = 64 });
            result.Add(new CourseMarks { Number = "HACK-0101", Name = "Hacking Fundamentals", ProgramId = 3, Credits = 4.5, FinalMark = 71 });
            result.Add(new CourseMarks { Number = "HACK-1212", Name = "Shell Access Control", ProgramId = 3, Credits = 4.5, FinalMark = 68 });
            result.Add(new CourseMarks { Number = "HACK-0100", Name = "White Hat/Black Hat History", ProgramId = 3, Credits = 4.5, FinalMark = 0 });
            //result.Add(new CourseMarks { Number = "", Name = "", Credits = 4.5, FinalMark = 0 });

            return result;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<StudyProgram> ListStudyPrograms()
        {
            List<StudyProgram> result = new List<StudyProgram>();

            result.Add(new StudyProgram { ProgramId = 1, Name = "Software Development" });
            result.Add(new StudyProgram { ProgramId = 2, Name = "Analysis" });
            result.Add(new StudyProgram { ProgramId = 3, Name = "Cyberdefense" });

            return result;
        }
    }

    public class CourseMarks
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public double Credits { get; set; }
        public int FinalMark { get; set; }
        public int ProgramId { get; set; }
    }

    public class StudyProgram
    {
        public int ProgramId { get; set; }
        public string Name { get; set; }
    }
}
