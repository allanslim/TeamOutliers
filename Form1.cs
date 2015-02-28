using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TeamOutliers
{
    public partial class Form1 : Form
    {


       private readonly Random _rng = new Random();
       private const string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


        string fullName;
        string dateOfBirth;
        string socialSecurityNumber;
        StreamWriter streamWriter;
        Form2 form2;

        public Form1()
        {
           initStreamWriter();
           form2 = new Form2(this, streamWriter);
           form2.Hide();
           InitializeComponent();
        }

        private void initStreamWriter() 
        {
           try
           {
              this.streamWriter = new StreamWriter(Application.StartupPath + "\\" + 
                  RandomString(10) + "_CustomerRecord.txt");
           }
           catch (Exception ex)
           {
              Console.WriteLine("Error creating file.");
              MessageBox.Show("Cannot create file for storage.");             
           }

        }


        private string RandomString(int size)
        {
           char[] buffer = new char[size];

           for (int i = 0; i < size; i++)
           {
              buffer[i] = _chars[_rng.Next(_chars.Length)];
           }
           return new string(buffer);
        }


        #region fullName, DOB, SSN
        private void tbFullName_TextChanged(object sender, EventArgs e)
        {
            if (tbFullName.Text.Length >= 1)
            {
                fullName = tbFullName.Text;
            }
        }

        private void tbDateOfBirth_TextChanged(object sender, EventArgs e)
        {
            if (tbDateOfBirth.Text.Length >= 1)
            {
  
                  dateOfBirth = tbDateOfBirth.Text;
                  dateOfBirth = string.Format("{0:DDMMYYYY}", dateOfBirth);
  

            }
        }

        private void tbSocialSecurityNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbSocialSecurityNumber.Text.Length >= 1)
            {
                try
                {
                    socialSecurityNumber = tbSocialSecurityNumber.Text;
                    socialSecurityNumber = string.Format("{0:XXX-XX-XXXX}",
                        socialSecurityNumber);
                }//end try
                catch
                {
                    MessageBox.Show("Please enter in the correct format.");
                }//end catch
            }//end if
        }
        #endregion

        #region buttons
        private void nextButton_Click(object sender, EventArgs e)
        {
           saveDataToFile();
           this.Hide();
           form2.Show();
        }

        private void saveDataToFile()
        {
           //Starts the stream writer and writes to a file in 
           //current directory called CustomerRecord.txt

           // This variable will store the line for check boxes.
           string checkBoxesLine = "Family Members with Related Conditions: ";

           //Write customers name to file
           if (fullName != null)
              streamWriter.Write(fullName + " ");

           //Write customers Date of Birth to file
           if (dateOfBirth != null)
              streamWriter.Write(dateOfBirth + " ");

           //Write customers Social Security Number to file
           if (socialSecurityNumber != null)
              streamWriter.Write(socialSecurityNumber);
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           //Stements to write check boxes to file
           if (cbOsteoperosis.Checked)
              streamWriter.Write("Osteoperosis, ");
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           if (cbDiabetis.Checked)
              streamWriter.Write("Diabetis, ");
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           if (cbStroke.Checked)
              streamWriter.Write("Stroke, ");
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           if (cbCancer.Checked)
              streamWriter.Write("Cancer, ");
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           if (cbHeartCondition.Checked)
              streamWriter.Write("Heart Condition, ");
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           if (cbBleedingDisorder.Checked)
              streamWriter.Write("Bleeding Disorder, ");
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           if (cbHighBloodPressure.Checked)
              streamWriter.Write("High Blood Pressure, ");
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           if (cbHIVAIDS.Checked)
              streamWriter.Write("HIV/AIDS, ");
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           if (cbUlcers.Checked)
              streamWriter.Write("Ulcers, ");
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           if (cbAsthmaCOPD.Checked)
              streamWriter.Write("Asthma/COPD, ");
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           //Continues textbox to file
           if (tbOther.Text.Length >= 1)
              streamWriter.WriteLine("Other Conditions: " + tbOther.Text);
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           //Write age and cause of mother death to file
           if (tbMotherAge.Text.Length > 0 && tbMotherCause.Text.Length > 0)
              streamWriter.Write("Mother Deceased: " + tbMotherAge.Text + ", " + tbMotherCause.Text);
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           //Write age and cause of father death to file
           if (tbFatherAge.Text.Length > 0 && tbFatherCause.Text.Length > 0)
              streamWriter.Write("Father Deceased" + tbFatherAge.Text + ", " + tbFatherCause.Text);
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           //Write age and cause of grandfather (mother) death to file
           if (tbGrandfatherMotherAge.Text.Length > 0 && tbGrandfatherMotherCause.Text.Length > 0)
              streamWriter.Write("Grand Father (Mother) Deceased" + tbGrandfatherMotherAge.Text + ", " + tbGrandfatherMotherCause.Text);
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           //Write age and cause of grandfather (father) death to file
           if (tbGrandfatherFatherAge.Text.Length > 0 && tbGrandfatherFatherCause.Text.Length > 0)
              streamWriter.Write("Grand Father (Father) Deceased" + tbGrandfatherFatherAge.Text + ", " + tbGrandfatherFatherCause.Text);
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           //Write age and cause of grandmother (mother) death to file
           if (tbGrandmotherMotherAge.Text.Length > 0 && tbGrandmotherMotherCause.Text.Length > 0)
              streamWriter.Write("Grand Mother (Mother) Deceased" + tbGrandmotherMotherAge.Text + ", " + tbGrandmotherMotherCause.Text);
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           //Write age and cause of grandmother (father) death to file
           if (tbGrandmotherFatherAge.Text.Length > 0 && tbGrandmotherFatherCause.Text.Length > 0)
              streamWriter.Write("Grandmother (Father) Deceased" + tbGrandmotherFatherAge.Text + ", " + tbGrandmotherFatherCause.Text);
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           //Write allergy information to file
           if (tbAllergies.Text != null)
              streamWriter.Write("Allergies: " + tbAllergies.Text);
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           //Write age and cause of father death to file
           if (tbAdditionalInformation.Text != null)
              streamWriter.Write("Additional Information: " + tbAdditionalInformation.Text);
           streamWriter.WriteLine(); // <--- this is new, means: insert line break

           // Enumerate all controls in panel.
           foreach (Control control in pnlMedicalHistory.Controls)
           {
              // Make sure the control is CheckBox, ignore others.
              if (control is CheckBox)
              {
                 // Cast it to CheckBox variable, to make it easier to work with.
                 CheckBox checkBox = (CheckBox)control;

                 // Make sure it is checked, and if it is, make sure that the Tag property
                 // has been set to string, so that we can get it's ID.
                 if (checkBox.Checked && checkBox.Tag is string)
                 {
                    // Cast tag to string.
                    string checkBoxId = (string)checkBox.Tag;

                    // Append tag and comma to the end of the line.
                    checkBoxesLine += string.Format("{0}, ", checkBoxId);
                 }//end if
              }//end if
           }//end foreach

           // That's it, we have the whole line, write it as a new line.
           streamWriter.WriteLine(checkBoxesLine);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        private void tbAllergies_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDateOfBirth_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            bool isOK = true;

            switch (tb.Name) { 
                case("tbDateOfBirth"):
                     isOK = Regex.IsMatch(tbDateOfBirth.Text, @"[0-3][0-9][0-1][0-9][0-9][0-9][0-9][0-9]");
                  if (!isOK)
                  {
                       tbDateOfBirth.Text = "";
                     MessageBox.Show("The Date of Birth must be entered in the format as DDMMYYYY.", "DOB ERROR",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               break;

                // source for this solution: http://stackoverflow.com/questions/7067874/regular-expression-for-ssn
                case ("tbSocialSecurityNumber"):
               isOK = Regex.IsMatch(tbSocialSecurityNumber.Text, @"^\d{3}\-?\d{2}\-?\d{4}$");
                  if (!isOK)
                  {
                      tbSocialSecurityNumber.Text = "";
                     MessageBox.Show("The Social Security Number must be entered in the format as XXX-XX-XXXX.", 
                         "DOB ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
               break;
            } // end switch
           
        }//end savebutton_click

        
    }
}
