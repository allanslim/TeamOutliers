using System;
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


    public partial class Form2 : Form
    {

       private Form previousForm;
       private Form nextForm;
       private StreamWriter streamWriter;

       public Form2(Form form, StreamWriter streamWriter)
        {
           previousForm = form;
           this.streamWriter = streamWriter;
           nextForm = new Form3(this, streamWriter);
           InitializeComponent();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
           saveData();
           this.Hide();
           nextForm.Show();
        }

        private void saveData()
        {
           streamWriter.WriteLine("PRESCRIPTION MEDICATION:");
           medicationListView.Items.Cast<ListViewItem>().ToList().ForEach(medication => streamWriter.WriteLine(medication.Text));

           streamWriter.WriteLine("");
           streamWriter.WriteLine("SUPPLEMENTS, HERBS, OVER THE COUNTER and VITAMINS:");
           supplementListView.Items.Cast<ListViewItem>().ToList().ForEach(medication => streamWriter.WriteLine(medication.Text));
        }

        private void addRemoveMedicationOrSupplement_Click(object sender, EventArgs e)
        {

           Button button = sender as Button;

           switch (button.Name)
           {
              case "addMedicationButton":
                 addEntryToTheListView(medicationTextBox.Text, medicationDosageTextBox.Text, medicationListView);
                 break;
              
              case "addNutritionButton":
                 addEntryToTheListView(supplementTextBox.Text, supplementDosage.Text, supplementListView);
                 break;
         
              case "removeMedicationButton":
                 medicationListView.Items.Cast<ListViewItem>().
              Where(T => T.Selected).
              Select(T => T.Index).ToList().
              ForEach(T => medicationListView.Items.RemoveAt(T));
                 break;

              case "removeNutritionButton":
                 supplementListView.Items.Cast<ListViewItem>().
              Where(T => T.Selected).
              Select(T => T.Index).ToList().
              ForEach(T => supplementListView.Items.RemoveAt(T));
                 break;

           }

        }

        private void addEntryToTheListView(String medicine, String dosage, ListView listView)
        {
           if (medicine != "" && dosage != "")
           {

              string[] row = { medicine, dosage };

              if (!medicationOrSupplementExistInTheList(listView, medicine))
              {
                 ListViewItem listViewItem = new ListViewItem(row);

                 listView.Items.Add(listViewItem);
              }

           }
        }

  
        private bool medicationOrSupplementExistInTheList(ListView listView, String value)
        {
           return listView.FindItemWithText(value) != null;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
           returnToPreviousPage();
        }

        private void page1_Click(object sender, EventArgs e)
        {
           returnToPreviousPage();
        }

        private void returnToPreviousPage()
        {
           previousForm.Show();
           this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


    }
}
