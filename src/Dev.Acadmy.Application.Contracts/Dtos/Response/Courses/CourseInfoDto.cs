using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Dev.Acadmy.Dtos.Response.Courses
{
    public class CourseInfoDto : EntityDto<Guid>
    {
        public string CourseName { get; set; }
        public string SubjectName { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; }
        public string CourseImage { get; set; }
    }
}
