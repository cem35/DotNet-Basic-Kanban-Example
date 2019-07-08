using Kanban.Bussines.Abstract;
using Kanban.Bussines.Concrete;
using Kanban.DataAccess.Abstract;
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
    public partial class KanbanCreate : Form
    {
       // IUserService _userService;
        IToDoListService _toDoListService;
        IToDoItemService _toDoItemService;
        //IDependencyService _dependencyService;

        EfToDoListDal _toDoListDal  = new EfToDoListDal();
        EfToDoItemDal _toDoItemDal  = new EfToDoItemDal();
        //EfDependency  _dependency   = new EfDependency();

        int _userId;
        string _listName;

        public KanbanCreate()
        {
            InitializeComponent();
           // _userService = new UserManager(new EfUserDal());
            _toDoListService = new ToDoListManager(new EfToDoListDal());
            _toDoItemService = new ToDoItemManager(new EfToDoItemDal());
        }
 
        public void userValues(int id ,string listName)
        {
            _userId = id;
            _listName = listName;
        }

        public void CleanInputs()
        {
            tbxTableName.Text = "";
            tbxDescription.Text = "";
            tbxName.Text = "";
            cbxStatus.SelectedIndex = 0;
        }

        public void ComboBoxLoad()
        {
            cbxStatus.Items.Insert(0, "Not Started"); 
            cbxStatus.Items.Insert(1, "In Progress");
            cbxStatus.Items.Insert(2, "Compleated");
        }

        private void KanbanCreate_Load(object sender, EventArgs e)
        {
            lblLoginUser.Text = _listName;
            LoadLists();
            ComboBoxLoad();
            CleanInputs();
        }

        private void LoadLists()
        {
            // dgwKanban1.DataSource  = _toDoItemService.GetById(_userId);
            if (_toDoListService.GetListById(_userId) != null)
            {
                var sourceList = _toDoListService.GetListById(_userId);
                dgvListItem.DataSource = sourceList.Select(o => new ToDoListListView()
                { UserId = o.Id,
                  ListName = o.Name }).ToList();
            }
            //  dgvListItem.DataSource = _toDoListService.GetListById(_userId);
            
        }

        private void LoadItems()
        {
            if (dgvListItem.RowCount > 0)
            {
                var sourceItem = _toDoItemService.GetById(int.Parse(dgvListItem.CurrentRow.Cells[0].Value.ToString()));
                dgwKanban1.DataSource = sourceItem.Select(p => new ToDoItemListView()
                { Name = p.Name,
                  Description = p.Description,
                  Deadline = p.Deadline,
                  Status = p.Status,
                  Id = p.Id,
                  ToDoListId = p.ToDoListId
                }).ToList();
               // ToDoListId = Convert.ToInt32(sourceItem.Select(x => x.ToDoListId));

            }
                //dgwKanban1.DataSource = _toDoItemService.GetById(int.Parse(dgwKanban1.CurrentRow.Cells[1].Value.ToString()));

        }

        private void dgwKanban1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwKanban1.CurrentRow.Cells[0].Value != null)
            {
                tbxName.Text = dgwKanban1.CurrentRow.Cells[2].Value.ToString();
                tbxDescription.Text = dgwKanban1.CurrentRow.Cells[3].Value.ToString();
                cbxStatus.SelectedIndex = Convert.ToInt32(dgwKanban1.CurrentRow.Cells[5].Value.ToString());
                dtpDeadline.Value = DateTime.Parse(dgwKanban1.CurrentRow.Cells[4].Value.ToString());
            }
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            _toDoListDal.Update(new ToDoList
            {
                Id = int.Parse(dgvListItem.CurrentRow.Cells[0].Value.ToString()),
                UserId = int.Parse(dgvListItem.CurrentRow.Cells[1].Value.ToString()),
                Name = _listName + "-" + tbxTableName.Text
            });
            LoadLists();
            LoadItems();
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            _toDoListDal.Delete(new ToDoList
            {
                Id = int.Parse(dgvListItem.CurrentRow.Cells[0].Value.ToString()),
                UserId = int.Parse(dgvListItem.CurrentRow.Cells[1].Value.ToString()),
                Name = dgvListItem.CurrentRow.Cells[2].Value.ToString()
            });

            _toDoItemDal.DeleteAll(int.Parse(dgvListItem.CurrentRow.Cells[0].Value.ToString()));
            LoadItems();
            LoadLists();
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            _toDoListDal.Add(new ToDoList
            {
                UserId = _userId,
                Name = _listName + "-" + tbxTableName.Text
            });

            LoadLists();
            LoadItems();
        }

        private void dgvListItemContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListItem.CurrentRow.Cells[0].Value != null)
            {
               // int ListItemId = Convert.ToInt32(dgvListItem.CurrentRow.Cells[0].Value.ToString());
               // dgwKanban1.DataSource = _toDoItemService.GetById(ListItemId);
                LoadItems();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            _toDoItemDal.Add(new ToDoItem
            {
                Name = tbxName.Text,
                Description = tbxDescription.Text,
                Deadline = DateTime.Parse(dtpDeadline.Text),
                Status =   cbxStatus.SelectedIndex.ToString(),
                ToDoListId = Convert.ToInt32(dgwKanban1.CurrentRow.Cells[1].Value.ToString())

            });
            CleanInputs();
            LoadItems();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            _toDoItemDal.Update(new ToDoItem
            {
                Id = Convert.ToInt32(dgwKanban1.CurrentRow.Cells[0].Value.ToString()),
                ToDoListId = Convert.ToInt32(dgwKanban1.CurrentRow.Cells[1].Value.ToString()),
                Name = tbxName.Text,
                Description = tbxDescription.Text,
                Deadline = DateTime.Parse(dtpDeadline.Text),
                Status = cbxStatus.SelectedIndex.ToString() 
                //DepId = 0
            });
            LoadItems();
            CleanInputs();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            _toDoItemDal.Delete(new ToDoItem
            {
                Id = Convert.ToInt32(dgwKanban1.CurrentRow.Cells[0].Value.ToString()),
                Name = dgwKanban1.CurrentRow.Cells[2].Value.ToString(),
                Description = dgwKanban1.CurrentRow.Cells[3].Value.ToString(),
                Deadline = Convert.ToDateTime(dgwKanban1.CurrentRow.Cells[4].Value.ToString()),
                Status = dgwKanban1.CurrentRow.Cells[5].Value.ToString()
            });
            LoadItems();
        }
    }
}
