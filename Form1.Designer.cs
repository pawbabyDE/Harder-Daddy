﻿namespace KLIKAJJJ
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.buttonLevelTextBox = new System.Windows.Forms.TextBox();
            this.A1AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A1UpgradeAmmount = new System.Windows.Forms.Button();
            this.A1Label = new System.Windows.Forms.Label();
            this.A1UpgradeInterval = new System.Windows.Forms.Button();
            this.A1IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A1Timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(323, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 160);
            this.button1.TabIndex = 0;
            this.button1.Text = "Harder Daddy~~";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "kasa: $0";
            // 
            // upgradeButton
            // 
            this.upgradeButton.Location = new System.Drawing.Point(323, 235);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(183, 57);
            this.upgradeButton.TabIndex = 2;
            this.upgradeButton.Text = "Upgrade ($10)";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // buttonLevelTextBox
            // 
            this.buttonLevelTextBox.Location = new System.Drawing.Point(323, 298);
            this.buttonLevelTextBox.Name = "buttonLevelTextBox";
            this.buttonLevelTextBox.ReadOnly = true;
            this.buttonLevelTextBox.Size = new System.Drawing.Size(183, 23);
            this.buttonLevelTextBox.TabIndex = 3;
            this.buttonLevelTextBox.Text = "1";
            this.buttonLevelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1AmmountTextBox
            // 
            this.A1AmmountTextBox.Location = new System.Drawing.Point(659, 69);
            this.A1AmmountTextBox.Name = "A1AmmountTextBox";
            this.A1AmmountTextBox.ReadOnly = true;
            this.A1AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1AmmountTextBox.TabIndex = 4;
            this.A1AmmountTextBox.Text = "0";
            this.A1AmmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1UpgradeAmmount
            // 
            this.A1UpgradeAmmount.Location = new System.Drawing.Point(645, 98);
            this.A1UpgradeAmmount.Name = "A1UpgradeAmmount";
            this.A1UpgradeAmmount.Size = new System.Drawing.Size(126, 131);
            this.A1UpgradeAmmount.TabIndex = 5;
            this.A1UpgradeAmmount.Text = "MOAAAR";
            this.A1UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A1UpgradeAmmount.Click += new System.EventHandler(this.A1UpgradeAmmount_Click);
            // 
            // A1Label
            // 
            this.A1Label.AutoSize = true;
            this.A1Label.Location = new System.Drawing.Point(671, 51);
            this.A1Label.Name = "A1Label";
            this.A1Label.Size = new System.Drawing.Size(78, 15);
            this.A1Label.TabIndex = 6;
            this.A1Label.Text = "AutoUpgrade";
            // 
            // A1UpgradeInterval
            // 
            this.A1UpgradeInterval.Location = new System.Drawing.Point(645, 264);
            this.A1UpgradeInterval.Name = "A1UpgradeInterval";
            this.A1UpgradeInterval.Size = new System.Drawing.Size(126, 138);
            this.A1UpgradeInterval.TabIndex = 7;
            this.A1UpgradeInterval.Text = "PERVETIN BOOST";
            this.A1UpgradeInterval.UseVisualStyleBackColor = true;
            this.A1UpgradeInterval.Click += new System.EventHandler(this.A1UpgradeInterval_Click);
            // 
            // A1IntervalTextBox
            // 
            this.A1IntervalTextBox.Location = new System.Drawing.Point(659, 235);
            this.A1IntervalTextBox.Name = "A1IntervalTextBox";
            this.A1IntervalTextBox.ReadOnly = true;
            this.A1IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1IntervalTextBox.TabIndex = 8;
            this.A1IntervalTextBox.Text = "0";
            this.A1IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1Timer
            // 
            this.A1Timer.Tick += new System.EventHandler(this.A1Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "/min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A1IntervalTextBox);
            this.Controls.Add(this.A1UpgradeInterval);
            this.Controls.Add(this.A1Label);
            this.Controls.Add(this.A1UpgradeAmmount);
            this.Controls.Add(this.A1AmmountTextBox);
            this.Controls.Add(this.buttonLevelTextBox);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button upgradeButton;
        private TextBox buttonLevelTextBox;
        private TextBox A1AmmountTextBox;
        private Button A1UpgradeAmmount;
        private Label A1Label;
        private Button A1UpgradeInterval;
        private TextBox A1IntervalTextBox;
        private System.Windows.Forms.Timer A1Timer;
        private Label label2;
    }
}