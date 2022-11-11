using Microsoft.AspNetCore.Mvc;

namespace Demo_Asp.net_6_Web_API.Controllers
{
	[Route("api/controller")]
	[ApiController]
	public class DemoController : Controller
	{
		public static List<string> students = new List<string>();

		public DemoController()
		{
			if (students.Count == 0)
			{
				students.Add("ahmdad");
				students.Add("faisal");
				students.Add("waqas");
				students.Add("saad");
				students.Add("asad");

			}
		}

		/// GET Method

		[HttpGet]
		[Route("getallstudents")]
		public List<string> getallstudents()
		{
			return students;
		}

		/// Get Student by id

		[HttpGet]
		[Route("getstuentbyid")]
		public string getstudentbyid(int id)
		{
			if (id < 0 || id >= students.Count)
			{
				return ("Invalid Request");
			}

			return students[id];
		}

		// Post Method

		[HttpPost]
		[Route("addstudent")]
		public string addstudent(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return ("Invalid Request");
			}
			students.Add(name);
			return ("Added Successfully.");
		}


		// Delete Method
		[HttpDelete]
		[Route("deletestudent")]
		public string deletestudent(int index)
		{
			if (index < 0 || index >= students.Count)
			{
				return ("Invalid Request");
			}
			students.RemoveAt(index);
			return ("Remove Successfully.");
		}



		[HttpPut]
		[Route("updatename")]
		public string updatename(int index, string newname)
		{
			if (index < 0 || index >= students.Count)
			{
				return ("Invalid Request");
			}
			students[index] = newname;
			return ("Updated Successfully");
		}


	}
}
