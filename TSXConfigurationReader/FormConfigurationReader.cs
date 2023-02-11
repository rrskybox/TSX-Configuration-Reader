//IniParser is a helpful little library I found in a NuGet -- Ini-Parser by Ricardo Hernandez.
//Just search and load it in the VS Menu: Tools -> NuGet Package Manager -> Manage NuGet Package Manager for Solution...
using IniParser;
using IniParser.Model;

using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace TSXConfigurationReader
{
    public partial class FormConfigurationReader : Form
    {
        public FormConfigurationReader()
        {
            InitializeComponent();
            // Acquire the version information and put it in the form header
            try { this.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(); }
            catch { this.Text = " in Debug"; } //probably in debug, no version info available
            this.Text = "TSX Configuration Reader Ver " + this.Text;
        }

        IniData pData;

        #region form events

        private void OpenButton_Click(object sender, EventArgs e)

        {
            char[] bracketchars = new char[] { '[', ']' };
            int cN = 0;
            string section = "";

            List<string> cfgRaw = new List<string>();
            if (INIopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ConfigFileTextBox.Text = INIopenFileDialog.FileName;
                //Read in the file to a string list by line
                var parser = new FileIniDataParser();
                pData = parser.ReadFile(ConfigFileTextBox.Text);
                cfgRaw = File.ReadAllLines(ConfigFileTextBox.Text).ToList();
                cfgTreeView.Nodes.Clear();
                foreach (string line in cfgRaw)
                {
                    if (line.Contains("["))
                    {
                        section = line.Trim(bracketchars);
                        cN = AddMainNode(section);
                    }
                    else if (line != "")
                    {
                        if (line.Contains("Selection"))
                        {
                            string selectNode = "Selection=" + ParseSelection(section);
                            AddLeafNode(cN, selectNode);
                        }
                        else AddLeafNode(cN, StretchEquals(line));
                    }
                }
                cfgTreeView.Show();
            }
            return;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            RunSearch(SearchTextBox.Text);
            return;
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            cfgTreeView.CollapseAll();
            foreach (TreeNode node in cfgTreeView.Nodes)
            {
                foreach (TreeNode subnode in node.Nodes) subnode.ForeColor = Color.Black;
            }
            cfgTreeView.Show();
            SearchTextBox.Clear();
            return;
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) RunSearch(SearchTextBox.Text);
            return;
        }

        private void cfgTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Add selection (less assigned value) to favorites list
            //char [] sChar = new char[] { '='};
            string[] pickLine = cfgTreeView.SelectedNode.Text.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
            string pick = pickLine[0];
            Show();
        }

        #endregion

        private int AddMainNode(string section)
        {
            TreeNode cNode = cfgTreeView.Nodes.Add(section);
            return cfgTreeView.Nodes.IndexOf(cNode);
        }

        private int AddLeafNode(int main, string leaf)
        {
            TreeNode cNode = cfgTreeView.Nodes[main].Nodes.Add(leaf);
            return cfgTreeView.Nodes.IndexOf(cNode);
        }

        private string ParseSelection(string section)
        {
            //Figures out and returns the item entry selected in a Selection Line
            string pOut = pData[section]["Selection"];
            if (pOut != null)
            {
                string[] sItems = pOut.Split('|');
                if (sItems[0].Length > 1) sItems[0] = sItems[0].Substring(sItems[0].Length - 1, 1);
                int sIndx = Convert.ToInt32(sItems[0]);
                string selected = sItems[sIndx + 1];
                return selected;
            }
            else return "";
        }

        private string StretchEquals(string line)
        {
            return (line.Replace("=", " = "));
        }

        private void RunSearch(string sText)
        {
            cfgTreeView.CollapseAll();
            cfgTreeView.Show();
            foreach (TreeNode node in cfgTreeView.Nodes)
            {
                foreach (TreeNode subnode in node.Nodes)
                {
                    if (subnode.Text.ToLower().Contains(sText.ToLower()))
                    {
                        cfgTreeView.SelectedNode = subnode;
                        subnode.ForeColor = Color.Red;
                    }
                    else subnode.ForeColor = Color.Black;
                }
            }
        }

        private string SearchEntries(string section, string subentry)
        {
            return pData[section]["*" + subentry + "*"];
        }

    }
}

