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
using System.Xml;

namespace aac_project
{
    public partial class Form1 : Form
    {
        TrueOrFalse tofBF { get; set; }
        TrueOrFalse tofGreedy { get; set; }
        TrueOrFalseBoth tofBoth { get; set; }
        StreamWriter swBF;
        StreamWriter swGreedy;

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

            bfDataGridView.ColumnCount = 3;
            bfDataGridView.Columns[2].Name = greedyDataGridView.Columns[1].Name;
            bfDataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bfDataGridView.Columns[2].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            bfDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bfDataGridView.Columns[2].Frozen = false;
            bfDataGridView.Columns[0].Name = greedyDataGridView.Columns[0].Name;
            bfDataGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bfDataGridView.Columns[0].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            bfDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bfDataGridView.Columns[0].Frozen = false;
            bfDataGridView.Columns[0].FillWeight = 10;
            bfDataGridView.Columns[1].Name = "Occ";
            bfDataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bfDataGridView.Columns[1].HeaderCell.Style.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            bfDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bfDataGridView.Columns[1].Frozen = false;
            bfDataGridView.Columns[1].FillWeight = 10;
            bfDataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            bfDataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            bfDataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            bfDataGridView.AllowUserToAddRows = false;
            bfDataGridView.RowHeadersVisible = false;
            bfDataGridView.Enabled = true;
            bfDataGridView.ScrollBars = ScrollBars.Vertical;

            tofGreedy = new TrueOrFalse();
            tofBF = new TrueOrFalse();
            tofBoth = new TrueOrFalseBoth();
            controlsInputGreedyTextBox.DataBindings.Add("ForeColor", tofGreedy, "Clr");
            controlsInputGreedyButton.DataBindings.Add("Enabled", tofGreedy, "IsTrue");
            controlsInputBFButton.DataBindings.Add("Enabled", tofBF, "IsTrue");
            controlsInputBFTextBox.DataBindings.Add("ForeColor", tofBF, "Clr");
            conrolsSameInputCalculateButton.DataBindings.Add("Enabled", tofBoth, "IsTrueBoth");

            //swBF = new StreamWriter(@"C:\Szkola\aac\outBF.txt");
            //swGreedy = new StreamWriter(@"C:\Szkola\aac\outGreedy.txt");
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
            tofGreedy.IsTrue = false;
            controlsInputGreedyTextBox.Enabled = false;
            tofBoth.IsTrueBoth = false;
            greedyBackgroundWorker.RunWorkerAsync(input);
        }

        private void RunBruteForce()
        {
            if (!tofBF.IsTrue)
            {
                return;
            }
            string[] inputString = controlsInputBFTextBox.Text.Split(',');
            if (inputString.Length < 4)
            {
                return;
            }
            List<int> input = new List<int>();
            foreach (var num in inputString)
            {
                input.Add(int.Parse(num));
            }
            tofBF.IsTrue = false;
            controlsInputBFTextBox.Enabled = false;
            tofBoth.IsTrueBoth = false;
            //input.Sort();
            bfBackgroundWorker.RunWorkerAsync(input);
            //var tmp = GetAllPartitions(input.ToArray(), input.Count);
            //var res = tmp.Where(x => x.Count == 4);
            //MessageBox.Show("XD");
            //greedyDataGridView.Columns[1].Name = $"Results"; //- {res.Item2.Elapsed.TotalSeconds.ToString()}s
            //tofBF.IsTrue = true;
            //controlsInputBFTextBox.Enabled = true;
            //bfDataGridView.Rows.Clear();
            //foreach (var list_list in res)
            //{
            //    foreach (var list in list_list)
            //    {
            //        bfDataGridView.Rows.Add(new string[] { list.Sum().ToString(), string.Join(", ", list.ToArray()) });
            //    }
            //}

            //bfDataGridView.CurrentCell.Selected = false;
        }

