using Dev.Acadmy.Dtos.Response.Courses;
using System;
using System.Collections.Generic;


namespace Dev.Acadmy.Dtos.Response.Teachers
{
    public class TeacherWithCoursesDto : TeacherTopDto
    {
        public int TotalCourses { get; set; }
        public int TotalStudents { get; set; }
        public List<CourseInfoTeacherDto> Courses { get; set; } = new List<CourseInfoTeacherDto>();
    }

}
