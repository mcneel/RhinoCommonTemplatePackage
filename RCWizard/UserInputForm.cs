using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace RCWizard
{
  public partial class UserInputForm : Form
  {
    readonly Dictionary<string, string> m_replacements;

    public UserInputForm(Dictionary<string, string> replacements)
    {
      m_replacements = replacements;
      InitializeComponent();

      if (m_replacements != null)
      {
        //Title
        this.Text = string.Format(this.Text, m_replacements["$safeprojectname$"]);

        pluginname.Text = m_replacements["$safeprojectname$"] + "PlugIn";
        commandname.Text = m_replacements["$safeprojectname$"] + "Command";

        string path, exe_name;
        
        bool ok64 = RhinoFinder.FindRhino6(out path, out exe_name);
        rhino64path.Text = Path.Combine(path, exe_name);
        rhinoExe.Checked = ok64;

        if (File.Exists(Path.Combine(path, "rhinocommon.dll")))
        {
          UpdateRhinoCommonBasedPaths(Path.Combine(path, "rhinocommon.dll"));
        }
        else
        {
          rhinocommonpath.Text = "Please select a path to RhinoCommon.dll to continue.";
          etopath.Text = string.Empty;
          rhinouipath.Text = string.Empty;
          rhinocommonpath.ForeColor = Color.Red;
        }

        EnableOrDisableContinue();

        if (!Environment.Is64BitOperatingSystem)
        {
          rhinoExe.Enabled = false;
          rhino64browse.Visible = false;
          rhino64path.Enabled = false;
          rhino64path.Text = "This operating system is 32-bit.";
        }
      }

      var font = new Font(rhinocommonpath.Font.FontFamily,
        rhinocommonpath.Font.Size * 0.84f, rhinocommonpath.Font.Style, rhinocommonpath.Font.Unit, rhinocommonpath.Font.GdiCharSet);
      rhinocommonpath.Font = font;
      rhino64path.Font = font;
      eitheronetext.Font = font;
      etopath.Font = font;
      rhinouipath.Font = font;
    }

    protected UserInputForm() : this(null)
    {
      if (!DesignMode)
        throw new NotSupportedException("This constructor is only for design.");
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      FinalVariableSetup();
      base.OnClosing(e);
    }

    private void EnableOrDisableContinue()
    {
      eitheronetext.Visible = !rhinoExe.Checked;

      finish.Enabled =
        IsTextBoxAllRight(pluginname) && IsTextBoxAllRight(commandname) &&
        rhinoExe.Checked &&
        (rhinoExe.Checked ? File.Exists(rhino64path.Text) : true) &&
        File.Exists(rhinocommonpath.Text);
    }

    private bool IsTextBoxAllRight(TextBox tb)
    {
      return !string.IsNullOrEmpty(tb.Text);
    }

    private void ImportCheckedChanged(object sender, EventArgs e)
    {
      this.EnableDisableImportExport();
    }

    private void ExportCheckedChanged(object sender, EventArgs e)
    {
      this.EnableDisableImportExport();
    }

    private void EnableDisableImportExport()
    {
      bool enabled = import.Checked || export.Checked;
      extension.Enabled = enabled;
      description.Enabled = enabled;
    }

    private void ExotericPluginsClick(object sender, EventArgs e)
    {
      digitizer.Visible =
      rendering.Visible =
      export.Visible =
      import.Visible = true;

      extension.Visible =
      extensionlabel.Visible =
      description.Visible =
      descriptionlabel.Visible = true;

      usefullabel.Visible = false;

      exotericplugins.Visible = false;
      commandsample.Location -= new Size(0, 32);
    }

    private void UtilityCheckedChanged(object sender, EventArgs e)
    {
      commandsample.Enabled = utility.Checked;
    }

    private void EithertextboxTextChanged(object sender, EventArgs e)
    {
      var real_sender = sender as TextBox;

      if (real_sender != null)
      {
        string text = real_sender.Text;

        const string pattern = "^[^A-Za-z]+|[^A-Za-z0-9]+"; //finds bad chars at beginning or around
        if (Regex.IsMatch(text, pattern))
        {
          text = Regex.Replace(text, pattern, string.Empty);
          real_sender.Text = text;
        }
      }

      if (pluginname.Text == m_replacements["$safeprojectname$"])
        pluginname.Text = m_replacements["$safeprojectname$"] + "PlugIn";

      if (commandname.Text == m_replacements["$safeprojectname$"])
        commandname.Text = m_replacements["$safeprojectname$"] + "Command";

      if (commandname.Text == pluginname.Text)
        commandname.Text = pluginname.Text + "Command";

      EnableOrDisableContinue();
    }

    private void Rhino64CheckedChanged(object sender, EventArgs e)
    {
      EnableDisablePath(rhinoExe, rhino64path, rhino64browse);
    }

    private void EnableDisablePath(CheckBox rhino, Label path, Button browse)
    {
      if (rhino.Checked && !File.Exists(path.Text))
      {
        browse.PerformClick();
        if (!File.Exists(path.Text))
          rhino.Checked = false;
      }

      path.Visible = rhino.Checked;

      EnableOrDisableContinue();
    }

    private void Rhino64BrowseClick(object sender, EventArgs e)
    {
      var start_at = File.Exists(rhino64path.Text) ? rhino64path.Text : Get64BitPath();

      string location;
      if (!GetLocation("Rhino 5 64-bit executable", "Rhino.exe", start_at, out location))
        return;

      this.rhino64path.Text = location;
      this.rhinoExe.Checked = true;
      this.EnableOrDisableContinue();
    }

    private static string Get64BitPath()
    {
      string path = string.Empty;
      try
      {
        path = Environment.Is64BitProcess ?
          Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) : Environment.GetEnvironmentVariable("ProgramW6432");
      }
      catch (Exception)
      { }
      return path;
    }

    private void BrowseRhinocommonClick(object sender, EventArgs e)
    {
      var start_at = File.Exists(rhinocommonpath.Text) ? rhinocommonpath.Text :
        Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

      string location;
      if (GetLocation("RhinoCommon library", "RhinoCommon.dll", start_at, out location))
      {
        UpdateRhinoCommonBasedPaths(location);
        
        EnableOrDisableContinue();
      }
    }

    private void UpdateRhinoCommonBasedPaths(string rhinocommonLocation)
    {
      rhinocommonpath.Text = rhinocommonLocation;
      rhinocommonpath.ForeColor = SystemColors.ControlDark;

      var dir = Path.GetDirectoryName(rhinocommonLocation);
      if (dir != null)
      {
        etopath.Text = Path.Combine(dir, "Eto.dll");
        rhinouipath.ForeColor = SystemColors.ControlDark;

        rhinouipath.Text = Path.Combine(dir, "Rhino.UI.dll");
        rhinouipath.ForeColor = SystemColors.ControlDark;
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
      m_replacements["$pluginname$"] = pluginname.Text;
      m_replacements["$commandname$"] = commandname.Text;

      m_replacements["$rhinocommonURL$"] = rhinocommonpath.Text;
      m_replacements["$etoURL$"] = etopath.Text;
      m_replacements["$rhinouiURL$"] = rhinouipath.Text;

      m_replacements["$rhino5_64_checked$"] = rhinoExe.Checked ? "1" : "0";
      m_replacements["$rhino5_64_URL$"] = rhino64path.Text;

      m_replacements["$utility$"] = utility.Checked ? "1" : "0";
      m_replacements["$notutility$"] = utility.Checked ? "0" : "1";
      m_replacements["$digitizer$"] = digitizer.Checked ? "1" : "0";
      m_replacements["$rendering$"] = rendering.Checked ? "1" : "0";
      m_replacements["$import$"] = import.Checked ? "1" : "0";
      m_replacements["$export$"] = export.Checked ? "1" : "0";

      m_replacements["$extension$"] = extension.Text.Replace(".", string.Empty);
      m_replacements["$description$"] = description.Text;

      m_replacements["$utilitywithsample$"] = (utility.Checked && commandsample.Checked) ? "1" : "0";
      m_replacements["$utilitywithoutsample$"] = (utility.Checked && (!commandsample.Checked)) ? "1" : "0";
      m_replacements["$plugintype$"] =
        utility.Checked?"utility" : digitizer.Checked?"digitizer": import.Checked?"import": rendering.Checked?"rendering":"export";
    }
  }
}
