namespace systemProgLab1
{
    partial class Form1
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.threadsBox = new System.Windows.Forms.ComboBox();
            this.thredsPerCliccEdit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.receiveThreadsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.responseList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(25, 134);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(93, 39);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(31, 218);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(89, 39);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // threadsBox
            // 
            this.threadsBox.FormattingEnabled = true;
            this.threadsBox.Location = new System.Drawing.Point(284, 234);
            this.threadsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.threadsBox.Name = "threadsBox";
            this.threadsBox.Size = new System.Drawing.Size(121, 24);
            this.threadsBox.TabIndex = 2;
            // 
            // thredsPerCliccEdit
            // 
            this.thredsPerCliccEdit.Location = new System.Drawing.Point(284, 153);
            this.thredsPerCliccEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thredsPerCliccEdit.Name = "thredsPerCliccEdit";
            this.thredsPerCliccEdit.Size = new System.Drawing.Size(119, 22);
            this.thredsPerCliccEdit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threads list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of threads to create";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(475, 337);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(132, 39);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(475, 133);
            this.messageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(132, 157);
            this.messageBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message Field";
            // 
            // receiveThreadsButton
            // 
            this.receiveThreadsButton.Location = new System.Drawing.Point(25, 304);
            this.receiveThreadsButton.Margin = new System.Windows.Forms.Padding(4);
            this.receiveThreadsButton.Name = "receiveThreadsButton";
            this.receiveThreadsButton.Size = new System.Drawing.Size(119, 33);
            this.receiveThreadsButton.TabIndex = 9;
            this.receiveThreadsButton.Text = "Get Threads";
            this.receiveThreadsButton.UseVisualStyleBackColor = true;
            this.receiveThreadsButton.Click += new System.EventHandler(this.receiveThreadsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Command status";
            // 
            // responseList
            // 
            this.responseList.FormattingEnabled = true;
            this.responseList.ItemHeight = 16;
            this.responseList.Location = new System.Drawing.Point(689, 133);
            this.responseList.Name = "responseList";
            this.responseList.Size = new System.Drawing.Size(154, 148);
            this.responseList.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.responseList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.receiveThreadsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thredsPerCliccEdit);
            this.Controls.Add(this.threadsBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ComboBox threadsBox;
        private System.Windows.Forms.TextBox thredsPerCliccEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button receiveThreadsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox responseList;
    }
}

