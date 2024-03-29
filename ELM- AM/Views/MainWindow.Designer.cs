﻿namespace ELM__AM
{
    partial class MainWindow
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
            this.ImportAllButton = new System.Windows.Forms.Button();
            this.smsMessagesList = new System.Windows.Forms.ListView();
            this.TextID = new System.Windows.Forms.ColumnHeader();
            this.TextNumber = new System.Windows.Forms.ColumnHeader();
            this.TextMessage = new System.Windows.Forms.ColumnHeader();
            this.emailMessageList = new System.Windows.Forms.ListView();
            this.EmailID = new System.Windows.Forms.ColumnHeader();
            this.EmailAddress = new System.Windows.Forms.ColumnHeader();
            this.EmailSubject = new System.Windows.Forms.ColumnHeader();
            this.EmailMessage = new System.Windows.Forms.ColumnHeader();
            this.twitterMessageList = new System.Windows.Forms.ListView();
            this.TwitterID = new System.Windows.Forms.ColumnHeader();
            this.TwitterHandle = new System.Windows.Forms.ColumnHeader();
            this.TwitterMessage = new System.Windows.Forms.ColumnHeader();
            this.NewEntryButton = new System.Windows.Forms.Button();
            this.QuarentineButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JSONExportButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TrendingListButton = new System.Windows.Forms.Button();
            this.MentionsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.SIRMessageList = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // ImportAllButton
            // 
            this.ImportAllButton.Location = new System.Drawing.Point(39, 95);
            this.ImportAllButton.Name = "ImportAllButton";
            this.ImportAllButton.Size = new System.Drawing.Size(172, 49);
            this.ImportAllButton.TabIndex = 0;
            this.ImportAllButton.Text = "Import CSV";
            this.ImportAllButton.UseVisualStyleBackColor = true;
            this.ImportAllButton.Click += new System.EventHandler(this.ImportAllButton_Click);
            // 
            // smsMessagesList
            // 
            this.smsMessagesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TextID,
            this.TextNumber,
            this.TextMessage});
            this.smsMessagesList.GridLines = true;
            this.smsMessagesList.HideSelection = false;
            this.smsMessagesList.Location = new System.Drawing.Point(39, 184);
            this.smsMessagesList.Name = "smsMessagesList";
            this.smsMessagesList.Size = new System.Drawing.Size(1081, 138);
            this.smsMessagesList.TabIndex = 1;
            this.smsMessagesList.UseCompatibleStateImageBehavior = false;
            // 
            // TextID
            // 
            this.TextID.Name = "TextID";
            this.TextID.Text = "Text ID";
            this.TextID.Width = 150;
            // 
            // TextNumber
            // 
            this.TextNumber.Name = "TextNumber";
            this.TextNumber.Text = "Text Number";
            this.TextNumber.Width = 150;
            // 
            // TextMessage
            // 
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Text = "Text Message";
            this.TextMessage.Width = 600;
            // 
            // emailMessageList
            // 
            this.emailMessageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmailID,
            this.EmailAddress,
            this.EmailSubject,
            this.EmailMessage});
            this.emailMessageList.HideSelection = false;
            this.emailMessageList.Location = new System.Drawing.Point(39, 538);
            this.emailMessageList.Name = "emailMessageList";
            this.emailMessageList.Size = new System.Drawing.Size(1081, 139);
            this.emailMessageList.TabIndex = 2;
            this.emailMessageList.UseCompatibleStateImageBehavior = false;
            // 
            // EmailID
            // 
            this.EmailID.Name = "EmailID";
            this.EmailID.Text = "Email ID";
            this.EmailID.Width = 150;
            // 
            // EmailAddress
            // 
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Text = "Email Address";
            this.EmailAddress.Width = 150;
            // 
            // EmailSubject
            // 
            this.EmailSubject.Name = "EmailSubject";
            this.EmailSubject.Text = "Email Subject";
            this.EmailSubject.Width = 150;
            // 
            // EmailMessage
            // 
            this.EmailMessage.Name = "EmailMessage";
            this.EmailMessage.Text = "Email Message";
            this.EmailMessage.Width = 450;
            // 
            // twitterMessageList
            // 
            this.twitterMessageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TwitterID,
            this.TwitterHandle,
            this.TwitterMessage});
            this.twitterMessageList.HideSelection = false;
            this.twitterMessageList.Location = new System.Drawing.Point(39, 364);
            this.twitterMessageList.Name = "twitterMessageList";
            this.twitterMessageList.Size = new System.Drawing.Size(1081, 132);
            this.twitterMessageList.TabIndex = 3;
            this.twitterMessageList.UseCompatibleStateImageBehavior = false;
            // 
            // TwitterID
            // 
            this.TwitterID.Name = "TwitterID";
            this.TwitterID.Text = "Twitter ID";
            this.TwitterID.Width = 150;
            // 
            // TwitterHandle
            // 
            this.TwitterHandle.Name = "TwitterHandle";
            this.TwitterHandle.Text = "Twitter Handle";
            this.TwitterHandle.Width = 150;
            // 
            // TwitterMessage
            // 
            this.TwitterMessage.Name = "TwitterMessage";
            this.TwitterMessage.Text = "Twitter Message";
            this.TwitterMessage.Width = 600;
            // 
            // NewEntryButton
            // 
            this.NewEntryButton.Location = new System.Drawing.Point(226, 95);
            this.NewEntryButton.Name = "NewEntryButton";
            this.NewEntryButton.Size = new System.Drawing.Size(144, 49);
            this.NewEntryButton.TabIndex = 4;
            this.NewEntryButton.Text = "New Entry";
            this.NewEntryButton.UseVisualStyleBackColor = true;
            this.NewEntryButton.Click += new System.EventHandler(this.NewEntryButton_Click);
            // 
            // QuarentineButton
            // 
            this.QuarentineButton.Location = new System.Drawing.Point(386, 95);
            this.QuarentineButton.Name = "QuarentineButton";
            this.QuarentineButton.Size = new System.Drawing.Size(164, 49);
            this.QuarentineButton.TabIndex = 5;
            this.QuarentineButton.Text = "Quarentine List";
            this.QuarentineButton.UseVisualStyleBackColor = true;
            this.QuarentineButton.Click += new System.EventHandler(this.QuarentineButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "SMS Messages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Twitter Messages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email Messages";
            // 
            // JSONExportButton
            // 
            this.JSONExportButton.Location = new System.Drawing.Point(866, 95);
            this.JSONExportButton.Name = "JSONExportButton";
            this.JSONExportButton.Size = new System.Drawing.Size(150, 49);
            this.JSONExportButton.TabIndex = 10;
            this.JSONExportButton.Text = "JSON Export";
            this.JSONExportButton.UseVisualStyleBackColor = true;
            this.JSONExportButton.Click += new System.EventHandler(this.JSONExportButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Euston Leisure - Message Filtering Service";
            // 
            // TrendingListButton
            // 
            this.TrendingListButton.Location = new System.Drawing.Point(566, 95);
            this.TrendingListButton.Name = "TrendingListButton";
            this.TrendingListButton.Size = new System.Drawing.Size(134, 49);
            this.TrendingListButton.TabIndex = 12;
            this.TrendingListButton.Text = "Trending List";
            this.TrendingListButton.UseVisualStyleBackColor = true;
            this.TrendingListButton.Click += new System.EventHandler(this.TrendingListButton_Click);
            // 
            // MentionsButton
            // 
            this.MentionsButton.Location = new System.Drawing.Point(716, 95);
            this.MentionsButton.Name = "MentionsButton";
            this.MentionsButton.Size = new System.Drawing.Size(135, 49);
            this.MentionsButton.TabIndex = 13;
            this.MentionsButton.Text = "Mentions List";
            this.MentionsButton.UseVisualStyleBackColor = true;
            this.MentionsButton.Click += new System.EventHandler(this.MentionsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "SIR Email Messages";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Email ID";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Email Address";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Email Subject";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "Email Message";
            this.columnHeader4.Width = 450;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Text = "Branch Code";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Name = "columnHeader6";
            this.columnHeader6.Text = "Incident Code";
            this.columnHeader6.Width = 150;
            // 
            // SIRMessageList
            // 
            this.SIRMessageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.SIRMessageList.HideSelection = false;
            this.SIRMessageList.Location = new System.Drawing.Point(39, 712);
            this.SIRMessageList.Name = "SIRMessageList";
            this.SIRMessageList.Size = new System.Drawing.Size(1081, 139);
            this.SIRMessageList.TabIndex = 2;
            this.SIRMessageList.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email ID";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Email Address";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Email Subject";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Email Message";
            this.columnHeader10.Width = 450;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Branch Code";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Incident code";
            this.columnHeader12.Width = 150;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1156, 892);
            this.Controls.Add(this.SIRMessageList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MentionsButton);
            this.Controls.Add(this.TrendingListButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JSONExportButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuarentineButton);
            this.Controls.Add(this.NewEntryButton);
            this.Controls.Add(this.twitterMessageList);
            this.Controls.Add(this.emailMessageList);
            this.Controls.Add(this.smsMessagesList);
            this.Controls.Add(this.ImportAllButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELM System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button ImportAllButton;
        private System.Windows.Forms.ListView smsMessagesList;
        private System.Windows.Forms.ColumnHeader TextID;
        private System.Windows.Forms.ListView emailMessageList;
        private System.Windows.Forms.ListView twitterMessageList;
        private System.Windows.Forms.ColumnHeader TextNumber;
        private System.Windows.Forms.ColumnHeader TextMessage;
        private System.Windows.Forms.ColumnHeader TwitterID;
        private System.Windows.Forms.ColumnHeader EmailSubject;

        private System.Windows.Forms.ColumnHeader TwitterHandle;
        private System.Windows.Forms.ColumnHeader TwitterMessage;
        private System.Windows.Forms.ColumnHeader EmailID;
        private System.Windows.Forms.ColumnHeader EmailAddress;
        private System.Windows.Forms.ColumnHeader EmailMessage;
        private System.Windows.Forms.Button NewEntryButton;
        private System.Windows.Forms.Button QuarentineButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button JSONExportButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TrendingListButton;
        private System.Windows.Forms.Button MentionsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView SIRMessageList;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

