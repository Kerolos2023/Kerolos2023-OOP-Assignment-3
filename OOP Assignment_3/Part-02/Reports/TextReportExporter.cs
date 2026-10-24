
namespace RefactoringLab.Part02.Reports;

public class TextReportExporter : ReportExporter
{
    protected override List<string[]> Load() =>
    [
        ["Id", "Name"],
        ["1", "Keyboard"],
        ["2", "Mouse"]
    ];

    protected override string Format(List<string[]> rows) =>
        string.Join(
            Environment.NewLine,
            rows.Select(r => string.Join(" | ", r)));
}
