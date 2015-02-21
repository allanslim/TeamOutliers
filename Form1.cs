using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamOutliers
{
    public partial class Form1 : Form
    {
        string fullName;
        string dateOfBirth;
        string socialSecurityNumber;

        public Form1()
        {
            InitializeComponent();
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
                    dateOfBirth = string.Format("{0:ddMMMyyyy}",
                        dateOfBirth);
            }
        }

        private void tbSocialSecurityNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbSocialSecurityNumber.Text.Length >= 1)
            {
                try
                {
                    socialSecurityNumber = tbSocialSecurityNumber.Text;
                    socialSecurityNumber = string.Format("{0:xxx-xx-xxxx}",
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
            //MessageBox.Show(socialSecurityNumber);
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region save button
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Starts the stream writer and writes to a file in 
            //current directory called CustomerRecord.txt
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\CustomerRecord.txt"))
            {
                // This variable will store the line for check boxes.
                string checkBoxesLine = "Family Members with Related Conditions: ";

                //Write customers name to file
                if (fullName != null)
                    sw.Write(fullName + " ");

                //Write customers Date of Birth to file
                if (dateOfBirth != null)
                    sw.Write(dateOfBirth + " ");

                //Write customers Social Security Number to file
                if (socialSecurityNumber != null)
                    sw.Write(socialSecurityNumber);
                    sw.WriteLine(); // <--- this is new, means: insert line break

                //Stements to write check boxes to file
                if (cbOsteoperosis.Checked)
                    sw.Write("Osteoperosis, ");
                    sw.WriteLine(); // <--- this is new, means: insert line break

                if (cbDiabetis.Checked)
                    sw.Write("Diabetis, ");
                    sw.WriteLine(); // <--- this is new, means: insert line break

                if (cbStroke.Checked)
                    sw.Write("Stroke, ");
                    sw.WriteLine(); // <--- this is new, means: insert line break

                if (cbCancer.Checked)
                    sw.Write("Cancer, ");
                    sw.WriteLine(); // <--- this is new, means: insert line break

                if (cbHeartCondition.Checked)
                    sw.Write("Heart Condition, ");
                    sw.WriteLine(); // <--- this is new, means: insert line break

                if (cbBleedingDisorder.Checked)
                    sw.Write("Bleeding Disorder, ");
                    sw.WriteLine(); // <--- this is new, means: insert line break

                if (cbHighBloodPressure.Checked)
                    sw.Write("High Blood Pressure, ");
                    sw.WriteLine(); // <--- this is new, means: insert line break

                if (cbHIVAIDS.Checked)
                    sw.Write("HIV/AIDS, ");
                    sw.WriteLine(); // <--- this is new, means: insert line break

                if (cbUlcers.Checked)
                    sw.Write("Ulcers, ");
                    sw.WriteLine(); // <--- this is new, means: insert line break

                if (cbAsthmaCOPD.Checked)
                    sw.Write("Asthma/COPD, ");
                    sw.WriteLine(); // <--- this is new, means: insert line break

                //Continues textbox to file
                if (tbOther.Text.Length >= 1)
                    sw.WriteLine("Other Conditions: " + tbOther.Text);
                    sw.WriteLine(); // <--- this is new, means: insert line break

                //Write age and cause of mother death to file
                if (tbMotherAge.Text.Length > 0 && tbMotherCause.Text.Length > 0)                
                    sw.Write("Mothger Deceased: " + tbMotherAge.Text + ", " + tbMotherCause.Text);
                    sw.WriteLine(); // <--- this is new, means: insert line break

                //Write age and cause of father death to file
                if (tbFatherAge.Text.Length > 0 && tbFatherCause.Text.Length > 0)
                    sw.Write("Father Deceased" + tbFatherAge.Text + ", " + tbFatherCause.Text);
                    sw.WriteLine(); // <--- this is new, means: insert line break

                //Write age and cause of grandfather (mother) death to file
                if (tbGrandfatherMotherAge.Text.Length > 0 && tbGrandfatherMotherCause.Text.Length > 0)
                    sw.Write("Grand Father (Mother) Deceased" + tbGrandfatherMotherAge.Text + ", " + tbGrandfatherMotherCause.Text);
                    sw.WriteLine(); // <--- this is new, means: insert line break

                //Write age and cause of grandfather (father) death to file
                if (tbGrandfatherFatherAge.Text.Length > 0 && tbGrandfatherFatherCause.Text.Length > 0)
                    sw.Write("Grand Father (Father) Deceased" + tbGrandfatherFatherAge.Text + ", " + tbGrandfatherFatherCause.Text);
                    sw.WriteLine(); // <--- this is new, means: insert line break

                //Write age and cause of grandmother (mother) death to file
                if (tbGrandmotherMotherAge.Text.Length > 0 && tbGrandmotherMotherCause.Text.Length > 0)
                    sw.Write("Grand Mother (Mother) Deceased" + tbGrandmotherMotherAge.Text + ", " + tbGrandmotherMotherCause.Text);
                    sw.WriteLine(); // <--- this is new, means: insert line break

                //Write age and cause of grandmother (father) death to file
                if (tbGrandmotherFatherAge.Text.Length > 0 && tbGrandmotherFatherCause.Text.Length > 0)
                    sw.Write("Grandmother (Father) Deceased" + tbGrandmotherFatherAge.Text + ", " + tbGrandmotherFatherCause.Text);
                    sw.WriteLine(); // <--- this is new, means: insert line break

                //Write allergy information to file
                if (tbAllergies.Text != null)
                    sw.Write("Allergies: " + tbAllergies.Text);
                    sw.WriteLine(); // <--- this is new, means: insert line break

                //Write age and cause of father death to file
                if (tbAdditionalInformation.Text != null)
                    sw.Write("Additional Information: " + tbAdditionalInformation.Text);
                    sw.WriteLine(); // <--- this is new, means: insert line break

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
                sw.WriteLine(checkBoxesLine);
            }//end using streamwriter
        }//end savebutton_click

        #endregion
    }
}
