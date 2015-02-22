namespace TeamOutliers
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.pastAccidents = new System.Windows.Forms.GroupBox();
            this.medicationListView = new System.Windows.Forms.ListView();
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeMedicationButton = new System.Windows.Forms.Button();
            this.addMedicationButton = new System.Windows.Forms.Button();
            this.medicationDosageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.medicationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chronicPain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pastAccidents.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(298, 345);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // pastAccidents
            // 
            this.pastAccidents.Controls.Add(this.textBox1);
            this.pastAccidents.Controls.Add(this.label3);
            this.pastAccidents.Controls.Add(this.medicationListView);
            this.pastAccidents.Controls.Add(this.removeMedicationButton);
            this.pastAccidents.Controls.Add(this.addMedicationButton);
            this.pastAccidents.Controls.Add(this.medicationDosageTextBox);
            this.pastAccidents.Controls.Add(this.label2);
            this.pastAccidents.Controls.Add(this.medicationTextBox);
            this.pastAccidents.Controls.Add(this.label1);
            this.pastAccidents.Location = new System.Drawing.Point(15, 51);
            this.pastAccidents.Name = "pastAccidents";
            this.pastAccidents.Size = new System.Drawing.Size(677, 279);
            this.pastAccidents.TabIndex = 41;
            this.pastAccidents.TabStop = false;
            this.pastAccidents.Text = "PLEASE LIST ANY PAST ACCIDENTS, SEVER FALLS, MAJOR INJURIES, AS WELL AS FACTURES " +
    "AND DISLOCATIONS";
            // 
            // medicationListView
            // 
            this.medicationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.year,
            this.type,
            this.chronicPain});
            this.medicationListView.Location = new System.Drawing.Point(19, 32);
            this.medicationListView.Name = "medicationListView";
            this.medicationListView.Size = new System.Drawing.Size(545, 155);
            this.medicationListView.TabIndex = 5;
            this.medicationListView.UseCompatibleStateImageBehavior = false;
            this.medicationListView.View = System.Windows.Forms.View.Details;
            // 
            // year
            // 
            this.year.Text = "Year";
            this.year.Width = 71;
            // 
            // type
            // 
            this.type.Text = "Type of Injury";
            this.type.Width = 215;
            // 
            // removeMedicationButton
            // 
            this.removeMedicationButton.Location = new System.Drawing.Point(117, 248);
            this.removeMedicationButton.Name = "removeMedicationButton";
            this.removeMedicationButton.Size = new System.Drawing.Size(75, 23);
            this.removeMedicationButton.TabIndex = 4;
            this.removeMedicationButton.Text = "REMOVE";
            this.removeMedicationButton.UseVisualStyleBackColor = true;
            // 
            // addMedicationButton
            // 
            this.addMedicationButton.Location = new System.Drawing.Point(19, 248);
            this.addMedicationButton.Name = "addMedicationButton";
            this.addMedicationButton.Size = new System.Drawing.Size(75, 23);
            this.addMedicationButton.TabIndex = 4;
            this.addMedicationButton.Text = "ADD";
            this.addMedicationButton.UseVisualStyleBackColor = true;
            // 
            // medicationDosageTextBox
            // 
            this.medicationDosageTextBox.Location = new System.Drawing.Point(204, 212);
            this.medicationDosageTextBox.Name = "medicationDosageTextBox";
            this.medicationDosageTextBox.Size = new System.Drawing.Size(154, 20);
            this.medicationDosageTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type of Injury";
            // 
            // medicationTextBox
            // 
            this.medicationTextBox.Location = new System.Drawing.Point(81, 212);
            this.medicationTextBox.Name = "medicationTextBox";
            this.medicationTextBox.Size = new System.Drawing.Size(47, 20);
            this.medicationTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year";
            // 
            // chronicPain
            // 
            this.chronicPain.Text = "Discribe any Chronic Pain";
            this.chronicPain.Width = 254;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chronic Pain";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 212);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(729, 657);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.pastAccidents);
            this.Name = "Form3";
            this.Text = "Past History";
            this.pastAccidents.ResumeLayout(false);
            this.pastAccidents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox pastAccidents;
        private System.Windows.Forms.ListView medicationListView;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.Button removeMedicationButton;
        private System.Windows.Forms.Button addMedicationButton;
        private System.Windows.Forms.TextBox medicationDosageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox medicationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader chronicPain;
    }
}