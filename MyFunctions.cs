using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
//using Autodesk.Revit.UI;

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;

using Application = Autodesk.Revit.ApplicationServices.Application;
using Autodesk.Revit.UI;

namespace LinkAndWorksetCreator
{
    public class MyFunctions
    {
        /// <summary>
        /// Get Revit link instances in current document.
        /// </summary>
        /// <param name="document">Current document.</param>
        /// <returns>List of RevitLinkInstances in current document.</returns>
        public static List<RevitLinkInstance> GetRevitLinkInstances(Document document)
        {
            Document doc = document;
            List<RevitLinkInstance> linkedFiles = new List<RevitLinkInstance>();
            try
            {
                FilteredElementCollector collector = new FilteredElementCollector(doc);
                collector.OfClass(typeof(RevitLinkInstance));

                foreach (Element elem in collector)
                {
                    RevitLinkInstance instance = elem as RevitLinkInstance;
                    Document linkDoc = instance.GetLinkDocument();
                    RevitLinkInstance link = elem as RevitLinkInstance;
                    if (link.GetLinkDocument() != null)
                    {
                        linkedFiles.Add(link);
                    }
                }
            }
            catch (System.Exception ex)
            {
                Autodesk.Revit.UI.TaskDialog.Show("GetRevitIns!", "GetRevitIns" + "\n\nMessage:\n" + ex.ToString() + "\n\nStackTrace:\n" + ex.StackTrace);
            }
            return linkedFiles;
        }
        /// <summary>
        /// Get worksets in current document.
        /// </summary>
        /// <param name="document">Current document.</param>
        /// <returns>List of worksets in current document.</returns>
        public static List<Workset> GetWorksetList(Document document)
        {
            List<Workset> worksetlist = new List<Workset>();
            try
            {
                FilteredWorksetCollector worksets = new FilteredWorksetCollector(document).OfKind(WorksetKind.UserWorkset);

                foreach (Workset ws in worksets)
                {
                    worksetlist.Add(ws);
                }
            }
            catch (System.Exception ex)
            {
                Autodesk.Revit.UI.TaskDialog.Show("GetWorksets!", "GetWorksets" + "\n\nMessage:\n" + ex.ToString() + "\n\nStackTrace:\n" + ex.StackTrace);
            }
            return worksetlist;
        }
        /// <summary>
        /// Create RevitLinkType.
        /// </summary>
        /// <param name="document">Current document.</param>
        /// <param name="pathName">Path name of the link as string.</param>
        /// <returns>ElementId of created RevitLinkType.</returns>
        public static ElementId CreateRevitLinkType(Document doc, string pathName)
            {
                FilePath path = new FilePath(pathName);
                RevitLinkOptions options = new RevitLinkOptions(false);
                // Create new revit link storing absolute path to file
                LinkLoadResult result = RevitLinkType.Create(doc, path, options);
                return (result.ElementId);
            }
        /// <summary>
        /// Create RevitLinkType.
        /// </summary>
        /// <param name="document">Current document.</param>
        /// <param name="linkTypeId">linktypeid as ElementId.</param>
        /// <returns>ElementId of created RevitLinkInstance.</returns>
        public static void CreateLinkInstances(Document doc, ElementId linkTypeId)
        {
            // Create revit link instance at origin
            RevitLinkInstance.Create(doc, linkTypeId, ImportPlacement.Origin);
        }
        public static string FileVersion(string filePath)
        {
            try
            {
                // Get file info by using BasicFileInfo.
                BasicFileInfo fileInfo = BasicFileInfo.Extract(filePath);

                // Return Revit version number.
                return fileInfo.Format;
            }
            catch (Exception ex)
            {
                // Return null if there is an error.
                MessageBox.Show($"File version info couldn't get: {ex.Message}" + ex.StackTrace,  "Version check error.");
                return null;
            }
        }
    }
}