using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace ZooWizard
{
  public partial class ZooUserInputForm : Form
  {
    readonly Dictionary<string, string> m_replacements;

    public ZooUserInputForm(Dictionary<string, string> replacements)
    {
      m_replacements = replacements;
      InitializeComponent();
      if (replacements == null) return;

      //Title
      this.Text = string.Format(this.Text, m_replacements["$safeprojectname$"]);

      pluginclassname.Text = m_replacements["$safeprojectname$"] + "Class";

      m_replacements["$zooguid$"] = string.Empty;
      zooguid.Text = m_replacements["$zooguid$"];

      try
      {
        string path, dllName;
        ZooFinder.FindZooDll(out path, out dllName);
        zoodllpath.Text = Path.Combine(path, dllName);
      }
      catch(InvalidOperationException ex)
      {
        zoodllpath.Text = ex.Message;
        zoodllpath.ForeColor = Color.Red;
      }

      ValidateFormAndSetFinish();
    }

    protected ZooUserInputForm() : this(null)
    {
      if (!DesignMode)
        throw new NotSupportedException("This constructor is only for design.");
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      FinalVariableSetup();
      base.OnClosing(e);
    }

    private void ValidateFormAndSetFinish()
    {
      bool guidOk = IsGuidValid(zooguid.Text);
      if (guidOk)
        zooguid.Text = new Guid(zooguid.Text).ToString();

      finish.Enabled =
        IsTextBoxAllRight(pluginclassname) &&
        IsTextBoxAllRight(zooguid) &&
        File.Exists(zoodllpath.Text) &&
        guidOk;
    }

    private bool IsTextBoxAllRight(TextBox tb)
    {
      return !string.IsNullOrEmpty(tb.Text);
    }

    private bool IsGuidValid(string text)
    {
      Guid id;
      return Guid.TryParse(text, out id);
    }

    private void textbox_TextChanged(object sender, EventArgs e)
    {
      TextBox realSender = sender as TextBox;

      if (realSender != null)
      {
        string text = realSender.Text;

        const string pattern = "^[^A-Za-z]+|[^A-Za-z0-9]+"; //finds bad chars at beginning or around
        if (Regex.IsMatch(text, pattern))
        {
          text = Regex.Replace(text, pattern, string.Empty);
          realSender.Text = text;
        }
      }

      if (pluginclassname.Text == m_replacements["$safeprojectname$"])
        pluginclassname.Text = m_replacements["$safeprojectname$"] + "Class";

      ValidateFormAndSetFinish();
    }

    private void zooGuid_TextChanged(object sender, EventArgs e)
    {
      ValidateFormAndSetFinish();
    }

    private void browseRhinocommon_Click(object sender, EventArgs e)
    {
      string startAt = File.Exists(zoodllpath.Text) ? zoodllpath.Text :
        Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

      string location;
      if (GetLocation("ZooPlugin.dll library", "ZooPlugin.dll", startAt, out location))
      {
        zoodllpath.Text = location;
        zoodllpath.ForeColor = SystemColors.ControlDark;
        ValidateFormAndSetFinish();
      }
    }

    private static bool GetLocation(string userName, string fileName, string startAt, out string location)
    {
      using (var ofd = new OpenFileDialog())
      {
        ofd.Title = string.Format("Find {0}", userName);
        if (Directory.Exists(startAt))
          ofd.InitialDirectory = startAt;
        else if(File.Exists(startAt))
          ofd.InitialDirectory = Path.GetDirectoryName(startAt);
        ofd.Filter = string.Format("{0} ({1})|{1}",
          userName, fileName);
        if (ofd.ShowDialog() == DialogResult.OK)
        {
          location = ofd.FileName;
          return true;
        }
      }
      location = string.Empty;
      return false;
    }

    private void FinalVariableSetup()
    {
      m_replacements["$pluginclassname$"] = pluginclassname.Text;
      m_replacements["$zooguid$"] = zooguid.Text;

      m_replacements["$zoodllpath$"] = zoodllpath.Text;
    }

    private void UserInputForm_Load(object sender, EventArgs e)
    {

    }
  }
}