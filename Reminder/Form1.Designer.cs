namespace Reminder
{
    partial class Reminder
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
            this.button1 = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.toDoThing = new System.Windows.Forms.TextBox();
            this.toDoList = new System.Windows.Forms.ListBox();
            this.log = new System.Windows.Forms.Label();
            this.toDoDetail = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(74, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(74, 261);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(293, 22);
            this.datePicker.TabIndex = 1;
            // 
            // toDoThing
            // 
            this.toDoThing.BackColor = System.Drawing.Color.DimGray;
            this.toDoThing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoThing.ForeColor = System.Drawing.Color.White;
            this.toDoThing.Location = new System.Drawing.Point(74, 50);
            this.toDoThing.Name = "toDoThing";
            this.toDoThing.Size = new System.Drawing.Size(293, 28);
            this.toDoThing.TabIndex = 2;
            // 
            // toDoList
            // 
            this.toDoList.BackColor = System.Drawing.Color.DimGray;
            this.toDoList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDoList.Cursor = System.Windows.Forms.Cursors.Cross;
            this.toDoList.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoList.ForeColor = System.Drawing.Color.White;
            this.toDoList.FormattingEnabled = true;
            this.toDoList.ItemHeight = 22;
            this.toDoList.Location = new System.Drawing.Point(428, 50);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(293, 112);
            this.toDoList.TabIndex = 3;
            this.toDoList.SelectedIndexChanged += new System.EventHandler(this.toDoList_SelectedIndexChanged);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(74, 286);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(0, 16);
            this.log.TabIndex = 4;
            // 
            // toDoDetail
            // 
            this.toDoDetail.BackColor = System.Drawing.Color.DimGray;
            this.toDoDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDoDetail.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoDetail.ForeColor = System.Drawing.Color.White;
            this.toDoDetail.Location = new System.Drawing.Point(74, 105);
            this.toDoDetail.Name = "toDoDetail";
            this.toDoDetail.Size = new System.Drawing.Size(293, 150);
            this.toDoDetail.TabIndex = 7;
            this.toDoDetail.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Detail";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(425, 28);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(72, 16);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "To do list";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel.ForeColor = System.Drawing.Color.White;
            this.detailLabel.Location = new System.Drawing.Point(424, 165);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(0, 22);
            this.detailLabel.TabIndex = 13;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DimGray;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(238, 310);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(129, 45);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.DimGray;
            this.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.ForeColor = System.Drawing.Color.White;
            this.delButton.Location = new System.Drawing.Point(641, 323);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(80, 27);
            this.delButton.TabIndex = 15;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(794, 395);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toDoDetail);
            this.Controls.Add(this.log);
            this.Controls.Add(this.toDoList);
            this.Controls.Add(this.toDoThing);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.button1);
            this.Name = "Reminder";
            this.Text = "Reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox toDoThing;
        private System.Windows.Forms.ListBox toDoList;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.RichTextBox toDoDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button delButton;
    }
}

