using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aac_project
{
    public partial class Form1 : Form
    {
        TrueOrFalse tofBF { get; set; }
        TrueOrFalse tofGreedy { get; set; }
        TrueOrFalse tofBoth { get; set; }

        public Form1()
        {
            InitializeComponent();

            greedyDataGridView.ColumnCount = 2;
            greedyDataGridView.Columns[1].Name = "Results";
            greedyDataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            greedyDataGridView.Columns[1].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            greedyDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            greedyDataGridView.Columns[1].Frozen = false;
            greedyDataGridView.Columns[0].Name = "Sum";
            greedyDataGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            greedyDataGridView.Columns[0].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            greedyDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            greedyDataGridView.Columns[0].Frozen = false;
            greedyDataGridView.Columns[0].FillWeight = 10;
            greedyDataGridView.AllowUserToAddRows = false;
            greedyDataGridView.RowHeadersVisible = false;
            greedyDataGridView.Enabled = true;
            greedyDataGridView.ScrollBars = ScrollBars.Horizontal;

            bfDataGridView.ColumnCount = 2;
            bfDataGridView.Columns[1].Name = greedyDataGridView.Columns[1].Name;
            bfDataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bfDataGridView.Columns[1].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            bfDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bfDataGridView.Columns[1].Frozen = false;
            bfDataGridView.Columns[0].Name = greedyDataGridView.Columns[0].Name;
            bfDataGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bfDataGridView.Columns[0].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            bfDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bfDataGridView.Columns[0].Frozen = false;
            bfDataGridView.Columns[0].FillWeight = 10;
            bfDataGridView.AllowUserToAddRows = false;
            bfDataGridView.RowHeadersVisible = false;
            bfDataGridView.Enabled = true;
            bfDataGridView.ScrollBars = ScrollBars.Horizontal;

            tofGreedy = new TrueOrFalse();
            tofBF = new TrueOrFalse();
            tofBoth = new TrueOrFalse();
            controlsInputGreedyTextBox.DataBindings.Add("ForeColor", tofGreedy, "Clr");
            controlsInputGreedyButton.DataBindings.Add("Enabled", tofGreedy, "IsTrue");
            controlsInputBFButton.DataBindings.Add("Enabled", tofBF, "IsTrue");
            controlsInputBFTextBox.DataBindings.Add("ForeColor", tofBF, "Clr");
            conrolsSameInputCalculateButton.DataBindings.Add("Enabled", tofBoth, "IsTrue");
        }

        private void controlsInputGreedyButton_Click(object sender, EventArgs e)
        {
            RunGreedy();
        }

        private void RunGreedy()
        {
            if (!tofGreedy.IsTrue)
            {
                return;
            }
            List<int> testListLong = new List<int> { 2, 3, 4, 5, 6, 7, 8, 1, 1, 2, 15, 10,
                12, 3, 15, 16, 17, 12, 3, 1, 2, 3, 4, 5, 6, 7, 8, 1, 1, 2, 15, 10, 12, 3, 15, 16,
                17, 12, 3, 1, 2, 3, 4, 5, 6, 7, 8, 1, 1, 2, 15, 10, 12, 3, 15, 16, 17, 12, 3, 1, 2,
                3, 4, 5, 6, 7, 8, 1, 1, 2, 15, 10, 12, 3, 15, 16, 17, 12, 3, 1, 2, 3, 4, 5, 6, 7,
                8, 1, 1, 2, 15, 10, 12, 3, 15, 16, 17, 12, 3, 1, 2, 3, 4, 5, 6, 7, 8, 1, 1, 2, 15 };
            List<int> testList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 1, 1, 2, 15, 10,
                12, 3, 15, 16, 17, 12, 3 };

            string[] inputString = controlsInputGreedyTextBox.Text.Split(',');
            if (inputString.Length < 4)
            {
                return;
            }
            List<int> input = new List<int>();
            foreach (var num in inputString)
            {
                input.Add(int.Parse(num));
            }

            List<List<int>> resultThread = null;
            Thread thread = new Thread(() =>
            {
                resultThread = GreedyFind(input);
            });
            tofGreedy.IsTrue = false;
            controlsInputGreedyTextBox.Enabled = false;
            Stopwatch sw = Stopwatch.StartNew();
            thread.Start();
            thread.Join();
            sw.Stop();
            greedyDataGridView.Columns[1].Name = $"Results - {sw.Elapsed.TotalSeconds.ToString()}s";
            tofGreedy.IsTrue = true;
            controlsInputGreedyTextBox.Enabled = true;

            greedyDataGridView.Rows.Clear();
            foreach (var list in resultThread)
            {
                greedyDataGridView.Rows.Add(new string[] { list.Sum().ToString(), string.Join("  ", list.ToArray()) });
            }
            greedyDataGridView.CurrentCell.Selected = false;
        }

        private List<List<int>> GreedyFind(List<int> S)
        {
            if (S.Count < 4)
            {
                return null;
            }

            int i = 1;
            while (i < S.Count)
            {
                int j = i;
                while (j > 0 && S[j - 1] < S[j])
                {
                    int tmp = S[j];
                    S[j] = S[j - 1];
                    S[j - 1] = tmp;
                    j--;
                }
                i++;
            }
            List<List<int>> ret = new List<List<int>>();
            for (int k = 0; k < 4; k++)
            {
                ret.Add(new List<int>());
                ret[k].Add(S[0]);
                S.RemoveAt(0);
            }
            foreach (var num in S)
            {
                var index = HelperFindIndex(ret);
                ret[index].Add(num);
                //S.Remove(num);
            }
            return ret;
        }

        private int HelperFindIndex(List<List<int>> list)
        {
            var listSum = new List<int>();
            foreach (var l in list)
            {
                listSum.Add(l.Sum());
            }
            var indexMin = 0;
            for (int i = 0; i < listSum.Count; i++)
            {
                if (listSum[indexMin] > listSum[i])
                {
                    indexMin = i;
                }
            }
            return indexMin;
        }

        private void RunBruteForce()
        {
            MessageBox.Show("TO DO");
        }

        private void greedyDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            MessageBox.Show((sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), e.ColumnIndex == 0 ? "Sum" : "Full subset");
        }

        private void controlsLoadFromFileButton_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt";
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName);
                controlsInputGreedyTextBox.Text = sr.ReadToEnd();
                controlsInputBFTextBox.Text = controlsInputGreedyTextBox.Text;
            }
        }

        private void controlsInputBFButton_Click(object sender, EventArgs e)
        {
            RunBruteForce();
        }

        private void conrolsSameInputCalculateButton_Click(object sender, EventArgs e)
        {
            RunGreedy();
            RunBruteForce();
        }

        private void controlsInputGreedyTextBox_TextChanged(object sender, EventArgs e)
        {
            var txt = (sender as TextBox).Text;
            if (txt.Length <= 0)
            {
                return;
            }
            string[] txtSplit = txt.Split(',');
            try
            {
                foreach (string num in txtSplit)
                {
                    int.Parse(num);
                }
                if (txtSplit.Length >= 4)
                {
                    tofGreedy.IsTrue = true;
                    tofGreedy.Clr = Color.Black;
                    if (tofBF.IsTrue)
                    {
                        tofBoth.IsTrue = true;
                    }
                }
            }
            catch (FormatException ex)
            {
                tofGreedy.Clr = Color.Red;
                tofGreedy.IsTrue = false;
                tofBoth.IsTrue = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error caught {ex.ToString()}");
            }
        }

        private void controlsInputBFTextBox_TextChanged(object sender, EventArgs e)
        {
            var txt = (sender as TextBox).Text;
            if (txt.Length <= 0)
            {
                return;
            }
            string[] txtSplit = txt.Split(',');
            try
            {
                foreach (string num in txtSplit)
                {
                    int.Parse(num);
                }
                if (txtSplit.Length >= 4)
                {
                    tofBF.IsTrue = true;
                    tofBF.Clr = Color.Black;
                    if (tofGreedy.IsTrue)
                    {
                        tofBoth.IsTrue = true;
                    }
                }
            }
            catch (FormatException ex)
            {
                tofBF.Clr = Color.Red;
                tofBF.IsTrue = false;
                tofBoth.IsTrue = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error caught {ex.ToString()}");
            }
        }
    }
    public class TrueOrFalse : INotifyPropertyChanged
    {
        private bool _isTrue;
        private Color _clr;
        public event PropertyChangedEventHandler PropertyChanged;
        public TrueOrFalse()
        {
            _isTrue = false;
            _clr = Color.Red;
        }
        public bool IsTrue
        {
            get { return _isTrue; }
            set
            {
                _isTrue = value;
                RaisePropertyChanged("IsTrue");
            }
        }
        public Color Clr
        {
            get { return _clr; }
            set
            {
                _clr = value;
                RaisePropertyChanged("Clr");
            }
        }
        private void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
