using System;
using Sort.Presenter;
using Sort.View;
using System.Windows.Forms;

namespace Sort
{
    public partial class MainWindow : Form, ISort
    {
        private SortPresenter _sortPresenter;

        public string InputArray { get => TxtInputArray.Text; set => TxtInputArray.Text = value; }
        public string OutputArray { get => TxtSortedArray.Text; set => TxtSortedArray.Text = value; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _sortPresenter = new SortPresenter(this);
            TxtInputArray.Text = string.Join(" ", _sortPresenter.SetArray());
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            _sortPresenter = new SortPresenter(this);
            TxtSortedArray.Text = string.Join(" ", _sortPresenter.GetArray());
        }
    }
}