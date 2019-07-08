using Kanban.Bussines.Abstract;
using Kanban.Bussines.Concrete;
using Kanban.DataAccess.Concreate.EntityFramework;
using Kanban.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban
{
    public partial class Form1 : Form
    {
        IUserService _userService;
        User _loginUser;
         
        public string userName = ""; 
        public int userId =0;
        public int Id;
        public Form1()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _userService.Add(new Entities.Concrete.User
            {
                Name=tbxUserName.Text,
                Surname=tbxSurname.Text,
                Password=tbxPassword.Text,
                Email = tbxEmail.Text
            });
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgwList.DataSource = _userService.GetAll();
        }
      
        private void btnToDoList_Click(object sender, EventArgs e)
        {
            KanbanCreate newPage = new KanbanCreate();
            newPage.Show();
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _loginUser =_userService.Login(tbxPassName.Text,tbxPassPassword.Text);
            if (_loginUser != null)
            {
                KanbanCreate newPage = new KanbanCreate();
                userName = _loginUser.Name;
                userId = _loginUser.Id;
                newPage.userValues(userId, userName);
                newPage.Show();
                this.Hide();
            }
            else lbltry.Text = "Girdiğiniz bilgiler hatalı";
        }
    }
}
