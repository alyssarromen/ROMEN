using Microsoft.AspNetCore.Mvc;
using RomenITELEC1C.Models;

namespace RomenITELEC1C.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        StudentModel st = new StudentModel();
        st.StudentId = 2021160625;
        st.StudentName = "Alyssa Marie R. Romen";
        st.DateEnrolled = DateTime.Parse("29/07/2023");
        st.StudentCourse = Course.BSIT;
        st.Email = "alyssamarie.romen.cics@ust.edu.ph";

        ViewBag.StudentModel = st;
        return View();
    }
}
