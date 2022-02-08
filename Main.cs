using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITraining_8_2
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;                     

            NavisworksExportOptions nwсOptions = new NavisworksExportOptions
            {
                ExportScope = NavisworksExportScope.Model,

                ViewId = doc.ActiveView.Id
            };

            doc.Export(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Export.nwc", nwсOptions);

            return Result.Succeeded;
           
        }
    }
}
