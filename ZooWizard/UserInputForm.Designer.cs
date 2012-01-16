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
      this.label4 = new System.Windows.Forms.Label();
      this.zoodlllabel = new System.Windows.Forms.Label();
      this.browseZooDllButton = new System.Windows.Forms.Button();
      this.zoodllpath = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // pluginclassname
      // 
      this.pluginclassname.BackColor = System.Drawing.SystemColors.Window;
      this.pluginclassname.Location = new System.Drawing.Point(130, 54);
      this.pluginclassname.Name = "pluginclassname";
      this.pluginclassname.Size = new System.Drawing.Size(232, 20);
      this.pluginclassname.TabIndex = 0;
      this.pluginclassname.TextChanged += new System.EventHandler(this.textbox_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(117, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Zoo Plug-in class name";
      // 
      // finish
      // 
      this.finish.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.finish.Location = new System.Drawing.Point(229, 318);
      this.finish.Name = "finish";
      this.finish.Size = new System.Drawing.Size(75, 23);
      this.finish.TabIndex = 10;
      this.finish.Text = "Finish";
      this.finish.UseVisualStyleBackColor = true;
      // 
      // cancel
      // 
      this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancel.Location = new System.Drawing.Point(310, 318);
      this.cancel.Name = "cancel";
      this.cancel.Size = new System.Drawing.Size(75, 23);
      this.cancel.TabIndex = 11;
      this.cancel.Text = "Cancel";
      this.cancel.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 86);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(118, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Linked Rhino plug-in ID";
      // 
      // zooguid
      // 
      this.zooguid.Location = new System.Drawing.Point(130, 84);
      this.zooguid.Name = "zooguid";
      this.zooguid.Size = new System.Drawing.Size(232, 20);
      this.zooguid.TabIndex = 1;
      this.zooguid.TextChanged += new System.EventHandler(this.zooGuid_TextChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Controls.Add(this.zoodlllabel);
      this.groupBox2.Controls.Add(this.browseZooDllButton);
      this.groupBox2.Controls.Add(this.zoodllpath);
      this.groupBox2.Location = new System.Drawing.Point(12, 222);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(373, 90);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Zoo .dll reference";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label4.Location = new System.Drawing.Point(7, 16);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(308, 26);
      this.label4.TabIndex = 15;
      this.label4.Text = "A  reference to the ZooPlugin.dll file will be added to the project.\r\n\"Copylocal\"" +
    " will be set to false.";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // zoodlllabel
      // 
      this.zoodlllabel.AutoSize = true;
      this.zoodlllabel.Location = new System.Drawing.Point(7, 51);
      this.zoodlllabel.Name = "zoodlllabel";
      this.zoodlllabel.Size = new System.Drawing.Size(68, 13);
      this.zoodlllabel.TabIndex = 9;
      this.zoodlllabel.Text = "ZooPlugin.dll";
      // 
      // browseZooDllButton
      // 
      this.browseZooDllButton.Location = new System.Drawing.Point(81, 47);
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
      this.zoodllpath.Location = new System.Drawing.Point(4, 66);
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
      this.label3.Location = new System.Drawing.Point(8, 18);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(344, 52);
      this.label3.TabIndex = 14;
      this.label3.Text = resources.GetString("label3.Text");
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.zooguid);
      this.groupBox1.Location = new System.Drawing.Point(12, 98);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(373, 118);
      this.groupBox1.TabIndex = 15;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Linked ID";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.label5);
      this.groupBox3.Controls.Add(this.label1);
      this.groupBox3.Controls.Add(this.pluginclassname);
      this.groupBox3.Location = new System.Drawing.Point(12, 12);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(373, 80);
      this.groupBox3.TabIndex = 16;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Class name";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label5.Location = new System.Drawing.Point(7, 17);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(307, 26);
      this.label5.TabIndex = 15;
      this.label5.Text = "The name of the class that implements the IZooPlugin interface.\r\nChoose a valid c" +
    "lass identifier.";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // UserInputForm
      // 
      this.AcceptButton = this.finish;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.CancelButton = this.cancel;
      this.ClientSize = new System.Drawing.Size(397, 352);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.cancel);
      this.Controls.Add(this.finish);
      this.ForeColor = System.Drawing.SystemColors.ControlText;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UserInputForm";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "New Zoo Plug-In ({0})";
      this.Load += new System.EventHandler(this.UserInputForm_Load);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
    }
}

