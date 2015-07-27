using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiaWeb2._0
{
    public partial class TIA : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.QuickNav.SelectedIndex = -1;
            }
            if (Cache["SelectedNodePath"] != null)
                this.QuickNav.SelectedIndex = System.Convert.ToInt16(Cache["SelectedNodePath"].ToString());
            //if (this.QuickNav.SelectedIndex != null)
            //{
               

            //}
            //this.QuickNav.Panes += new CommandEventHandler(ViewState);
            //this.QuickNav.vi
                //if (ViewState["SelectedNodePath"] != null)
                //{
                //    TreeNode node = this.QuickNavTree.FindNode(ViewState["SelectedNodePath"].ToString());
                //    if (node != null)
                //        node.Select();
                //}
        }

        //protected void TreeView1_TreeNodeExpanded(object sender, TreeNodeEventArgs e)
        //{
        //    TreeView tv = (TreeView)sender;
        //    foreach (TreeNode item in this.QuickNavTree.Nodes)
        //    {
        //        if (item != e.Node)
        //        {
        //            item.Expanded = false;
        //        }

        //    }
        //}

        //protected void TreeView2_TreeNodeExpanded(object sender, TreeNodeEventArgs e)
        //{
        //    foreach (TreeNode item in this.SiteNavTree.Nodes)
        //    {
        //        if (item != e.Node)
        //        {
        //            item.Expanded = false;
        //        }

        //    }
        //}

        public void accordion_selectedIndexChanged(int i)
        {
            if (this.QuickNav.SelectedIndex != -1)
            {
                this.QuickNav.SelectedIndex = i;
                Cache["SelectedNodePath"] = this.QuickNav.SelectedIndex;

            }
            //return base.SaveViewState();
        }

        //protected void QuickNavTree_SelectedNodeChanged(object sender, EventArgs e)
        //{
        //    if (this.QuickNavTree.SelectedNode != null)
        //    {
        //        ViewState["SelectedNodePath"] = this.QuickNavTree.SelectedNode.ValuePath;

        //    }
        //}
    }
}