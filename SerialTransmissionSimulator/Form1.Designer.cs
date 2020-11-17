﻿namespace SerialTransmissionSimulator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.converterBinaryCodeBox = new System.Windows.Forms.TextBox();
            this.receiverTextBox = new System.Windows.Forms.TextBox();
            this.clearSenderButton = new System.Windows.Forms.Button();
            this.sendSenderButton = new System.Windows.Forms.Button();
            this.clearConverterButton = new System.Windows.Forms.Button();
            this.sendConverterButton = new System.Windows.Forms.Button();
            this.clearReceiverButton = new System.Windows.Forms.Button();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            this.SuspendLayout();
            // 
            // senderTextBox
            // 
            this.senderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senderTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderTextBox.Location = new System.Drawing.Point(99, 57);
            this.senderTextBox.Multiline = true;
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.senderTextBox.Size = new System.Drawing.Size(167, 191);
            this.senderTextBox.TabIndex = 0;
            // 
            // converterBinaryCodeBox
            // 
            this.converterBinaryCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.converterBinaryCodeBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converterBinaryCodeBox.Location = new System.Drawing.Point(314, 57);
            this.converterBinaryCodeBox.Multiline = true;
            this.converterBinaryCodeBox.Name = "converterBinaryCodeBox";
            this.converterBinaryCodeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.converterBinaryCodeBox.Size = new System.Drawing.Size(167, 191);
            this.converterBinaryCodeBox.TabIndex = 4;
            // 
            // receiverTextBox
            // 
            this.receiverTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiverTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiverTextBox.Location = new System.Drawing.Point(534, 57);
            this.receiverTextBox.Multiline = true;
            this.receiverTextBox.Name = "receiverTextBox";
            this.receiverTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receiverTextBox.Size = new System.Drawing.Size(167, 191);
            this.receiverTextBox.TabIndex = 5;
            // 
            // clearSenderButton
            // 
            this.clearSenderButton.BackColor = System.Drawing.Color.GhostWhite;
            this.clearSenderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSenderButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.clearSenderButton.FlatAppearance.BorderSize = 2;
            this.clearSenderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.clearSenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSenderButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSenderButton.Location = new System.Drawing.Point(99, 276);
            this.clearSenderButton.Name = "clearSenderButton";
            this.clearSenderButton.Size = new System.Drawing.Size(150, 37);
            this.clearSenderButton.TabIndex = 6;
            this.clearSenderButton.Text = "CLEAR";
            this.clearSenderButton.UseVisualStyleBackColor = false;
            this.clearSenderButton.Click += new System.EventHandler(this.clearSender_Click);
            // 
            // sendSenderButton
            // 
            this.sendSenderButton.BackColor = System.Drawing.Color.GhostWhite;
            this.sendSenderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendSenderButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.sendSenderButton.FlatAppearance.BorderSize = 2;
            this.sendSenderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.sendSenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendSenderButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendSenderButton.Location = new System.Drawing.Point(99, 331);
            this.sendSenderButton.Name = "sendSenderButton";
            this.sendSenderButton.Size = new System.Drawing.Size(150, 37);
            this.sendSenderButton.TabIndex = 7;
            this.sendSenderButton.Text = "SEND";
            this.sendSenderButton.UseVisualStyleBackColor = false;
            this.sendSenderButton.Click += new System.EventHandler(this.sendToConverter_Click);
            // 
            // clearConverterButton
            // 
            this.clearConverterButton.BackColor = System.Drawing.Color.GhostWhite;
            this.clearConverterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearConverterButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.clearConverterButton.FlatAppearance.BorderSize = 2;
            this.clearConverterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.clearConverterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearConverterButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearConverterButton.Location = new System.Drawing.Point(314, 276);
            this.clearConverterButton.Name = "clearConverterButton";
            this.clearConverterButton.Size = new System.Drawing.Size(150, 37);
            this.clearConverterButton.TabIndex = 8;
            this.clearConverterButton.Text = "CLEAR";
            this.clearConverterButton.UseVisualStyleBackColor = false;
            this.clearConverterButton.Click += new System.EventHandler(this.clearConverter_Click);
            // 
            // sendConverterButton
            // 
            this.sendConverterButton.BackColor = System.Drawing.Color.GhostWhite;
            this.sendConverterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendConverterButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.sendConverterButton.FlatAppearance.BorderSize = 2;
            this.sendConverterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.sendConverterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendConverterButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendConverterButton.Location = new System.Drawing.Point(314, 331);
            this.sendConverterButton.Name = "sendConverterButton";
            this.sendConverterButton.Size = new System.Drawing.Size(150, 37);
            this.sendConverterButton.TabIndex = 9;
            this.sendConverterButton.Text = "SEND";
            this.sendConverterButton.UseVisualStyleBackColor = false;
            this.sendConverterButton.Click += new System.EventHandler(this.sendToReceiver);
            // 
            // clearReceiverButton
            // 
            this.clearReceiverButton.BackColor = System.Drawing.Color.GhostWhite;
            this.clearReceiverButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearReceiverButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.clearReceiverButton.FlatAppearance.BorderSize = 2;
            this.clearReceiverButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.clearReceiverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearReceiverButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearReceiverButton.Location = new System.Drawing.Point(535, 277);
            this.clearReceiverButton.Name = "clearReceiverButton";
            this.clearReceiverButton.Size = new System.Drawing.Size(150, 37);
            this.clearReceiverButton.TabIndex = 10;
            this.clearReceiverButton.Text = "CLEAR";
            this.clearReceiverButton.UseVisualStyleBackColor = false;
            this.clearReceiverButton.Click += new System.EventHandler(this.clearReceiver_Click);
            // 
            // arrow1
            // 
            this.arrow1.BackColor = System.Drawing.Color.Transparent;
            this.arrow1.BackgroundImage = global::SerialTransmissionSimulator.Properties.Resources.arrow;
            this.arrow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrow1.Location = new System.Drawing.Point(254, 143);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(54, 28);
            this.arrow1.TabIndex = 11;
            this.arrow1.TabStop = false;
            // 
            // arrow2
            // 
            this.arrow2.BackColor = System.Drawing.Color.Transparent;
            this.arrow2.BackgroundImage = global::SerialTransmissionSimulator.Properties.Resources.arrow;
            this.arrow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrow2.Location = new System.Drawing.Point(474, 143);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(54, 28);
            this.arrow2.TabIndex = 12;
            this.arrow2.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "Serial Transmission Simulator";
            this.notifyIcon2.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 461);
            this.Controls.Add(this.arrow2);
            this.Controls.Add(this.arrow1);
            this.Controls.Add(this.clearReceiverButton);
            this.Controls.Add(this.sendConverterButton);
            this.Controls.Add(this.clearConverterButton);
            this.Controls.Add(this.sendSenderButton);
            this.Controls.Add(this.clearSenderButton);
            this.Controls.Add(this.receiverTextBox);
            this.Controls.Add(this.converterBinaryCodeBox);
            this.Controls.Add(this.senderTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Serial Transmission Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.TextBox converterBinaryCodeBox;
        private System.Windows.Forms.TextBox receiverTextBox;
        private System.Windows.Forms.Button clearSenderButton;
        private System.Windows.Forms.Button sendSenderButton;
        private System.Windows.Forms.Button clearConverterButton;
        private System.Windows.Forms.Button sendConverterButton;
        private System.Windows.Forms.Button clearReceiverButton;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.PictureBox arrow2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}
