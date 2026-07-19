using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_Midterm_A1_Rollano_Kristopher.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Footer();
            ViewData["Name"] = "Kristopher Rj L. Rollano";
            ViewData["Position"] = "Aspiring Software Web Developer";
            ViewData["Description"] =
                "Welcome to my professional portfolio.";

            return View();
        }

        public IActionResult About()
        {
            Footer();
            ViewData["Title"] = "About Me";

            ViewData["Biography"] =
                "I am a student at Lyceum of Alabang pursuing a Bachelor of Science in Information Technology. Throughout my academic journey, I have focused on object-oriented programming, database management, and web application development using ASP.NET Core MVC.";

            ViewData["Goals"] =
                "My goal is to become a professional full-stack software developer. I enjoy building responsive web applications, learning new technologies, solving programming challenges, and continuously improving my software development skills.";

            return View();
        }

        public IActionResult Skills()
        {
            Footer();
            ViewData["Title"] = "Technical Skills";

            ViewData["Description"] =
                "A collection of programming languages, web technologies, databases, and development tools that I use to build responsive and reliable software applications.";

            ViewData["ProgrammingTitle"] = "Programming";

            ViewData["ProgrammingDescription"] =
                "Developing desktop and backend applications using object-oriented programming principles.";

            ViewData["WebTitle"] = "Web Development";

            ViewData["WebDescription"] =
                "Building responsive and interactive web applications using modern frontend technologies.";

            ViewData["DatabaseTitle"] = "Database";

            ViewData["DatabaseDescription"] =
                "Designing, managing, and querying relational databases for software applications.";

            ViewData["ToolsTitle"] = "Development Tools";

            ViewData["ToolsDescription"] =
                "Using professional software development tools for coding, debugging, version control, and collaboration.";

            return View();
        }

        public IActionResult Projects()
        {
            Footer();
            ViewData["Title"] = "Projects Portfolio";

            ViewData["Description"] =
                "Demonstrated repository configurations highlighting my coding structure and architecture implementations.";

            // Project 1
            ViewData["Project1Name"] = "FizzBuzz Application";
            ViewData["Project1Description"] = "A clean implementation logic project executing iterative problem sets.";
            ViewData["Project1Tech"] = "C# Core";
            ViewData["Project1Link"] = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_A1_Rollano_Kristopher-Rj.git";

            // Project 2
            ViewData["Project2Name"] = "Console Calculator";
            ViewData["Project2Description"] = "Mathematical processing application parsing conditions and basic operations.";
            ViewData["Project2Tech"] = "C#";
            ViewData["Project2Link"] = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_A2_Rollano_Kristopher-Rj.git";

            // Project 3
            ViewData["Project3Name"] = "Student Management";
            ViewData["Project3Description"] = "A workflow tracking system managing object collections and persistent records.";
            ViewData["Project3Tech"] = "C# Data Layers";
            ViewData["Project3Link"] = "https://github.com/RollanoKristopher/BSIT31E1_Prelim_H1_Rollano_Kristopher-Rj.git";

            // Project 4
            ViewData["Project4Name"] = "File Ingestion Engine";
            ViewData["Project4Description"] = "High-performance data stream parsing engine sorting document objects dynamically.";
            ViewData["Project4Tech"] = "C# IO Streams";
            ViewData["Project4Link"] = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_H2_Rollano_KristopherRj.git";

            // Project 5
            ViewData["Project5Name"] = "Custom HTTP System";
            ViewData["Project5Description"] = "Low-level network client and socket listener simulated to handle request calls.";
            ViewData["Project5Tech"] = "C# Networking";
            ViewData["Project5Link"] = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_A3_Rollano_Kristopher-Rj.git";

            // Project 6
            ViewData["Project6Name"] = "Transport Resolver";
            ViewData["Project6Description"] = "Algorithm challenge mapping optimized route calculations and node pathways.";
            ViewData["Project6Tech"] = "Data Structures";
            ViewData["Project6Link"] = "https://github.com/RollanoKristopher/BSIT_31E1_PRELIM_Q1_Rollano_Kristopher_Rj.git";

            return View();
        }

        public IActionResult Contact()
        {
            Footer();
            ViewData["Title"] = "Contact Me";

            ViewData["Description"] =
                "Feel free to connect with me directly through my email, mobile number, or GitHub profile.";

            ViewData["Email"] = "kristopherrjrollano@gmail.com";
            ViewData["Phone"] = "0991-402-6896";
            ViewData["GitHubName"] = "github.com/RollanoKristopher";
            ViewData["GitHubLink"] = "https://github.com/RollanoKristopher";
            ViewData["Resume"] = "~/files/Kristopher_Rollano_Resume.pdf";

            return View();
        }

         private void Footer()
        {
            ViewData["Location"] = "Lyceum of Alabang, Muntinlupa City";

            ViewData["Facebook"] = "https://www.facebook.com/";

            ViewData["GitHub"] = "https://github.com/RollanoKristopher";

            ViewData["Microsoft"] = "https://www.microsoft.com/";

            ViewData["LinkedIn"] = "https://www.linkedin.com/";

            ViewData["DevFocus"] =
                "Focused on ASP.NET Core MVC, C#, Bootstrap, SQL Server, and modern web application development.";

            ViewData["Copyright"] =
                "© 2026 Kristopher Rj L. Rollano. All Rights Reserved.";
        }
    }
}