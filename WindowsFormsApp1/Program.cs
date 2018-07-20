using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Autofac.Features.ResolveAnything;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).As<IPersonExporter>();

            builder.RegisterType<PersonExporterFactory>().As<IPersonExporterFactory>();

            IContainer container = builder.Build();

            PersonList _frm = container.Resolve<PersonList>();

            Application.Run(_frm);
        }
    }
}
