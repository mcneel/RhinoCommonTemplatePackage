using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RhinoCommonWizard
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TemplateWizard;
    using System.Windows.Forms;
    using EnvDTE;

    namespace CustomWizard
    {
        /// <summary>
        /// See: http://msdn.microsoft.com/en-us/library/ms185301.aspx
        /// </summary>
        public class CollectInformationWizard : IWizard
        {
            private UserInputForm inputForm;

            // This method is called before opening any item that 
            // has the OpenInEditor attribute.
            public void BeforeOpeningFile(ProjectItem projectItem)
            {
            }

            public void ProjectFinishedGenerating(Project project)
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
                try
                {
                    // Display a form to the user. The form collects 
                    // input for the custom message.
                    inputForm = new UserInputForm();
                    inputForm.ShowDialog();

                    string testComment = inputForm.TestComment;

                    replacementsDictionary["$custommessage$"] = testComment;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            // This method is only called for item templates,
            // not for project templates.
            public bool ShouldAddProjectItem(string filePath)
            {
                return true;
            }
        }
    }
}
