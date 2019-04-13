namespace GUI_movie
{
    partial class PmCineplexForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.rdocredit = new System.Windows.Forms.RadioButton();
            this.rdocash = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txttickets = new System.Windows.Forms.TextBox();
            this.rdoyes = new System.Windows.Forms.RadioButton();
            this.rdono = new System.Windows.Forms.RadioButton();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnrevenue = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.GroupBox();
            this.rdoarthur = new System.Windows.Forms.RadioButton();
            this.rdothor = new System.Windows.Forms.RadioButton();
            this.rdopriest = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.paymentBox = new System.Windows.Forms.GroupBox();
            this.passionBox = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.rdo1pm = new System.Windows.Forms.RadioButton();
            this.rdo4pm = new System.Windows.Forms.RadioButton();
            this.rdo7pm = new System.Windows.Forms.RadioButton();
            this.rdo930pm = new System.Windows.Forms.RadioButton();
            this.timeBox = new System.Windows.Forms.GroupBox();
            this.lblTP = new System.Windows.Forms.Label();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.weekDayEndBox = new System.Windows.Forms.GroupBox();
            this.rdoend = new System.Windows.Forms.RadioButton();
            this.rdoday = new System.Windows.Forms.RadioButton();
            this.rtbdisplay = new System.Windows.Forms.RichTextBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.titleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.paymentBox.SuspendLayout();
            this.passionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.timeBox.SuspendLayout();
            this.weekDayEndBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // rdocredit
            // 
            this.rdocredit.AutoSize = true;
            this.rdocredit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdocredit.Location = new System.Drawing.Point(153, 32);
            this.rdocredit.Name = "rdocredit";
            this.rdocredit.Size = new System.Drawing.Size(116, 23);
            this.rdocredit.TabIndex = 7;
            this.rdocredit.TabStop = true;
            this.rdocredit.Text = "Credit Card";
            this.rdocredit.UseVisualStyleBackColor = true;
            this.rdocredit.CheckedChanged += new System.EventHandler(this.rdocredit_CheckedChanged);
            // 
            // rdocash
            // 
            this.rdocash.AutoSize = true;
            this.rdocash.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdocash.Location = new System.Drawing.Point(23, 32);
            this.rdocash.Name = "rdocash";
            this.rdocash.Size = new System.Drawing.Size(64, 23);
            this.rdocash.TabIndex = 8;
            this.rdocash.TabStop = true;
            this.rdocash.Text = "Cash";
            this.rdocash.UseVisualStyleBackColor = true;
            this.rdocash.CheckedChanged += new System.EventHandler(this.rdocash_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "No of tickets:";
            // 
            // txttickets
            // 
            this.txttickets.Location = new System.Drawing.Point(168, 554);
            this.txttickets.MaxLength = 2;
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(102, 20);
            this.txttickets.TabIndex = 12;
            this.txttickets.TextChanged += new System.EventHandler(this.txttickets_TextChanged);
            // 
            // rdoyes
            // 
            this.rdoyes.AutoSize = true;
            this.rdoyes.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoyes.Location = new System.Drawing.Point(32, 39);
            this.rdoyes.Name = "rdoyes";
            this.rdoyes.Size = new System.Drawing.Size(53, 23);
            this.rdoyes.TabIndex = 16;
            this.rdoyes.TabStop = true;
            this.rdoyes.Text = "Yes";
            this.rdoyes.UseVisualStyleBackColor = true;
            this.rdoyes.CheckedChanged += new System.EventHandler(this.rdoyes_CheckedChanged);
            // 
            // rdono
            // 
            this.rdono.AutoSize = true;
            this.rdono.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdono.Location = new System.Drawing.Point(153, 39);
            this.rdono.Name = "rdono";
            this.rdono.Size = new System.Drawing.Size(48, 23);
            this.rdono.TabIndex = 17;
            this.rdono.TabStop = true;
            this.rdono.Text = "No";
            this.rdono.UseVisualStyleBackColor = true;
            this.rdono.CheckedChanged += new System.EventHandler(this.rdono_CheckedChanged);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.Location = new System.Drawing.Point(12, 612);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(149, 47);
            this.btnconfirm.TabIndex = 18;
            this.btnconfirm.Text = "&Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(621, 611);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(142, 48);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnrevenue
            // 
            this.btnrevenue.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrevenue.Location = new System.Drawing.Point(187, 612);
            this.btnrevenue.Name = "btnrevenue";
            this.btnrevenue.Size = new System.Drawing.Size(149, 47);
            this.btnrevenue.TabIndex = 20;
            this.btnrevenue.Text = "&Revenue";
            this.btnrevenue.UseVisualStyleBackColor = true;
            this.btnrevenue.Click += new System.EventHandler(this.btnrevenue_Click);
            // 
            // titleBox
            // 
            this.titleBox.Controls.Add(this.rdoarthur);
            this.titleBox.Controls.Add(this.rdothor);
            this.titleBox.Controls.Add(this.rdopriest);
            this.titleBox.Controls.Add(this.pictureBox4);
            this.titleBox.Controls.Add(this.pictureBox2);
            this.titleBox.Controls.Add(this.pictureBox3);
            this.titleBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(368, 56);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(507, 215);
            this.titleBox.TabIndex = 21;
            this.titleBox.TabStop = false;
            this.titleBox.Text = "Title";
            this.titleBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoarthur
            // 
            this.rdoarthur.AutoSize = true;
            this.rdoarthur.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoarthur.Location = new System.Drawing.Point(383, 184);
            this.rdoarthur.Name = "rdoarthur";
            this.rdoarthur.Size = new System.Drawing.Size(75, 23);
            this.rdoarthur.TabIndex = 31;
            this.rdoarthur.TabStop = true;
            this.rdoarthur.Text = "Arthur";
            this.rdoarthur.UseVisualStyleBackColor = true;
            this.rdoarthur.CheckedChanged += new System.EventHandler(this.rdoarthur_CheckedChanged);
            // 
            // rdothor
            // 
            this.rdothor.AutoSize = true;
            this.rdothor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdothor.Location = new System.Drawing.Point(58, 184);
            this.rdothor.Name = "rdothor";
            this.rdothor.Size = new System.Drawing.Size(61, 23);
            this.rdothor.TabIndex = 30;
            this.rdothor.TabStop = true;
            this.rdothor.Text = "Thor";
            this.rdothor.UseVisualStyleBackColor = true;
            this.rdothor.CheckedChanged += new System.EventHandler(this.rdothor_CheckedChanged);
            // 
            // rdopriest
            // 
            this.rdopriest.AutoSize = true;
            this.rdopriest.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdopriest.Location = new System.Drawing.Point(224, 184);
            this.rdopriest.Name = "rdopriest";
            this.rdopriest.Size = new System.Drawing.Size(68, 23);
            this.rdopriest.TabIndex = 29;
            this.rdopriest.TabStop = true;
            this.rdopriest.Text = "Priest";
            this.rdopriest.UseVisualStyleBackColor = true;
            this.rdopriest.CheckedChanged += new System.EventHandler(this.rdopriest_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::GUI_movie.Properties.Resources.images__2_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(21, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 137);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GUI_movie.Properties.Resources.images;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(355, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 142);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::GUI_movie.Properties.Resources.images__1_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(186, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 137);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // paymentBox
            // 
            this.paymentBox.Controls.Add(this.rdocash);
            this.paymentBox.Controls.Add(this.rdocredit);
            this.paymentBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBox.Location = new System.Drawing.Point(34, 233);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(280, 72);
            this.paymentBox.TabIndex = 22;
            this.paymentBox.TabStop = false;
            this.paymentBox.Text = "Payment Mode";
            // 
            // passionBox
            // 
            this.passionBox.Controls.Add(this.rdono);
            this.passionBox.Controls.Add(this.rdoyes);
            this.passionBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passionBox.Location = new System.Drawing.Point(34, 320);
            this.passionBox.Name = "passionBox";
            this.passionBox.Size = new System.Drawing.Size(280, 92);
            this.passionBox.TabIndex = 23;
            this.passionBox.TabStop = false;
            this.passionBox.Text = "Passion Card";
            this.passionBox.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(780, 611);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(129, 48);
            this.btnexit.TabIndex = 24;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImage = global::GUI_movie.Properties.Resources.our_logo;
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoBox.Location = new System.Drawing.Point(139, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(212, 206);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.logoBox_Click);
            // 
            // rdo1pm
            // 
            this.rdo1pm.AutoSize = true;
            this.rdo1pm.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo1pm.Location = new System.Drawing.Point(39, 25);
            this.rdo1pm.Name = "rdo1pm";
            this.rdo1pm.Size = new System.Drawing.Size(60, 23);
            this.rdo1pm.TabIndex = 26;
            this.rdo1pm.TabStop = true;
            this.rdo1pm.Text = "1pm";
            this.rdo1pm.UseVisualStyleBackColor = true;
            this.rdo1pm.CheckedChanged += new System.EventHandler(this.rdo1pm_CheckedChanged);
            // 
            // rdo4pm
            // 
            this.rdo4pm.AutoSize = true;
            this.rdo4pm.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo4pm.Location = new System.Drawing.Point(128, 25);
            this.rdo4pm.Name = "rdo4pm";
            this.rdo4pm.Size = new System.Drawing.Size(60, 23);
            this.rdo4pm.TabIndex = 27;
            this.rdo4pm.TabStop = true;
            this.rdo4pm.Text = "4pm";
            this.rdo4pm.UseVisualStyleBackColor = true;
            this.rdo4pm.CheckedChanged += new System.EventHandler(this.rdo4pm_CheckedChanged);
            // 
            // rdo7pm
            // 
            this.rdo7pm.AutoSize = true;
            this.rdo7pm.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo7pm.Location = new System.Drawing.Point(214, 25);
            this.rdo7pm.Name = "rdo7pm";
            this.rdo7pm.Size = new System.Drawing.Size(60, 23);
            this.rdo7pm.TabIndex = 28;
            this.rdo7pm.TabStop = true;
            this.rdo7pm.Text = "7pm";
            this.rdo7pm.UseVisualStyleBackColor = true;
            this.rdo7pm.CheckedChanged += new System.EventHandler(this.rdo7pm_CheckedChanged);
            // 
            // rdo930pm
            // 
            this.rdo930pm.AutoSize = true;
            this.rdo930pm.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo930pm.Location = new System.Drawing.Point(305, 25);
            this.rdo930pm.Name = "rdo930pm";
            this.rdo930pm.Size = new System.Drawing.Size(83, 23);
            this.rdo930pm.TabIndex = 29;
            this.rdo930pm.TabStop = true;
            this.rdo930pm.Text = "9.30pm";
            this.rdo930pm.UseVisualStyleBackColor = true;
            this.rdo930pm.CheckedChanged += new System.EventHandler(this.rdo930pm_CheckedChanged);
            // 
            // timeBox
            // 
            this.timeBox.Controls.Add(this.rdo930pm);
            this.timeBox.Controls.Add(this.rdo7pm);
            this.timeBox.Controls.Add(this.rdo4pm);
            this.timeBox.Controls.Add(this.rdo1pm);
            this.timeBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.Location = new System.Drawing.Point(471, 288);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(407, 56);
            this.timeBox.TabIndex = 30;
            this.timeBox.TabStop = false;
            this.timeBox.Text = "Time";
            this.timeBox.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTP.Location = new System.Drawing.Point(376, 575);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(102, 19);
            this.lblTP.TabIndex = 31;
            this.lblTP.Text = "Total Price:";
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotalprice.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.Location = new System.Drawing.Point(484, 570);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(121, 34);
            this.lbltotalprice.TabIndex = 32;
            this.lbltotalprice.Click += new System.EventHandler(this.lbltotalprice_Click);
            // 
            // weekDayEndBox
            // 
            this.weekDayEndBox.Controls.Add(this.rdoend);
            this.weekDayEndBox.Controls.Add(this.rdoday);
            this.weekDayEndBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekDayEndBox.Location = new System.Drawing.Point(34, 445);
            this.weekDayEndBox.Name = "weekDayEndBox";
            this.weekDayEndBox.Size = new System.Drawing.Size(274, 62);
            this.weekDayEndBox.TabIndex = 33;
            this.weekDayEndBox.TabStop = false;
            this.weekDayEndBox.Text = "Weekday/Weekend";
            // 
            // rdoend
            // 
            this.rdoend.AutoSize = true;
            this.rdoend.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoend.Location = new System.Drawing.Point(164, 25);
            this.rdoend.Name = "rdoend";
            this.rdoend.Size = new System.Drawing.Size(98, 23);
            this.rdoend.TabIndex = 1;
            this.rdoend.TabStop = true;
            this.rdoend.Text = "Weekend";
            this.rdoend.UseVisualStyleBackColor = true;
            this.rdoend.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoday
            // 
            this.rdoday.AutoSize = true;
            this.rdoday.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoday.Location = new System.Drawing.Point(21, 25);
            this.rdoday.Name = "rdoday";
            this.rdoday.Size = new System.Drawing.Size(98, 23);
            this.rdoday.TabIndex = 0;
            this.rdoday.TabStop = true;
            this.rdoday.Text = "Weekday";
            this.rdoday.UseVisualStyleBackColor = true;
            this.rdoday.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rtbdisplay
            // 
            this.rtbdisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbdisplay.Location = new System.Drawing.Point(334, 381);
            this.rtbdisplay.Name = "rtbdisplay";
            this.rtbdisplay.Size = new System.Drawing.Size(575, 177);
            this.rtbdisplay.TabIndex = 34;
            this.rtbdisplay.Text = "";
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(550, 359);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(77, 19);
            this.lblRevenue.TabIndex = 35;
            this.lblRevenue.Text = "Revenue";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(472, 359);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 19);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "Total";
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSlot.Location = new System.Drawing.Point(387, 359);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(87, 19);
            this.lblTimeSlot.TabIndex = 37;
            this.lblTimeSlot.Text = "Time-Slot";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.Location = new System.Drawing.Point(330, 359);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(59, 19);
            this.lblMovie.TabIndex = 38;
            this.lblMovie.Text = "Movie";
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(12, 19);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(118, 30);
            this.btnRead.TabIndex = 40;
            this.btnRead.Text = "&To ReadForm";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 26);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.Value = new System.DateTime(2011, 7, 4, 1, 23, 57, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(633, 359);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 19);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(796, 359);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 19);
            this.lblTime.TabIndex = 35;
            this.lblTime.Text = "Time";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker2.Location = new System.Drawing.Point(747, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 26);
            this.dateTimePicker2.TabIndex = 42;
            // 
            // PmCineplexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 679);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.lblTimeSlot);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.rtbdisplay);
            this.Controls.Add(this.weekDayEndBox);
            this.Controls.Add(this.lbltotalprice);
            this.Controls.Add(this.lblTP);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.paymentBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.btnrevenue);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.txttickets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.passionBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "PmCineplexForm";
            this.Text = "PM Moving Ticketing System  ";
            this.Load += new System.EventHandler(this.PmCineplexForm_Load);
            this.titleBox.ResumeLayout(false);
            this.titleBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.paymentBox.ResumeLayout(false);
            this.paymentBox.PerformLayout();
            this.passionBox.ResumeLayout(false);
            this.passionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.timeBox.ResumeLayout(false);
            this.timeBox.PerformLayout();
            this.weekDayEndBox.ResumeLayout(false);
            this.weekDayEndBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdocredit;
        private System.Windows.Forms.RadioButton rdocash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.RadioButton rdoyes;
        private System.Windows.Forms.RadioButton rdono;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnrevenue;
        private System.Windows.Forms.GroupBox titleBox;
        private System.Windows.Forms.GroupBox paymentBox;
        private System.Windows.Forms.GroupBox passionBox;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton rdoarthur;
        private System.Windows.Forms.RadioButton rdothor;
        private System.Windows.Forms.RadioButton rdopriest;
        private System.Windows.Forms.RadioButton rdo1pm;
        private System.Windows.Forms.RadioButton rdo4pm;
        private System.Windows.Forms.RadioButton rdo7pm;
        private System.Windows.Forms.RadioButton rdo930pm;
        private System.Windows.Forms.GroupBox timeBox;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.GroupBox weekDayEndBox;
        private System.Windows.Forms.RadioButton rdoend;
        private System.Windows.Forms.RadioButton rdoday;
        private System.Windows.Forms.RichTextBox rtbdisplay;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

