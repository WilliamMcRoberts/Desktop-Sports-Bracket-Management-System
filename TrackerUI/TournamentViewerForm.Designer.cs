using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnPlayedGamesOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.VSLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AccessibleName = "";
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 50);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(271, 62);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(273, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "<none>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = " Round";
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.BackColor = System.Drawing.Color.Silver;
            this.RoundDropDown.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(144, 157);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(318, 45);
            this.RoundDropDown.TabIndex = 3;
            // 
            // UnPlayedGamesOnlyCheckBox
            // 
            this.UnPlayedGamesOnlyCheckBox.AutoSize = true;
            this.UnPlayedGamesOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnPlayedGamesOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnPlayedGamesOnlyCheckBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UnPlayedGamesOnlyCheckBox.Location = new System.Drawing.Point(147, 222);
            this.UnPlayedGamesOnlyCheckBox.Name = "UnPlayedGamesOnlyCheckBox";
            this.UnPlayedGamesOnlyCheckBox.Size = new System.Drawing.Size(220, 27);
            this.UnPlayedGamesOnlyCheckBox.TabIndex = 4;
            this.UnPlayedGamesOnlyCheckBox.Text = "UnPlayed Matchups Only";
            this.UnPlayedGamesOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BackColor = System.Drawing.Color.Silver;
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matchupListBox.ForeColor = System.Drawing.Color.Black;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 28;
            this.matchupListBox.Location = new System.Drawing.Point(27, 275);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(443, 282);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamOneName.Location = new System.Drawing.Point(521, 258);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(203, 45);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamTwoName.Location = new System.Drawing.Point(522, 426);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(202, 45);
            this.teamTwoName.TabIndex = 7;
            this.teamTwoName.Text = "<team two>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(522, 321);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamOneScoreLabel.TabIndex = 8;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(522, 488);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamTwoScoreLabel.TabIndex = 9;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamOneScoreTextBox
            // 
            this.teamOneScoreTextBox.BackColor = System.Drawing.Color.Silver;
            this.teamOneScoreTextBox.ForeColor = System.Drawing.Color.Black;
            this.teamOneScoreTextBox.Location = new System.Drawing.Point(614, 316);
            this.teamOneScoreTextBox.Name = "teamOneScoreTextBox";
            this.teamOneScoreTextBox.Size = new System.Drawing.Size(125, 43);
            this.teamOneScoreTextBox.TabIndex = 10;
            // 
            // teamTwoScoreTextBox
            // 
            this.teamTwoScoreTextBox.BackColor = System.Drawing.Color.Silver;
            this.teamTwoScoreTextBox.ForeColor = System.Drawing.Color.Black;
            this.teamTwoScoreTextBox.Location = new System.Drawing.Point(614, 483);
            this.teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
            this.teamTwoScoreTextBox.Size = new System.Drawing.Size(125, 43);
            this.teamTwoScoreTextBox.TabIndex = 11;
            // 
            // VSLabel
            // 
            this.VSLabel.AutoSize = true;
            this.VSLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VSLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.VSLabel.Location = new System.Drawing.Point(582, 388);
            this.VSLabel.Name = "VSLabel";
            this.VSLabel.Size = new System.Drawing.Size(71, 38);
            this.VSLabel.TabIndex = 12;
            this.VSLabel.Text = "-VS-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(786, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 63);
            this.button1.TabIndex = 13;
            this.button1.Text = "Score";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(934, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VSLabel);
            this.Controls.Add(this.teamTwoScoreTextBox);
            this.Controls.Add(this.teamOneScoreTextBox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnPlayedGamesOnlyCheckBox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label label1;
        private Label label2;
        private ComboBox RoundDropDown;
        private CheckBox UnPlayedGamesOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamTwoName;
        private Label teamOneScoreLabel;
        private Label teamTwoScoreLabel;
        private TextBox teamOneScoreTextBox;
        private TextBox teamTwoScoreTextBox;
        private Label VSLabel;
        private Button button1;
    }
}