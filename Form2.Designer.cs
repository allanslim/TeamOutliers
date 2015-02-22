namespace TeamOutliers
{
    partial class Form2
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
            this.nextButton = new System.Windows.Forms.Button();
            this.medicationGroup = new System.Windows.Forms.GroupBox();
            this.medicationListView = new System.Windows.Forms.ListView();
            this.medication = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dosage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeMedicationButton = new System.Windows.Forms.Button();
            this.addMedicationButton = new System.Windows.Forms.Button();
            this.medicationDosageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.medicationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.supplementGroup = new System.Windows.Forms.GroupBox();
            this.supplementListView = new System.Windows.Forms.ListView();
            this.nutrition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nutritionDosage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeNutritionButton = new System.Windows.Forms.Button();
            this.addNutritionButton = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.supplementTextBox = new System.Windows.Forms.TextBox();
            this.supplementDosage = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.page1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.medicationGroup.SuspendLayout();
            this.supplementGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(617, 744);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 39;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // medicationGroup
            // 
            this.medicationGroup.Controls.Add(this.medicationListView);
            this.medicationGroup.Controls.Add(this.removeMedicationButton);
            this.medicationGroup.Controls.Add(this.addMedicationButton);
            this.medicationGroup.Controls.Add(this.medicationDosageTextBox);
            this.medicationGroup.Controls.Add(this.label2);
            this.medicationGroup.Controls.Add(this.medicationTextBox);
            this.medicationGroup.Controls.Add(this.label1);
            this.medicationGroup.Location = new System.Drawing.Point(15, 51);
            this.medicationGroup.Name = "medicationGroup";
            this.medicationGroup.Size = new System.Drawing.Size(677, 279);
            this.medicationGroup.TabIndex = 40;
            this.medicationGroup.TabStop = false;
            this.medicationGroup.Text = "PLEASE LIST ALL PRESCRIPTION MEDICATIONS YOU ARE CURRENTLY TAKING";
            // 
            // medicationListView
            // 
            this.medicationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.medication,
            this.dosage});
            this.medicationListView.Location = new System.Drawing.Point(19, 32);
            this.medicationListView.Name = "medicationListView";
            this.medicationListView.Size = new System.Drawing.Size(545, 155);
            this.medicationListView.TabIndex = 5;
            this.medicationListView.UseCompatibleStateImageBehavior = false;
            this.medicationListView.View = System.Windows.Forms.View.Details;
            // 
            // medication
            // 
            this.medication.Text = "Medication";
            this.medication.Width = 273;
            // 
            // dosage
            // 
            this.dosage.Text = "Dosage";
            this.dosage.Width = 267;
            // 
            // removeMedicationButton
            // 
            this.removeMedicationButton.Location = new System.Drawing.Point(117, 248);
            this.removeMedicationButton.Name = "removeMedicationButton";
            this.removeMedicationButton.Size = new System.Drawing.Size(75, 23);
            this.removeMedicationButton.TabIndex = 4;
            this.removeMedicationButton.Text = "REMOVE";
            this.removeMedicationButton.UseVisualStyleBackColor = true;
            this.removeMedicationButton.Click += new System.EventHandler(this.addRemoveMedicationOrSupplement_Click);
            // 
            // addMedicationButton
            // 
            this.addMedicationButton.Location = new System.Drawing.Point(19, 248);
            this.addMedicationButton.Name = "addMedicationButton";
            this.addMedicationButton.Size = new System.Drawing.Size(75, 23);
            this.addMedicationButton.TabIndex = 4;
            this.addMedicationButton.Text = "ADD";
            this.addMedicationButton.UseVisualStyleBackColor = true;
            this.addMedicationButton.Click += new System.EventHandler(this.addRemoveMedicationOrSupplement_Click);
            // 
            // medicationDosageTextBox
            // 
            this.medicationDosageTextBox.Location = new System.Drawing.Point(364, 212);
            this.medicationDosageTextBox.Name = "medicationDosageTextBox";
            this.medicationDosageTextBox.Size = new System.Drawing.Size(200, 20);
            this.medicationDosageTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dosage";
            // 
            // medicationTextBox
            // 
            this.medicationTextBox.Location = new System.Drawing.Point(81, 212);
            this.medicationTextBox.Name = "medicationTextBox";
            this.medicationTextBox.Size = new System.Drawing.Size(211, 20);
            this.medicationTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medication";
            // 
            // supplementGroup
            // 
            this.supplementGroup.Controls.Add(this.supplementListView);
            this.supplementGroup.Controls.Add(this.removeNutritionButton);
            this.supplementGroup.Controls.Add(this.addNutritionButton);
            this.supplementGroup.Controls.Add(this.label28);
            this.supplementGroup.Controls.Add(this.supplementTextBox);
            this.supplementGroup.Controls.Add(this.supplementDosage);
            this.supplementGroup.Controls.Add(this.label27);
            this.supplementGroup.Location = new System.Drawing.Point(15, 379);
            this.supplementGroup.Name = "supplementGroup";
            this.supplementGroup.Size = new System.Drawing.Size(677, 335);
            this.supplementGroup.TabIndex = 40;
            this.supplementGroup.TabStop = false;
            this.supplementGroup.Text = "PLEASE LIST ALL NUTRITIONAL SUPPLEMENTS (S), HERBS (H), VITAMINES (V) AND OVER TH" +
    "E COUNTER DRUGS (OTC) YOU ARE CURRENTLY TAKING";
            // 
            // supplementListView
            // 
            this.supplementListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nutrition,
            this.nutritionDosage});
            this.supplementListView.Location = new System.Drawing.Point(19, 44);
            this.supplementListView.Name = "supplementListView";
            this.supplementListView.Size = new System.Drawing.Size(545, 182);
            this.supplementListView.TabIndex = 5;
            this.supplementListView.UseCompatibleStateImageBehavior = false;
            this.supplementListView.View = System.Windows.Forms.View.Details;
            // 
            // nutrition
            // 
            this.nutrition.Text = "S, H, V, OTC";
            this.nutrition.Width = 273;
            // 
            // nutritionDosage
            // 
            this.nutritionDosage.Text = "Dosage";
            this.nutritionDosage.Width = 267;
            // 
            // removeNutritionButton
            // 
            this.removeNutritionButton.Location = new System.Drawing.Point(117, 294);
            this.removeNutritionButton.Name = "removeNutritionButton";
            this.removeNutritionButton.Size = new System.Drawing.Size(75, 23);
            this.removeNutritionButton.TabIndex = 4;
            this.removeNutritionButton.Text = "REMOVE";
            this.removeNutritionButton.UseVisualStyleBackColor = true;
            this.removeNutritionButton.Click += new System.EventHandler(this.addRemoveMedicationOrSupplement_Click);
            // 
            // addNutritionButton
            // 
            this.addNutritionButton.Location = new System.Drawing.Point(19, 294);
            this.addNutritionButton.Name = "addNutritionButton";
            this.addNutritionButton.Size = new System.Drawing.Size(75, 23);
            this.addNutritionButton.TabIndex = 4;
            this.addNutritionButton.Text = "ADD";
            this.addNutritionButton.UseVisualStyleBackColor = true;
            this.addNutritionButton.Click += new System.EventHandler(this.addRemoveMedicationOrSupplement_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 255);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(69, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "S, H, V, OTC";
            // 
            // supplementTextBox
            // 
            this.supplementTextBox.Location = new System.Drawing.Point(91, 252);
            this.supplementTextBox.Name = "supplementTextBox";
            this.supplementTextBox.Size = new System.Drawing.Size(201, 20);
            this.supplementTextBox.TabIndex = 1;
            // 
            // supplementDosage
            // 
            this.supplementDosage.Location = new System.Drawing.Point(364, 252);
            this.supplementDosage.Name = "supplementDosage";
            this.supplementDosage.Size = new System.Drawing.Size(191, 20);
            this.supplementDosage.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(314, 255);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Dosage";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(15, 744);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 41;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // page1
            // 
            this.page1.AutoSize = true;
            this.page1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page1.Location = new System.Drawing.Point(15, 13);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(41, 13);
            this.page1.TabIndex = 42;
            this.page1.Text = "Page 1";
            this.page1.Click += new System.EventHandler(this.page1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "> Page 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(729, 657);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.supplementGroup);
            this.Controls.Add(this.medicationGroup);
            this.Controls.Add(this.nextButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.medicationGroup.ResumeLayout(false);
            this.medicationGroup.PerformLayout();
            this.supplementGroup.ResumeLayout(false);
            this.supplementGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.GroupBox medicationGroup;
        private System.Windows.Forms.GroupBox supplementGroup;
        private System.Windows.Forms.Button addMedicationButton;
        private System.Windows.Forms.TextBox medicationDosageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox medicationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeMedicationButton;
        private System.Windows.Forms.Button removeNutritionButton;
        private System.Windows.Forms.Button addNutritionButton;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox supplementTextBox;
        private System.Windows.Forms.TextBox supplementDosage;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ListView medicationListView;
        private System.Windows.Forms.ListView supplementListView;
        private System.Windows.Forms.ColumnHeader medication;
        private System.Windows.Forms.ColumnHeader dosage;
        private System.Windows.Forms.ColumnHeader nutrition;
        private System.Windows.Forms.ColumnHeader nutritionDosage;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label page1;
        private System.Windows.Forms.Label label3;
    }
}