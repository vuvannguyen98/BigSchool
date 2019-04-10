using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

        [Required(ErrorMessage = "Địa điểm -- không được để trống")]
        public string Place { get; set; }

        [Required(ErrorMessage = "Ngày -- không được để trống")]
        [FutureDate(ErrorMessage = "Ngày tháng năm phải lớn hơn ngày tháng năm ở hiện tại")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Thời gian -- không được để trống")]
        [ValidTime(ErrorMessage = "Định dạng sai (hh:mm)")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn -- Thể loại")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}