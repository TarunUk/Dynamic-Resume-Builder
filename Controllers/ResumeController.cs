using Microsoft.AspNetCore.Mvc;
using Resume_Builder.Models;

namespace Resume_Builder.Controllers
{
    public class ResumeController : Controller
    {
        // GET: /Resume/Build
        public IActionResult Build()
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            return View(model);
        }

        // POST: /Resume/SavePersonal
        [HttpPost]
        public IActionResult SavePersonal(PersonalInfo info)
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            model.Personal = info;
            HttpContext.Session.SetObjectAsJson("Resume", model);
            return RedirectToAction("Experience");
        }

        // GET: /Resume/Experience
        public IActionResult Experience()
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            return View(model);
        }

        // POST: /Resume/SaveExperience
        [HttpPost]
        public IActionResult SaveExperience(ResumeModel form)
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            model.WorkExperiences = form.WorkExperiences ?? new List<WorkExperience>();
            HttpContext.Session.SetObjectAsJson("Resume", model);
            return RedirectToAction("Education");
        }

        // GET: /Resume/Education
        public IActionResult Education()
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            return View(model);
        }

        // POST: /Resume/SaveEducation
        [HttpPost]
        public IActionResult SaveEducation(ResumeModel form)
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            model.Educations = form.Educations ?? new List<Education>();
            HttpContext.Session.SetObjectAsJson("Resume", model);
            return RedirectToAction("Skills");
        }

        // GET: /Resume/Skills
        public IActionResult Skills()
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            return View(model);
        }

        // POST: /Resume/SaveSkills
        [HttpPost]
        public IActionResult SaveSkills(string skillsInput)
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            model.Skills = skillsInput?
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrEmpty(s))
                .ToList() ?? new List<string>();
            HttpContext.Session.SetObjectAsJson("Resume", model);
            return RedirectToAction("Projects");
        }

        // GET: /Resume/Projects
        public IActionResult Projects()
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            return View(model);
        }

        // POST: /Resume/SaveProjects
        [HttpPost]
        public IActionResult SaveProjects(ResumeModel form)
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            model.Projects = form.Projects ?? new List<Project>();
            HttpContext.Session.SetObjectAsJson("Resume", model);
            return RedirectToAction("Certifications");
        }


        // GET: /Resume/Certifications
        public IActionResult Certifications()
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            return View(model);
        }

        // POST: /Resume/SaveCertifications
        [HttpPost]
        public IActionResult SaveCertifications(ResumeModel form)
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            model.Certifications = form.Certifications ?? new List<Certification>();
            HttpContext.Session.SetObjectAsJson("Resume", model);
            return RedirectToAction("Languages");
        }


        // GET: /Resume/Languages
        public IActionResult Languages()
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            return View(model);
        }

        // POST: /Resume/SaveLanguages
        [HttpPost]
        public IActionResult SaveLanguages(ResumeModel form)
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            model.Languages = form.Languages ?? new List<Language>();
            HttpContext.Session.SetObjectAsJson("Resume", model);
            return RedirectToAction("Template");
        }

        // GET: /Resume/Template
        public IActionResult Template()
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            return View(model);
        }

        // POST: /Resume/SaveTemplate
        [HttpPost]
        public IActionResult SaveTemplate(string selectedTemplate)
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            model.SelectedTemplate = selectedTemplate;
            HttpContext.Session.SetObjectAsJson("Resume", model);
            return RedirectToAction("Preview");
        }


        // GET: /Resume/Preview
        public IActionResult Preview()
        {
            var model = HttpContext.Session.GetObjectFromJson<ResumeModel>("Resume")
                        ?? new ResumeModel();
            return View(model);
        }
    }
}