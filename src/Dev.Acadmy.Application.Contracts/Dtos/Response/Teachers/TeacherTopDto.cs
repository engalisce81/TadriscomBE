using System;
using Volo.Abp.Application.Dtos;

namespace Dev.Acadmy.Dtos.Response.Teachers
{
    public class TeacherTopDto :EntityDto<Guid>
    {
        public string TeacherName { get; set; }
        public string TeacherImage { get; set; }
        public string SubjectName { get; set; }
        public double Rating { get; set; }
    }
}
