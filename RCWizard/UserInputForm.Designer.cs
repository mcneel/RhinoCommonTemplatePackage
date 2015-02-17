namespace RCWizard
{
    partial class UserInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInputForm));
      this.pluginname = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.finish = new System.Windows.Forms.Button();
      this.cancel = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.commandname = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.exotericplugins = new System.Windows.Forms.Button();
      this.rendering = new System.Windows.Forms.RadioButton();
      this.commandsample = new System.Windows.Forms.CheckBox();
      this.usefullabel = new System.Windows.Forms.Label();
      this.descriptionlabel = new System.Windows.Forms.Label();
      this.description = new System.Windows.Forms.TextBox();
      this.extensionlabel = new System.Windows.Forms.Label();
      this.extension = new System.Windows.Forms.TextBox();
      this.import = new System.Windows.Forms.RadioButton();
      this.export = new System.Windows.Forms.RadioButton();
      this.digitizer = new System.Windows.Forms.RadioButton();
      this.utility = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.eitheronetext = new System.Windows.Forms.Label();
      this.rhinocommonlabel = new System.Windows.Forms.Label();
      this.browseRhinocommon = new System.Windows.Forms.Button();
      this.rhinocommonpath = new System.Windows.Forms.Label();
      this.rhino64browse = new System.Windows.Forms.Button();
      this.rhino64path = new System.Windows.Forms.Label();
      this.rhino64 = new System.Windows.Forms.CheckBox();
      this.etopath = new System.Windows.Forms.Label();
      this.rhinouipath = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // pluginname
      // 
      this.pluginname.BackColor = System.Drawing.SystemColors.Window;
      this.pluginname.Location = new System.Drawing.Point(256, 21);
      this.pluginname.Margin = new System.Windows.Forms.Padding(6);
      this.pluginname.Name = "pluginname";
      this.pluginname.Size = new System.Drawing.Size(436, 31);
      this.pluginname.TabIndex = 0;
      this.pluginname.TextChanged += new System.EventHandler(this.EithertextboxTextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 27);
      this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(194, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "Plug-in class name";
      // 
      // finish
      // 
      this.finish.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.finish.Location = new System.Drawing.Point(384, 677);
      this.finish.Margin = new System.Windows.Forms.Padding(6);
      this.finish.Name = "finish";
      this.finish.Size = new System.Drawing.Size(150, 44);
      this.finish.TabIndex = 10;
      this.finish.Text = "Finish";
      this.finish.UseVisualStyleBackColor = true;
      // 
      // cancel
      // 
      this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancel.Location = new System.Drawing.Point(546, 677);
      this.cancel.Margin = new System.Windows.Forms.Padding(6);
      this.cancel.Name = "cancel";
      this.cancel.Size = new System.Drawing.Size(150, 44);
      this.cancel.TabIndex = 11;
      this.cancel.Text = "Cancel";
      this.cancel.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 77);
      this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(224, 25);
      this.label2.TabIndex = 5;
      this.label2.Text = "Command class name";
      // 
      // commandname
      // 
      this.commandname.Location = new System.Drawing.Point(256, 71);
      this.commandname.Margin = new System.Windows.Forms.Padding(6);
      this.commandname.Name = "commandname";
      this.commandname.Size = new System.Drawing.Size(436, 31);
      this.commandname.TabIndex = 1;
      this.commandname.TextChanged += new System.EventHandler(this.EithertextboxTextChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.exotericplugins);
      this.groupBox1.Controls.Add(this.rendering);
      this.groupBox1.Controls.Add(this.commandsample);
      this.groupBox1.Controls.Add(this.usefullabel);
      this.groupBox1.Controls.Add(this.descriptionlabel);
      this.groupBox1.Controls.Add(this.description);
      this.groupBox1.Controls.Add(this.extensionlabel);
      this.groupBox1.Controls.Add(this.extension);
      this.groupBox1.Controls.Add(this.import);
      this.groupBox1.Controls.Add(this.export);
      this.groupBox1.Controls.Add(this.digitizer);
      this.groupBox1.Controls.Add(this.utility);
      this.groupBox1.Location = new System.Drawing.Point(24, 121);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
      this.groupBox1.Size = new System.Drawing.Size(672, 271);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Type";
      // 
      // exotericplugins
      // 
      this.exotericplugins.Location = new System.Drawing.Point(410, 71);
      this.exotericplugins.Margin = new System.Windows.Forms.Padding(6);
      this.exotericplugins.Name = "exotericplugins";
      this.exotericplugins.Size = new System.Drawing.Size(214, 46);
      this.exotericplugins.TabIndex = 4;
      this.exotericplugins.Text = "Show more types...";
      this.exotericplugins.UseVisualStyleBackColor = true;
      this.exotericplugins.Click += new System.EventHandler(this.ExotericPluginsClick);
      // 
      // rendering
      // 
      this.rendering.AutoSize = true;
      this.rendering.Location = new System.Drawing.Point(376, 60);
      this.rendering.Margin = new System.Windows.Forms.Padding(6);
      this.rendering.Name = "rendering";
      this.rendering.Size = new System.Drawing.Size(219, 29);
      this.rendering.TabIndex = 2;
      this.rendering.Text = "Rendering plug-in.";
      this.rendering.UseVisualStyleBackColor = true;
      this.rendering.Visible = false;
      // 
      // commandsample
      // 
      this.commandsample.AutoSize = true;
      this.commandsample.Checked = true;
      this.commandsample.CheckState = System.Windows.Forms.CheckState.Checked;
      this.commandsample.Location = new System.Drawing.Point(28, 146);
      this.commandsample.Margin = new System.Windows.Forms.Padding(6);
      this.commandsample.Name = "commandsample";
      this.commandsample.Size = new System.Drawing.Size(297, 29);
      this.commandsample.TabIndex = 3;
      this.commandsample.Text = "Provide command sample.";
      this.commandsample.UseVisualStyleBackColor = true;
      // 
      // usefullabel
      // 
      this.usefullabel.AutoSize = true;
      this.usefullabel.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.usefullabel.Location = new System.Drawing.Point(12, 88);
      this.usefullabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.usefullabel.Name = "usefullabel";
      this.usefullabel.Size = new System.Drawing.Size(241, 50);
      this.usefullabel.TabIndex = 15;
      this.usefullabel.Text = "Adds commands\r\nto modify the document.";
      // 
      // descriptionlabel
      // 
      this.descriptionlabel.AutoSize = true;
      this.descriptionlabel.Location = new System.Drawing.Point(324, 219);
      this.descriptionlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.descriptionlabel.Name = "descriptionlabel";
      this.descriptionlabel.Size = new System.Drawing.Size(158, 25);
      this.descriptionlabel.TabIndex = 10;
      this.descriptionlabel.Text = "File description";
      this.descriptionlabel.Visible = false;
      // 
      // description
      // 
      this.description.Enabled = false;
      this.description.Location = new System.Drawing.Point(484, 213);
      this.description.Margin = new System.Windows.Forms.Padding(6);
      this.description.Name = "description";
      this.description.Size = new System.Drawing.Size(154, 31);
      this.description.TabIndex = 2;
      this.description.TabStop = false;
      this.description.Text = "Text file";
      this.description.Visible = false;
      // 
      // extensionlabel
      // 
      this.extensionlabel.AutoSize = true;
      this.extensionlabel.Location = new System.Drawing.Point(374, 175);
      this.extensionlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.extensionlabel.Name = "extensionlabel";
      this.extensionlabel.Size = new System.Drawing.Size(107, 25);
      this.extensionlabel.TabIndex = 8;
      this.extensionlabel.Text = "Extension";
      this.extensionlabel.Visible = false;
      // 
      // extension
      // 
      this.extension.Enabled = false;
      this.extension.Location = new System.Drawing.Point(484, 169);
      this.extension.Margin = new System.Windows.Forms.Padding(6);
      this.extension.Name = "extension";
      this.extension.Size = new System.Drawing.Size(60, 31);
      this.extension.TabIndex = 2;
      this.extension.TabStop = false;
      this.extension.Text = ".txt";
      this.extension.Visible = false;
      // 
      // import
      // 
      this.import.AutoSize = true;
      this.import.Location = new System.Drawing.Point(376, 92);
      this.import.Margin = new System.Windows.Forms.Padding(6);
      this.import.Name = "import";
      this.import.Size = new System.Drawing.Size(220, 29);
      this.import.TabIndex = 2;
      this.import.Text = "File import plug-in.";
      this.import.UseVisualStyleBackColor = true;
      this.import.Visible = false;
      this.import.CheckedChanged += new System.EventHandler(this.ImportCheckedChanged);
      // 
      // export
      // 
      this.export.AutoSize = true;
      this.export.Location = new System.Drawing.Point(376, 125);
      this.export.Margin = new System.Windows.Forms.Padding(6);
      this.export.Name = "export";
      this.export.Size = new System.Drawing.Size(221, 29);
      this.export.TabIndex = 2;
      this.export.Text = "File export plug-in.";
      this.export.UseVisualStyleBackColor = true;
      this.export.Visible = false;
      this.export.CheckedChanged += new System.EventHandler(this.ExportCheckedChanged);
      // 
      // digitizer
      // 
      this.digitizer.AutoSize = true;
      this.digitizer.Location = new System.Drawing.Point(376, 27);
      this.digitizer.Margin = new System.Windows.Forms.Padding(6);
      this.digitizer.Name = "digitizer";
      this.digitizer.Size = new System.Drawing.Size(198, 29);
      this.digitizer.TabIndex = 2;
      this.digitizer.Text = "Digitizer plug-in.";
      this.digitizer.UseVisualStyleBackColor = true;
      this.digitizer.Visible = false;
      // 
      // utility
      // 
      this.utility.AutoSize = true;
      this.utility.Checked = true;
      this.utility.Location = new System.Drawing.Point(30, 48);
      this.utility.Margin = new System.Windows.Forms.Padding(6);
      this.utility.Name = "utility";
      this.utility.Size = new System.Drawing.Size(252, 29);
      this.utility.TabIndex = 2;
      this.utility.TabStop = true;
      this.utility.Text = "General utility plug-in.";
      this.utility.UseVisualStyleBackColor = true;
      this.utility.CheckedChanged += new System.EventHandler(this.UtilityCheckedChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.rhinouipath);
      this.groupBox2.Controls.Add(this.etopath);
      this.groupBox2.Controls.Add(this.eitheronetext);
      this.groupBox2.Controls.Add(this.rhinocommonlabel);
      this.groupBox2.Controls.Add(this.browseRhinocommon);
      this.groupBox2.Controls.Add(this.rhinocommonpath);
      this.groupBox2.Controls.Add(this.rhino64browse);
      this.groupBox2.Controls.Add(this.rhino64path);
      this.groupBox2.Controls.Add(this.rhino64);
      this.groupBox2.Location = new System.Drawing.Point(24, 404);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
      this.groupBox2.Size = new System.Drawing.Size(672, 250);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Reference and debug paths";
      // 
      // eitheronetext
      // 
      this.eitheronetext.AutoSize = true;
      this.eitheronetext.ForeColor = System.Drawing.Color.Red;
      this.eitheronetext.Location = new System.Drawing.Point(254, 178);
      this.eitheronetext.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.eitheronetext.Name = "eitheronetext";
      this.eitheronetext.Size = new System.Drawing.Size(349, 25);
      this.eitheronetext.TabIndex = 15;
      this.eitheronetext.Text = "Please select a Rhino.exe location.";
      this.eitheronetext.Visible = false;
      // 
      // rhinocommonlabel
      // 
      this.rhinocommonlabel.AutoSize = true;
      this.rhinocommonlabel.Location = new System.Drawing.Point(26, 40);
      this.rhinocommonlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.rhinocommonlabel.Name = "rhinocommonlabel";
      this.rhinocommonlabel.Size = new System.Drawing.Size(153, 25);
      this.rhinocommonlabel.TabIndex = 9;
      this.rhinocommonlabel.Text = "RhinoCommon";
      // 
      // browseRhinocommon
      // 
      this.browseRhinocommon.Location = new System.Drawing.Point(182, 33);
      this.browseRhinocommon.Margin = new System.Windows.Forms.Padding(6);
      this.browseRhinocommon.Name = "browseRhinocommon";
      this.browseRhinocommon.Size = new System.Drawing.Size(48, 37);
      this.browseRhinocommon.TabIndex = 5;
      this.browseRhinocommon.Text = "...";
      this.browseRhinocommon.UseVisualStyleBackColor = true;
      this.browseRhinocommon.Click += new System.EventHandler(this.BrowseRhinocommonClick);
      // 
      // rhinocommonpath
      // 
      this.rhinocommonpath.AutoSize = true;
      this.rhinocommonpath.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.rhinocommonpath.Location = new System.Drawing.Point(8, 69);
      this.rhinocommonpath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.rhinocommonpath.Name = "rhinocommonpath";
      this.rhinocommonpath.Size = new System.Drawing.Size(241, 25);
      this.rhinocommonpath.TabIndex = 13;
      this.rhinocommonpath.Text = "path\\to\\rhinocommon.dll";
      // 
      // rhino64browse
      // 
      this.rhino64browse.Location = new System.Drawing.Point(150, 175);
      this.rhino64browse.Margin = new System.Windows.Forms.Padding(6);
      this.rhino64browse.Name = "rhino64browse";
      this.rhino64browse.Size = new System.Drawing.Size(48, 37);
      this.rhino64browse.TabIndex = 9;
      this.rhino64browse.Text = "...";
      this.rhino64browse.UseVisualStyleBackColor = true;
      this.rhino64browse.Click += new System.EventHandler(this.Rhino64BrowseClick);
      // 
      // rhino64path
      // 
      this.rhino64path.AutoSize = true;
      this.rhino64path.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.rhino64path.Location = new System.Drawing.Point(8, 208);
      this.rhino64path.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.rhino64path.Name = "rhino64path";
      this.rhino64path.Size = new System.Drawing.Size(173, 25);
      this.rhino64path.TabIndex = 12;
      this.rhino64path.Text = "path\\to\\rhino.exe";
      // 
      // rhino64
      // 
      this.rhino64.AutoSize = true;
      this.rhino64.Location = new System.Drawing.Point(32, 176);
      this.rhino64.Margin = new System.Windows.Forms.Padding(6);
      this.rhino64.Name = "rhino64";
      this.rhino64.Size = new System.Drawing.Size(116, 29);
      this.rhino64.TabIndex = 8;
      this.rhino64.Text = "6 64-bit";
      this.rhino64.UseVisualStyleBackColor = true;
      this.rhino64.CheckedChanged += new System.EventHandler(this.Rhino64CheckedChanged);
      // 
      // etopath
      // 
      this.etopath.AutoSize = true;
      this.etopath.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.etopath.Location = new System.Drawing.Point(7, 94);
      this.etopath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.etopath.Name = "etopath";
      this.etopath.Size = new System.Drawing.Size(142, 25);
      this.etopath.TabIndex = 16;
      this.etopath.Text = "path\\to\\eto.dll";
      // 
      // rhinouipath
      // 
      this.rhinouipath.AutoSize = true;
      this.rhinouipath.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.rhinouipath.Location = new System.Drawing.Point(8, 119);
      this.rhinouipath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.rhinouipath.Name = "rhinouipath";
      this.rhinouipath.Size = new System.Drawing.Size(177, 25);
      this.rhinouipath.TabIndex = 17;
      this.rhinouipath.Text = "path\\to\\rhinoui.dll";
      // 
      // UserInputForm
      // 
      this.AcceptButton = this.finish;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.CancelButton = this.cancel;
      this.ClientSize = new System.Drawing.Size(720, 742);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.commandname);
      this.Controls.Add(this.cancel);
      this.Controls.Add(this.finish);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pluginname);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UserInputForm";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "New RhinoCommon Plug-In ({0})";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pluginname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commandname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton digitizer;
        private System.Windows.Forms.RadioButton utility;
        private System.Windows.Forms.RadioButton import;
        private System.Windows.Forms.RadioButton export;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox rhino64;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label extensionlabel;
        private System.Windows.Forms.TextBox extension;
        private System.Windows.Forms.Label rhino64path;
        private System.Windows.Forms.Button rhino64browse;
        private System.Windows.Forms.Label rhinocommonlabel;
        private System.Windows.Forms.Button browseRhinocommon;
        private System.Windows.Forms.Label rhinocommonpath;
        private System.Windows.Forms.Label usefullabel;
        private System.Windows.Forms.Label eitheronetext;
        private System.Windows.Forms.CheckBox commandsample;
        private System.Windows.Forms.Button exotericplugins;
        private System.Windows.Forms.RadioButton rendering;
        private System.Windows.Forms.Label rhinouipath;
        private System.Windows.Forms.Label etopath;
    }
}

