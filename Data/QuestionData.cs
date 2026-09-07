using PrefinalExamMVC.Models;

namespace PrefinalExamMVC.Data;

/// <summary>
/// In-memory source of truth for all 20 Prefinal Exam items.
/// Each item was added incrementally (one item = one commit) while
/// answering the exam.
/// </summary>
public static class QuestionData
{
    public static List<QuestionAnswer> All { get; } = new()
    {
        new QuestionAnswer
        {
            Number = 1,
            Topic = "Relational Data Modeling & Model Binding",
            Question = "What is the main problem solved by using a database instead of an in-memory collection?",
            Choices = new Dictionary<string, string>
            {
                { "A", "It makes C# code shorter" },
                { "B", "It prevents the application from restarting" },
                { "C", "It allows data to persist after the application stops" },
                { "D", "It removes the need for MVC" }
            },
            CorrectLetter = "C",
            Rationale = "A database keeps data even after the app process ends; an in-memory collection is wiped on restart."
        },
        new QuestionAnswer
        {
            Number = 2,
            Topic = "Relational Data Modeling & Model Binding",
            Question = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
            Choices = new Dictionary<string, string>
            {
                { "A", "Code-First" },
                { "B", "Database-First" },
                { "C", "Model-First" },
                { "D", "Controller-First" }
            },
            CorrectLetter = "B",
            Rationale = "Database-First reverse-engineers models and a DbContext from an existing schema."
        },
        new QuestionAnswer
        {
            Number = 3,
            Topic = "Relational Data Modeling & Model Binding",
            Question = "What is the primary purpose of Entity Framework Core?",
            Choices = new Dictionary<string, string>
            {
                { "A", "To create HTML pages automatically" },
                { "B", "To replace the MVC Controller" },
                { "C", "To map objects in code to relational database data" },
                { "D", "To replace the C# compiler" }
            },
            CorrectLetter = "C",
            Rationale = "EF Core is an ORM: it maps C# objects to rows/tables in a relational database."
        },
        new QuestionAnswer
        {
            Number = 4,
            Topic = "Relational Data Modeling & Model Binding",
            Question = "Which EF Core component is primarily responsible for communicating with the database?",
            Choices = new Dictionary<string, string>
            {
                { "A", "DbContext" },
                { "B", "DbSetView" },
                { "C", "ControllerContext" },
                { "D", "RazorContext" }
            },
            CorrectLetter = "A",
            Rationale = "DbContext manages the connection, change tracking, and querying against the database."
        },
        new QuestionAnswer
        {
            Number = 5,
            Topic = "Relational Data Modeling & Model Binding",
            Question = "What does 'dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models' primarily do?",
            Choices = new Dictionary<string, string>
            {
                { "A", "Deletes the database" },
                { "B", "Creates a new MVC project" },
                { "C", "Generates EF Core models and a DbContext from an existing database" },
                { "D", "Starts the MVC application" }
            },
            CorrectLetter = "C",
            Rationale = "This is the Database-First scaffolding command; it reverse-engineers models/DbContext into the Models folder."
        },
        new QuestionAnswer
        {
            Number = 6,
            Topic = "Conceptual Data Architecture: ERD & Razor",
            Question = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
            Choices = new Dictionary<string, string>
            {
                { "A", "Program.cs only" },
                { "B", "appsettings.json" },
                { "C", "Index.cshtml" },
                { "D", "Student.cs" }
            },
            CorrectLetter = "B",
            Rationale = "Configuration values like connection strings live in appsettings.json and are read via configuration binding."
        },
        new QuestionAnswer
        {
            Number = 7,
            Topic = "Conceptual Data Architecture: ERD & Razor",
            Question = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
            Choices = new Dictionary<string, string>
            {
                { "A", "One-to-One" },
                { "B", "One-to-Many" },
                { "C", "Many-to-Many" },
                { "D", "Many-to-One only" }
            },
            CorrectLetter = "B",
            Rationale = "One Section maps to many Students, which is the definition of a one-to-many relationship."
        },
        new QuestionAnswer
        {
            Number = 8,
            Topic = "Conceptual Data Architecture: ERD & Razor",
            Question = "In 'public int SectionId { get; set; } / public Section Section { get; set; }', what is SectionId?",
            Choices = new Dictionary<string, string>
            {
                { "A", "Primary key of Student" },
                { "B", "Foreign key referencing Section" },
                { "C", "Navigation property" },
                { "D", "Database connection string" }
            },
            CorrectLetter = "B",
            Rationale = "SectionId is the scalar foreign key column pointing to the related Section row."
        },
        new QuestionAnswer
        {
            Number = 9,
            Topic = "Conceptual Data Architecture: ERD & Razor",
            Question = "What is the purpose of a navigation property such as 'public Section Section { get; set; }'?",
            Choices = new Dictionary<string, string>
            {
                { "A", "It stores the database password" },
                { "B", "It represents a relationship to another entity" },
                { "C", "It creates a new database" },
                { "D", "It validates the student's name" }
            },
            CorrectLetter = "B",
            Rationale = "Navigation properties let you traverse object relationships (e.g., Student.Section) instead of manually joining."
        },
        new QuestionAnswer
        {
            Number = 10,
            Topic = "Conceptual Data Architecture: ERD & Razor",
            Question = "What does .Include() generally allow EF Core to do?",
            Choices = new Dictionary<string, string>
            {
                { "A", "Delete the Section table" },
                { "B", "Load related Section data together with Students" },
                { "C", "Create a new Student" },
                { "D", "Validate Student input" }
            },
            CorrectLetter = "B",
            Rationale = ".Include() performs eager loading, pulling in related entities in the same query."
        },
        new QuestionAnswer
        {
            Number = 11,
            Topic = "Data Normalization, Validation & ModelState",
            Question = "Why might a ViewModel be used when displaying Student and Section information?",
            Choices = new Dictionary<string, string>
            {
                { "A", "To replace the database" },
                { "B", "To combine or shape the data specifically needed by the view" },
                { "C", "To automatically create database tables" },
                { "D", "To prevent controllers from using LINQ" }
            },
            CorrectLetter = "B",
            Rationale = "ViewModels tailor/combine entity data into exactly the shape a view needs, without exposing raw entities."
        },
        new QuestionAnswer
        {
            Number = 12,
            Topic = "Data Normalization, Validation & ModelState",
            Question = "For 'var students = _context.Students.Include(s => s.Section).ToList();', what is the main benefit of Include(s => s.Section)?",
            Choices = new Dictionary<string, string>
            {
                { "A", "It loads the related Section navigation property" },
                { "B", "It creates a Section object manually" },
                { "C", "It removes the foreign key" },
                { "D", "It prevents the query from accessing the database" }
            },
            CorrectLetter = "A",
            Rationale = "The lambda tells EF Core which navigation property to eagerly load alongside the main entity."
        },
        new QuestionAnswer
        {
            Number = 13,
            Topic = "Data Normalization, Validation & ModelState",
            Question = "Which type of validation occurs in the browser before a request is sent to the server?",
            Choices = new Dictionary<string, string>
            {
                { "A", "Database-level validation" },
                { "B", "Client-side validation" },
                { "C", "Server-side validation" },
                { "D", "EF Core migration validation" }
            },
            CorrectLetter = "B",
            Rationale = "Client-side validation (e.g., via jQuery Unobtrusive Validation) runs in the browser before submission."
        },
        new QuestionAnswer
        {
            Number = 14,
            Topic = "Data Normalization, Validation & ModelState",
            Question = "Why is server-side validation still necessary if client-side validation exists?",
            Choices = new Dictionary<string, string>
            {
                { "A", "Client-side validation can be bypassed" },
                { "B", "Client-side validation automatically modifies the database" },
                { "C", "Server-side validation only works with SQLite" },
                { "D", "Client-side validation cannot display messages" }
            },
            CorrectLetter = "A",
            Rationale = "Client-side checks can be disabled or skipped (e.g., direct HTTP requests), so the server must re-validate."
        },
        new QuestionAnswer
        {
            Number = 15,
            Topic = "Data Normalization, Validation & ModelState",
            Question = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
            Choices = new Dictionary<string, string>
            {
                { "A", "Student Number should always be nullable" },
                { "B", "Student Number should be unique" },
                { "C", "Student Number should always be the same" },
                { "D", "Student Number should contain only spaces" }
            },
            CorrectLetter = "B",
            Rationale = "The business rule directly maps to a uniqueness constraint on Student Number."
        },
        new QuestionAnswer
        {
            Number = 16,
            Topic = "Intro to SQL & In-Memory CRUD",
            Question = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
            Choices = new Dictionary<string, string>
            {
                { "A", "It protects data integrity even if application-level validation is bypassed" },
                { "B", "It makes Razor Views render faster" },
                { "C", "It removes the need for a Controller" },
                { "D", "It automatically creates a ViewModel" }
            },
            CorrectLetter = "A",
            Rationale = "A DB constraint is the last line of defense, enforcing the rule regardless of how data was inserted."
        },
        new QuestionAnswer
        {
            Number = 17,
            Topic = "Intro to SQL & In-Memory CRUD",
            Question = "What is the purpose of a try...catch block in a controller?",
            Choices = new Dictionary<string, string>
            {
                { "A", "To create navigation properties" },
                { "B", "To catch and handle exceptions that may occur during execution" },
                { "C", "To generate database tables" },
                { "D", "To perform client-side validation" }
            },
            CorrectLetter = "B",
            Rationale = "try/catch intercepts runtime exceptions so the app can handle them gracefully instead of crashing."
        },
        new QuestionAnswer
        {
            Number = 18,
            Topic = "Intro to SQL & In-Memory CRUD",
            Question = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
            Choices = new Dictionary<string, string>
            {
                { "A", "UseDatabase()" },
                { "B", "UseExceptionHandler()" },
                { "C", "UseValidationHandler()" },
                { "D", "UseMvcDatabase()" }
            },
            CorrectLetter = "B",
            Rationale = "UseExceptionHandler() is the built-in middleware for catching unhandled exceptions app-wide."
        },
        new QuestionAnswer
        {
            Number = 19,
            Topic = "Intro to SQL & In-Memory CRUD",
            Question = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
            Choices = new Dictionary<string, string>
            {
                { "A", "Display the student's information anyway" },
                { "B", "Display a Not Found (404) response/page" },
                { "C", "Delete Student 999" },
                { "D", "Create Student 999 automatically" }
            },
            CorrectLetter = "B",
            Rationale = "A missing resource should correctly return HTTP 404, matching REST/HTTP semantics."
        },
        new QuestionAnswer
        {
            Number = 20,
            Topic = "Intro to SQL & In-Memory CRUD",
            Question = "A student already belongs to Section A for a subject. The application attempts to assign the same student to Section A again. What is the primary concern?",
            Choices = new Dictionary<string, string>
            {
                { "A", "Data integrity" },
                { "B", "HTML formatting" },
                { "C", "CSS inheritance" },
                { "D", "Razor syntax" }
            },
            CorrectLetter = "A",
            Rationale = "Duplicate assignment is a data integrity issue — the same relationship shouldn't be stored twice."
        },
        // Items are appended below, one at a time.
    };
}
