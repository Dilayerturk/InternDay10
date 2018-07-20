using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PersonExporterFactory : IPersonExporterFactory
    {
        List<IPersonExporter> Exporters;

        public PersonExporterFactory(IPersonExporter[] allExporters)
        {
            Exporters = new List<IPersonExporter>(allExporters);
        }

        public List<string> GetSupportedExporterNames()
        {
            List<string> _names = new List<string>();
            for (int i = 0; i < Exporters.Count; i++)
                _names.Add(Exporters[i].Name);

            return _names;
        }

        public IPersonExporter CreateExporter(string name)
        {
            for (int i = 0; i < Exporters.Count; i++)
            {
                if (Exporters[i].Name == name)
                    return Exporters[i];
            }

            return null;
        }
    }
}
