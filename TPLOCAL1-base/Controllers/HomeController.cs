﻿using Microsoft.AspNetCore.Mvc;
using TPLOCAL1.Models;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        //methode "naturally" call by router
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //retourn to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "OpinionList":

                        var opinionReader = new OpinionList();

                       
                        string xmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "XlmFile", "DataAvis.xml"); 
                        List<Opinion> avisList = opinionReader.GetAvis(xmlFilePath);

                        return View("ListeAvis", avisList);

                    case "Form":
                        return View("Form", new FormModel());
                    default:
                        //retourn to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }


        //methode to send datas from form to validation page
        [HttpPost]
        public ActionResult ValidationFormulaire(FormModel model) 
        {
            if (!ModelState.IsValid)
            {
                return View("Form", model);
            }

            return View("Validation", model);
        }
    }
}