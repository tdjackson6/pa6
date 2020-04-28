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
    public partial class frmEdit : Form
    {
        private Book myBook;
        private string cwid;
        private string mode;

        public frmEdit(object tempBook, string tempMode, string tempCwid)
        {
            myBook = (Book)tempBook;
            cwid = tempCwid;
            mode = tempMode;
            InitializeComponent();
            pbCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if(mode == "edit")
            {
                txtTitleData.Text = myBook.title;
                txtAuthorData.Text = myBook.author;
                txtGenreData.Text = myBook.genre;
                txtCopiesData.Text = myBook.copies.ToString();
                txtISBNData.Text = myBook.isbn;
                txtCoverData.Text = myBook.cover;
                txtLengthData.Text = myBook.length.ToString();

                pbCover.Load(myBook.cover);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            myBook.title = txtTitleData.Text ;
            myBook.author = txtAuthorData.Text;
            myBook.genre = txtGenreData.Text;
            myBook.copies= int.Parse(txtCopiesData.Text);
            myBook.isbn = txtISBNData.Text;
            myBook.cover = txtCoverData.Text;
            myBook.length = int.Parse(txtLengthData.Text);
            myBook.cwid = cwid;

            BookFile.SaveBook(myBook, cwid, mode);

            MessageBox.Show("Content was saved", "Saved", MessageBoxButtons.OK,MessageBoxIcon.Information);

            this.Close();
        }
    }
}
