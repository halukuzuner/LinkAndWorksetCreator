using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace LinkAndWorksetCreator
{
[Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
[Autodesk.Revit.DB.Macros.AddInId("194F3071-6E91-4BE9-94BC-9BCBF2FDE6E1")]
public partial class ThisApplication
{
    private void Module_Startup(object? sender, EventArgs e)
    {
    }

    private void Module_Shutdown(object? sender, EventArgs e)
    {
    }

    public void CreateWorkset()
    {
        //MessageBox.Show("Hello, World!");
        WorksetCreatorForm mainForm = new WorksetCreatorForm(this);
        mainForm.ShowDialog();
    }
    public void CreateLink()
    {
        //MessageBox.Show("Hello, World!");
        LinkCreatorForm linkcreatorform = new LinkCreatorForm(this);
        linkcreatorform.ShowDialog();
    }
}
}