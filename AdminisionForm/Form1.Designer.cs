namespace AdminisionForm
{
    partial class AdminisionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.programComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelToDisplayWhenProgramSelected = new System.Windows.Forms.Label();
            this.educationGroupBox = new System.Windows.Forms.GroupBox();
            this.noTARadioButton = new System.Windows.Forms.RadioButton();
            this.highSchoolRadioButton = new System.Windows.Forms.RadioButton();
            this.gedRadioButton = new System.Windows.Forms.RadioButton();
            this.processButton = new System.Windows.Forms.Button();
            this.collegeGroupBox = new System.Windows.Forms.GroupBox();
            this.doctorateRadioButton = new System.Windows.Forms.RadioButton();
            this.mastersDegreeRadioButton = new System.Windows.Forms.RadioButton();
            this.bachelorDegree = new System.Windows.Forms.RadioButton();
            this.attendedCollegeRadioButton = new System.Windows.Forms.RadioButton();
            this.experienceGroupBox = new System.Windows.Forms.GroupBox();
            this.laboratoryRadioButton = new System.Windows.Forms.RadioButton();
            this.familyBusinessRadioButton = new System.Windows.Forms.RadioButton();
            this.workExperienceRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.actScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.satScore = new System.Windows.Forms.TextBox();
            this.actCheckBox = new System.Windows.Forms.CheckBox();
            this.satCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.educationGroupBox.SuspendLayout();
            this.collegeGroupBox.SuspendLayout();
            this.experienceGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the National University program admission requirements  calendar. Plea" +
    "se select the program which interests you.";
            // 
            // programComboBox
            // 
            this.programComboBox.FormattingEnabled = true;
            this.programComboBox.Location = new System.Drawing.Point(118, 94);
            this.programComboBox.Name = "programComboBox";
            this.programComboBox.Size = new System.Drawing.Size(319, 21);
            this.programComboBox.TabIndex = 1;
            this.programComboBox.SelectedIndexChanged += new System.EventHandler(this.programComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose a Program:";
            // 
            // labelToDisplayWhenProgramSelected
            // 
            this.labelToDisplayWhenProgramSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToDisplayWhenProgramSelected.Location = new System.Drawing.Point(18, 140);
            this.labelToDisplayWhenProgramSelected.Name = "labelToDisplayWhenProgramSelected";
            this.labelToDisplayWhenProgramSelected.Size = new System.Drawing.Size(431, 63);
            this.labelToDisplayWhenProgramSelected.TabIndex = 3;
            this.labelToDisplayWhenProgramSelected.Text = "Thank you. Now please indicate your qualifications by selecting the appropriate b" +
    "oxes and recommendation based on your particular experience will be made.";
            // 
            // educationGroupBox
            // 
            this.educationGroupBox.Controls.Add(this.noTARadioButton);
            this.educationGroupBox.Controls.Add(this.highSchoolRadioButton);
            this.educationGroupBox.Controls.Add(this.gedRadioButton);
            this.educationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educationGroupBox.Location = new System.Drawing.Point(21, 206);
            this.educationGroupBox.Name = "educationGroupBox";
            this.educationGroupBox.Size = new System.Drawing.Size(286, 133);
            this.educationGroupBox.TabIndex = 4;
            this.educationGroupBox.TabStop = false;
            this.educationGroupBox.Text = "Education (Highest Completed)";
            // 
            // noTARadioButton
            // 
            this.noTARadioButton.AutoSize = true;
            this.noTARadioButton.Location = new System.Drawing.Point(18, 82);
            this.noTARadioButton.Name = "noTARadioButton";
            this.noTARadioButton.Size = new System.Drawing.Size(141, 19);
            this.noTARadioButton.TabIndex = 2;
            this.noTARadioButton.TabStop = true;
            this.noTARadioButton.Text = "None of the Above";
            this.noTARadioButton.UseVisualStyleBackColor = true;
            // 
            // highSchoolRadioButton
            // 
            this.highSchoolRadioButton.AutoSize = true;
            this.highSchoolRadioButton.Location = new System.Drawing.Point(18, 57);
            this.highSchoolRadioButton.Name = "highSchoolRadioButton";
            this.highSchoolRadioButton.Size = new System.Drawing.Size(166, 19);
            this.highSchoolRadioButton.TabIndex = 1;
            this.highSchoolRadioButton.TabStop = true;
            this.highSchoolRadioButton.Text = "High School Graduate";
            this.highSchoolRadioButton.UseVisualStyleBackColor = true;
            // 
            // gedRadioButton
            // 
            this.gedRadioButton.AutoSize = true;
            this.gedRadioButton.Location = new System.Drawing.Point(18, 32);
            this.gedRadioButton.Name = "gedRadioButton";
            this.gedRadioButton.Size = new System.Drawing.Size(54, 19);
            this.gedRadioButton.TabIndex = 0;
            this.gedRadioButton.TabStop = true;
            this.gedRadioButton.Text = "GED";
            this.gedRadioButton.UseVisualStyleBackColor = true;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(326, 508);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(142, 23);
            this.processButton.TabIndex = 5;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // collegeGroupBox
            // 
            this.collegeGroupBox.Controls.Add(this.doctorateRadioButton);
            this.collegeGroupBox.Controls.Add(this.mastersDegreeRadioButton);
            this.collegeGroupBox.Controls.Add(this.bachelorDegree);
            this.collegeGroupBox.Controls.Add(this.attendedCollegeRadioButton);
            this.collegeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.collegeGroupBox.Location = new System.Drawing.Point(21, 362);
            this.collegeGroupBox.Name = "collegeGroupBox";
            this.collegeGroupBox.Size = new System.Drawing.Size(286, 169);
            this.collegeGroupBox.TabIndex = 6;
            this.collegeGroupBox.TabStop = false;
            this.collegeGroupBox.Text = "College Education (Highest Completed)";
            // 
            // doctorateRadioButton
            // 
            this.doctorateRadioButton.AutoSize = true;
            this.doctorateRadioButton.Location = new System.Drawing.Point(18, 115);
            this.doctorateRadioButton.Name = "doctorateRadioButton";
            this.doctorateRadioButton.Size = new System.Drawing.Size(87, 19);
            this.doctorateRadioButton.TabIndex = 3;
            this.doctorateRadioButton.TabStop = true;
            this.doctorateRadioButton.Text = "Doctorate";
            this.doctorateRadioButton.UseVisualStyleBackColor = true;
            // 
            // mastersDegreeRadioButton
            // 
            this.mastersDegreeRadioButton.AutoSize = true;
            this.mastersDegreeRadioButton.Location = new System.Drawing.Point(18, 89);
            this.mastersDegreeRadioButton.Name = "mastersDegreeRadioButton";
            this.mastersDegreeRadioButton.Size = new System.Drawing.Size(131, 19);
            this.mastersDegreeRadioButton.TabIndex = 2;
            this.mastersDegreeRadioButton.TabStop = true;
            this.mastersDegreeRadioButton.Text = "Master\'s Degree";
            this.mastersDegreeRadioButton.UseVisualStyleBackColor = true;
            // 
            // bachelorDegree
            // 
            this.bachelorDegree.AutoSize = true;
            this.bachelorDegree.Location = new System.Drawing.Point(18, 65);
            this.bachelorDegree.Name = "bachelorDegree";
            this.bachelorDegree.Size = new System.Drawing.Size(144, 19);
            this.bachelorDegree.TabIndex = 1;
            this.bachelorDegree.TabStop = true;
            this.bachelorDegree.Text = "Bachelor\'s Degree";
            this.bachelorDegree.UseVisualStyleBackColor = true;
            // 
            // attendedCollegeRadioButton
            // 
            this.attendedCollegeRadioButton.AutoSize = true;
            this.attendedCollegeRadioButton.Location = new System.Drawing.Point(18, 41);
            this.attendedCollegeRadioButton.Name = "attendedCollegeRadioButton";
            this.attendedCollegeRadioButton.Size = new System.Drawing.Size(264, 19);
            this.attendedCollegeRadioButton.TabIndex = 0;
            this.attendedCollegeRadioButton.TabStop = true;
            this.attendedCollegeRadioButton.Text = "Attended College (degree unfinished)";
            this.attendedCollegeRadioButton.UseVisualStyleBackColor = true;
            // 
            // experienceGroupBox
            // 
            this.experienceGroupBox.Controls.Add(this.laboratoryRadioButton);
            this.experienceGroupBox.Controls.Add(this.familyBusinessRadioButton);
            this.experienceGroupBox.Controls.Add(this.workExperienceRadioButton);
            this.experienceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experienceGroupBox.Location = new System.Drawing.Point(21, 557);
            this.experienceGroupBox.Name = "experienceGroupBox";
            this.experienceGroupBox.Size = new System.Drawing.Size(282, 100);
            this.experienceGroupBox.TabIndex = 7;
            this.experienceGroupBox.TabStop = false;
            this.experienceGroupBox.Text = "Additional Experience";
            // 
            // laboratoryRadioButton
            // 
            this.laboratoryRadioButton.AutoSize = true;
            this.laboratoryRadioButton.Location = new System.Drawing.Point(18, 73);
            this.laboratoryRadioButton.Name = "laboratoryRadioButton";
            this.laboratoryRadioButton.Size = new System.Drawing.Size(158, 19);
            this.laboratoryRadioButton.TabIndex = 2;
            this.laboratoryRadioButton.TabStop = true;
            this.laboratoryRadioButton.Text = "Laboratory Research";
            this.laboratoryRadioButton.UseVisualStyleBackColor = true;
            // 
            // familyBusinessRadioButton
            // 
            this.familyBusinessRadioButton.AutoSize = true;
            this.familyBusinessRadioButton.Location = new System.Drawing.Point(18, 47);
            this.familyBusinessRadioButton.Name = "familyBusinessRadioButton";
            this.familyBusinessRadioButton.Size = new System.Drawing.Size(129, 19);
            this.familyBusinessRadioButton.TabIndex = 1;
            this.familyBusinessRadioButton.TabStop = true;
            this.familyBusinessRadioButton.Text = "Family Business";
            this.familyBusinessRadioButton.UseVisualStyleBackColor = true;
            // 
            // workExperienceRadioButton
            // 
            this.workExperienceRadioButton.AutoSize = true;
            this.workExperienceRadioButton.Location = new System.Drawing.Point(18, 21);
            this.workExperienceRadioButton.Name = "workExperienceRadioButton";
            this.workExperienceRadioButton.Size = new System.Drawing.Size(203, 19);
            this.workExperienceRadioButton.TabIndex = 0;
            this.workExperienceRadioButton.TabStop = true;
            this.workExperienceRadioButton.Text = "Work Experience in industry";
            this.workExperienceRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.actScore);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.satScore);
            this.groupBox3.Controls.Add(this.actCheckBox);
            this.groupBox3.Controls.Add(this.satCheckBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(326, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 203);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Score";
            // 
            // actScore
            // 
            this.actScore.Location = new System.Drawing.Point(57, 143);
            this.actScore.Name = "actScore";
            this.actScore.Size = new System.Drawing.Size(66, 21);
            this.actScore.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score";
            // 
            // satScore
            // 
            this.satScore.Location = new System.Drawing.Point(57, 69);
            this.satScore.Name = "satScore";
            this.satScore.Size = new System.Drawing.Size(66, 21);
            this.satScore.TabIndex = 1;
            // 
            // actCheckBox
            // 
            this.actCheckBox.AutoSize = true;
            this.actCheckBox.Location = new System.Drawing.Point(7, 101);
            this.actCheckBox.Name = "actCheckBox";
            this.actCheckBox.Size = new System.Drawing.Size(51, 19);
            this.actCheckBox.TabIndex = 0;
            this.actCheckBox.Text = "ACT";
            this.actCheckBox.UseVisualStyleBackColor = true;
            // 
            // satCheckBox
            // 
            this.satCheckBox.AutoSize = true;
            this.satCheckBox.Location = new System.Drawing.Point(7, 32);
            this.satCheckBox.Name = "satCheckBox";
            this.satCheckBox.Size = new System.Drawing.Size(51, 19);
            this.satCheckBox.TabIndex = 0;
            this.satCheckBox.Text = "SAT";
            this.satCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(326, 547);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(142, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(326, 586);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AdminisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 700);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.experienceGroupBox);
            this.Controls.Add(this.collegeGroupBox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.educationGroupBox);
            this.Controls.Add(this.labelToDisplayWhenProgramSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.programComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminisionForm";
            this.Text = "Adminision Form";
            this.educationGroupBox.ResumeLayout(false);
            this.educationGroupBox.PerformLayout();
            this.collegeGroupBox.ResumeLayout(false);
            this.collegeGroupBox.PerformLayout();
            this.experienceGroupBox.ResumeLayout(false);
            this.experienceGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox programComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelToDisplayWhenProgramSelected;
        private System.Windows.Forms.GroupBox educationGroupBox;
        private System.Windows.Forms.RadioButton noTARadioButton;
        private System.Windows.Forms.RadioButton highSchoolRadioButton;
        private System.Windows.Forms.RadioButton gedRadioButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.GroupBox collegeGroupBox;
        private System.Windows.Forms.RadioButton doctorateRadioButton;
        private System.Windows.Forms.RadioButton mastersDegreeRadioButton;
        private System.Windows.Forms.RadioButton bachelorDegree;
        private System.Windows.Forms.RadioButton attendedCollegeRadioButton;
        private System.Windows.Forms.GroupBox experienceGroupBox;
        private System.Windows.Forms.RadioButton laboratoryRadioButton;
        private System.Windows.Forms.RadioButton familyBusinessRadioButton;
        private System.Windows.Forms.RadioButton workExperienceRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox actScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox satScore;
        private System.Windows.Forms.CheckBox actCheckBox;
        private System.Windows.Forms.CheckBox satCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

