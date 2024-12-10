using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkAndWorksetCreator
{
    public partial class LinkCreatorForm : System.Windows.Forms.Form
    {
        //  Current application.
        private ThisApplication thisApplication;
        //  Curren document.
        private Document doc;
        //  To store revit link instances.
        List<RevitLinkInstance> revitlinks = new List<RevitLinkInstance>();
        // To store files selection state. true if files selected by SelectFiles button.
        public bool filesselected = false;
        //  To store path of selected revit files.
        public string[] filepaths;

        public LinkCreatorForm(ThisApplication application)
        {
            thisApplication = application;
            doc = application.ActiveUIDocument.Document;
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            filesselected = false;

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                dataGridView2.Rows.Clear();

                filepaths = openFileDialog1.FileNames;

                foreach (string link in filepaths)
                {
                    var index = this.dataGridView2.Rows.Add();
                    //  If current document and selected document versions are the same.
                    if (doc.Application.VersionNumber.ToString() == MyFunctions.FileVersion(link).ToString())
                    {
                        this.dataGridView2.Rows[index].Cells[0].Value = true;
                    }
                    else
                    {   //  Prevent link checkbox selection.
                        this.dataGridView2.Rows[index].Cells[0].Value = false;
                        this.dataGridView2.Rows[index].ReadOnly = true;

                    }
                    this.dataGridView2.Rows[index].Cells[1].Value = Path.GetFileName(link);
                    this.dataGridView2.Rows[index].Cells[2].Value = MyFunctions.FileVersion(link).ToString();
                    this.dataGridView2.Rows[index].Cells[3].Value = Path.GetDirectoryName(link);
                }
                filesselected = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLinkFiles_Click(object sender, EventArgs e)
        {
            if (filesselected)
            {
                ElementId instanceid = null;
                string path;
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[0].Value))
                    {
                        path = dataGridView2.Rows[i].Cells[3].Value.ToString() + "\\" + dataGridView2.Rows[i].Cells[1].Value.ToString();
                        // Start transaction.
                        using (Transaction trans = new Transaction(doc, "Create Workset"))
                        {
                            trans.Start();
                            instanceid = MyFunctions.CreateRevitLinkType(doc, path);
                            MyFunctions.CreateLinkInstances(doc, instanceid);
                            //  Commit transaction.
                            trans.Commit();
                        }
                    }
                }
            }
        }
    }
}
