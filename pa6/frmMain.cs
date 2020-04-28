using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa6
{
    public partial class frmMain : Form
    {
        List<Book> myBooks;
        string cwid;

        public frmMain(string tempCwid)
        {
            this.cwid = tempCwid;
            InitializeComponent();
            pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            myBooks = BookFile.GetAllBooks(cwid);
            lstBooks.DataSource = myBooks;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book myBook = (Book)lstBooks.SelectedItem;

            txtTitleData.Text = myBook.title;
            txtAuthorData.Text = myBook.author;
            txtISBNData.Text = myBook.isbn;
            txtGenreData.Text = myBook.genre;
            txtCopiesData.Text = myBook.copies.ToString();
            txtLengthData.Text = myBook.length.ToString();

            try
            {
                pbCover.Load(myBook.cover);
            }
            catch
            {

            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Book myBook = (Book)lstBooks.SelectedItem;
            myBook.copies--;
            BookFile.SaveBook(myBook, cwid, "edit");
            LoadList();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            Book myBook = (Book)lstBooks.SelectedItem;
            myBook.copies++;
            BookFile.SaveBook(myBook, cwid, "edit");
            LoadList();

        }
        
        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            Book myBook = (Book)lstBooks.SelectedItem;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                BookFile.DeleteBook(myBook, cwid);
                LoadList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Book myBooks = (Book)lstBooks.SelectedItem;
            frmEdit myForm = new frmEdit(myBooks,"edit",cwid);


            if(myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                LoadList();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {


            Book myBooks = new Book();
            frmEdit myForm = new frmEdit(myBooks, "new", cwid);


            if (myForm.ShowDialog() == DialogResult.OK)
            {

            }
            else
            {
                LoadList();
            }
        }
    }
}