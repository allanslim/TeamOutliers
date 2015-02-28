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
            this.historyPainTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.historyListView = new System.Windows.Forms.ListView();
            this.year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chronicPain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removeHistoryButton = new System.Windows.Forms.Button();
            this.addHistoryButton = new System.Windows.Forms.Button();
            this.historyTypeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.historyYearTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hospitalPainTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hospitalListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hospitalRemoveButton = new System.Windows.Forms.Button();
            this.hospitalAddButton = new System.Windows.Forms.Button();
            this.hospitalReasonTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hospitalYearTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.page1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.pastAccidents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(629, 683);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // pastAccidents
            // 
            this.pastAccidents.Controls.Add(this.historyPainTextBox);
            this.pastAccidents.Controls.Add(this.label3);
            this.pastAccidents.Controls.Add(this.historyListView);
            this.pastAccidents.Controls.Add(this.removeHistoryButton);
            this.pastAccidents.Controls.Add(this.addHistoryButton);
            this.pastAccidents.Controls.Add(this.historyTypeTextBox);
            this.pastAccidents.Controls.Add(this.label2);
            this.pastAccidents.Controls.Add(this.historyYearTextBox);
            this.pastAccidents.Controls.Add(this.label1);
            this.pastAccidents.Location = new System.Drawing.Point(12, 95);
            this.pastAccidents.Name = "pastAccidents";
            this.pastAccidents.Size = new System.Drawing.Size(677, 279);
            this.pastAccidents.TabIndex = 41;
            this.pastAccidents.TabStop = false;
            this.pastAccidents.Text = "PLEASE LIST ANY PAST ACCIDENTS, SEVER FALLS, MAJOR INJURIES, AS WELL AS FACTURES " +
    "AND DISLOCATIONS";
            // 
            // historyPainTextBox
            // 
            this.historyPainTextBox.Location = new System.Drawing.Point(432, 212);
            this.historyPainTextBox.Multiline = true;
            this.historyPainTextBox.Name = "historyPainTextBox";
            this.historyPainTextBox.Size = new System.Drawing.Size(180, 20);
            this.historyPainTextBox.TabIndex = 8;
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
            // historyListView
            // 
            this.historyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.year,
            this.type,
            this.chronicPain});
            this.historyListView.Location = new System.Drawing.Point(19, 32);
            this.historyListView.Name = "historyListView";
            this.historyListView.Size = new System.Drawing.Size(545, 155);
            this.historyListView.TabIndex = 5;
            this.historyListView.UseCompatibleStateImageBehavior = false;
            this.historyListView.View = System.Windows.Forms.View.Details;
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
            // chronicPain
            // 
            this.chronicPain.Text = "Discribe any Chronic Pain";
            this.chronicPain.Width = 254;
            // 
            // removeHistoryButton
            // 
            this.removeHistoryButton.Location = new System.Drawing.Point(117, 248);
            this.removeHistoryButton.Name = "removeHistoryButton";
            this.removeHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.removeHistoryButton.TabIndex = 4;
            this.removeHistoryButton.Text = "REMOVE";
            this.removeHistoryButton.UseVisualStyleBackColor = true;
            this.removeHistoryButton.Click += new System.EventHandler(this.historyListView_Click);
            // 
            // addHistoryButton
            // 
            this.addHistoryButton.Location = new System.Drawing.Point(19, 248);
            this.addHistoryButton.Name = "addHistoryButton";
            this.addHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.addHistoryButton.TabIndex = 4;
            this.addHistoryButton.Text = "ADD";
            this.addHistoryButton.UseVisualStyleBackColor = true;
            this.addHistoryButton.Click += new System.EventHandler(this.historyListView_Click);
            // 
            // historyTypeTextBox
            // 
            this.historyTypeTextBox.Location = new System.Drawing.Point(204, 212);
            this.historyTypeTextBox.Name = "historyTypeTextBox";
            this.historyTypeTextBox.Size = new System.Drawing.Size(154, 20);
            this.historyTypeTextBox.TabIndex = 3;
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
            // historyYearTextBox
            // 
            this.historyYearTextBox.Location = new System.Drawing.Point(81, 212);
            this.historyYearTextBox.Name = "historyYearTextBox";
            this.historyYearTextBox.Size = new System.Drawing.Size(47, 20);
            this.historyYearTextBox.TabIndex = 1;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hospitalPainTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hospitalListView);
            this.groupBox1.Controls.Add(this.hospitalRemoveButton);
            this.groupBox1.Controls.Add(this.hospitalAddButton);
            this.groupBox1.Controls.Add(this.hospitalReasonTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hospitalYearTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 279);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLEASE LIST ANY PREVIOUS SURGERIES OR HOSPITAL VISITS";
            // 
            // hospitalPainTextBox
            // 
            this.hospitalPainTextBox.Location = new System.Drawing.Point(432, 212);
            this.hospitalPainTextBox.Multiline = true;
            this.hospitalPainTextBox.Name = "hospitalPainTextBox";
            this.hospitalPainTextBox.Size = new System.Drawing.Size(180, 20);
            this.hospitalPainTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chronic Pain";
            // 
            // hospitalListView
            // 
            this.hospitalListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.hospitalListView.Location = new System.Drawing.Point(19, 32);
            this.hospitalListView.Name = "hospitalListView";
            this.hospitalListView.Size = new System.Drawing.Size(545, 155);
            this.hospitalListView.TabIndex = 5;
            this.hospitalListView.UseCompatibleStateImageBehavior = false;
            this.hospitalListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Year";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reason for Visit";
            this.columnHeader2.Width = 215;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Discribe any Chronic Pain";
            this.columnHeader3.Width = 254;
            // 
            // hospitalRemoveButton
            // 
            this.hospitalRemoveButton.Location = new System.Drawing.Point(117, 248);
            this.hospitalRemoveButton.Name = "hospitalRemoveButton";
            this.hospitalRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.hospitalRemoveButton.TabIndex = 4;
            this.hospitalRemoveButton.Text = "REMOVE";
            this.hospitalRemoveButton.UseVisualStyleBackColor = true;
            this.hospitalRemoveButton.Click += new System.EventHandler(this.historyListView_Click);
            // 
            // hospitalAddButton
            // 
            this.hospitalAddButton.Location = new System.Drawing.Point(19, 248);
            this.hospitalAddButton.Name = "hospitalAddButton";
            this.hospitalAddButton.Size = new System.Drawing.Size(75, 23);
            this.hospitalAddButton.TabIndex = 4;
            this.hospitalAddButton.Text = "ADD";
            this.hospitalAddButton.UseVisualStyleBackColor = true;
            this.hospitalAddButton.Click += new System.EventHandler(this.historyListView_Click);
            // 
            // hospitalReasonTextBox
            // 
            this.hospitalReasonTextBox.Location = new System.Drawing.Point(204, 212);
            this.hospitalReasonTextBox.Name = "hospitalReasonTextBox";
            this.hospitalReasonTextBox.Size = new System.Drawing.Size(154, 20);
            this.hospitalReasonTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Reason";
            // 
            // hospitalYearTextBox
            // 
            this.hospitalYearTextBox.Location = new System.Drawing.Point(81, 212);
            this.hospitalYearTextBox.Name = "hospitalYearTextBox";
            this.hospitalYearTextBox.Size = new System.Drawing.Size(47, 20);
            this.hospitalYearTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "> Page 2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // page1
            // 
            this.page1.AutoSize = true;
            this.page1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.page1.Location = new System.Drawing.Point(9, 27);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(41, 13);
            this.page1.TabIndex = 44;
            this.page1.Text = "Page 1";
            this.page1.Click += new System.EventHandler(this.page1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "> Page 3";
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(12, 683);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 48;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(729, 712);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.page1);
            this.Controls.Add(this.pastAccidents);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Past History";
            this.pastAccidents.ResumeLayout(false);
            this.pastAccidents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox pastAccidents;
        private System.Windows.Forms.ListView historyListView;
        private System.Windows.Forms.ColumnHeader year;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.Button removeHistoryButton;
        private System.Windows.Forms.Button addHistoryButton;
        private System.Windows.Forms.TextBox historyTypeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox historyYearTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox historyPainTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader chronicPain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hospitalPainTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView hospitalListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button hospitalRemoveButton;
        private System.Windows.Forms.Button hospitalAddButton;
        private System.Windows.Forms.TextBox hospitalReasonTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hospitalYearTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label page1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button previousButton;
    }
}