using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkAndWorksetCreator
{
    public partial class WorksetCreatorForm : System.Windows.Forms.Form
    {
        private ThisApplication thisApplication;
        private Document doc;
        List<RevitLinkInstance> revitlinks = new List<RevitLinkInstance>();
        public WorksetCreatorForm(ThisApplication application)
        {
            thisApplication = application;
            doc = application.ActiveUIDocument.Document;
            InitializeComponent();
            label1.Text = doc.PathName.ToString();
        }

        private void btnGetRevitLinks_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            this.revitlinks.Clear();
            this.revitlinks = MyFunctions.GetRevitLinkInstances(doc);

            foreach (var link in revitlinks)
            {
                var index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = true;
                this.dataGridView1.Rows[index].Cells[1].Value = Path.GetFileName(link.GetLinkDocument().PathName);
            }
        }

        private void btnGetWorkSets_Click(object sender, EventArgs e)
        {
            if (!doc.IsWorkshared)
            {
                MessageBox.Show("Documnet is not workshared.");
            }
            else
            {
                dataGridView2.Rows.Clear();
                List<Workset> worksets = MyFunctions.GetWorksetList(doc);

                foreach (Workset ws in worksets)
                {
                    var index = this.dataGridView2.Rows.Add();
                    this.dataGridView2.Rows[index].Cells[1].Value = ws.Id.ToString();
                    this.dataGridView2.Rows[index].Cells[2].Value = ws.Name.ToString();
                }
            }
        }

        private void btnCreateWorkset_Click(object sender, EventArgs e)
        {
            if (!doc.IsWorkshared)
            {
                MessageBox.Show("Documnet is not workshared.");
            }
            else
            {
                List<string> linknamelist = new List<string>();
                foreach (RevitLinkInstance revitlinkinstance in this.revitlinks)
                {
                    linknamelist.Add(revitlinkinstance.Name);
                }

                List<Workset> worksets = MyFunctions.GetWorksetList(doc);
                List<string> worksetnamelist = new List<string>();
                foreach (Workset workset in worksets)
                {
                    worksetnamelist.Add(workset.Name);
                }

                foreach (RevitLinkInstance revitlinkinstance in revitlinks)
                {
                    if (false == worksetnamelist.Contains(textBoxPrefix.Text + Path.GetFileName(revitlinkinstance.GetLinkDocument().PathName)))
                    {
                        // Transaction başlat
                        using (Transaction trans = new Transaction(doc, "Create Workset"))
                        {
                            trans.Start();
                            Workset ws = Workset.Create(doc, textBoxPrefix.Text + Path.GetFileName(revitlinkinstance.GetLinkDocument().PathName));

                            //  Get type of RevitLinkInstance.
                            RevitLinkType revitlinktype = (RevitLinkType)doc.GetElement(revitlinkinstance.GetTypeId());

                            //  Set workset of RevitLinkType and RevitLinkInstance to newly created workset.
                            revitlinktype.get_Parameter(BuiltInParameter.ELEM_PARTITION_PARAM).Set(ws.Id.IntegerValue);
                            revitlinkinstance.get_Parameter(BuiltInParameter.ELEM_PARTITION_PARAM).Set(ws.Id.IntegerValue);

                            //  Commit transaction.
                            trans.Commit();
                        }
                    }
                }
                btnGetWorkSets_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
