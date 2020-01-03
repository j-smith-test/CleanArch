using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using ClearArch.Infrastructure.Data.Context;

namespace ClearArch.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {

        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
