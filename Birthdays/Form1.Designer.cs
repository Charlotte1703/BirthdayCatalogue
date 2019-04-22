namespace Birthdays
{
    partial class FormBirthday
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
            this.textBoxPerson = new System.Windows.Forms.TextBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelPerson = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxDaysToBirthday = new System.Windows.Forms.TextBox();
            this.labelDaysToBirthday = new System.Windows.Forms.Label();
            this.buttonBirthdaysNear = new System.Windows.Forms.Button();
            this.buttonBirthdayOctober = new System.Windows.Forms.Button();
            this.buttonBirthdayNovember = new System.Windows.Forms.Button();
            this.buttonBirthdayDecember = new System.Windows.Forms.Button();
            this.buttonBirthdayJanuary = new System.Windows.Forms.Button();
            this.buttonBirthdayFebruary = new System.Windows.Forms.Button();
            this.buttonBirthdayMarch = new System.Windows.Forms.Button();
            this.buttonBirthdayApril = new System.Windows.Forms.Button();
            this.buttonBirthdayMay = new System.Windows.Forms.Button();
            this.buttonBirthdayJune = new System.Windows.Forms.Button();
            this.buttonBirthdayJuly = new System.Windows.Forms.Button();
            this.buttonBirthdayAugust = new System.Windows.Forms.Button();
            this.buttonBirthdaySeptember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPerson
            // 
            this.textBoxPerson.Location = new System.Drawing.Point(26, 76);
            this.textBoxPerson.Name = "textBoxPerson";
            this.textBoxPerson.Size = new System.Drawing.Size(236, 20);
            this.textBoxPerson.TabIndex = 0;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(26, 238);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(76, 23);
            this.buttonPrevious.TabIndex = 1;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(190, 238);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(76, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Location = new System.Drawing.Point(23, 60);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(118, 13);
            this.labelPerson.TabIndex = 3;
            this.labelPerson.Text = "Name and Date of Birth";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(26, 131);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(236, 20);
            this.textBoxAge.TabIndex = 4;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(23, 115);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age";
            // 
            // textBoxDaysToBirthday
            // 
            this.textBoxDaysToBirthday.Location = new System.Drawing.Point(26, 188);
            this.textBoxDaysToBirthday.Name = "textBoxDaysToBirthday";
            this.textBoxDaysToBirthday.Size = new System.Drawing.Size(236, 20);
            this.textBoxDaysToBirthday.TabIndex = 6;
            // 
            // labelDaysToBirthday
            // 
            this.labelDaysToBirthday.AutoSize = true;
            this.labelDaysToBirthday.Location = new System.Drawing.Point(23, 172);
            this.labelDaysToBirthday.Name = "labelDaysToBirthday";
            this.labelDaysToBirthday.Size = new System.Drawing.Size(84, 13);
            this.labelDaysToBirthday.TabIndex = 7;
            this.labelDaysToBirthday.Text = "Days to Birthday";
            // 
            // buttonBirthdaysNear
            // 
            this.buttonBirthdaysNear.Location = new System.Drawing.Point(26, 285);
            this.buttonBirthdaysNear.Name = "buttonBirthdaysNear";
            this.buttonBirthdaysNear.Size = new System.Drawing.Size(240, 24);
            this.buttonBirthdaysNear.TabIndex = 8;
            this.buttonBirthdaysNear.Text = "Birthdays Near";
            this.buttonBirthdaysNear.UseVisualStyleBackColor = true;
            this.buttonBirthdaysNear.Click += new System.EventHandler(this.buttonBirthdaysNear_Click);
            // 
            // buttonBirthdayOctober
            // 
            this.buttonBirthdayOctober.Location = new System.Drawing.Point(26, 416);
            this.buttonBirthdayOctober.Name = "buttonBirthdayOctober";
            this.buttonBirthdayOctober.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdayOctober.TabIndex = 9;
            this.buttonBirthdayOctober.Text = "Oct";
            this.buttonBirthdayOctober.UseVisualStyleBackColor = true;
            this.buttonBirthdayOctober.Click += new System.EventHandler(this.buttonBirthdayThisMonth_Click);
            // 
            // buttonBirthdayNovember
            // 
            this.buttonBirthdayNovember.Location = new System.Drawing.Point(108, 416);
            this.buttonBirthdayNovember.Name = "buttonBirthdayNovember";
            this.buttonBirthdayNovember.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdayNovember.TabIndex = 10;
            this.buttonBirthdayNovember.Text = "Nov";
            this.buttonBirthdayNovember.UseVisualStyleBackColor = true;
            this.buttonBirthdayNovember.Click += new System.EventHandler(this.buttonBirthdayNovember_Click);
            // 
            // buttonBirthdayDecember
            // 
            this.buttonBirthdayDecember.Location = new System.Drawing.Point(190, 416);
            this.buttonBirthdayDecember.Name = "buttonBirthdayDecember";
            this.buttonBirthdayDecember.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdayDecember.TabIndex = 11;
            this.buttonBirthdayDecember.Text = "Dec";
            this.buttonBirthdayDecember.UseVisualStyleBackColor = true;
            this.buttonBirthdayDecember.Click += new System.EventHandler(this.buttonBirthdayDecember_Click);
            // 
            // buttonBirthdayJanuary
            // 
            this.buttonBirthdayJanuary.Location = new System.Drawing.Point(26, 329);
            this.buttonBirthdayJanuary.Name = "buttonBirthdayJanuary";
            this.buttonBirthdayJanuary.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdayJanuary.TabIndex = 12;
            this.buttonBirthdayJanuary.Text = "Jan";
            this.buttonBirthdayJanuary.UseVisualStyleBackColor = true;
            this.buttonBirthdayJanuary.Click += new System.EventHandler(this.buttonBirthdayJanuary_Click);
            // 
            // buttonBirthdayFebruary
            // 
            this.buttonBirthdayFebruary.Location = new System.Drawing.Point(108, 329);
            this.buttonBirthdayFebruary.Name = "buttonBirthdayFebruary";
            this.buttonBirthdayFebruary.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdayFebruary.TabIndex = 13;
            this.buttonBirthdayFebruary.Text = "Feb";
            this.buttonBirthdayFebruary.UseVisualStyleBackColor = true;
            this.buttonBirthdayFebruary.Click += new System.EventHandler(this.buttonBirthdayFebruary_Click);
            // 
            // buttonBirthdayMarch
            // 
            this.buttonBirthdayMarch.Location = new System.Drawing.Point(190, 329);
            this.buttonBirthdayMarch.Name = "buttonBirthdayMarch";
            this.buttonBirthdayMarch.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdayMarch.TabIndex = 14;
            this.buttonBirthdayMarch.Text = "Mar";
            this.buttonBirthdayMarch.UseVisualStyleBackColor = true;
            this.buttonBirthdayMarch.Click += new System.EventHandler(this.buttonBirthdayMarch_Click);
            // 
            // buttonBirthdayApril
            // 
            this.buttonBirthdayApril.Location = new System.Drawing.Point(26, 358);
            this.buttonBirthdayApril.Name = "buttonBirthdayApril";
            this.buttonBirthdayApril.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdayApril.TabIndex = 15;
            this.buttonBirthdayApril.Text = "Apr";
            this.buttonBirthdayApril.UseVisualStyleBackColor = true;
            this.buttonBirthdayApril.Click += new System.EventHandler(this.buttonBirthdayApril_Click);
            // 
            // buttonBirthdayMay
            // 
            this.buttonBirthdayMay.Location = new System.Drawing.Point(108, 358);
            this.buttonBirthdayMay.Name = "buttonBirthdayMay";
            this.buttonBirthdayMay.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdayMay.TabIndex = 16;
            this.buttonBirthdayMay.Text = "May";
            this.buttonBirthdayMay.UseVisualStyleBackColor = true;
            this.buttonBirthdayMay.Click += new System.EventHandler(this.buttonBirthdayMay_Click);
            // 
            // buttonBirthdayJune
            // 
            this.buttonBirthdayJune.Location = new System.Drawing.Point(191, 358);
            this.buttonBirthdayJune.Name = "buttonBirthdayJune";
            this.buttonBirthdayJune.Size = new System.Drawing.Size(75, 23);
            this.buttonBirthdayJune.TabIndex = 17;
            this.buttonBirthdayJune.Text = "Jun";
            this.buttonBirthdayJune.UseVisualStyleBackColor = true;
            this.buttonBirthdayJune.Click += new System.EventHandler(this.buttonBirthdayJune_Click);
            // 
            // buttonBirthdayJuly
            // 
            this.buttonBirthdayJuly.Location = new System.Drawing.Point(26, 387);
            this.buttonBirthdayJuly.Name = "buttonBirthdayJuly";
            this.buttonBirthdayJuly.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdayJuly.TabIndex = 18;
            this.buttonBirthdayJuly.Text = "Jul";
            this.buttonBirthdayJuly.UseVisualStyleBackColor = true;
            this.buttonBirthdayJuly.Click += new System.EventHandler(this.buttonBirthdayJuly_Click);
            // 
            // buttonBirthdayAugust
            // 
            this.buttonBirthdayAugust.Location = new System.Drawing.Point(108, 387);
            this.buttonBirthdayAugust.Name = "buttonBirthdayAugust";
            this.buttonBirthdayAugust.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdayAugust.TabIndex = 19;
            this.buttonBirthdayAugust.Text = "Aug";
            this.buttonBirthdayAugust.UseVisualStyleBackColor = true;
            this.buttonBirthdayAugust.Click += new System.EventHandler(this.buttonBirthdayAugust_Click);
            // 
            // buttonBirthdaySeptember
            // 
            this.buttonBirthdaySeptember.Location = new System.Drawing.Point(190, 387);
            this.buttonBirthdaySeptember.Name = "buttonBirthdaySeptember";
            this.buttonBirthdaySeptember.Size = new System.Drawing.Size(76, 23);
            this.buttonBirthdaySeptember.TabIndex = 20;
            this.buttonBirthdaySeptember.Text = "Sep";
            this.buttonBirthdaySeptember.UseVisualStyleBackColor = true;
            this.buttonBirthdaySeptember.Click += new System.EventHandler(this.buttonBirthdaySeptember_Click);
            // 
            // FormBirthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 464);
            this.Controls.Add(this.buttonBirthdaySeptember);
            this.Controls.Add(this.buttonBirthdayAugust);
            this.Controls.Add(this.buttonBirthdayJuly);
            this.Controls.Add(this.buttonBirthdayJune);
            this.Controls.Add(this.buttonBirthdayMay);
            this.Controls.Add(this.buttonBirthdayApril);
            this.Controls.Add(this.buttonBirthdayMarch);
            this.Controls.Add(this.buttonBirthdayFebruary);
            this.Controls.Add(this.buttonBirthdayJanuary);
            this.Controls.Add(this.buttonBirthdayDecember);
            this.Controls.Add(this.buttonBirthdayNovember);
            this.Controls.Add(this.buttonBirthdayOctober);
            this.Controls.Add(this.buttonBirthdaysNear);
            this.Controls.Add(this.labelDaysToBirthday);
            this.Controls.Add(this.textBoxDaysToBirthday);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelPerson);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.textBoxPerson);
            this.Name = "FormBirthday";
            this.Text = "Birthday Viewer";
            this.Load += new System.EventHandler(this.FormBirthday_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPerson;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxDaysToBirthday;
        private System.Windows.Forms.Label labelDaysToBirthday;
        private System.Windows.Forms.Button buttonBirthdaysNear;
        private System.Windows.Forms.Button buttonBirthdayOctober;
        private System.Windows.Forms.Button buttonBirthdayNovember;
        private System.Windows.Forms.Button buttonBirthdayDecember;
        private System.Windows.Forms.Button buttonBirthdayJanuary;
        private System.Windows.Forms.Button buttonBirthdayFebruary;
        private System.Windows.Forms.Button buttonBirthdayMarch;
        private System.Windows.Forms.Button buttonBirthdayApril;
        private System.Windows.Forms.Button buttonBirthdayMay;
        private System.Windows.Forms.Button buttonBirthdayJune;
        private System.Windows.Forms.Button buttonBirthdayJuly;
        private System.Windows.Forms.Button buttonBirthdayAugust;
        private System.Windows.Forms.Button buttonBirthdaySeptember;
    }
}

