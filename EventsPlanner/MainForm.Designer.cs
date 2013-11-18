namespace EventsPlanner
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.plMainListBox = new System.Windows.Forms.ListBox();
            this.plDeleteEventButton = new System.Windows.Forms.Button();
            this.plEditEventButton = new System.Windows.Forms.Button();
            this.plAddEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plMainListBox
            // 
            this.plMainListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plMainListBox.FormattingEnabled = true;
            this.plMainListBox.HorizontalScrollbar = true;
            this.plMainListBox.Location = new System.Drawing.Point(47, 37);
            this.plMainListBox.Name = "plMainListBox";
            this.plMainListBox.Size = new System.Drawing.Size(465, 524);
            this.plMainListBox.TabIndex = 0;
            // 
            // plDeleteEventButton
            // 
            this.plDeleteEventButton.BackgroundImage = global::EventsPlanner.Properties.Resources.delImg;
            this.plDeleteEventButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plDeleteEventButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plDeleteEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plDeleteEventButton.Location = new System.Drawing.Point(560, 296);
            this.plDeleteEventButton.Name = "plDeleteEventButton";
            this.plDeleteEventButton.Size = new System.Drawing.Size(89, 88);
            this.plDeleteEventButton.TabIndex = 3;
            this.plDeleteEventButton.UseVisualStyleBackColor = true;
            // 
            // plEditEventButton
            // 
            this.plEditEventButton.BackgroundImage = global::EventsPlanner.Properties.Resources.editImg;
            this.plEditEventButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plEditEventButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plEditEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plEditEventButton.Location = new System.Drawing.Point(560, 176);
            this.plEditEventButton.Name = "plEditEventButton";
            this.plEditEventButton.Size = new System.Drawing.Size(89, 88);
            this.plEditEventButton.TabIndex = 2;
            this.plEditEventButton.UseVisualStyleBackColor = true;
            // 
            // plAddEventButton
            // 
            this.plAddEventButton.BackgroundImage = global::EventsPlanner.Properties.Resources.addImg;
            this.plAddEventButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plAddEventButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plAddEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plAddEventButton.Location = new System.Drawing.Point(560, 59);
            this.plAddEventButton.Name = "plAddEventButton";
            this.plAddEventButton.Size = new System.Drawing.Size(89, 88);
            this.plAddEventButton.TabIndex = 1;
            this.plAddEventButton.UseVisualStyleBackColor = true;
            this.plAddEventButton.Click += new System.EventHandler(this.plAddEventButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 685);
            this.Controls.Add(this.plDeleteEventButton);
            this.Controls.Add(this.plEditEventButton);
            this.Controls.Add(this.plAddEventButton);
            this.Controls.Add(this.plMainListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Planner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox plMainListBox;
        private System.Windows.Forms.Button plAddEventButton;
        private System.Windows.Forms.Button plEditEventButton;
        private System.Windows.Forms.Button plDeleteEventButton;
    }
}

