using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TeamOutliers
{
    public partial class Form3 : Form
    {
        private Form2 previousForm;
        private StreamWriter streamWriter;

        public Form3(Form2 form, StreamWriter streamWriter)
        {
           this.streamWriter = streamWriter;
            previousForm = form;
            InitializeComponent();
        }

        public void saveData()
        {
            streamWriter.WriteLine("");
            streamWriter.WriteLine("ACCIDENTS:");
            List<ListViewItem> dataHistory = historyListView.Items.Cast<ListViewItem>().ToList();

            foreach (ListViewItem item in dataHistory)
            {
                String value = "";
                var subitems = item.SubItems;
                for (int i = 0; i < subitems.Count; i++)
                {
                    value += subitems[i].Text+" ";
                }
                streamWriter.WriteLine(value);
            }

            streamWriter.WriteLine("");
            streamWriter.WriteLine("SURGERIES AND HOSPITALIZATION:");
            List<ListViewItem> dataHospital = hospitalListView.Items.Cast<ListViewItem>().ToList();

            foreach (ListViewItem item in dataHospital)
            {
                String value = "";
                var subitems = item.SubItems;
                for (int i = 0; i < subitems.Count; i++)
                {
                    value += subitems[i].Text + " ";
                }
                streamWriter.WriteLine(value);
            }
       
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for entering your information!");
            saveData();
         
            this.streamWriter.Close();

            this.Hide(); 

            Form1 form1 = new Form1();
            form1.Show();
            
        }

        private void historyListView_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch (button.Name)
            {

                case "addHistoryButton":
                    addEntryToTheListView(historyYearTextBox.Text, historyTypeTextBox.Text, historyPainTextBox.Text, historyListView);
                    break;
                case "removeHistoryButton":
                    historyListView.Items.Cast<ListViewItem>().
                    Where(T => T.Selected).
                    Select(T => T.Index).ToList().
                    ForEach(T => historyListView.Items.RemoveAt(T));
                    break;
                case "hospitalAddButton":
                    addEntryToTheHospitalListView(hospitalYearTextBox.Text, hospitalReasonTextBox.Text, hospitalPainTextBox.Text, hospitalListView);
                    break;

                case "hospitalRemoveButton":
                    hospitalListView.Items.Cast<ListViewItem>().
                    Where(T => T.Selected).
                    Select(T => T.Index).ToList().
                    ForEach(T => hospitalListView.Items.RemoveAt(T));
                    break;
            }
        }

        private void addEntryToTheListView(String year, String type, String pain, ListView listView)
        {
            if (year != "" && type != "" && pain != "")
            {

                string[] row = { year, type, pain };
                
                ListViewItem listViewItem = new ListViewItem(row);
                listView.Items.Add(listViewItem);


            }
        }

        private void addEntryToTheHospitalListView(String year, String type, String pain, ListView listView)
        {
            if (year != "" && type != "" && pain != "")
            {

                string[] row = { year, type, pain };

                ListViewItem listViewItem = new ListViewItem(row);
                listView.Items.Add(listViewItem);


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            returnToPreviousPage();
        }

        private void returnToPreviousPage()
        {
            previousForm.Show();
            this.Hide();
        }

        private void returnToFirstPage()
        {
            previousForm.getPreviousForm().Show();
            this.Hide();
        }

        private void page1_Click(object sender, EventArgs e)
        {
            returnToFirstPage();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            returnToPreviousPage();
        }


    }
}
