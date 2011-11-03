using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RhinoCommonWizard
{
    public partial class UserInputForm : Form
    {
        public string TestComment
        {
            get;
            set;
        }

        public UserInputForm()
        {
            InitializeComponent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            TestComment = this.testCommentBox.Text;
            Close();
        }
    }
}
