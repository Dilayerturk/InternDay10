using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public interface IPersonExporterFactory
    {
        IPersonExporter CreateExporter(string name);
        List<string> GetSupportedExporterNames();
    }
}