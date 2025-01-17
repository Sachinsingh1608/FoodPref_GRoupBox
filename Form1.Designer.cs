﻿namespace WindowsFormsApp1
{
    partial class Veg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.CheckBox();
            this.Bike = new System.Windows.Forms.CheckBox();
            this.Cycle = new System.Windows.Forms.CheckBox();
            this.Hindi = new System.Windows.Forms.RadioButton();
            this.English = new System.Windows.Forms.RadioButton();
            this.Urdu = new System.Windows.Forms.RadioButton();
            this.Food = new System.Windows.Forms.GroupBox();
            this.omnivores = new System.Windows.Forms.RadioButton();
            this.Nonveg = new System.Windows.Forms.RadioButton();
            this.VegBut = new System.Windows.Forms.RadioButton();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.TransGender = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.RollNoBut = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Clear = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Savedata = new System.Windows.Forms.Button();
            this.LoadData = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Shoe = new System.Windows.Forms.ListBox();
            this.Food.SuspendLayout();
            this.Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(837, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "RollNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mother Tongue";
            // 
            // Car
            // 
            this.Car.AutoSize = true;
            this.Car.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Car.Location = new System.Drawing.Point(84, 277);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(70, 24);
            this.Car.TabIndex = 4;
            this.Car.Text = "Car";
            this.Car.UseVisualStyleBackColor = true;
            this.Car.CheckedChanged += new System.EventHandler(this.Car_CheckedChanged);
            this.Car.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Car_KeyPress);
            // 
            // Bike
            // 
            this.Bike.AutoSize = true;
            this.Bike.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bike.Location = new System.Drawing.Point(84, 318);
            this.Bike.Name = "Bike";
            this.Bike.Size = new System.Drawing.Size(83, 24);
            this.Bike.TabIndex = 5;
            this.Bike.Text = "Bike";
            this.Bike.UseVisualStyleBackColor = true;
            this.Bike.CheckedChanged += new System.EventHandler(this.Bike_CheckedChanged);
            // 
            // Cycle
            // 
            this.Cycle.AutoSize = true;
            this.Cycle.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cycle.Location = new System.Drawing.Point(84, 369);
            this.Cycle.Name = "Cycle";
            this.Cycle.Size = new System.Drawing.Size(96, 24);
            this.Cycle.TabIndex = 6;
            this.Cycle.Text = "Cycle";
            this.Cycle.UseVisualStyleBackColor = true;
            this.Cycle.CheckedChanged += new System.EventHandler(this.Cycle_CheckedChanged);
            // 
            // Hindi
            // 
            this.Hindi.AutoSize = true;
            this.Hindi.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hindi.Location = new System.Drawing.Point(629, 277);
            this.Hindi.Name = "Hindi";
            this.Hindi.Size = new System.Drawing.Size(95, 24);
            this.Hindi.TabIndex = 7;
            this.Hindi.TabStop = true;
            this.Hindi.Text = "Hindi";
            this.Hindi.UseVisualStyleBackColor = true;
            this.Hindi.CheckedChanged += new System.EventHandler(this.Hindi_CheckedChanged);
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.English.Location = new System.Drawing.Point(629, 318);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(121, 24);
            this.English.TabIndex = 8;
            this.English.TabStop = true;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = true;
            this.English.CheckedChanged += new System.EventHandler(this.English_CheckedChanged);
            // 
            // Urdu
            // 
            this.Urdu.AutoSize = true;
            this.Urdu.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Urdu.Location = new System.Drawing.Point(629, 368);
            this.Urdu.Name = "Urdu";
            this.Urdu.Size = new System.Drawing.Size(82, 24);
            this.Urdu.TabIndex = 9;
            this.Urdu.TabStop = true;
            this.Urdu.Text = "Urdu";
            this.Urdu.UseVisualStyleBackColor = true;
            this.Urdu.CheckedChanged += new System.EventHandler(this.Urdu_CheckedChanged);
            // 
            // Food
            // 
            this.Food.Controls.Add(this.omnivores);
            this.Food.Controls.Add(this.Nonveg);
            this.Food.Controls.Add(this.VegBut);
            this.Food.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food.Location = new System.Drawing.Point(201, 227);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(376, 190);
            this.Food.TabIndex = 10;
            this.Food.TabStop = false;
            this.Food.Text = "Food Preferences";
            this.Food.Enter += new System.EventHandler(this.Food_Enter);
            // 
            // omnivores
            // 
            this.omnivores.AutoSize = true;
            this.omnivores.Location = new System.Drawing.Point(24, 142);
            this.omnivores.Name = "omnivores";
            this.omnivores.Size = new System.Drawing.Size(147, 24);
            this.omnivores.TabIndex = 13;
            this.omnivores.TabStop = true;
            this.omnivores.Text = "omnivores";
            this.omnivores.UseVisualStyleBackColor = true;
            this.omnivores.CheckedChanged += new System.EventHandler(this.omnivores_CheckedChanged);
            // 
            // Nonveg
            // 
            this.Nonveg.AutoSize = true;
            this.Nonveg.Location = new System.Drawing.Point(24, 91);
            this.Nonveg.Name = "Nonveg";
            this.Nonveg.Size = new System.Drawing.Size(108, 24);
            this.Nonveg.TabIndex = 12;
            this.Nonveg.TabStop = true;
            this.Nonveg.Text = "NonVeg";
            this.Nonveg.UseVisualStyleBackColor = true;
            this.Nonveg.CheckedChanged += new System.EventHandler(this.Nonveg_CheckedChanged);
            // 
            // VegBut
            // 
            this.VegBut.AutoSize = true;
            this.VegBut.Location = new System.Drawing.Point(24, 50);
            this.VegBut.Name = "VegBut";
            this.VegBut.Size = new System.Drawing.Size(69, 24);
            this.VegBut.TabIndex = 11;
            this.VegBut.TabStop = true;
            this.VegBut.Text = "Veg";
            this.VegBut.UseVisualStyleBackColor = true;
            this.VegBut.CheckedChanged += new System.EventHandler(this.VegBut_CheckedChanged);
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.TransGender);
            this.Gender.Controls.Add(this.Female);
            this.Gender.Controls.Add(this.Male);
            this.Gender.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(875, 227);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(350, 198);
            this.Gender.TabIndex = 11;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            this.Gender.Enter += new System.EventHandler(this.Gender_Enter);
            // 
            // TransGender
            // 
            this.TransGender.AutoSize = true;
            this.TransGender.Location = new System.Drawing.Point(35, 135);
            this.TransGender.Name = "TransGender";
            this.TransGender.Size = new System.Drawing.Size(173, 24);
            this.TransGender.TabIndex = 16;
            this.TransGender.TabStop = true;
            this.TransGender.Text = "TransGender";
            this.TransGender.UseVisualStyleBackColor = true;
            this.TransGender.CheckedChanged += new System.EventHandler(this.TransGender_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(35, 84);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(108, 24);
            this.Female.TabIndex = 15;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(35, 43);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(82, 24);
            this.Male.TabIndex = 14;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Shoes";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.Location = new System.Drawing.Point(518, 514);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(0, 20);
            this.Data.TabIndex = 14;
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(203, 54);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(328, 36);
            this.Name.TabIndex = 15;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // RollNoBut
            // 
            this.RollNoBut.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollNoBut.FormattingEnabled = true;
            this.RollNoBut.Location = new System.Drawing.Point(980, 49);
            this.RollNoBut.Name = "RollNoBut";
            this.RollNoBut.Size = new System.Drawing.Size(233, 28);
            this.RollNoBut.TabIndex = 16;
            this.RollNoBut.SelectedIndexChanged += new System.EventHandler(this.RollNoBut_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "DOB";
            // 
            // DOB
            // 
            this.DOB.CalendarFont = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(203, 115);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(430, 27);
            this.DOB.TabIndex = 18;
            this.DOB.ValueChanged += new System.EventHandler(this.DOB_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.LightGray;
            this.Clear.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(28, 601);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 36);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.LightGray;
            this.Add.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(263, 601);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(110, 36);
            this.Add.TabIndex = 20;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Savedata
            // 
            this.Savedata.BackColor = System.Drawing.Color.LightGray;
            this.Savedata.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savedata.Location = new System.Drawing.Point(503, 601);
            this.Savedata.Name = "Savedata";
            this.Savedata.Size = new System.Drawing.Size(149, 36);
            this.Savedata.TabIndex = 21;
            this.Savedata.Text = "Save Data";
            this.Savedata.UseVisualStyleBackColor = false;
            this.Savedata.Click += new System.EventHandler(this.Savedata_Click);
            // 
            // LoadData
            // 
            this.LoadData.BackColor = System.Drawing.Color.LightGray;
            this.LoadData.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadData.Location = new System.Drawing.Point(760, 601);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(142, 36);
            this.LoadData.TabIndex = 22;
            this.LoadData.Text = "Load Data";
            this.LoadData.UseVisualStyleBackColor = false;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.LightGray;
            this.View.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.Location = new System.Drawing.Point(1067, 601);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(110, 36);
            this.View.TabIndex = 23;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.LightGray;
            this.Close.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(1326, 601);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(110, 36);
            this.Close.TabIndex = 24;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Shoe
            // 
            this.Shoe.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoe.FormattingEnabled = true;
            this.Shoe.ItemHeight = 18;
            this.Shoe.Items.AddRange(new object[] {
            "One",
            "Two ",
            "Three"});
            this.Shoe.Location = new System.Drawing.Point(80, 465);
            this.Shoe.Name = "Shoe";
            this.Shoe.Size = new System.Drawing.Size(238, 58);
            this.Shoe.TabIndex = 26;
            // 
            // Veg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1447, 708);
            this.Controls.Add(this.Shoe);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.View);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.Savedata);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RollNoBut);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Urdu);
            this.Controls.Add(this.English);
            this.Controls.Add(this.Hindi);
            this.Controls.Add(this.Cycle);
            this.Controls.Add(this.Bike);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
           // this.Name = "Veg";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Veg_Load);
            this.Food.ResumeLayout(false);
            this.Food.PerformLayout();
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Car;
        private System.Windows.Forms.CheckBox Bike;
        private System.Windows.Forms.CheckBox Cycle;
        private System.Windows.Forms.RadioButton Hindi;
        private System.Windows.Forms.RadioButton English;
        private System.Windows.Forms.RadioButton Urdu;
        private System.Windows.Forms.GroupBox Food;
        private System.Windows.Forms.RadioButton omnivores;
        private System.Windows.Forms.RadioButton Nonveg;
        private System.Windows.Forms.RadioButton VegBut;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.RadioButton TransGender;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.ComboBox RollNoBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Savedata;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ListBox Shoe;
    }
}

