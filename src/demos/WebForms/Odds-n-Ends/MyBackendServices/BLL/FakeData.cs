using Humanizer;
using MyBackendServices.Data;
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
        private static Random _rnd = new Random();

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CourseMarks> ListCourseMarks()
        {
            // For Faking some back-end exception
            if (_rnd.Next(10) > 7)
                throw new Exception($"Fake Data Exception in {nameof(ListCourseMarks)}. Nothing to be alarmed about. Refresh the page and all should be fine....");
            List<CourseMarks> result = new List<CourseMarks>();

            // TODO: Add some data
            result.Add(new CourseMarks { Number = "PROG-0101", Name = "Programming Fundamentals", ProgramId = 1, Credits = 4.5, FinalMark = 80 });
            result.Add(new CourseMarks { Number = "DATA-1508", Name = "Practical Database Fundamentals", ProgramId = 1, Credits = 4.5, FinalMark = 72 });
            result.Add(new CourseMarks { Number = "PROG-1022", Name = "Intro to Systems Analysis", ProgramId = 2, Credits = 4.5, FinalMark = 64 });
            result.Add(new CourseMarks { Number = "HACK-0101", Name = "Hacking Fundamentals", ProgramId = 3, Credits = 4.5, FinalMark = 71 });
            result.Add(new CourseMarks { Number = "HACK-1212", Name = "Shell Access Control", ProgramId = 3, Credits = 4.5, FinalMark = 68 });
            result.Add(new CourseMarks { Number = "HACK-0100", Name = "White Hat/Black Hat History", ProgramId = 3, Credits = 4.5, FinalMark = 0 });
            result.Add(new CourseMarks { Number = "PROG-1504", Name = "API Development", ProgramId = 1, Credits = 3 });
            result.Add(new CourseMarks { Number = "HACK-1021", Name = "Website Security", ProgramId = 3, Credits = 3 });
            result.Add(new CourseMarks { Number = "HACK-2007", Name = "Network Security", ProgramId = 3, Credits = 3 });
            result.Add(new CourseMarks { Number = "PROG-2008", Name = "Domain Driven Design", ProgramId = 1, Credits = 3 });
            result.Add(new CourseMarks { Number = "PROG-2104", Name = "Building Distributed Systems", ProgramId = 1, Credits = 3 });
            result.Add(new CourseMarks { Number = "HACK-1010", Name = "OWASP Top Ten", ProgramId = 3, Credits = 3 });
            result.Add(new CourseMarks { Number = "PROG-2001", Name = "Event Sourcing", ProgramId = 1, Credits = 3 });
            result.Add(new CourseMarks { Number = "DATA-2012", Name = "Database Security", ProgramId = 3, Credits = 3 });
            result.Add(new CourseMarks { Number = "NCC-1701", Name = "Starship Security Systems", ProgramId = 3, Credits = 3 });
            //result.Add(new CourseMarks { Number = "", Name = "", Credits = 4.5, FinalMark = 0 });

            return result;
        }
        public List<CourseMarks> ListCourseMarks(int programId)
        {
            var result = ListCourseMarks();
            if (programId == 0)
                return result;
            return result.Where(x => x.ProgramId == programId).ToList();
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

        public List<Fish> ListFishThings()
        {
            using(var context = new DAL.AquamanContext())
            {
                return context.SlimeyThings.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Number> GetSomeNumbers()
        {
            return Enumerable.Range(1, 5).Select(x => new Number { Value = x  }).ToList();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Number> GetMultiplesOfSomeNumber(int number)
        {
            if(number > 0)
                return Enumerable.Range(1, 7).Select(x => new Number { Value = x * number }).ToList();
            return new List<Number>();
        }
    }

    public class Number
    {
        public int Value { get; set; }
        public string Name
        {
            get
            {
                return Value.ToOrdinalWords();
            }
        }
    }

    public class CourseMarks
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public double Credits { get; set; }
        public int? FinalMark { get; set; }
        public int ProgramId { get; set; }
    }

    public class StudyProgram
    {
        public int ProgramId { get; set; }
        public string Name { get; set; }
    }
}
