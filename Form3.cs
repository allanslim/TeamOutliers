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
        private Form previousForm;
        private StreamWriter streamWriter;
       // Form1 form1 = new Form1();

        public Form3(Form form, StreamWriter streamWriter)
        {
           this.streamWriter = streamWriter;
            previousForm = form;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //David - you need to display all the information here in  abig MessageDialog;
            MessageBox.Show("Thanks for entering your information!");
            this.streamWriter.Close();
            this.Close();
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

                //if (!medicationOrSupplementExistInTheList(listView, medicine))
                ListViewItem listViewItem = new ListViewItem(row);

                listView.Items.Add(listViewItem);


            }
        }

        private void addEntryToTheHospitalListView(String year, String type, String pain, ListView listView)
        {
            if (year != "" && type != "" && pain != "")
            {

                string[] row = { year, type, pain };

                //if (!medicationOrSupplementExistInTheList(listView, medicine))
                ListViewItem listViewItem = new ListViewItem(row);

                listView.Items.Add(listViewItem);


            }
        }

        private void addHistoryButton_Click(object sender, EventArgs e)
        {

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
            previousForm.Show();
            this.Hide();
        }

        private void page1_Click(object sender, EventArgs e)
        {
            // do something to get back to page 1.
        }

    }
}
