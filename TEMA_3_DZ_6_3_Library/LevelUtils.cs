using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace TEMA_3_DZ_6_3_Library
{
    public class LevelUtils
    {
        public static List<Level> GetLevels(ExternalCommandData commandData)
        {

            var doc = commandData.Application.ActiveUIDocument.Document;
            List<Level> levels = new FilteredElementCollector(doc, doc.ActiveView.Id)
                .OfClass(typeof(Level))
                .Cast<Level>()
                .ToList();
            return levels;
        }
    }
}
