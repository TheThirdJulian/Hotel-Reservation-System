using HotelDBMS.DBModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDBMS
{
    public partial class FormEmployeeRooms : Form
    {
        private UserRepo repo;

        private int SelectedId = 0;

        public FormEmployeeRooms()
        {
            InitializeComponent();

            repo = new UserRepo();
            LoadRoomsDB();
        }

        private void LoadRoomsDB() 
        {
            HotelDBEntities db = new HotelDBEntities();
            DgvRooms.DataSource = db.Rooms.ToList();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtType.Clear();
            TxtPrice.Clear();
            TxtDesc.Clear();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtName.Text) || String.IsNullOrEmpty(TxtType.Text) || String.IsNullOrEmpty(TxtPrice.Text))
            {
                MessageBox.Show("Cannot register! One of the inputs is invalid!", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Rooms addedroom = new Rooms();
            addedroom.roomname = TxtName.Text;
            addedroom.roomtype = TxtType.Text;
            addedroom.roomprice = Convert.ToDecimal(TxtPrice.Text);
            addedroom.roomdesc = TxtDesc.Text;
            addedroom.roomoccupants = 0;

            HotelDBEntities db = new HotelDBEntities();
            db.Rooms.Add(addedroom);
            db.SaveChanges();
            MessageBox.Show("Room successfully added!", "Successful Room Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SelectedId = 0;
            BtnClear_Click(sender, e);
            LoadRoomsDB();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtName.Text) || String.IsNullOrEmpty(TxtType.Text) || String.IsNullOrEmpty(TxtPrice.Text))
            {
                MessageBox.Show("Cannot update! One of the inputs is invalid!", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Rooms updatedroom = repo.GetRoomById(SelectedId);
            //updatedroom.roomname = TxtName.Text;
            //updatedroom.roomtype = TxtType.Text;
            //updatedroom.roomprice = Convert.ToDecimal(TxtPrice.Text);
            //updatedroom.roomdesc = TxtDesc.Text;

            HotelDBEntities db = new HotelDBEntities();
            db.SP_Room_Update(SelectedId, TxtName.Text, TxtType.Text, Convert.ToDecimal(TxtPrice.Text), TxtDesc.Text);

            //db.SaveChanges();
            MessageBox.Show("Room successfully updated!", "Successful Room Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SelectedId = 0;
            BtnClear_Click(sender, e);
            LoadRoomsDB();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedId == 0)
            {
                MessageBox.Show("Cannot delete! Select a room first!", "No Selected Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HotelDBEntities db = new HotelDBEntities();
            db.SP_Room_Delete(SelectedId);

            //Rooms deletedroom = repo.GetRoomById(SelectedId);
            //db.Rooms.Remove(deletedroom);
            //db.SaveChanges();
            MessageBox.Show("Room successfully deleted!", "Successful Room Deletion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            SelectedId = 0;
            BtnClear_Click(sender, e);
            LoadRoomsDB();
        }

        private void DgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedId = Convert.ToInt32(DgvRooms.Rows[e.RowIndex].Cells[0].Value);
                Rooms selectedroom = repo.GetRoomById(SelectedId);

                LabelId.Text = SelectedId.ToString();
                TxtName.Text = selectedroom.roomname;
                TxtType.Text = selectedroom.roomtype;
                TxtPrice.Text = selectedroom.roomprice.ToString();
                TxtDesc.Text = selectedroom.roomdesc;
                if (selectedroom.roomoccupants == 0)
                {
                    LabelStatus.Text = "AVAILABLE";
                }
                else 
                {
                    LabelStatus.Text = "OCCUPIED";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Dispose();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            FormEmployeeHome home = new FormEmployeeHome();
            home.Show();
            this.Dispose();
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter)) 
            {
                decimal price;
                if (!decimal.TryParse(TxtPrice.Text, out price))
                {
                    MessageBox.Show("Please input numbers only!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPrice.Text = TxtPrice.Text.Substring(0, TxtPrice.Text.Length - 1);
                }
            }
        }
    }
}
