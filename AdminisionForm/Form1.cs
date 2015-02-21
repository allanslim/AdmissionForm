using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminisionForm
{
   public partial class AdminisionForm : Form
   {

      public readonly string[] programs = { 
            "Bachelor of Science in Accountancy", 
             "Certificate in Accountancy", 
             "Graduate Certificate in Accountancy", 
             "Master of Accountancy", "Minor in Accountancy", 
             "Associate of Science in Business", 
             "Bachelor of Business Administration", 
             "Bachelor of Science in Financial Management", 
             "Certificate in Finance",
             "Master of Business Administration", 
             "Minor in Business Administration", 
             "Minor in Business Studies", 
             "Minor in Economics",
             "Associate of Arts Hospitality and Customer Service",
             "Bachelor of Science in Hospitality and Casino Management",
             "Bachelor of Science in Organizational Leadership",
             "Certificate in Basic Human Resource Management",
             "Certificate in Basics of Casino Management",
             "Certificate in Hospitality and Casino Management",
             "Certificate in Human Resources Management", 
             "Master of Arts in Cause Leadership", 
             "Master of Arts in Human Resource Management", 
             "Master of Science in Business Analytics", 
             "Master of Science in Management Information Systems", 
             "Master of Science in Organizational Leadership", 
             "Master of Science in Sustainability Management", 
             "Bachelor of Arts in Integrated Marketing Communications",
             "Bachelor of Arts in Management", 
             "Certificate in Basic Sales and Marketing", 
             "Certificate in International Business", 
             "Certificate in Marketing",
             "Global Master in Business Administration (GMBA) in Spanish",
             "Maestría Global en Administración De Negocios (GMBA) en Español", 
             "Master of Global Management", "Minor in Business Administration",
             "Minor in Business Studies", 
             "Associate of Science in Engineering Technology",
             "Bachelor of Science in Biomedical Engineering Technology",
             "Bachelor of Science in Construction Engineering Technology",
             "Bachelor of Science in Construction Management",
             "Bachelor of Science in Electrical and Computer Engineering", 
             "Bachelor of Science in Manufacturing Design Engineering",
             "Graduate Certificate in Project Management",
             "Master of Science in Electrical Engineering", 
             "Master of Science in Engineering Management",
             "Master of Science in Sustainability Management", 
             "Bachelor of Arts in Digital Media Design",
             "Bachelor of Science in Computer Science",
             "Bachelor of Science in Information Systems",
             "Bachelor of Science in Information Technology Management", 
             "Master of Science in Computer Science",
             "Master of Science in Cyber Security and Information Assurance", 
             "Master of Science in Data Analytics", 
             "Master of Science in Information Technology Management", 
             "Master of Science in Management Information Systems",
             "Minor in Computer Science", 
             "Minor in Information Technology Management", 
             "Minor in Technology", 
             "Undergraduate Certificate in Information Technology Management" };


      private enum Result { ADMITTED, DENIED };
      private enum Education { GED, HIGH_SCHOOL, NONE_OF_THE_ABOVE, EMPTY };
      private enum CollegeEducation { UNFINISHED_COLLEGE, BACHELOR, MASTER, DOCTORATE, EMPTY };
      private enum Experience { WORK_EXPERIENCE, FAMILY_BUSINESS_EXPERIENCE, LABORATORY_RESEARCH_EXPERIENCE, EMPTY };

      private Education education;
      private CollegeEducation collegeEducation;
      private Experience experience;

      public AdminisionForm()
      {
         InitializeComponent();

         resetData();

         initializeComboBox();

         initializeControlsEventHandler();

      }

      private void initializeControlsEventHandler()
      {
         noTARadioButton.Click += new System.EventHandler(this.education_Click);
         highSchoolRadioButton.Click += new System.EventHandler(this.education_Click);
         gedRadioButton.Click += new System.EventHandler(this.education_Click);

         doctorateRadioButton.Click += new System.EventHandler(this.education_Click);
         mastersDegreeRadioButton.Click += new System.EventHandler(this.education_Click);
         bachelorDegree.Click += new System.EventHandler(this.education_Click);
         attendedCollegeRadioButton.Click += new System.EventHandler(this.education_Click);

         laboratoryRadioButton.Click += new System.EventHandler(this.education_Click);
         familyBusinessRadioButton.Click += new System.EventHandler(this.education_Click);
         workExperienceRadioButton.Click += new System.EventHandler(this.education_Click);

         satCheckBox.Click += new System.EventHandler(this.checkBox_CheckedChanged);
         actCheckBox.Click += new System.EventHandler(this.checkBox_CheckedChanged);
      }

      private void initializeComboBox()
      {
         foreach (String program in programs)
         {
            programComboBox.Items.Add(program);
         }
      }

      private void education_Click(object sender, EventArgs e)
      {

         RadioButton rb = sender as RadioButton;
         clearAllRadioButtonsExcept(rb);

         switch (rb.Name)
         {
            case "gedRadioButton":
               education = Education.GED;
               break;
            case "highSchoolRadioButton":
               education = Education.HIGH_SCHOOL;
               break;
            case "noTARadioButton":
               education = Education.NONE_OF_THE_ABOVE;
               break;
            case "doctorateRadioButton":
               collegeEducation = CollegeEducation.DOCTORATE;
               break;
            case "mastersDegreeRadioButton":
               collegeEducation = CollegeEducation.MASTER;
               break;
            case "bachelorDegree":
               collegeEducation = CollegeEducation.BACHELOR;
               break;
            case "attendedCollegeRadioButton":
               collegeEducation = CollegeEducation.UNFINISHED_COLLEGE;
               break;
            case "laboratoryRadioButton":
               experience = Experience.LABORATORY_RESEARCH_EXPERIENCE;
               break;
            case "familyBusinessRadioButton":
               experience = Experience.FAMILY_BUSINESS_EXPERIENCE;
               break;
            case "workExperienceRadioButton":
               experience = Experience.WORK_EXPERIENCE;
               break;
         }
      }

      private void clearAllRadioButtonsExcept(RadioButton radioButton)
      {
         resetPreviouslySelectedData();

         collegeGroupBox.Controls.OfType<RadioButton>().ToList().
             Where(rb => rb.Name != radioButton.Name).ToList().
             ForEach(rb => rb.Checked = false);

         experienceGroupBox.Controls.OfType<RadioButton>().ToList().
             Where(rb => rb.Name != radioButton.Name).
             ToList().
             ForEach(rb => rb.Checked = false);

         educationGroupBox.Controls.OfType<RadioButton>().ToList().
             Where(rb => rb.Name != radioButton.Name).ToList().
             ForEach(rb => rb.Checked = false);

      }

      private void programComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         if ((string)programComboBox.SelectedItem != null)
         {
            labelToDisplayWhenProgramSelected.Show();
         }
      }

      private void processButton_Click(object sender, EventArgs e)
      {

         if (!isFormFilledUp())
         {
            MessageBox.Show("Please fill up the form.");
            return;
         }

         Tuple<float, float> scores = extractScores();

         float satScore = scores.Item1;
         float actScore = scores.Item2;

         Result educationResult = calculateEducationResult(satScore, actScore);

         Result collegeResult = calculateCollegeEducation(satScore, actScore);

         Result experienceResult = calculateExperience(satScore, actScore);

         if (isAdmitted(educationResult, collegeResult, experienceResult))
         {
            MessageBox.Show("Congratulations! You are admitted for: " + programComboBox.SelectedItem);
            resetData();
         }
         else
         {
            MessageBox.Show("You did not meet the school requirements for admimission.");
            resetData();
         }
      }

      private static bool isAdmitted(Result educationResult, Result collegeResult, Result experienceResult)
      {
         return educationResult == Result.ADMITTED ||
             collegeResult == Result.ADMITTED ||
             experienceResult == Result.ADMITTED;
      }


      private Result calculateEducationResult(float satScore, float actScore)
      {
         Result result = Result.DENIED;
         if (education == Education.HIGH_SCHOOL ||
             education == Education.GED &&
             hasAcceptableScore(satScore, actScore))
         {
            result = Result.ADMITTED;
         }

         return result;
      }


      private Result calculateCollegeEducation(float satScore, float actScore)
      {
         Result result = Result.DENIED;

         if (hasBachelorMastersOrDoctorateDegree() ||
             hasUnfinishedCollegeButWithAcceptableScore(satScore, actScore))
         {
            result = Result.ADMITTED;
         }

         return result;
      }

      private Result calculateExperience(float satScore, float actScore)
      {
         Result result = Result.DENIED;

         if (hasExperience(satScore, actScore) &&
             hasAcceptableScore(satScore, actScore))
         {
            result = Result.ADMITTED;
         }

         return result;
      }

      private bool hasExperience(float satScore, float actScore)
      {
         return experience == Experience.FAMILY_BUSINESS_EXPERIENCE ||
                         experience == Experience.LABORATORY_RESEARCH_EXPERIENCE ||
                         experience == Experience.WORK_EXPERIENCE;
      }


      private bool hasUnfinishedCollegeButWithAcceptableScore(float satScore, float actScore)
      {
         return collegeEducation == CollegeEducation.UNFINISHED_COLLEGE &&
             hasAcceptableScore(satScore, actScore);
      }

      private bool hasBachelorMastersOrDoctorateDegree()
      {
         return collegeEducation == CollegeEducation.BACHELOR ||
                         collegeEducation == CollegeEducation.MASTER ||
                         collegeEducation == CollegeEducation.DOCTORATE;
      }

      private static bool hasAcceptableScore(float satScore, float actScore)
      {
         return satScore >= 1000 && actScore >= 15;
      }



      private Tuple<float, float> extractScores()
      {
         try
         {
            float ac, sc;
            float.TryParse(satScore.Text, out sc);
            float.TryParse(actScore.Text, out ac);

            return new Tuple<float, float>(sc, ac);
         }
         catch (Exception e)
         {
            Console.WriteLine(e);
            return new Tuple<float, float>(-1, -1);
         }
      }

      private bool isFormFilledUp()
      {
         Console.WriteLine(programComboBox.SelectedIndex);
         return (education != Education.EMPTY || collegeEducation != CollegeEducation.EMPTY ||
                         experience != Experience.EMPTY) && programComboBox.SelectedIndex > -1;
      }

      private void checkBox_CheckedChanged(object sender, EventArgs e)
      {
         CheckBox cb = sender as CheckBox;

         switch (cb.Name)
         {
            case "satCheckBox":
               if (cb.Checked)
               {
                  satScore.Enabled = true;
               }
               else
               {
                  satScore.Text = "";
                  satScore.Enabled = false;
               }
               break;
            case "actCheckBox":
               if (cb.Checked)
               {
                  actScore.Enabled = true;
               }
               else
               {
                  actScore.Text = "";
                  actScore.Enabled = false;
               }
               break;
         }
      }

      private void exitButton_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void clearButton_Click(object sender, EventArgs e)
      {
         resetData();
      }


      private void resetData()
      {
         satScore.Enabled = false;
         actScore.Enabled = false;

         noTARadioButton.Checked = false;
         highSchoolRadioButton.Checked = false;
         gedRadioButton.Checked = false;

         doctorateRadioButton.Checked = false;
         mastersDegreeRadioButton.Checked = false;
         bachelorDegree.Checked = false;
         attendedCollegeRadioButton.Checked = false;

         laboratoryRadioButton.Checked = false;
         familyBusinessRadioButton.Checked = false;
         workExperienceRadioButton.Checked = false;

         satCheckBox.Checked = false;
         actCheckBox.Checked = false;

         satScore.Text = "";
         actScore.Text = "";

         resetPreviouslySelectedData();

         labelToDisplayWhenProgramSelected.Hide();

         programComboBox.SelectedIndex = -1;
      }

      private void resetPreviouslySelectedData()
      {
         education = Education.EMPTY;
         collegeEducation = CollegeEducation.EMPTY;
         experience = Experience.EMPTY;
      }
   }
}
