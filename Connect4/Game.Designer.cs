﻿namespace Connect4
{
    partial class GameForm
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
            this.pnlGraphics = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOpponentName = new System.Windows.Forms.Label();
            this.btnAbandon = new System.Windows.Forms.Button();
            this.txtMessageLog = new System.Windows.Forms.RichTextBox();
            this.txtPendingMessage = new System.Windows.Forms.RichTextBox();
            this.btnSubmitChat = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlGraphics
            // 
            this.pnlGraphics.BackColor = System.Drawing.SystemColors.Control;
            this.pnlGraphics.Location = new System.Drawing.Point(12, 12);
            this.pnlGraphics.Name = "pnlGraphics";
            this.pnlGraphics.Size = new System.Drawing.Size(881, 756);
            this.pnlGraphics.TabIndex = 0;
            this.pnlGraphics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGraphics_MouseDown);
            this.pnlGraphics.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGraphics_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(924, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connect 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(899, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your name:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(966, 49);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "lblUsername";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(899, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opponent name:";
            // 
            // lblOpponentName
            // 
            this.lblOpponentName.AutoSize = true;
            this.lblOpponentName.Location = new System.Drawing.Point(991, 62);
            this.lblOpponentName.Name = "lblOpponentName";
            this.lblOpponentName.Size = new System.Drawing.Size(92, 13);
            this.lblOpponentName.TabIndex = 5;
            this.lblOpponentName.Text = "lblOpponentName";
            // 
            // btnAbandon
            // 
            this.btnAbandon.Location = new System.Drawing.Point(899, 727);
            this.btnAbandon.Name = "btnAbandon";
            this.btnAbandon.Size = new System.Drawing.Size(205, 39);
            this.btnAbandon.TabIndex = 6;
            this.btnAbandon.Text = "Abandon";
            this.btnAbandon.UseVisualStyleBackColor = true;
            this.btnAbandon.Click += new System.EventHandler(this.btnAbandon_Click);
            // 
            // txtMessageLog
            // 
            this.txtMessageLog.Enabled = false;
            this.txtMessageLog.Location = new System.Drawing.Point(902, 112);
            this.txtMessageLog.Name = "txtMessageLog";
            this.txtMessageLog.Size = new System.Drawing.Size(205, 422);
            this.txtMessageLog.TabIndex = 7;
            this.txtMessageLog.Text = "";
            // 
            // txtPendingMessage
            // 
            this.txtPendingMessage.Location = new System.Drawing.Point(902, 540);
            this.txtPendingMessage.Name = "txtPendingMessage";
            this.txtPendingMessage.Size = new System.Drawing.Size(205, 35);
            this.txtPendingMessage.TabIndex = 8;
            this.txtPendingMessage.Text = "";
            this.txtPendingMessage.TextChanged += new System.EventHandler(this.txtPendingMessage_TextChanged);
            // 
            // btnSubmitChat
            // 
            this.btnSubmitChat.Location = new System.Drawing.Point(902, 589);
            this.btnSubmitChat.Name = "btnSubmitChat";
            this.btnSubmitChat.Size = new System.Drawing.Size(204, 35);
            this.btnSubmitChat.TabIndex = 9;
            this.btnSubmitChat.Text = "Send Message";
            this.btnSubmitChat.UseVisualStyleBackColor = true;
            this.btnSubmitChat.Click += new System.EventHandler(this.btnSubmitChat_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(958, 75);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(39, 13);
            this.lblTurn.TabIndex = 10;
            this.lblTurn.Text = "lblTurn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(899, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Your turn:";
            // 
            // GameForm
            // 
            this.AcceptButton = this.btnSubmitChat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1119, 778);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnSubmitChat);
            this.Controls.Add(this.txtPendingMessage);
            this.Controls.Add(this.txtMessageLog);
            this.Controls.Add(this.btnAbandon);
            this.Controls.Add(this.lblOpponentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGraphics);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1135, 817);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1135, 817);
            this.Name = "GameForm";
            this.Text = "Connect 4 - Game In Progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGraphics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOpponentName;
        private System.Windows.Forms.Button btnAbandon;
        private System.Windows.Forms.RichTextBox txtMessageLog;
        private System.Windows.Forms.RichTextBox txtPendingMessage;
        private System.Windows.Forms.Button btnSubmitChat;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label3;
    }
}

