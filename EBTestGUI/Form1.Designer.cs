﻿namespace EBTestGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.EBTestTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButtonBHTest = new System.Windows.Forms.RadioButton();
            this.radioButtonBHLive = new System.Windows.Forms.RadioButton();
            this.IPServerButton = new System.Windows.Forms.Button();
            this.panelCheckBH = new System.Windows.Forms.Panel();
            this.dateTimePickerBH = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioButtonCarBH = new System.Windows.Forms.RadioButton();
            this.radioButtonTrainBH = new System.Windows.Forms.RadioButton();
            this.radioButtonFerryBH = new System.Windows.Forms.RadioButton();
            this.radioButtonBusBH = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButtonNoServerBH = new System.Windows.Forms.RadioButton();
            this.radioButtonS2BH = new System.Windows.Forms.RadioButton();
            this.radioButtonS1BH = new System.Windows.Forms.RadioButton();
            this.OrderNo_textBox = new System.Windows.Forms.TextBox();
            this.panelGenOS = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.GenOSWriteExcel = new System.Windows.Forms.RadioButton();
            this.GenOS = new System.Windows.Forms.RadioButton();
            this.RunGenOSButton = new System.Windows.Forms.Button();
            this.OS_textField = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.radioButtonTestOS = new System.Windows.Forms.RadioButton();
            this.radioButtonLiveOS = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.EditXMLButton = new System.Windows.Forms.Button();
            this.GenOSButton = new System.Windows.Forms.Button();
            this.CheckBHButton = new System.Windows.Forms.Button();
            this.TestBuyButton = new System.Windows.Forms.Button();
            this.panelInstruction = new System.Windows.Forms.Panel();
            this.richTextBoxInstruction = new System.Windows.Forms.RichTextBox();
            this.panelTestBuy = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.radioButtonCar = new System.Windows.Forms.RadioButton();
            this.radioButtonTrain = new System.Windows.Forms.RadioButton();
            this.radioButtonFerry = new System.Windows.Forms.RadioButton();
            this.radioButtonBus = new System.Windows.Forms.RadioButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.radioButtonNoServer = new System.Windows.Forms.RadioButton();
            this.radioButtonS2 = new System.Windows.Forms.RadioButton();
            this.radioButtonS1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.radioButtonSGD = new System.Windows.Forms.RadioButton();
            this.radioButtonMYR = new System.Windows.Forms.RadioButton();
            this.panel17 = new System.Windows.Forms.Panel();
            this.radioButtonTest = new System.Windows.Forms.RadioButton();
            this.radioButtonLive = new System.Windows.Forms.RadioButton();
            this.panel5.SuspendLayout();
            this.panelCheckBH.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelGenOS.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelInstruction.SuspendLayout();
            this.panelTestBuy.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // EBTestTitle
            // 
            this.EBTestTitle.AutoSize = true;
            this.EBTestTitle.Font = new System.Drawing.Font("Myanmar Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EBTestTitle.Location = new System.Drawing.Point(275, 20);
            this.EBTestTitle.Name = "EBTestTitle";
            this.EBTestTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EBTestTitle.Size = new System.Drawing.Size(253, 34);
            this.EBTestTitle.TabIndex = 7;
            this.EBTestTitle.Text = "EasyBook Test Automation";
            this.EBTestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.radioButtonBHTest);
            this.panel5.Controls.Add(this.radioButtonBHLive);
            this.panel5.Location = new System.Drawing.Point(28, 219);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(96, 79);
            this.panel5.TabIndex = 2;
            // 
            // radioButtonBHTest
            // 
            this.radioButtonBHTest.AutoSize = true;
            this.radioButtonBHTest.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBHTest.Location = new System.Drawing.Point(22, 43);
            this.radioButtonBHTest.Name = "radioButtonBHTest";
            this.radioButtonBHTest.Size = new System.Drawing.Size(45, 19);
            this.radioButtonBHTest.TabIndex = 1;
            this.radioButtonBHTest.Text = "Test";
            this.radioButtonBHTest.UseVisualStyleBackColor = true;
            this.radioButtonBHTest.CheckedChanged += new System.EventHandler(this.siteName);
            this.radioButtonBHTest.Click += new System.EventHandler(this.siteName);
            // 
            // radioButtonBHLive
            // 
            this.radioButtonBHLive.AutoSize = true;
            this.radioButtonBHLive.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBHLive.Location = new System.Drawing.Point(21, 18);
            this.radioButtonBHLive.Name = "radioButtonBHLive";
            this.radioButtonBHLive.Size = new System.Drawing.Size(46, 19);
            this.radioButtonBHLive.TabIndex = 0;
            this.radioButtonBHLive.Text = "Live";
            this.radioButtonBHLive.UseVisualStyleBackColor = true;
            this.radioButtonBHLive.CheckedChanged += new System.EventHandler(this.siteName);
            this.radioButtonBHLive.Click += new System.EventHandler(this.siteName);
            // 
            // IPServerButton
            // 
            this.IPServerButton.BackColor = System.Drawing.Color.SkyBlue;
            this.IPServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IPServerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPServerButton.Location = new System.Drawing.Point(204, 237);
            this.IPServerButton.Name = "IPServerButton";
            this.IPServerButton.Size = new System.Drawing.Size(124, 53);
            this.IPServerButton.TabIndex = 1;
            this.IPServerButton.Text = "Check Booking History";
            this.IPServerButton.UseVisualStyleBackColor = false;
            this.IPServerButton.Click += new System.EventHandler(this.CheckHistoryClick);
            // 
            // panelCheckBH
            // 
            this.panelCheckBH.BackColor = System.Drawing.Color.LightGray;
            this.panelCheckBH.Controls.Add(this.dateTimePickerBH);
            this.panelCheckBH.Controls.Add(this.panel8);
            this.panelCheckBH.Controls.Add(this.panel7);
            this.panelCheckBH.Controls.Add(this.OrderNo_textBox);
            this.panelCheckBH.Controls.Add(this.panel5);
            this.panelCheckBH.Controls.Add(this.IPServerButton);
            this.panelCheckBH.Location = new System.Drawing.Point(240, 60);
            this.panelCheckBH.Name = "panelCheckBH";
            this.panelCheckBH.Size = new System.Drawing.Size(380, 330);
            this.panelCheckBH.TabIndex = 9;
            // 
            // dateTimePickerBH
            // 
            this.dateTimePickerBH.Location = new System.Drawing.Point(132, 31);
            this.dateTimePickerBH.Name = "dateTimePickerBH";
            this.dateTimePickerBH.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerBH.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.radioButtonCarBH);
            this.panel8.Controls.Add(this.radioButtonTrainBH);
            this.panel8.Controls.Add(this.radioButtonFerryBH);
            this.panel8.Controls.Add(this.radioButtonBusBH);
            this.panel8.Location = new System.Drawing.Point(28, 76);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(87, 131);
            this.panel8.TabIndex = 14;
            // 
            // radioButtonCarBH
            // 
            this.radioButtonCarBH.AutoSize = true;
            this.radioButtonCarBH.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCarBH.Location = new System.Drawing.Point(19, 89);
            this.radioButtonCarBH.Name = "radioButtonCarBH";
            this.radioButtonCarBH.Size = new System.Drawing.Size(42, 19);
            this.radioButtonCarBH.TabIndex = 3;
            this.radioButtonCarBH.Text = "Car";
            this.radioButtonCarBH.UseVisualStyleBackColor = true;
            this.radioButtonCarBH.Click += new System.EventHandler(this.productType);
            // 
            // radioButtonTrainBH
            // 
            this.radioButtonTrainBH.AutoSize = true;
            this.radioButtonTrainBH.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrainBH.Location = new System.Drawing.Point(19, 66);
            this.radioButtonTrainBH.Name = "radioButtonTrainBH";
            this.radioButtonTrainBH.Size = new System.Drawing.Size(50, 19);
            this.radioButtonTrainBH.TabIndex = 2;
            this.radioButtonTrainBH.Text = "Train";
            this.radioButtonTrainBH.UseVisualStyleBackColor = true;
            this.radioButtonTrainBH.Click += new System.EventHandler(this.productType);
            // 
            // radioButtonFerryBH
            // 
            this.radioButtonFerryBH.AutoSize = true;
            this.radioButtonFerryBH.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFerryBH.Location = new System.Drawing.Point(19, 43);
            this.radioButtonFerryBH.Name = "radioButtonFerryBH";
            this.radioButtonFerryBH.Size = new System.Drawing.Size(51, 19);
            this.radioButtonFerryBH.TabIndex = 1;
            this.radioButtonFerryBH.Text = "Ferry";
            this.radioButtonFerryBH.UseVisualStyleBackColor = true;
            this.radioButtonFerryBH.Click += new System.EventHandler(this.productType);
            // 
            // radioButtonBusBH
            // 
            this.radioButtonBusBH.AutoSize = true;
            this.radioButtonBusBH.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBusBH.Location = new System.Drawing.Point(19, 20);
            this.radioButtonBusBH.Name = "radioButtonBusBH";
            this.radioButtonBusBH.Size = new System.Drawing.Size(44, 19);
            this.radioButtonBusBH.TabIndex = 0;
            this.radioButtonBusBH.Text = "Bus";
            this.radioButtonBusBH.UseVisualStyleBackColor = true;
            this.radioButtonBusBH.Click += new System.EventHandler(this.productType);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.radioButtonNoServerBH);
            this.panel7.Controls.Add(this.radioButtonS2BH);
            this.panel7.Controls.Add(this.radioButtonS1BH);
            this.panel7.Location = new System.Drawing.Point(133, 76);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(93, 114);
            this.panel7.TabIndex = 7;
            // 
            // radioButtonNoServerBH
            // 
            this.radioButtonNoServerBH.AutoSize = true;
            this.radioButtonNoServerBH.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNoServerBH.Location = new System.Drawing.Point(15, 68);
            this.radioButtonNoServerBH.Name = "radioButtonNoServerBH";
            this.radioButtonNoServerBH.Size = new System.Drawing.Size(74, 19);
            this.radioButtonNoServerBH.TabIndex = 2;
            this.radioButtonNoServerBH.Text = "Irrelevant";
            this.radioButtonNoServerBH.UseVisualStyleBackColor = true;
            this.radioButtonNoServerBH.Click += new System.EventHandler(this.serverType);
            // 
            // radioButtonS2BH
            // 
            this.radioButtonS2BH.AutoSize = true;
            this.radioButtonS2BH.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS2BH.Location = new System.Drawing.Point(15, 43);
            this.radioButtonS2BH.Name = "radioButtonS2BH";
            this.radioButtonS2BH.Size = new System.Drawing.Size(37, 19);
            this.radioButtonS2BH.TabIndex = 1;
            this.radioButtonS2BH.Text = "S2";
            this.radioButtonS2BH.UseVisualStyleBackColor = true;
            this.radioButtonS2BH.Click += new System.EventHandler(this.serverType);
            // 
            // radioButtonS1BH
            // 
            this.radioButtonS1BH.AutoSize = true;
            this.radioButtonS1BH.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS1BH.Location = new System.Drawing.Point(16, 18);
            this.radioButtonS1BH.Name = "radioButtonS1BH";
            this.radioButtonS1BH.Size = new System.Drawing.Size(36, 19);
            this.radioButtonS1BH.TabIndex = 0;
            this.radioButtonS1BH.Text = "S1";
            this.radioButtonS1BH.UseVisualStyleBackColor = true;
            this.radioButtonS1BH.Click += new System.EventHandler(this.serverType);
            // 
            // OrderNo_textBox
            // 
            this.OrderNo_textBox.ForeColor = System.Drawing.Color.DimGray;
            this.OrderNo_textBox.Location = new System.Drawing.Point(34, 29);
            this.OrderNo_textBox.Name = "OrderNo_textBox";
            this.OrderNo_textBox.Size = new System.Drawing.Size(81, 20);
            this.OrderNo_textBox.TabIndex = 13;
            this.OrderNo_textBox.Text = "Order No";
            this.OrderNo_textBox.Click += new System.EventHandler(this.OrderNo_Click);
            // 
            // panelGenOS
            // 
            this.panelGenOS.BackColor = System.Drawing.Color.LightGray;
            this.panelGenOS.Controls.Add(this.panel11);
            this.panelGenOS.Controls.Add(this.RunGenOSButton);
            this.panelGenOS.Controls.Add(this.OS_textField);
            this.panelGenOS.Controls.Add(this.panel10);
            this.panelGenOS.Location = new System.Drawing.Point(240, 60);
            this.panelGenOS.Name = "panelGenOS";
            this.panelGenOS.Size = new System.Drawing.Size(380, 330);
            this.panelGenOS.TabIndex = 11;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.GenOSWriteExcel);
            this.panel11.Controls.Add(this.GenOS);
            this.panel11.Location = new System.Drawing.Point(149, 88);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(205, 75);
            this.panel11.TabIndex = 6;
            // 
            // GenOSWriteExcel
            // 
            this.GenOSWriteExcel.AutoSize = true;
            this.GenOSWriteExcel.Location = new System.Drawing.Point(17, 41);
            this.GenOSWriteExcel.Name = "GenOSWriteExcel";
            this.GenOSWriteExcel.Size = new System.Drawing.Size(181, 17);
            this.GenOSWriteExcel.TabIndex = 1;
            this.GenOSWriteExcel.TabStop = true;
            this.GenOSWriteExcel.Text = "Generate OS and Write To Excel";
            this.GenOSWriteExcel.UseVisualStyleBackColor = true;
            this.GenOSWriteExcel.CheckedChanged += new System.EventHandler(this.GenOSAction);
            // 
            // GenOS
            // 
            this.GenOS.AutoSize = true;
            this.GenOS.Location = new System.Drawing.Point(17, 18);
            this.GenOS.Name = "GenOS";
            this.GenOS.Size = new System.Drawing.Size(109, 17);
            this.GenOS.TabIndex = 0;
            this.GenOS.TabStop = true;
            this.GenOS.Text = "Generate OS only";
            this.GenOS.UseVisualStyleBackColor = true;
            this.GenOS.CheckedChanged += new System.EventHandler(this.GenOSAction);
            // 
            // RunGenOSButton
            // 
            this.RunGenOSButton.Location = new System.Drawing.Point(133, 234);
            this.RunGenOSButton.Name = "RunGenOSButton";
            this.RunGenOSButton.Size = new System.Drawing.Size(96, 38);
            this.RunGenOSButton.TabIndex = 5;
            this.RunGenOSButton.Text = "Run";
            this.RunGenOSButton.UseVisualStyleBackColor = true;
            this.RunGenOSButton.Click += new System.EventHandler(this.RunGenOS_Click);
            // 
            // OS_textField
            // 
            this.OS_textField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.OS_textField.Location = new System.Drawing.Point(121, 46);
            this.OS_textField.Name = "OS_textField";
            this.OS_textField.Size = new System.Drawing.Size(144, 20);
            this.OS_textField.TabIndex = 4;
            this.OS_textField.Text = "Cart ID";
            this.OS_textField.Click += new System.EventHandler(this.OSTextField_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.radioButtonTestOS);
            this.panel10.Controls.Add(this.radioButtonLiveOS);
            this.panel10.Location = new System.Drawing.Point(28, 88);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(96, 79);
            this.panel10.TabIndex = 3;
            // 
            // radioButtonTestOS
            // 
            this.radioButtonTestOS.AutoSize = true;
            this.radioButtonTestOS.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTestOS.Location = new System.Drawing.Point(22, 43);
            this.radioButtonTestOS.Name = "radioButtonTestOS";
            this.radioButtonTestOS.Size = new System.Drawing.Size(45, 19);
            this.radioButtonTestOS.TabIndex = 1;
            this.radioButtonTestOS.Text = "Test";
            this.radioButtonTestOS.UseVisualStyleBackColor = true;
            this.radioButtonTestOS.CheckedChanged += new System.EventHandler(this.siteType);
            // 
            // radioButtonLiveOS
            // 
            this.radioButtonLiveOS.AutoSize = true;
            this.radioButtonLiveOS.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLiveOS.Location = new System.Drawing.Point(22, 18);
            this.radioButtonLiveOS.Name = "radioButtonLiveOS";
            this.radioButtonLiveOS.Size = new System.Drawing.Size(46, 19);
            this.radioButtonLiveOS.TabIndex = 0;
            this.radioButtonLiveOS.Text = "Live";
            this.radioButtonLiveOS.UseVisualStyleBackColor = true;
            this.radioButtonLiveOS.CheckedChanged += new System.EventHandler(this.siteType);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.Controls.Add(this.buttonLogOut);
            this.panel3.Controls.Add(this.InstructionButton);
            this.panel3.Controls.Add(this.EditXMLButton);
            this.panel3.Controls.Add(this.GenOSButton);
            this.panel3.Controls.Add(this.CheckBHButton);
            this.panel3.Controls.Add(this.TestBuyButton);
            this.panel3.Location = new System.Drawing.Point(-3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 470);
            this.panel3.TabIndex = 3;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(26, 421);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(134, 24);
            this.buttonLogOut.TabIndex = 5;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // InstructionButton
            // 
            this.InstructionButton.Location = new System.Drawing.Point(24, 20);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(137, 36);
            this.InstructionButton.TabIndex = 4;
            this.InstructionButton.Text = "Instruction";
            this.InstructionButton.UseVisualStyleBackColor = true;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
            // 
            // EditXMLButton
            // 
            this.EditXMLButton.Location = new System.Drawing.Point(24, 223);
            this.EditXMLButton.Name = "EditXMLButton";
            this.EditXMLButton.Size = new System.Drawing.Size(137, 36);
            this.EditXMLButton.TabIndex = 3;
            this.EditXMLButton.Text = "XML Documentation";
            this.EditXMLButton.UseVisualStyleBackColor = true;
            this.EditXMLButton.Click += new System.EventHandler(this.XMLDocButton_Click);
            // 
            // GenOSButton
            // 
            this.GenOSButton.Location = new System.Drawing.Point(24, 120);
            this.GenOSButton.Name = "GenOSButton";
            this.GenOSButton.Size = new System.Drawing.Size(138, 36);
            this.GenOSButton.TabIndex = 2;
            this.GenOSButton.Text = "Generate OS";
            this.GenOSButton.UseVisualStyleBackColor = true;
            this.GenOSButton.Click += new System.EventHandler(this.GenerateOSTab_Click);
            // 
            // CheckBHButton
            // 
            this.CheckBHButton.Location = new System.Drawing.Point(24, 171);
            this.CheckBHButton.Name = "CheckBHButton";
            this.CheckBHButton.Size = new System.Drawing.Size(138, 36);
            this.CheckBHButton.TabIndex = 1;
            this.CheckBHButton.Text = "Check Booking History";
            this.CheckBHButton.UseVisualStyleBackColor = true;
            this.CheckBHButton.Click += new System.EventHandler(this.CheckBHButton_Click);
            // 
            // TestBuyButton
            // 
            this.TestBuyButton.Location = new System.Drawing.Point(24, 71);
            this.TestBuyButton.Name = "TestBuyButton";
            this.TestBuyButton.Size = new System.Drawing.Size(138, 36);
            this.TestBuyButton.TabIndex = 0;
            this.TestBuyButton.Text = "Test Buy";
            this.TestBuyButton.UseVisualStyleBackColor = true;
            this.TestBuyButton.Click += new System.EventHandler(this.TestBuyButton_Click);
            // 
            // panelInstruction
            // 
            this.panelInstruction.BackColor = System.Drawing.Color.LightGray;
            this.panelInstruction.Controls.Add(this.richTextBoxInstruction);
            this.panelInstruction.Location = new System.Drawing.Point(240, 60);
            this.panelInstruction.Name = "panelInstruction";
            this.panelInstruction.Size = new System.Drawing.Size(380, 330);
            this.panelInstruction.TabIndex = 13;
            // 
            // richTextBoxInstruction
            // 
            this.richTextBoxInstruction.Location = new System.Drawing.Point(30, 29);
            this.richTextBoxInstruction.Name = "richTextBoxInstruction";
            this.richTextBoxInstruction.ReadOnly = true;
            this.richTextBoxInstruction.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxInstruction.Size = new System.Drawing.Size(316, 281);
            this.richTextBoxInstruction.TabIndex = 0;
            this.richTextBoxInstruction.Text = resources.GetString("richTextBoxInstruction.Text");
            // 
            // panelTestBuy
            // 
            this.panelTestBuy.BackColor = System.Drawing.Color.LightGray;
            this.panelTestBuy.Controls.Add(this.panel14);
            this.panelTestBuy.Controls.Add(this.panel15);
            this.panelTestBuy.Controls.Add(this.button2);
            this.panelTestBuy.Controls.Add(this.panel16);
            this.panelTestBuy.Controls.Add(this.panel17);
            this.panelTestBuy.Location = new System.Drawing.Point(240, 60);
            this.panelTestBuy.Name = "panelTestBuy";
            this.panelTestBuy.Size = new System.Drawing.Size(380, 330);
            this.panelTestBuy.TabIndex = 14;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.radioButtonCar);
            this.panel14.Controls.Add(this.radioButtonTrain);
            this.panel14.Controls.Add(this.radioButtonFerry);
            this.panel14.Controls.Add(this.radioButtonBus);
            this.panel14.Location = new System.Drawing.Point(31, 22);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(87, 131);
            this.panel14.TabIndex = 0;
            // 
            // radioButtonCar
            // 
            this.radioButtonCar.AutoSize = true;
            this.radioButtonCar.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCar.Location = new System.Drawing.Point(19, 89);
            this.radioButtonCar.Name = "radioButtonCar";
            this.radioButtonCar.Size = new System.Drawing.Size(42, 19);
            this.radioButtonCar.TabIndex = 3;
            this.radioButtonCar.Text = "Car";
            this.radioButtonCar.UseVisualStyleBackColor = true;
            this.radioButtonCar.CheckedChanged += new System.EventHandler(this.productType);
            // 
            // radioButtonTrain
            // 
            this.radioButtonTrain.AutoSize = true;
            this.radioButtonTrain.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTrain.Location = new System.Drawing.Point(19, 66);
            this.radioButtonTrain.Name = "radioButtonTrain";
            this.radioButtonTrain.Size = new System.Drawing.Size(50, 19);
            this.radioButtonTrain.TabIndex = 2;
            this.radioButtonTrain.Text = "Train";
            this.radioButtonTrain.UseVisualStyleBackColor = true;
            this.radioButtonTrain.CheckedChanged += new System.EventHandler(this.productType);
            // 
            // radioButtonFerry
            // 
            this.radioButtonFerry.AutoSize = true;
            this.radioButtonFerry.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFerry.Location = new System.Drawing.Point(19, 43);
            this.radioButtonFerry.Name = "radioButtonFerry";
            this.radioButtonFerry.Size = new System.Drawing.Size(51, 19);
            this.radioButtonFerry.TabIndex = 1;
            this.radioButtonFerry.Text = "Ferry";
            this.radioButtonFerry.UseVisualStyleBackColor = true;
            this.radioButtonFerry.CheckedChanged += new System.EventHandler(this.productType);
            // 
            // radioButtonBus
            // 
            this.radioButtonBus.AutoSize = true;
            this.radioButtonBus.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBus.Location = new System.Drawing.Point(19, 20);
            this.radioButtonBus.Name = "radioButtonBus";
            this.radioButtonBus.Size = new System.Drawing.Size(44, 19);
            this.radioButtonBus.TabIndex = 0;
            this.radioButtonBus.Text = "Bus";
            this.radioButtonBus.UseVisualStyleBackColor = true;
            this.radioButtonBus.CheckedChanged += new System.EventHandler(this.productType);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Transparent;
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.radioButtonNoServer);
            this.panel15.Controls.Add(this.radioButtonS2);
            this.panel15.Controls.Add(this.radioButtonS1);
            this.panel15.Location = new System.Drawing.Point(143, 144);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(93, 114);
            this.panel15.TabIndex = 6;
            // 
            // radioButtonNoServer
            // 
            this.radioButtonNoServer.AutoSize = true;
            this.radioButtonNoServer.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNoServer.Location = new System.Drawing.Point(15, 68);
            this.radioButtonNoServer.Name = "radioButtonNoServer";
            this.radioButtonNoServer.Size = new System.Drawing.Size(74, 19);
            this.radioButtonNoServer.TabIndex = 2;
            this.radioButtonNoServer.Text = "Irrelevant";
            this.radioButtonNoServer.UseVisualStyleBackColor = true;
            this.radioButtonNoServer.CheckedChanged += new System.EventHandler(this.serverType);
            // 
            // radioButtonS2
            // 
            this.radioButtonS2.AutoSize = true;
            this.radioButtonS2.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS2.Location = new System.Drawing.Point(15, 43);
            this.radioButtonS2.Name = "radioButtonS2";
            this.radioButtonS2.Size = new System.Drawing.Size(37, 19);
            this.radioButtonS2.TabIndex = 1;
            this.radioButtonS2.Text = "S2";
            this.radioButtonS2.UseVisualStyleBackColor = true;
            this.radioButtonS2.CheckedChanged += new System.EventHandler(this.serverType);
            // 
            // radioButtonS1
            // 
            this.radioButtonS1.AutoSize = true;
            this.radioButtonS1.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonS1.Location = new System.Drawing.Point(16, 18);
            this.radioButtonS1.Name = "radioButtonS1";
            this.radioButtonS1.Size = new System.Drawing.Size(36, 19);
            this.radioButtonS1.TabIndex = 0;
            this.radioButtonS1.Text = "S1";
            this.radioButtonS1.UseVisualStyleBackColor = true;
            this.radioButtonS1.CheckedChanged += new System.EventHandler(this.serverType);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(262, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Run_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Transparent;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.radioButtonSGD);
            this.panel16.Controls.Add(this.radioButtonMYR);
            this.panel16.Location = new System.Drawing.Point(32, 175);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(89, 83);
            this.panel16.TabIndex = 5;
            // 
            // radioButtonSGD
            // 
            this.radioButtonSGD.AutoSize = true;
            this.radioButtonSGD.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSGD.Location = new System.Drawing.Point(19, 43);
            this.radioButtonSGD.Name = "radioButtonSGD";
            this.radioButtonSGD.Size = new System.Drawing.Size(47, 19);
            this.radioButtonSGD.TabIndex = 1;
            this.radioButtonSGD.Text = "SGD";
            this.radioButtonSGD.UseVisualStyleBackColor = true;
            this.radioButtonSGD.CheckedChanged += new System.EventHandler(this.paypalType);
            // 
            // radioButtonMYR
            // 
            this.radioButtonMYR.AutoSize = true;
            this.radioButtonMYR.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMYR.Location = new System.Drawing.Point(19, 20);
            this.radioButtonMYR.Name = "radioButtonMYR";
            this.radioButtonMYR.Size = new System.Drawing.Size(49, 19);
            this.radioButtonMYR.TabIndex = 0;
            this.radioButtonMYR.Text = "MYR";
            this.radioButtonMYR.UseVisualStyleBackColor = true;
            this.radioButtonMYR.CheckedChanged += new System.EventHandler(this.paypalType);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.radioButtonTest);
            this.panel17.Controls.Add(this.radioButtonLive);
            this.panel17.Location = new System.Drawing.Point(143, 23);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(93, 108);
            this.panel17.TabIndex = 1;
            // 
            // radioButtonTest
            // 
            this.radioButtonTest.AutoSize = true;
            this.radioButtonTest.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTest.Location = new System.Drawing.Point(17, 42);
            this.radioButtonTest.Name = "radioButtonTest";
            this.radioButtonTest.Size = new System.Drawing.Size(45, 19);
            this.radioButtonTest.TabIndex = 1;
            this.radioButtonTest.Text = "Test";
            this.radioButtonTest.UseVisualStyleBackColor = true;
            this.radioButtonTest.CheckedChanged += new System.EventHandler(this.siteType);
            // 
            // radioButtonLive
            // 
            this.radioButtonLive.AutoSize = true;
            this.radioButtonLive.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLive.Location = new System.Drawing.Point(16, 17);
            this.radioButtonLive.Name = "radioButtonLive";
            this.radioButtonLive.Size = new System.Drawing.Size(46, 19);
            this.radioButtonLive.TabIndex = 0;
            this.radioButtonLive.Text = "Live";
            this.radioButtonLive.UseVisualStyleBackColor = true;
            this.radioButtonLive.CheckedChanged += new System.EventHandler(this.siteType);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelInstruction);
            this.Controls.Add(this.panelTestBuy);
            this.Controls.Add(this.panelGenOS);
            this.Controls.Add(this.panelCheckBH);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.EBTestTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easybook Test Automation";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelCheckBH.ResumeLayout(false);
            this.panelCheckBH.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelGenOS.ResumeLayout(false);
            this.panelGenOS.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelInstruction.ResumeLayout(false);
            this.panelTestBuy.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EBTestTitle;
        private System.Windows.Forms.Button IPServerButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButtonBHTest;
        private System.Windows.Forms.RadioButton radioButtonBHLive;
        private System.Windows.Forms.Panel panelCheckBH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button GenOSButton;
        private System.Windows.Forms.Button CheckBHButton;
        private System.Windows.Forms.Button TestBuyButton;
        private System.Windows.Forms.Button InstructionButton;
        private System.Windows.Forms.Button EditXMLButton;
        private System.Windows.Forms.Panel panelGenOS;
        private System.Windows.Forms.TextBox OrderNo_textBox;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton radioButtonCarBH;
        private System.Windows.Forms.RadioButton radioButtonTrainBH;
        private System.Windows.Forms.RadioButton radioButtonFerryBH;
        private System.Windows.Forms.RadioButton radioButtonBusBH;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioButtonNoServerBH;
        private System.Windows.Forms.RadioButton radioButtonS2BH;
        private System.Windows.Forms.RadioButton radioButtonS1BH;
        private System.Windows.Forms.Button RunGenOSButton;
        private System.Windows.Forms.TextBox OS_textField;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton radioButtonTestOS;
        private System.Windows.Forms.RadioButton radioButtonLiveOS;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton GenOSWriteExcel;
        private System.Windows.Forms.RadioButton GenOS;
        private System.Windows.Forms.Panel panelInstruction;
        private System.Windows.Forms.Panel panelTestBuy;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.RadioButton radioButtonCar;
        private System.Windows.Forms.RadioButton radioButtonTrain;
        private System.Windows.Forms.RadioButton radioButtonFerry;
        private System.Windows.Forms.RadioButton radioButtonBus;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.RadioButton radioButtonNoServer;
        private System.Windows.Forms.RadioButton radioButtonS2;
        private System.Windows.Forms.RadioButton radioButtonS1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.RadioButton radioButtonSGD;
        private System.Windows.Forms.RadioButton radioButtonMYR;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.RadioButton radioButtonTest;
        private System.Windows.Forms.RadioButton radioButtonLive;
        private System.Windows.Forms.DateTimePicker dateTimePickerBH;
        private System.Windows.Forms.RichTextBox richTextBoxInstruction;
        private System.Windows.Forms.Button buttonLogOut;
    }
}

