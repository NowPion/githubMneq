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
    public partial class MainForm : Form
    {
        
        IList<WinAction> winActionList;
        IList<RoleAction> roleActionsList;
        public static User AndroidUser;
        Dictionary<string, Action<object, EventArgs>> SalesManin = new Dictionary<string, Action<object, EventArgs>>();
        public MainForm(string username)
        {

            AndroidUser = new UserService().GetUser(username);
            InitializeComponent();
            SalesManinAdd();
           
        }

        void SalesManinAdd()
        {
            SalesManin.Add("002", new Action<object, EventArgs>(NewMenuItem_Click));
            SalesManin.Add("003", new Action<object, EventArgs>(OpenMenuItem_Click));
            SalesManin.Add("004", new Action<object, EventArgs>(SaveMenuItem_Click));
            SalesManin.Add("005", new Action<object, EventArgs>(PuraMenuItem_Click));
            SalesManin.Add("007", new Action<object, EventArgs>(ioeMenuItem_Click));                                                                                                    
            SalesManin.Add("046", new Action<object, EventArgs>(Permissions_Click));
            SalesManin.Add("012", new Action<object, EventArgs>(DeliveryMaster_Click));
        }
        public ToolStripMenuItem ToolSit(string roleAction)
        {
            ToolStripMenuItem fileMenuItem = new ToolStripMenuItem();
            fileMenuItem.Text = new WinActionService().GetWinAction(roleAction).ActionName;
            if (SalesManin.ContainsKey(roleAction))
            {
                fileMenuItem.Click += SalesManin[roleAction].Invoke;
                return fileMenuItem;
            }

            foreach (RoleAction role in roleActionsList)
            {
                if (role.ParentActionId == roleAction)
                {
                 
                    fileMenuItem.DropDownItems.Add(ToolSit(role.ActionId));

                }
            }

            return fileMenuItem;
        }




    private void MainForm_Load(object sender, EventArgs e)
        {

            //winActionList = AndroidUser.UserRoleActionList;
            roleActionsList = AndroidUser.UserRoleActionList;

            userNametool.Text = AndroidUser.UserName;
            passtool.Text = AndroidUser.RoleName;

            foreach (RoleAction win in roleActionsList)
            {

                if (win.ParentActionId == "000")
                {
                    menuStrip.Items.Add(ToolSit(win.ActionId));
                }
              
            }

              MainMenuStrip = menuStrip;
        }

        public void NewMenuItem_Click(object sender, EventArgs e)
        {
            SalesManForm salesManForm = new SalesManForm();
            salesManForm.MdiParent = this;
            salesManForm.Show();
        }
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.MdiParent = this;
            customerForm.Show();
        }
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.MdiParent = this;
            productForm.Show();

        }
        private void PuraMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.MdiParent = this;
            supplierForm.Show();
        }
        private void ioeMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseMasterForm purchaseMasterForm = new PurchaseMasterForm();
            purchaseMasterForm.MdiParent = this;
            purchaseMasterForm.Show();
        }

        private void Permissions_Click(object sender, EventArgs e)
        {
            PermissionsForm permissionsForm = new PermissionsForm();
            permissionsForm.MdiParent = this;
            permissionsForm.Show();
        }

        private void DeliveryMaster_Click(object sender, EventArgs e)
        {
            DeliveryMasterForm deliveryMasterForm = new DeliveryMasterForm();
            deliveryMasterForm.MdiParent = this;
            deliveryMasterForm.Show();
        }

    }
}
