namespace ToDoList_App_v1
{
    partial class ToDoList
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
            this.titleCard = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.taskDescriptionLabel = new System.Windows.Forms.Label();
            this.taskTitleLabel = new System.Windows.Forms.Label();
            this.newTaskBtn = new System.Windows.Forms.Button();
            this.saveTaskBtn = new System.Windows.Forms.Button();
            this.deleteTaskBtn = new System.Windows.Forms.Button();
            this.editTaskBtn = new System.Windows.Forms.Button();
            this.myListAppView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myListAppView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleCard
            // 
            this.titleCard.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCard.Location = new System.Drawing.Point(2, -1);
            this.titleCard.Name = "titleCard";
            this.titleCard.Size = new System.Drawing.Size(722, 38);
            this.titleCard.TabIndex = 0;
            this.titleCard.Text = "MyList";
            this.titleCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 59);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(712, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 106);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(712, 20);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // taskDescriptionLabel
            // 
            this.taskDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescriptionLabel.Location = new System.Drawing.Point(13, 87);
            this.taskDescriptionLabel.Name = "taskDescriptionLabel";
            this.taskDescriptionLabel.Size = new System.Drawing.Size(711, 16);
            this.taskDescriptionLabel.TabIndex = 3;
            this.taskDescriptionLabel.Text = "Description";
            // 
            // taskTitleLabel
            // 
            this.taskTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitleLabel.Location = new System.Drawing.Point(13, 40);
            this.taskTitleLabel.Name = "taskTitleLabel";
            this.taskTitleLabel.Size = new System.Drawing.Size(711, 16);
            this.taskTitleLabel.TabIndex = 5;
            this.taskTitleLabel.Text = "Title:";
            // 
            // newTaskBtn
            // 
            this.newTaskBtn.Location = new System.Drawing.Point(12, 132);
            this.newTaskBtn.Name = "newTaskBtn";
            this.newTaskBtn.Size = new System.Drawing.Size(175, 30);
            this.newTaskBtn.TabIndex = 6;
            this.newTaskBtn.Text = "New";
            this.newTaskBtn.UseVisualStyleBackColor = true;
            // 
            // saveTaskBtn
            // 
            this.saveTaskBtn.Location = new System.Drawing.Point(549, 132);
            this.saveTaskBtn.Name = "saveTaskBtn";
            this.saveTaskBtn.Size = new System.Drawing.Size(175, 30);
            this.saveTaskBtn.TabIndex = 7;
            this.saveTaskBtn.Text = "Save";
            this.saveTaskBtn.UseVisualStyleBackColor = true;
            // 
            // deleteTaskBtn
            // 
            this.deleteTaskBtn.Location = new System.Drawing.Point(370, 132);
            this.deleteTaskBtn.Name = "deleteTaskBtn";
            this.deleteTaskBtn.Size = new System.Drawing.Size(175, 30);
            this.deleteTaskBtn.TabIndex = 8;
            this.deleteTaskBtn.Text = "Delete";
            this.deleteTaskBtn.UseVisualStyleBackColor = true;
            // 
            // editTaskBtn
            // 
            this.editTaskBtn.Location = new System.Drawing.Point(191, 132);
            this.editTaskBtn.Name = "editTaskBtn";
            this.editTaskBtn.Size = new System.Drawing.Size(175, 30);
            this.editTaskBtn.TabIndex = 9;
            this.editTaskBtn.Text = "Edit";
            this.editTaskBtn.UseVisualStyleBackColor = true;
            // 
            // myListAppView
            // 
            this.myListAppView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myListAppView.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.myListAppView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myListAppView.GridColor = System.Drawing.SystemColors.HighlightText;
            this.myListAppView.Location = new System.Drawing.Point(12, 169);
            this.myListAppView.Name = "myListAppView";
            this.myListAppView.Size = new System.Drawing.Size(712, 304);
            this.myListAppView.TabIndex = 10;
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(736, 485);
            this.Controls.Add(this.myListAppView);
            this.Controls.Add(this.editTaskBtn);
            this.Controls.Add(this.deleteTaskBtn);
            this.Controls.Add(this.saveTaskBtn);
            this.Controls.Add(this.newTaskBtn);
            this.Controls.Add(this.taskTitleLabel);
            this.Controls.Add(this.taskDescriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleCard);
            this.Name = "ToDoList";
            this.Text = "MyList App v1";
            this.Load += new System.EventHandler(this.ToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myListAppView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleCard;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label taskDescriptionLabel;
        private System.Windows.Forms.Label taskTitleLabel;
        private System.Windows.Forms.Button newTaskBtn;
        private System.Windows.Forms.Button saveTaskBtn;
        private System.Windows.Forms.Button deleteTaskBtn;
        private System.Windows.Forms.Button editTaskBtn;
        private System.Windows.Forms.DataGridView myListAppView;
    }
}

