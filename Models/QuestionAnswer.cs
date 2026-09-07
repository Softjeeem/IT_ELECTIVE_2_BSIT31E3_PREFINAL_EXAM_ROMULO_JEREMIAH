namespace PrefinalExamMVC.Models;

/// <summary>
/// Represents a single Prefinal Exam item: the question, its four choices,
/// my chosen answer, and a short rationale. No database — this is plain
/// in-memory data shaped for the view.
/// </summary>
public class QuestionAnswer
{
    public int Number { get; set; }
    public string Topic { get; set; } = string.Empty;
    public string Question { get; set; } = string.Empty;
    public Dictionary<string, string> Choices { get; set; } = new();
    public string CorrectLetter { get; set; } = string.Empty;
    public string Rationale { get; set; } = string.Empty;

    public string CorrectAnswerText =>
        Choices.TryGetValue(CorrectLetter, out var text) ? text : string.Empty;
}
