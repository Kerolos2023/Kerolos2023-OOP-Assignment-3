
namespace RefactoringLab.Part02.Reports;

public abstract class ReportExporter
{
    public void Export(string path)
    {
        var rows = Load();

        if (!Validate(rows))
            throw new InvalidOperationException("Invalid data");

        var content = Format(rows);

        Save(path, content);
    }

    protected abstract List<string[]> Load();

    protected virtual bool Validate(List<string[]> rows) =>
        rows.Count > 1 && rows[0].Length > 0;

    protected abstract string Format(List<string[]> rows);

    protected void Save(string path, string content) =>
        File.WriteAllText(path, content);
}
