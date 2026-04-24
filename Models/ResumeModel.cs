namespace Resume_Builder.Models
{
    public class ResumeModel
    {
        public PersonalInfo Personal { get; set; } = new();
        public List<WorkExperience> WorkExperiences { get; set; } = new();
        public List<Education> Educations { get; set; } = new();
        public List<string> Skills { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
        public List<Certification> Certifications { get; set; } = new();
        public List<Language> Languages { get; set; } = new();
        public string SelectedTemplate { get; set; } = "ModernProfessional";
    }

    public class PersonalInfo
    {
        public string FullName { get; set; } = "";
        public string ProfessionalTitle { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Location { get; set; } = "";
        public string LinkedIn { get; set; } = "";
        public string Summary { get; set; } = "";
        public string ProfilePhotoBase64 { get; set; } = "";
    }

    public class WorkExperience
    {
        public string JobTitle { get; set; } = "";
        public string Company { get; set; } = "";
        public string StartDate { get; set; } = "";
        public string EndDate { get; set; } = "";
        public bool IsCurrentJob { get; set; } = false;
        public string Description { get; set; } = "";
    }

    public class Education
    {
        public string Degree { get; set; } = "";
        public string School { get; set; } = "";
        public string FieldOfStudy { get; set; } = "";
        public string StartYear { get; set; } = "";
        public string EndYear { get; set; } = "";
        public string Grade { get; set; } = "";
    }

    public class Project
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string TechStack { get; set; } = "";
        public string Link { get; set; } = "";
    }

    public class Certification
    {
        public string Name { get; set; } = "";
        public string IssuedBy { get; set; } = "";
        public string Year { get; set; } = "";
    }

    public class Language
    {
        public string Name { get; set; } = "";
        public string Proficiency { get; set; } = "Fluent";
    }
}