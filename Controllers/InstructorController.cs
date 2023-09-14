using Microsoft.AspNetCore.Mvc;
using RomenITELEC1C.Models;

namespace RomenITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
        {
            new Instructor()
            {
                InstructorId=1, InstructorFirstName = "Gabriel", InstructorLastName = "Montano", IsTenured= true,
                InstructorEmail ="gabrielmontano@ust.edu.ph", Rank = Rank.Instructor, DateHired = DateTime.Now
            },
            new Instructor()
            {
                InstructorId=2, InstructorFirstName = "Goldie", InstructorLastName = "Pare", IsTenured= true,
                InstructorEmail ="goldiemay@ust.edu.ph", Rank = Rank.AssistProf, DateHired = DateTime.Parse("28/09/2022")            },
            new Instructor()
            {
                InstructorId=3, InstructorFirstName = "Ashley", InstructorLastName = "Santos", IsTenured= true,
                InstructorEmail ="alyssamarie@ust.edu.ph", Rank = Rank.Prof, DateHired = DateTime.Parse("28/07/2022")
            }
        };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            //Search for the student whose id matches the given id
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (instructor != null)//was an instructor found?
                return View(instructor);

            return NotFound();
        }
    }
}

