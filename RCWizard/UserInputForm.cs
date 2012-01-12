using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace RCWizard
{
  public partial class UserInputForm : Form
  {
    Dictionary<string, string> _replacements;

    public UserInputForm(Dictionary<string, string> replacements)
    {
      _replacements = replacements;
      InitializeComponent();

      if (_replacements != null)
      {
        //Title
        this.Text = string.Format(this.Text, _replacements["$safeprojectname$"]);

        pluginname.Text = _replacements["$safeprojectname$"] + "PlugIn";
        commandname.Text = _replacements["$safeprojectname$"] + "Command";

        string path, exeName;
        bool ok32 = RhinoFinder.FindRhino5_32bit(out path, out exeName);
        rhino32path.Text = Path.Combine(path, exeName);
        rhino32.Checked = ok32;

        string path32 = path;
        bool ok64 = RhinoFinder.FindRhino5_64bit(out path, out exeName);
        rhino64path.Text = Path.Combine(path, exeName);
        rhino64.Checked = ok64;

        if (File.Exists(Path.Combine(path, "rhinocommon.dll")))
          rhinocommonpath.Text = Path.Combine(path, "rhinocommon.dll");
        else if (File.Exists(Path.Combine(path32, "rhinocommon.dll")))
          rhinocommonpath.Text = Path.Combine(path32, "rhinocommon.dll");
        else
        {
          rhinocommonpath.Text = "Please select a path to RhinoCommon.dll to continue.";
          rhinocommonpath.ForeColor = Color.Red;
        }

        EnableOrDisableContinue();

        if (!Environment.Is64BitOperatingSystem)
        {
          rhino64.Enabled = false;
          rhino64browse.Visible = false;
          rhino64path.Enabled = false;
          rhino64path.Text = "This operating system is 32-bit.";
        }
      }

      Font f = new Font(rhinocommonpath.Font.FontFamily,
        rhinocommonpath.Font.Size * 0.84f, rhinocommonpath.Font.Style, rhinocommonpath.Font.Unit, rhinocommonpath.Font.GdiCharSet);
      rhinocommonpath.Font = f;
      rhino32path.Font = f;
      rhino64path.Font = f;
      eitheronetext.Font = f;
    }

    protected UserInputForm() : this(null)
    {
      if (!DesignMode)
        throw new NotSupportedException("This constructor is only for design.");
    }

    private void finishButton_Click(object sender, EventArgs e)
    {
    }

    protected override void OnClosing(CancelEventArgs e)
    {
      FinalVariableSetup();
      base.OnClosing(e);
    }

    private void EnableOrDisableContinue()
    {
      bool either32or64isChecked = rhino32.Checked || rhino64.Checked;

      eitheronetext.Visible = !either32or64isChecked;

      finish.Enabled =
        IsTextBoxAllRight(pluginname) && IsTextBoxAllRight(commandname) &&
        either32or64isChecked &&
        (rhino32.Checked ? File.Exists(rhino32path.Text) : true) &&
        (rhino64.Checked ? File.Exists(rhino64path.Text) : true) &&
        File.Exists(rhinocommonpath.Text);
    }

    private bool IsTextBoxAllRight(TextBox tb)
    {
      return !string.IsNullOrEmpty(tb.Text);
    }

    private void import_CheckedChanged(object sender, EventArgs e)
    {
      EnableDisable_import_export();
    }

    private void export_CheckedChanged(object sender, EventArgs e)
    {
      EnableDisable_import_export();
    }

    private void EnableDisable_import_export()
    {
      bool enabled = import.Checked || export.Checked;
      extension.Enabled = enabled;
      description.Enabled = enabled;
    }

    private void exotericplugins_Click(object sender, EventArgs e)
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

    private void utility_CheckedChanged(object sender, EventArgs e)
    {
      commandsample.Enabled = utility.Checked;
    }

    private void eithertextbox_TextChanged(object sender, EventArgs e)
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

      if (pluginname.Text == _replacements["$safeprojectname$"])
        pluginname.Text = _replacements["$safeprojectname$"] + "PlugIn";

      if (commandname.Text == _replacements["$safeprojectname$"])
        commandname.Text = _replacements["$safeprojectname$"] + "Command";

      if (commandname.Text == pluginname.Text)
        commandname.Text = pluginname.Text + "Command";

      EnableOrDisableContinue();
    }

    private void rhino32_CheckedChanged(object sender, EventArgs e)
    {
      EnableDisablePath(rhino32, rhino32path, rhino32browse);
    }

    private void rhino64_CheckedChanged(object sender, EventArgs e)
    {
      EnableDisablePath(rhino64, rhino64path, rhino64browse);
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

    private void rhino32browse_Click(object sender, EventArgs e)
    {
      string startAt = File.Exists(rhino32path.Text) ? rhino32path.Text :
        Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

      string location;
      if (GetLocation("Rhino 5 32-bit executable", "Rhino4.exe", startAt, out location))
      {
        rhino32path.Text = location;
        rhino32.Checked = true;
        EnableOrDisableContinue();
      }
    }

    private void rhino64browse_Click(object sender, EventArgs e)
    {
      string startAt = File.Exists(rhino64path.Text) ? rhino64path.Text : Get64BitPath();

      string location;
      if (GetLocation("Rhino 5 64-bit executable", "Rhino.exe", startAt, out location))
      {
        rhino64path.Text = location;
        rhino64.Checked = true;
        EnableOrDisableContinue();
      }
    }

    private static string Get64BitPath()
    {
      string path = string.Empty;
      try
      {
        if (Environment.Is64BitProcess)
          path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        else
          path = Environment.GetEnvironmentVariable("ProgramW6432");
      }
      catch { }
      return path;
    }

    private void browseRhinocommon_Click(object sender, EventArgs e)
    {
      string startAt = File.Exists(rhinocommonpath.Text) ? rhinocommonpath.Text :
        Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

      string location;
      if (GetLocation("RhinoCommon library", "RhinoCommon.dll", startAt, out location))
      {
        rhinocommonpath.Text = location;
        rhinocommonpath.ForeColor = SystemColors.ControlDark;
        EnableOrDisableContinue();
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
      _replacements["$pluginname$"] = pluginname.Text;
      _replacements["$commandname$"] = commandname.Text;

      _replacements["$rhinocommonURL$"] = rhinocommonpath.Text;

      _replacements["$rhino5_32_checked$"] = rhino32.Checked ? "1" : "0";
      _replacements["$rhino5_32_URL$"] = rhino32path.Text;

      _replacements["$rhino5_64_checked$"] = rhino64.Checked ? "1" : "0";
      _replacements["$rhino5_64_URL$"] = rhino64path.Text;

      _replacements["$utility$"] = utility.Checked ? "1" : "0";
      _replacements["$notutility$"] = utility.Checked ? "0" : "1";
      _replacements["$digitizer$"] = digitizer.Checked ? "1" : "0";
      _replacements["$rendering$"] = rendering.Checked ? "1" : "0";
      _replacements["$import$"] = import.Checked ? "1" : "0";
      _replacements["$export$"] = export.Checked ? "1" : "0";

      _replacements["$extension$"] = extension.Text.Replace(".", string.Empty);
      _replacements["$description$"] = description.Text;

      _replacements["$utilitywithsample$"] = (utility.Checked && commandsample.Checked) ? "1" : "0";
      _replacements["$utilitywithoutsample$"] = (utility.Checked && (!commandsample.Checked)) ? "1" : "0";
      _replacements["$plugintype$"] =
        utility.Checked?"utility" : digitizer.Checked?"digitizer": import.Checked?"import": rendering.Checked?"rendering":"export";
    }
  }
}
