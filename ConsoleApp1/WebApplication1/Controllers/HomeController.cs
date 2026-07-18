using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ViewData["SiteName"] = "Shyke Portfolio";
            ViewData["Footer"] = "© 2026 All Rights Reserved";
            base.OnActionExecuting(context);
        }
    

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Index()
    {
        ViewData["Title"] = "Home";

        return View();
    }
    public IActionResult About()
    {
        ViewData["Title"] = "About Me";

        ViewData["BioTitle"] = "Biography & Education";
        ViewData["BioContent"] = "I am a student at Lyceum of Alabang pursuing a Bachelor of Science degree in Information Technology. Throughout my academic journey, I have focused heavily on object-oriented programming methodologies and web architectures. I thoroughly enjoy creating responsive web applications and discovering modern frontend libraries.";

        ViewData["GoalTitle"] = "Career Goals & Interests";
        ViewData["GoalContent"] = "My core ambition is to establish myself as a professional full-stack software developer, contributing to high-performance enterprise applications. Outside of my formal development studies, I stay involved in tech trends by exploring automated tools, debugging legacy frameworks, and playing competitive video games.";

        return View();
    }

    public IActionResult Skills()
    {
        ViewData["Title"] = "Skills";

        ViewData["SectionTitle"] = "Technical Skills";
        ViewData["SectionDesc"] = "A summary of core technologies, tools, and platforms I work with.";

        ViewData["ProgTitle"] = "Programming";
        ViewData["ProgContent"] = "C#, VB.NET, Python";

        ViewData["WebTitle"] = "Web";
        ViewData["WebContent"] = "HTML, CSS, JavaScript, Bootstrap, W3.CSS";

        ViewData["DbTitle"] = "Database";
        ViewData["DbContent"] = "MySQL, MS Access, SQL Server, XAMPP";

        ViewData["ToolsTitle"] = "Tools";
        ViewData["ToolsContent"] = "Visual Studio 2026 / 2022, VS Code, GitHub";

        return View();
    }

    public IActionResult Projects()
    {
        ViewData["Title"] = "Projects";

        // Section Header
        ViewData["SectionTitle"] = "Projects Portfolio";
        ViewData["SectionDesc"] = "Demonstrated repository configurations highlighting my coding structure and architecture implementations.";

        // Project 1
        ViewData["P1_Title"] = "FizzBuzz Application";
        ViewData["P1_Desc"] = "A clean implementation logic project executing iterative problem sets.";
        ViewData["P1_Tech"] = "C# Core";
        ViewData["P1_Img"] = "~/images/projects/Fizzbuzz.png";
        ViewData["P1_Link"] = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_A1_Rollano_Kristopher-Rj.git";

        // Project 2
        ViewData["P2_Title"] = "Console Calculator";
        ViewData["P2_Desc"] = "Mathematical processing application parsing conditions and basic operations cleanly.";
        ViewData["P2_Tech"] = "C#";
        ViewData["P2_Img"] = "~/images/projects/Calculator.png";
        ViewData["P2_Link"] = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_A2_Rollano_Kristopher-Rj.git";

        // Project 3
        ViewData["P3_Title"] = "Student Management";
        ViewData["P3_Desc"] = "A workflow tracking system managing object collections and persistent records securely.";
        ViewData["P3_Tech"] = "C# Data Layers";
        ViewData["P3_Img"] = "~/images/projects/SMS.png";
        ViewData["P3_Link"] = "https://github.com/RollanoKristopher/BSIT31E1_Prelim_H1_Rollano_Kristopher-Rj.git";

        // Project 4
        ViewData["P4_Title"] = "File Ingestion Engine";
        ViewData["P4_Desc"] = "High-performance data stream parsing engine sorting document objects dynamically.";
        ViewData["P4_Tech"] = "C# IO Streams";
        ViewData["P4_Img"] = "~/images/projects/File Ingestion Engine.png";
        ViewData["P4_Link"] = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_H2_Rollano_KristopherRj.git";

        // Project 5
        ViewData["P5_Title"] = "Custom HTTP System";
        ViewData["P5_Desc"] = "Low-level network client and socket listener simulated to handle discrete request calls.";
        ViewData["P5_Tech"] = "C# Networking";
        ViewData["P5_Img"] = "~/images/projects/HttpServer and Client.png";
        ViewData["P5_Link"] = "https://github.com/RollanoKristopher/BSIT31E1_PRELIM_A3_Rollano_Kristopher-Rj.git";

        // Project 6
        ViewData["P6_Title"] = "Transport Resolver";
        ViewData["P6_Desc"] = "Algorithm challenge mapping optimized route calculations and node pathways.";
        ViewData["P6_Tech"] = "Data Structures";
        ViewData["P6_Img"] = "~/images/projects/Transport Resolver Challenge.png";
        ViewData["P6_Link"] = "https://github.com/RollanoKristopher/BSIT_31E1_PRELIM_Q1_Rollano_Kristopher_Rj.git";

        // Footer
        ViewData["Location"] = "834 Prk 6 San Roque San Pedro Laguna, Philippines, 4023";
        ViewData["GitHub"] = "https://github.com/RollanoKristopher";
        ViewData["DevFocus"] = "Building structured applications emphasizing software paradigms, MVC conventions, clean layouts, and comprehensive platform delivery.";
        ViewData["Copyright"] = "© Kristopher Rollano 2026";

        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Title"] = "Contact";

        ViewData["SectionTitle"] = "Contact";
        ViewData["SectionDesc"] = "Feel free to connect with me directly through my email or professional networking pipelines.";

        // Contact Details
        ViewData["Email"] = "kristopherrjrollano@gmail.com";
        ViewData["Phone"] = "0991-402-6896";
        ViewData["GitHub"] = "https://github.com/RollanoKristopher";

        return View();
    }


    public IActionResult Footer()
    {
        ViewData["Title"] = "Footer";

        // Location
        ViewData["Location"] = "834 Prk 6 San Roque San Pedro Laguna, Philippines, 4023";

        // Social Links
        ViewData["Facebook"] = "#!";
        ViewData["GitHub"] = "https://github.com/RollanoKristopher";
        ViewData["Microsoft"] = "#!";
        ViewData["LinkedIn"] = "#!";

        // Development Focus
        ViewData["DevFocus"] = "Building structured applications emphasizing software paradigms, MVC conventions, clean layouts, and comprehensive platform delivery.";

        // Copyright
        ViewData["Copyright"] = "© Kristopher Rollano 2026";

        return View();
    }

}