        // adapted from a similar question on so
        public static IEnumerable<List<List<int>>> GetPartitions(int[] elements, int numOfElements)
        {

            if (numOfElements <= 0)
            {
                yield return new List<List<int>>();
            }
            else
            {
               
                int elem = elements[numOfElements - 1];
                var shorter = GetPartitions(elements, numOfElements - 1);

                foreach (var part in shorter)
                {
                    var newlist = new List<int>();
                    newlist.Add(elem);
                    part.Add(newlist);
                    yield return part;
                    part.RemoveAt(part.Count - 1);
                    foreach (var list in part.ToArray())
                    {
                        list.Add(elem);
                        yield return part;
                        list.RemoveAt(list.Count - 1);
                    }
                }
            }
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

        private void greedyDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var grid = (sender as DataGridView);
            if (grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value is null)
            {
                return;
            }
            MessageBox.Show(grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), e.ColumnIndex == 0 ? "Sum" : "Full subset");
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
                    if (tofBF.IsTrue && tofGreedy.IsTrue)
                    {
                        tofBoth.IsTrueBoth = true;
                    }
                }
            }
            catch (FormatException ex)
            {
                tofGreedy.Clr = Color.Red;
                tofGreedy.IsTrue = false;
                tofBoth.IsTrueBoth = false;
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
                    if (tofBF.IsTrue && tofGreedy.IsTrue)
                    {
                        tofBoth.IsTrueBoth = true;
                    }
                }
            }
            catch (FormatException ex)
            {
                tofBF.Clr = Color.Red;
                tofBF.IsTrue = false;
                tofBoth.IsTrueBoth = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error caught {ex.ToString()}");
            }
        }

        private void bfBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<int> input = (List<int>)e.Argument;

            Stopwatch sw = Stopwatch.StartNew();
            var tmp = GetPartitions(input.ToArray(), input.Count);
            var res = tmp.Where(x => x.Count == 4);
            var res_optimal = FindMinPartitions(res);
            sw.Stop();
            e.Result = (res_optimal, sw);
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(1000);
            //}
        }

        private void bfBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            (List<List<List<int>>>, Stopwatch) res = ((List<List<List<int>>>, Stopwatch))e.Result;
            tofBF.IsTrue = true;
            if (tofGreedy.IsTrue)
            {
                tofBoth.IsTrueBoth = true;
            }
            controlsInputBFTextBox.Enabled = true;
            //MessageBox.Show(res.Item1.Count.ToString());
            bfDataGridView.Rows.Clear();
            MyDictionary myDictionary = new MyDictionary();

            foreach (var list_list in res.Item1)
            {
                myDictionary.Add(list_list);
            }
            bfDataGridView.Columns[2].Name = $"{myDictionary.Count.ToString()} Results - {res.Item2.Elapsed.TotalSeconds.ToString()}s";
            foreach (var pair in myDictionary.GetDict())
            {
                foreach (var list in pair.Key)
                {
                    bfDataGridView.Rows.Add(new string[] { list.Sum().ToString(), pair.Value.ToString(), string.Join(", ", list.ToArray()) });
                }
                //bfDataGridView.Rows.Add();
                if (myDictionary.GetDict().Last().Key != pair.Key)
                {
                    bfDataGridView.Rows.Add();
                }
            }
            //swBF.WriteLine(res.Item2.Elapsed.TotalSeconds.ToString());
            //swBF.Flush();
            //.CurrentCell.Selected = false;
        }

        private void greedyBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<int> input = (List<int>)e.Argument;

            Stopwatch sw = Stopwatch.StartNew();
            var res = GreedyFind(input);
            sw.Stop();
            e.Result = (res, sw);
            
        }

        private void greedyBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            (List<List<int>>, Stopwatch) res = ((List<List<int>>, Stopwatch))e.Result;
            //MessageBox.Show(res.ToString());

            greedyDataGridView.Columns[1].Name = $"Results - {res.Item2.Elapsed.TotalSeconds.ToString()}s";
            tofGreedy.IsTrue = true;
            if (tofBF.IsTrue)
            {
                tofBoth.IsTrueBoth = true;
            }
            controlsInputGreedyTextBox.Enabled = true;

            greedyDataGridView.Rows.Clear();
            foreach (var list in res.Item1)
            {
                greedyDataGridView.Rows.Add(new string[] { list.Sum().ToString(), string.Join(", ", list.ToArray()) });
            }
            greedyDataGridView.CurrentCell.Selected = false;
            //swGreedy.WriteLine(res.Item2.Elapsed.TotalSeconds.ToString());
            //swGreedy.Flush();
        }

        private List<List<List<int>>> FindMinPartitions(IEnumerable<List<List<int>>> paritions)
        {
            List<List<List<int>>> exactSolutions = new List<List<List<int>>>();
            Dictionary<List<List<int>>, int> minMaxIndexList = new Dictionary<List<List<int>>, int>();
            Dictionary<int, int> minMaxIndex = new Dictionary<int, int>();
            List<int> sums = new List<int>();
            List<int> exactSolutionsIndex = new List<int>();
            foreach (var parition in paritions.Select((Value, Index) => new { Value, Index }))
            {
                sums.Clear();
                foreach (var set in parition.Value)
                {
                    sums.Add(set.Sum());
                }
                if (sums.Distinct().Count()==1 && sums.Count==4) 
                {
                    exactSolutionsIndex.Add(parition.Index);
                }
                else if (exactSolutions.Count == 0)
                {
                    var sumDiff = sums.Max() - sums.Min();
                    if (parition.Index==0)
                    {
                        minMaxIndex.Add(parition.Index, sumDiff);
                        continue;
                    }
                    if (sumDiff <= minMaxIndex.Where(x=>x.Value == minMaxIndex.Min(e => e.Value)).First().Value)
                    {
                        minMaxIndex.Add(parition.Index, sumDiff);
                    }
                }
            }
            if (exactSolutionsIndex.Count==0)
            {
                var tmp = minMaxIndex.Where(x => x.Value == minMaxIndex.Min(e => e.Value));
                List<List<List<int>>> res = new List<List<List<int>>>();
                foreach (var key in tmp)
                {
                    res.Add(paritions.ElementAt(key.Key));
                }
                return res;
            }
            else
            {
                List<List<List<int>>> res = new List<List<List<int>>>();
                foreach (var key in exactSolutionsIndex)
                {
                    res.Add(paritions.ElementAt(key));
                }
                return res;
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

    public class TrueOrFalseBoth : INotifyPropertyChanged
    {
        private bool _isTrueBF;
        private bool _isTrueGreedy;
        private bool _isTrue;
        public event PropertyChangedEventHandler PropertyChanged;
        public TrueOrFalseBoth()
        {
            _isTrueBF = false;
            _isTrueGreedy = false;
        }
        public bool IsTrueBoth
        {
            get { return _isTrue; }
            set
            {
                _isTrue = value;
                RaisePropertyChanged("IsTrueBoth");
            }
        }
        public bool IsTrueGreedy
        {
            get { return _isTrueGreedy; }
            set
            {
                if (value && _isTrueBF)
                {
                    this.IsTrueBoth = true;
                }
                _isTrueGreedy = value;
            }
        }

        public bool IsTrueBF
        {
            get { return _isTrueBF; }
            set
            {
                if (value && _isTrueGreedy)
                {
                    this.IsTrueBoth = true;
                }
                _isTrueBF = value;
            }
        }
        private void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class MyDictionary
    {
        private Dictionary<List<List<int>>, int> dict;

        public MyDictionary()
        {
            dict = new Dictionary<List<List<int>>, int>();
        }
        public void Add(List<List<int>> list)
        {
            if (dict.Count == 0)
            {
                dict.Add(list, 1);
                return;
            }
            foreach (var elem in dict)
            {
                if (MyEquals(elem.Key, list))
                {
                    dict[elem.Key]++;
                    return;
                }
            }
            dict.Add(list, 1);
        }
        private static bool MyEquals(List<List<int>> list1, List<List<int>> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }
            var list11 = list1.OrderByDescending(l => l.Sum()).ToList();
            var list22 = list2.OrderByDescending(l => l.Sum()).ToList();
            for (int i = 0; i < list11.Count; i++)
            {
                if (list11[i].Sum() != list22[i].Sum())
                {
                    return false;
                }
                list11[i].Sort();
                list22[i].Sort();
                for (int j = 0; j < list11[i].Count; j++)
                {
                    if (list11[i][j] != list22[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public Dictionary<List<List<int>>, int> GetDict()
        {
            return dict;
        }

        public int Count
        {
            private set { }
            get { return dict.Count; }
        }

    }
}
