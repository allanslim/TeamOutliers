using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamOutliers
{


    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void addRemoveMedicationOrSupplement_Click(object sender, EventArgs e)
        {

           Button button = sender as Button;

           switch (button.Name)
           {
              case "addMedicationButton":
                 addMedication(medicationTextBox.Text, medicationDosageTextBox.Text, medicationListView);
                 break;
              case "addNutritionButton":
                 addMedication(supplementTextBox.Text, supplementDosage.Text, supplementListView);
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

        private void addMedication(String medicine, String dosage, ListView listView)
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


    }
}
