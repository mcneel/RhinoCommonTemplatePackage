namespace ZooWizard
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
      this.pluginclassname = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.finish = new System.Windows.Forms.Button();
      this.cancel = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.zooguid = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.zoodlllabel = new System.Windows.Forms.Label();
      this.browseZooDllButton = new System.Windows.Forms.Button();
      this.zoodllpath = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // pluginclassname
      // 
      this.pluginclassname.BackColor = System.Drawing.SystemColors.Window;
      this.pluginclassname.Location = new System.Drawing.Point(135, 11);
      this.pluginclassname.Name = "pluginclassname";
      this.pluginclassname.Size = new System.Drawing.Size(213, 20);
      this.pluginclassname.TabIndex = 0;
      this.pluginclassname.TextChanged += new System.EventHandler(this.textbox_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(117, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Zoo Plug-in class name";
      // 
      // finish
      // 
      this.finish.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.finish.Location = new System.Drawing.Point(192, 183);
      this.finish.Name = "finish";
      this.finish.Size = new System.Drawing.Size(75, 23);
      this.finish.TabIndex = 10;
      this.finish.Text = "Finish";
      this.finish.UseVisualStyleBackColor = true;
      // 
      // cancel
      // 
      this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancel.Location = new System.Drawing.Point(273, 183);
      this.cancel.Name = "cancel";
      this.cancel.Size = new System.Drawing.Size(75, 23);
      this.cancel.TabIndex = 11;
      this.cancel.Text = "Cancel";
      this.cancel.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(117, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Linked Rhino PlugIn ID";
      // 
      // zooguid
      // 
      this.zooguid.Location = new System.Drawing.Point(135, 37);
      this.zooguid.Name = "zooguid";
      this.zooguid.Size = new System.Drawing.Size(213, 20);
      this.zooguid.TabIndex = 1;
      this.zooguid.TextChanged += new System.EventHandler(this.zooGuid_TextChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.zoodlllabel);
      this.groupBox2.Controls.Add(this.browseZooDllButton);
      this.groupBox2.Controls.Add(this.zoodllpath);
      this.groupBox2.Location = new System.Drawing.Point(12, 109);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(336, 68);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Zoo .dll reference";
      // 
      // zoodlllabel
      // 
      this.zoodlllabel.AutoSize = true;
      this.zoodlllabel.Location = new System.Drawing.Point(8, 23);
      this.zoodlllabel.Name = "zoodlllabel";
      this.zoodlllabel.Size = new System.Drawing.Size(68, 13);
      this.zoodlllabel.TabIndex = 9;
      this.zoodlllabel.Text = "ZooPlugin.dll";
      // 
      // browseZooDllButton
      // 
      this.browseZooDllButton.Location = new System.Drawing.Point(86, 19);
      this.browseZooDllButton.Name = "browseZooDllButton";
      this.browseZooDllButton.Size = new System.Drawing.Size(24, 19);
      this.browseZooDllButton.TabIndex = 5;
      this.browseZooDllButton.Text = "...";
      this.browseZooDllButton.UseVisualStyleBackColor = true;
      this.browseZooDllButton.Click += new System.EventHandler(this.browseRhinocommon_Click);
      // 
      // zoodllpath
      // 
      this.zoodllpath.AutoSize = true;
      this.zoodllpath.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.zoodllpath.Location = new System.Drawing.Point(5, 38);
      this.zoodllpath.Name = "zoodllpath";
      this.zoodllpath.Size = new System.Drawing.Size(77, 13);
      this.zoodllpath.TabIndex = 13;
      this.zoodllpath.Text = "path\\to\\zoo.dll";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label3.Location = new System.Drawing.Point(12, 60);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(338, 39);
      this.label3.TabIndex = 14;
      this.label3.Text = resources.GetString("label3.Text");
      this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // UserInputForm
      // 
      this.AcceptButton = this.finish;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.CancelButton = this.cancel;
      this.ClientSize = new System.Drawing.Size(360, 218);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.zooguid);
      this.Controls.Add(this.cancel);
      this.Controls.Add(this.finish);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pluginclassname);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UserInputForm";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "New Zoo Plug-In ({0})";
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pluginclassname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox zooguid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label zoodlllabel;
        private System.Windows.Forms.Button browseZooDllButton;
        private System.Windows.Forms.Label zoodllpath;
        private System.Windows.Forms.Label label3;
    }
}

