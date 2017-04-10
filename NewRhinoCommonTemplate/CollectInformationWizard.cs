using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TemplateWizard;
using System.Windows.Forms;
using EnvDTE;

namespace NewRhinoCommonTemplate
{
  /// <summary>
  /// See: http://msdn.microsoft.com/en-us/library/ms185301.aspx
  /// </summary>
  public class CollectInformationWizard : IWizard
  {
    // This method is called before opening any item that 
    // has the OpenInEditor attribute.
    public void BeforeOpeningFile(ProjectItem projectItem)
    {
    }

    // This method is only called for item templates,
    // not for project templates.
    public void ProjectItemFinishedGenerating(ProjectItem
        projectItem)
    {
    }

    // This method is called after the project is created.
    public void RunFinished()
    {
    }

    public void RunStarted(object automationObject,
        Dictionary<string, string> replacementsDictionary,
        WizardRunKind runKind, object[] customParams)
    {

      string template_path = (customParams[0]?.ToString()) ?? string.Empty;
      var tokens = template_path.Split('\\');
      var template_file_name = tokens[tokens.Length - 1];

      bool should_add;
      try
      {
        Form input_form;
        if (template_file_name.Contains("Zoo"))
        {
          input_form = new ZooWizard.ZooUserInputForm(replacementsDictionary);
        }
        else
        {
          input_form = new RCWizard.UserInputForm(replacementsDictionary);
        }
          
        replacementsDictionary["$targetframeworkversion$"] = "4.5";
        should_add = input_form.ShowDialog() == DialogResult.OK;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
        throw new WizardCancelledException("An error occurred.", ex);
      }

      if (!should_add)
        throw new WizardBackoutException("User cancelled the wizard.");
    }

    public void ProjectFinishedGenerating(Project project)
    {
    }

    // This method is only called for item templates,
    // not for project templates.
    public bool ShouldAddProjectItem(string filePath)
    {
      return true;
    }
  }
}