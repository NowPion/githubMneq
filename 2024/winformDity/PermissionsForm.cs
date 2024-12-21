using Models;
using NewBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformDity
{
    public partial class PermissionsForm : Form
    {
        bool needSetRelateCheck = true;
        string Roeld;
        Dictionary<string,string> RoleActionsDictiony = new Dictionary<string, string>();
        Dictionary<string, string> RoleActionsNameDictiony = new Dictionary<string, string>();
        Dictionary<string, string> RoleActionSump = new Dictionary<string, string>();
        IList<WinAction> winActionList;
        public PermissionsForm()
        {
            InitializeComponent();
        }

        private void treeTest_AfterCheck(object sender, TreeViewEventArgs e)
        {
            
            if (!needSetRelateCheck)
            {
                return;
            }

            TreeNode node = e.Node;
            if (node.Checked)
            {
                node.Nodes.OfType<TreeNode>().ToList().ForEach(x => x.Checked = true);
            }
            else
            {
                node.Nodes.OfType<TreeNode>().ToList().ForEach(x => x.Checked = false);
            }
            needSetRelateCheck = false; //为本方法上锁，确保连带影响不会运行本事件中代码
            if (node.Checked)
            {
                while (node.Parent != null)
                {
                    node = node.Parent;
                    node.Checked = true;
                }
            }
            else
            {
                while (node.Parent != null)
                {
                    node = node.Parent;
                    bool hasCheckedChild = false;
                    foreach (TreeNode child in node.Nodes)
                    {
                        if (child.GetHashCode() == e.Node.GetHashCode())
                        {
                            continue;
                        }
                        if (child.Checked)
                        {
                            hasCheckedChild = true;
                            break;
                        }
                    }
                    if (!hasCheckedChild)
                    {
                        node.Checked = false;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            needSetRelateCheck = true; //为本方法解锁
        }
        public TreeNode ToolSit(WinAction winaction)
        {
            TreeNode treeNode = new TreeNode(winaction.ActionName);
            foreach (WinAction win in winActionList)
            {
                if (win.ParentActionId == winaction.ActionId)
                {
                    //TreeNode treeNodeItem = new TreeNode(win.ActionName);
                    treeNode.Nodes.Add(win.ActionName);

                }
            }

            return treeNode;
        }

        private void PermissionsForm_Load(object sender, EventArgs e)
        {
            //RoleActionService
            RoleGridView.DataSource = new RoleService().GetRoleList();
            winActionList = new WinActionService().GetWinActionList();
            foreach (WinAction win in winActionList)
            {
                RoleActionsNameDictiony.Add(win.ActionName, win.ActionId);
                RoleActionSump.Add(win.ActionId,win.ParentActionId);
                if (win.ParentActionId == "000")
                {
                    treeTest.Nodes.Add(ToolSit(win));
                }
            }
            treeTest.ExpandAll();

            //IList<RoleAction> roleActionsList = MainForm.AndroidUser.UserRoleActionList;

            //foreach(RoleAction role in roleActionsList)
            //{
            //    RoleActionsDictiony.Add(role.ActionId,role.ParentActionId);
            //    RoleActionsNameDictiony.Add(new WinActionService().GetWinAction(role.ActionId).ActionName, role.ActionId);
            //}

            //foreach (TreeNode n in treeTest.Nodes)
            //{
            //    //recursiveTotalNodes++;
            //    PrintRecursive(n);
            //}
            //treeTest.ExpandAll();
        }

        public void PringMeng(string RoleId)
        {
            RoleGridView.DataSource = new RoleService().GetRoleList();
            winActionList = new WinActionService().GetWinActionList();
            RoleActionsDictiony.Clear();
            IList<RoleAction> roleActionsList = new RoleActionService().CetRoleActionList(RoleId);

            foreach (RoleAction role in roleActionsList)
            {
                RoleActionsDictiony.Add(role.ActionId, role.ParentActionId);
            }

            foreach (TreeNode n in treeTest.Nodes)
            {
                //recursiveTotalNodes++;
                PrintRecursive(n);
            }
            treeTest.ExpandAll();
        }

        private void PrintRecursive(TreeNode treeNode)
        {
            if (RoleActionsDictiony.ContainsKey(RoleActionsNameDictiony[treeNode.Text]))
            {
                treeNode.Checked = true;
            }
            else
            {
                treeNode.Checked = false;
            }
           //MessageBox.Show(treeNode.Text);
            // Visit each node recursively.
            foreach (TreeNode n in treeNode.Nodes)
            {
                PrintRecursive(n);
            }
        }

       
        private void RoleGridView_Click(object sender, EventArgs e)
        {
           
            Int32 selectedRowCount =
            RoleGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            if (selectedRowCount > 0)
            {

                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = RoleGridView.SelectedRows[i].Index;
                }
                this.Roeld = RoleGridView.Rows[index].Cells[0].Value.ToString();
                PringMeng(this.Roeld);
                 //MessageBox.Show(RoleGridView.Rows[index].Cells[1].Value.ToString());
                //ScanDateView(new SalesManService().GetBySalesManID(SalesManGridView.Rows[index].Cells[0].Value.ToString()));
            }
        }
        IList<RoleAction> roleActions = new List<RoleAction>();
        private void AddPit_Click(object sender, EventArgs e)
        {
            roleActions.Clear();
            foreach (TreeNode n in treeTest.Nodes)
            {
                AdditRecursive(n);
            }

            bool staut = new RoleActionService().UpdataRoleAction(roleActions, Roeld);
            if (staut)
            {
                MessageBox.Show("操作成功！");
               
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
            //foreach(RoleAction role in roleActions)
            //{
            //    Console.WriteLine(role.ActionId + " --- " + role.RoleId + " ----- " + role.ParentActionId);
            //}




        }
        private void AdditRecursive(TreeNode treeNode)
        {
            if (treeNode.Checked)
            {
                RoleAction roleAction = new RoleAction();
                roleAction.RoleId = this.Roeld;
                roleAction.ActionId = RoleActionsNameDictiony[treeNode.Text];
                roleAction.ParentActionId = RoleActionSump[roleAction.ActionId];

                roleActions.Add(roleAction);
            }
            //MessageBox.Show(treeNode.Text);
            // Visit each node recursively.
            foreach (TreeNode n in treeNode.Nodes)
            {
                AdditRecursive(n);
            }
        }
    }
}
