using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

/*
    Варіант 5. Додаток зберігає інформацію про книги і авторів у бібліотеці.Кожна книга характеризується автором, назвою, видавництвом і роком видання.
    Реалізувати можливість редагування інформації про авторів, видавництвах і книгах.
    Реалізувати можливість збереження, вилучення та зміни даних про книги, видавництвах і авторів у таблиці БД.
*/

namespace SysPro_Lab_07
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        StringBuilder DBpath;

        public Form1()
        {
            InitializeComponent();
            DBpath = new StringBuilder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoadButton_Click_1(object sender, EventArgs e)
        {
            this.libraryTableAdapter.Fill(this.databaseDataSet.Library);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.libraryTableAdapter.Update(this.databaseDataSet);
            SqlCommand cmdUpdateDB = new SqlCommand("INSERT INTO Library" + "(ID,FIO,Grupa) Values (@ID,@FIO,@Grupa)");
)
        }
    }
}
