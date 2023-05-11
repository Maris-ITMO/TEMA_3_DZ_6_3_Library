using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace TEMA_3_DZ_6_3_Library
{
    public class SelectionUtils
    {
        public static List<XYZ> GetPoints(ExternalCommandData commandData, string promptMessage, ObjectSnapTypes objectSnapTypes)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;

            XYZ pickedPoint1 = uidoc.Selection.PickPoint(objectSnapTypes, promptMessage);
            XYZ pickedPoint2 = uidoc.Selection.PickPoint(objectSnapTypes, promptMessage);


            List<XYZ> points = new List<XYZ>() { pickedPoint1, pickedPoint2 };

            return points;
        }
    }
}
