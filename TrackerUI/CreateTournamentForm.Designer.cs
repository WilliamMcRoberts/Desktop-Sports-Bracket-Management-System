namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.removeSelectedTeamPlayerButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizeButton = new System.Windows.Forms.Button();
            this.teamsPlayersLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTournamentLabel.Location = new System.Drawing.Point(12, 9);
            this.createTournamentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(425, 62);
            this.createTournamentLabel.TabIndex = 0;
            this.createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentNameLabel.Location = new System.Drawing.Point(42, 71);
            this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(290, 45);
            this.tournamentNameLabel.TabIndex = 1;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.tournamentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.tournamentNameTextBox.Location = new System.Drawing.Point(12, 120);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(372, 43);
            this.tournamentNameTextBox.TabIndex = 2;
            this.tournamentNameTextBox.TextChanged += new System.EventHandler(this.tournamentNameTextBox_TextChanged);
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.BackColor = System.Drawing.Color.Silver;
            this.entryFeeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryFeeTextBox.ForeColor = System.Drawing.Color.Black;
            this.entryFeeTextBox.Location = new System.Drawing.Point(179, 183);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(205, 43);
            this.entryFeeTextBox.TabIndex = 4;
            this.entryFeeTextBox.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryFeeLabel.Location = new System.Drawing.Point(15, 180);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(153, 45);
            this.entryFeeLabel.TabIndex = 3;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamLabel.Location = new System.Drawing.Point(12, 264);
            this.selectTeamLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(191, 45);
            this.selectTeamLabel.TabIndex = 5;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.BackColor = System.Drawing.Color.Silver;
            this.selectTeamDropDown.ForeColor = System.Drawing.Color.Black;
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(15, 315);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(369, 45);
            this.selectTeamDropDown.TabIndex = 6;
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(204, 270);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(190, 38);
            this.createNewTeamLink.TabIndex = 7;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "<create new>";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createPrizeButton.Location = new System.Drawing.Point(98, 488);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(184, 63);
            this.createPrizeButton.TabIndex = 14;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addTeamButton.Location = new System.Drawing.Point(98, 385);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(184, 63);
            this.addTeamButton.TabIndex = 15;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // removeSelectedTeamPlayerButton
            // 
            this.removeSelectedTeamPlayerButton.BackColor = System.Drawing.Color.Silver;
            this.removeSelectedTeamPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.removeSelectedTeamPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedTeamPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedTeamPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedTeamPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedTeamPlayerButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedTeamPlayerButton.Location = new System.Drawing.Point(739, 157);
            this.removeSelectedTeamPlayerButton.Name = "removeSelectedTeamPlayerButton";
            this.removeSelectedTeamPlayerButton.Size = new System.Drawing.Size(166, 92);
            this.removeSelectedTeamPlayerButton.TabIndex = 17;
            this.removeSelectedTeamPlayerButton.Text = "Remove Selected";
            this.removeSelectedTeamPlayerButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTournamentButton.Location = new System.Drawing.Point(324, 535);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(274, 63);
            this.createTournamentButton.TabIndex = 18;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // removeSelectedPrizeButton
            // 
            this.removeSelectedPrizeButton.BackColor = System.Drawing.Color.Silver;
            this.removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedPrizeButton.Location = new System.Drawing.Point(739, 385);
            this.removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            this.removeSelectedPrizeButton.Size = new System.Drawing.Size(166, 92);
            this.removeSelectedPrizeButton.TabIndex = 19;
            this.removeSelectedPrizeButton.Text = "Remove Selected";
            this.removeSelectedPrizeButton.UseVisualStyleBackColor = false;
            // 
            // teamsPlayersLabel
            // 
            this.teamsPlayersLabel.AutoSize = true;
            this.teamsPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamsPlayersLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamsPlayersLabel.Location = new System.Drawing.Point(449, 71);
            this.teamsPlayersLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.teamsPlayersLabel.Name = "teamsPlayersLabel";
            this.teamsPlayersLabel.Size = new System.Drawing.Size(224, 45);
            this.teamsPlayersLabel.TabIndex = 20;
            this.teamsPlayersLabel.Text = "Teams/Players";
            this.teamsPlayersLabel.Click += new System.EventHandler(this.teamsPlayersLabel_Click);
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizesLabel.Location = new System.Drawing.Point(495, 321);
            this.prizesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(103, 45);
            this.prizesLabel.TabIndex = 21;
            this.prizesLabel.Text = "Prizes";
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.BackColor = System.Drawing.Color.Silver;
            this.tournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentTeamsListBox.ForeColor = System.Drawing.Color.Black;
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 28;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(416, 120);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(299, 198);
            this.tournamentTeamsListBox.TabIndex = 22;
            // 
            // prizesListBox
            // 
            this.prizesListBox.BackColor = System.Drawing.Color.Silver;
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesListBox.ForeColor = System.Drawing.Color.Black;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 28;
            this.prizesListBox.Location = new System.Drawing.Point(416, 370);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(299, 142);
            this.prizesListBox.TabIndex = 23;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(917, 610);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.teamsPlayersLabel);
            this.Controls.Add(this.removeSelectedPrizeButton);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.removeSelectedTeamPlayerButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextBox);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = " Create Tournament Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label createTournamentLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentNameTextBox;
        private TextBox entryFeeTextBox;
        private Label entryFeeLabel;
        private Label selectTeamLabel;
        private ComboBox selectTeamDropDown;
        private LinkLabel createNewTeamLink;
        private Button createPrizeButton;
        private Button addTeamButton;
        private Button removeSelectedTeamPlayerButton;
        private Button createTournamentButton;
        private Button removeSelectedPrizeButton;
        private Label teamsPlayersLabel;
        private Label prizesLabel;
        private ListBox tournamentTeamsListBox;
        private ListBox prizesListBox;
    }
}