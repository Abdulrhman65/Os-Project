namespace OsProject
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PathBox = new TextBox();
            PathLable = new Label();
            BrowseButton = new Button();
            QuickAccess = new Panel();
            LocalDiscCLabel = new Label();
            VideosLabel = new Label();
            DocumentsLabel = new Label();
            PicturesLabel = new Label();
            MusicLabel = new Label();
            ThisPCLabel = new Label();
            QuickAccessLable = new Label();
            panel2 = new Panel();
            ModifiedLable = new Label();
            label25 = new Label();
            CreatedLable = new Label();
            label24 = new Label();
            SizeLable = new Label();
            label22 = new Label();
            ExtensionLable = new Label();
            lable23 = new Label();
            FilePathLable = new Label();
            label21 = new Label();
            FileNameLable = new Label();
            Label = new Label();
            FileDetailsLabel = new Label();
            label6 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            ModifiedDate = new DataGridViewTextBoxColumn();
            FilesFoldersLable = new Label();
            panel4 = new Panel();
            panel7 = new Panel();
            LogBox = new RichTextBox();
            label5 = new Label();
            button10 = new Button();
            label3 = new Label();
            panel5 = new Panel();
            getInfobtn = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            deletebtn = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel6 = new Panel();
            Per = new Label();
            CurrentThread = new Label();
            CurrentOp = new Label();
            progressBar = new ProgressBar();
            label4 = new Label();
            textBox1 = new TextBox();
            Searchlabel = new Label();
            panel8 = new Panel();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label14 = new Label();
            DiskSpaceLabel = new Label();
            label11 = new Label();
            OpenedLabel = new Label();
            label12 = new Label();
            label13 = new Label();
            DeletedLabel = new Label();
            label9 = new Label();
            label10 = new Label();
            CreatedLabel = new Label();
            label8 = new Label();
            label7 = new Label();
            OperationsCountLabel = new Label();
            QuickAccess.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // PathBox
            // 
            PathBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PathBox.BackColor = Color.White;
            PathBox.BorderStyle = BorderStyle.FixedSingle;
            PathBox.Font = new Font("Segoe UI", 11.5F);
            PathBox.ForeColor = Color.FromArgb(15, 23, 42);
            PathBox.Location = new Point(66, 12);
            PathBox.Name = "PathBox";
            PathBox.Size = new Size(780, 28);
            PathBox.TabIndex = 0;
            // 
            // PathLable
            // 
            PathLable.AutoSize = true;
            PathLable.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            PathLable.ForeColor = Color.FromArgb(30, 41, 59);
            PathLable.Location = new Point(14, 15);
            PathLable.Name = "PathLable";
            PathLable.Size = new Size(45, 20);
            PathLable.TabIndex = 1;
            PathLable.Text = "Path:";
            // 
            // BrowseButton
            // 
            BrowseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BrowseButton.BackColor = Color.FromArgb(191, 219, 254);
            BrowseButton.Cursor = Cursors.Hand;
            BrowseButton.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            BrowseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 197, 253);
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BrowseButton.ForeColor = Color.FromArgb(15, 23, 42);
            BrowseButton.Location = new Point(854, 12);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(88, 30);
            BrowseButton.TabIndex = 2;
            BrowseButton.Text = "Browse..";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // QuickAccess
            // 
            QuickAccess.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            QuickAccess.BackColor = Color.White;
            QuickAccess.BorderStyle = BorderStyle.FixedSingle;
            QuickAccess.Controls.Add(LocalDiscCLabel);
            QuickAccess.Controls.Add(VideosLabel);
            QuickAccess.Controls.Add(DocumentsLabel);
            QuickAccess.Controls.Add(PicturesLabel);
            QuickAccess.Controls.Add(MusicLabel);
            QuickAccess.Controls.Add(ThisPCLabel);
            QuickAccess.Controls.Add(QuickAccessLable);
            QuickAccess.Location = new Point(12, 52);
            QuickAccess.Name = "QuickAccess";
            QuickAccess.Size = new Size(224, 382);
            QuickAccess.TabIndex = 3;
            // 
            // LocalDiscCLabel
            // 
            LocalDiscCLabel.AutoEllipsis = true;
            LocalDiscCLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            LocalDiscCLabel.ForeColor = Color.FromArgb(30, 41, 59);
            LocalDiscCLabel.Location = new Point(14, 284);
            LocalDiscCLabel.Name = "LocalDiscCLabel";
            LocalDiscCLabel.Size = new Size(196, 38);
            LocalDiscCLabel.TabIndex = 11;
            LocalDiscCLabel.Text = "💾 Local Disk (C:)";
            LocalDiscCLabel.TextAlign = ContentAlignment.MiddleLeft;
            LocalDiscCLabel.Click += LocalDiscCLabel_Click;
            // 
            // VideosLabel
            // 
            VideosLabel.AutoEllipsis = true;
            VideosLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            VideosLabel.ForeColor = Color.FromArgb(30, 41, 59);
            VideosLabel.Location = new Point(14, 238);
            VideosLabel.Name = "VideosLabel";
            VideosLabel.Size = new Size(196, 38);
            VideosLabel.TabIndex = 10;
            VideosLabel.Text = "🎬 Videos";
            VideosLabel.TextAlign = ContentAlignment.MiddleLeft;
            VideosLabel.Click += VideosLabel_Click;
            // 
            // DocumentsLabel
            // 
            DocumentsLabel.AutoEllipsis = true;
            DocumentsLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            DocumentsLabel.ForeColor = Color.FromArgb(30, 41, 59);
            DocumentsLabel.Location = new Point(14, 100);
            DocumentsLabel.Name = "DocumentsLabel";
            DocumentsLabel.Size = new Size(196, 38);
            DocumentsLabel.TabIndex = 9;
            DocumentsLabel.Text = "📄 Documents";
            DocumentsLabel.TextAlign = ContentAlignment.MiddleLeft;
            DocumentsLabel.Click += DocumentsLabel_Click;
            // 
            // PicturesLabel
            // 
            PicturesLabel.AutoEllipsis = true;
            PicturesLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            PicturesLabel.ForeColor = Color.FromArgb(30, 41, 59);
            PicturesLabel.Location = new Point(14, 146);
            PicturesLabel.Name = "PicturesLabel";
            PicturesLabel.Size = new Size(196, 38);
            PicturesLabel.TabIndex = 8;
            PicturesLabel.Text = "🖼️ Pictures";
            PicturesLabel.TextAlign = ContentAlignment.MiddleLeft;
            PicturesLabel.Click += PicturesLabel_Click;
            // 
            // MusicLabel
            // 
            MusicLabel.AutoEllipsis = true;
            MusicLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            MusicLabel.ForeColor = Color.FromArgb(30, 41, 59);
            MusicLabel.Location = new Point(14, 192);
            MusicLabel.Name = "MusicLabel";
            MusicLabel.Size = new Size(196, 38);
            MusicLabel.TabIndex = 7;
            MusicLabel.Text = "🎵 Music";
            MusicLabel.TextAlign = ContentAlignment.MiddleLeft;
            MusicLabel.Click += MusicLabel_Click;
            // 
            // ThisPCLabel
            // 
            ThisPCLabel.AutoEllipsis = true;
            ThisPCLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            ThisPCLabel.ForeColor = Color.FromArgb(30, 41, 59);
            ThisPCLabel.Location = new Point(14, 54);
            ThisPCLabel.Name = "ThisPCLabel";
            ThisPCLabel.Size = new Size(196, 38);
            ThisPCLabel.TabIndex = 5;
            ThisPCLabel.Text = "🖥️ This PC";
            ThisPCLabel.TextAlign = ContentAlignment.MiddleLeft;
            ThisPCLabel.Click += ThisPCLabel_Click;
            // 
            // QuickAccessLable
            // 
            QuickAccessLable.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            QuickAccessLable.ForeColor = Color.FromArgb(15, 23, 42);
            QuickAccessLable.Location = new Point(14, 10);
            QuickAccessLable.Name = "QuickAccessLable";
            QuickAccessLable.Size = new Size(196, 30);
            QuickAccessLable.TabIndex = 2;
            QuickAccessLable.Text = "Quick Access";
            QuickAccessLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ModifiedLable);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(CreatedLable);
            panel2.Controls.Add(label24);
            panel2.Controls.Add(SizeLable);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(ExtensionLable);
            panel2.Controls.Add(lable23);
            panel2.Controls.Add(FilePathLable);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(FileNameLable);
            panel2.Controls.Add(Label);
            panel2.Controls.Add(FileDetailsLabel);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 444);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 214);
            panel2.TabIndex = 4;
            // 
            // ModifiedLable
            // 
            ModifiedLable.AutoEllipsis = true;
            ModifiedLable.Font = new Font("Segoe UI", 10.5F);
            ModifiedLable.ForeColor = Color.FromArgb(15, 23, 42);
            ModifiedLable.Location = new Point(112, 177);
            ModifiedLable.Name = "ModifiedLable";
            ModifiedLable.Size = new Size(264, 25);
            ModifiedLable.TabIndex = 27;
            ModifiedLable.Text = "-";
            ModifiedLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label25.ForeColor = Color.FromArgb(100, 116, 139);
            label25.Location = new Point(14, 177);
            label25.Name = "label25";
            label25.Size = new Size(94, 25);
            label25.TabIndex = 26;
            label25.Text = "Modified:";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CreatedLable
            // 
            CreatedLable.AutoEllipsis = true;
            CreatedLable.Font = new Font("Segoe UI", 10.5F);
            CreatedLable.ForeColor = Color.FromArgb(15, 23, 42);
            CreatedLable.Location = new Point(112, 150);
            CreatedLable.Name = "CreatedLable";
            CreatedLable.Size = new Size(264, 25);
            CreatedLable.TabIndex = 25;
            CreatedLable.Text = "-";
            CreatedLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label24.ForeColor = Color.FromArgb(100, 116, 139);
            label24.Location = new Point(14, 150);
            label24.Name = "label24";
            label24.Size = new Size(94, 25);
            label24.TabIndex = 24;
            label24.Text = "Created:";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SizeLable
            // 
            SizeLable.AutoEllipsis = true;
            SizeLable.Font = new Font("Segoe UI", 10.5F);
            SizeLable.ForeColor = Color.FromArgb(15, 23, 42);
            SizeLable.Location = new Point(112, 123);
            SizeLable.Name = "SizeLable";
            SizeLable.Size = new Size(264, 25);
            SizeLable.TabIndex = 21;
            SizeLable.Text = "-";
            SizeLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label22.ForeColor = Color.FromArgb(100, 116, 139);
            label22.Location = new Point(14, 123);
            label22.Name = "label22";
            label22.Size = new Size(94, 25);
            label22.TabIndex = 20;
            label22.Text = "Size:";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ExtensionLable
            // 
            ExtensionLable.AutoEllipsis = true;
            ExtensionLable.Font = new Font("Segoe UI", 10.5F);
            ExtensionLable.ForeColor = Color.FromArgb(15, 23, 42);
            ExtensionLable.Location = new Point(112, 96);
            ExtensionLable.Name = "ExtensionLable";
            ExtensionLable.Size = new Size(264, 25);
            ExtensionLable.TabIndex = 19;
            ExtensionLable.Text = "-";
            ExtensionLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lable23
            // 
            lable23.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lable23.ForeColor = Color.FromArgb(100, 116, 139);
            lable23.Location = new Point(14, 96);
            lable23.Name = "lable23";
            lable23.Size = new Size(94, 25);
            lable23.TabIndex = 18;
            lable23.Text = "Extension:";
            lable23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FilePathLable
            // 
            FilePathLable.AutoEllipsis = true;
            FilePathLable.Font = new Font("Segoe UI", 10.5F);
            FilePathLable.ForeColor = Color.FromArgb(15, 23, 42);
            FilePathLable.Location = new Point(112, 69);
            FilePathLable.Name = "FilePathLable";
            FilePathLable.Size = new Size(264, 25);
            FilePathLable.TabIndex = 17;
            FilePathLable.Text = "-";
            FilePathLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            label21.ForeColor = Color.FromArgb(100, 116, 139);
            label21.Location = new Point(14, 69);
            label21.Name = "label21";
            label21.Size = new Size(94, 25);
            label21.TabIndex = 16;
            label21.Text = "File Path:";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FileNameLable
            // 
            FileNameLable.AutoEllipsis = true;
            FileNameLable.Font = new Font("Segoe UI", 10.5F);
            FileNameLable.ForeColor = Color.FromArgb(15, 23, 42);
            FileNameLable.Location = new Point(112, 42);
            FileNameLable.Name = "FileNameLable";
            FileNameLable.Size = new Size(264, 25);
            FileNameLable.TabIndex = 15;
            FileNameLable.Text = "-";
            FileNameLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label
            // 
            Label.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            Label.ForeColor = Color.FromArgb(100, 116, 139);
            Label.Location = new Point(14, 42);
            Label.Name = "Label";
            Label.Size = new Size(94, 25);
            Label.TabIndex = 14;
            Label.Text = "File Name:";
            Label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FileDetailsLabel
            // 
            FileDetailsLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            FileDetailsLabel.ForeColor = Color.FromArgb(15, 23, 42);
            FileDetailsLabel.Location = new Point(14, 8);
            FileDetailsLabel.Name = "FileDetailsLabel";
            FileDetailsLabel.Size = new Size(180, 28);
            FileDetailsLabel.TabIndex = 3;
            FileDetailsLabel.Text = "File Details";
            FileDetailsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 0);
            label6.TabIndex = 3;
            label6.Visible = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(FilesFoldersLable);
            panel3.Location = new Point(246, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(696, 382);
            panel3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(10, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 326);
            panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 36;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, Type, Size, ModifiedDate });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 6, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(226, 232, 240);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 28;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(672, 324);
            dataGridView1.TabIndex = 5;
            // 
            // NameColumn
            // 
            NameColumn.FillWeight = 40F;
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // Type
            // 
            Type.FillWeight = 18F;
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Size
            // 
            Size.FillWeight = 18F;
            Size.HeaderText = "Size";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            Size.ReadOnly = true;
            // 
            // ModifiedDate
            // 
            ModifiedDate.FillWeight = 24F;
            ModifiedDate.HeaderText = "Modified Date";
            ModifiedDate.MinimumWidth = 6;
            ModifiedDate.Name = "ModifiedDate";
            ModifiedDate.ReadOnly = true;
            // 
            // FilesFoldersLable
            // 
            FilesFoldersLable.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            FilesFoldersLable.ForeColor = Color.FromArgb(15, 23, 42);
            FilesFoldersLable.Location = new Point(14, 10);
            FilesFoldersLable.Name = "FilesFoldersLable";
            FilesFoldersLable.Size = new Size(240, 30);
            FilesFoldersLable.TabIndex = 4;
            FilesFoldersLable.Text = "Files And Folders";
            FilesFoldersLable.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(412, 444);
            panel4.Name = "panel4";
            panel4.Size = new Size(530, 214);
            panel4.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(248, 250, 252);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(LogBox);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(10, 42);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(6);
            panel7.Size = new Size(508, 160);
            panel7.TabIndex = 7;
            // 
            // LogBox
            // 
            LogBox.BackColor = Color.FromArgb(248, 250, 252);
            LogBox.BorderStyle = BorderStyle.None;
            LogBox.Dock = DockStyle.Fill;
            LogBox.Font = new Font("Consolas", 10F);
            LogBox.Location = new Point(6, 6);
            LogBox.Name = "LogBox";
            LogBox.ReadOnly = true;
            LogBox.Size = new Size(494, 146);
            LogBox.TabIndex = 5;
            LogBox.Text = "";
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 0);
            label5.TabIndex = 4;
            label5.Visible = false;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button10.BackColor = Color.FromArgb(191, 219, 254);
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(147, 197, 253);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button10.ForeColor = Color.FromArgb(15, 23, 42);
            button10.Location = new Point(428, 6);
            button10.Name = "button10";
            button10.Size = new Size(90, 30);
            button10.TabIndex = 5;
            button10.Text = "Clear Log";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(15, 23, 42);
            label3.Location = new Point(14, 8);
            label3.Name = "label3";
            label3.Size = new Size(200, 28);
            label3.TabIndex = 4;
            label3.Text = "Operations Log";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(getInfobtn);
            panel5.Controls.Add(button8);
            panel5.Controls.Add(button7);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(deletebtn);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(952, 52);
            panel5.Name = "panel5";
            panel5.Size = new Size(316, 382);
            panel5.TabIndex = 7;
            // 
            // getInfobtn
            // 
            getInfobtn.BackColor = Color.FromArgb(147, 197, 253);
            getInfobtn.Cursor = Cursors.Hand;
            getInfobtn.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);
            getInfobtn.FlatAppearance.BorderSize = 2;
            getInfobtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 165, 250);
            getInfobtn.FlatStyle = FlatStyle.Flat;
            getInfobtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            getInfobtn.ForeColor = Color.FromArgb(15, 23, 42);
            getInfobtn.Location = new Point(12, 304);
            getInfobtn.Name = "getInfobtn";
            getInfobtn.Size = new Size(290, 48);
            getInfobtn.TabIndex = 12;
            getInfobtn.Text = "Get Drive Info";
            getInfobtn.UseVisualStyleBackColor = false;
            getInfobtn.Click += getInfobtn_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(103, 232, 249);
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = Color.FromArgb(8, 145, 178);
            button8.FlatAppearance.BorderSize = 2;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 211, 238);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button8.ForeColor = Color.FromArgb(15, 23, 42);
            button8.Location = new Point(12, 234);
            button8.Name = "button8";
            button8.Size = new Size(142, 54);
            button8.TabIndex = 11;
            button8.Text = "📂 Open";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(253, 186, 116);
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = Color.FromArgb(234, 88, 12);
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 146, 60);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(15, 23, 42);
            button7.Location = new Point(12, 172);
            button7.Name = "button7";
            button7.Size = new Size(142, 54);
            button7.TabIndex = 10;
            button7.Text = "📄 Write File";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(196, 181, 253);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.FromArgb(124, 58, 237);
            button6.FlatAppearance.BorderSize = 2;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 139, 250);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(15, 23, 42);
            button6.Location = new Point(160, 234);
            button6.Name = "button6";
            button6.Size = new Size(142, 54);
            button6.TabIndex = 9;
            button6.Text = "🔍 Search Files";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(94, 234, 212);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.FromArgb(13, 148, 136);
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 212, 191);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(15, 23, 42);
            button5.Location = new Point(160, 172);
            button5.Name = "button5";
            button5.Size = new Size(142, 54);
            button5.TabIndex = 8;
            button5.Text = "📋 Copy/Move";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(240, 171, 252);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.FromArgb(192, 38, 211);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 121, 249);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(15, 23, 42);
            button4.Location = new Point(160, 110);
            button4.Name = "button4";
            button4.Size = new Size(142, 54);
            button4.TabIndex = 7;
            button4.Text = "🗃️ Read File";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.FromArgb(252, 165, 165);
            deletebtn.Cursor = Cursors.Hand;
            deletebtn.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
            deletebtn.FlatAppearance.BorderSize = 2;
            deletebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(248, 113, 113);
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            deletebtn.ForeColor = Color.FromArgb(15, 23, 42);
            deletebtn.Location = new Point(12, 110);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(142, 54);
            deletebtn.TabIndex = 6;
            deletebtn.Text = "🗑️ Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(253, 224, 71);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(202, 138, 4);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 204, 21);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(15, 23, 42);
            button2.Location = new Point(160, 48);
            button2.Name = "button2";
            button2.Size = new Size(142, 54);
            button2.TabIndex = 4;
            button2.Text = "📁 Create Folder";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(134, 239, 172);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(22, 163, 74);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 222, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(15, 23, 42);
            button1.Location = new Point(12, 48);
            button1.Name = "button1";
            button1.Size = new Size(142, 54);
            button1.TabIndex = 3;
            button1.Text = "➕ Create File";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(15, 23, 42);
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 5;
            label1.Text = "Operations";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(Per);
            panel6.Controls.Add(CurrentThread);
            panel6.Controls.Add(CurrentOp);
            panel6.Controls.Add(progressBar);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(952, 444);
            panel6.Name = "panel6";
            panel6.Size = new Size(316, 214);
            panel6.TabIndex = 8;
            // 
            // Per
            // 
            Per.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            Per.ForeColor = Color.FromArgb(15, 23, 42);
            Per.Location = new Point(14, 92);
            Per.Name = "Per";
            Per.Size = new Size(50, 26);
            Per.TabIndex = 18;
            Per.Text = "0%";
            Per.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CurrentThread
            // 
            CurrentThread.AutoEllipsis = true;
            CurrentThread.Font = new Font("Segoe UI", 10.5F);
            CurrentThread.ForeColor = Color.FromArgb(71, 85, 105);
            CurrentThread.Location = new Point(14, 140);
            CurrentThread.Name = "CurrentThread";
            CurrentThread.Size = new Size(288, 28);
            CurrentThread.TabIndex = 17;
            CurrentThread.Text = "Running in: -";
            CurrentThread.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CurrentOp
            // 
            CurrentOp.AutoEllipsis = true;
            CurrentOp.Font = new Font("Segoe UI", 10.5F);
            CurrentOp.ForeColor = Color.FromArgb(15, 23, 42);
            CurrentOp.Location = new Point(14, 50);
            CurrentOp.Name = "CurrentOp";
            CurrentOp.Size = new Size(288, 28);
            CurrentOp.TabIndex = 16;
            CurrentOp.Text = "op";
            CurrentOp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(68, 92);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(234, 26);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 6;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(15, 23, 42);
            label4.Location = new Point(14, 8);
            label4.Name = "label4";
            label4.Size = new Size(220, 28);
            label4.TabIndex = 5;
            label4.Text = "Current Operation";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 11.5F);
            textBox1.ForeColor = Color.FromArgb(15, 23, 42);
            textBox1.Location = new Point(952, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Search Files...";
            textBox1.Size = new Size(284, 28);
            textBox1.TabIndex = 9;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // Searchlabel
            // 
            Searchlabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Searchlabel.BackColor = Color.Transparent;
            Searchlabel.Font = new Font("Segoe UI", 11.5F);
            Searchlabel.Location = new Point(1240, 14);
            Searchlabel.Name = "Searchlabel";
            Searchlabel.Size = new Size(28, 26);
            Searchlabel.TabIndex = 0;
            Searchlabel.Text = "🔍";
            Searchlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(191, 214, 238);
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label17);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(label19);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(DiskSpaceLabel);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(OpenedLabel);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(label13);
            panel8.Controls.Add(DeletedLabel);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(CreatedLabel);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label7);
            panel8.Controls.Add(OperationsCountLabel);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 670);
            panel8.Name = "panel8";
            panel8.Size = new Size(1280, 40);
            panel8.TabIndex = 10;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11F);
            label17.ForeColor = Color.FromArgb(148, 163, 184);
            label17.Location = new Point(1034, 8);
            label17.Name = "label17";
            label17.Size = new Size(13, 20);
            label17.TabIndex = 19;
            label17.Text = "|";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(30, 41, 59);
            label18.Location = new Point(768, 10);
            label18.Name = "label18";
            label18.Size = new Size(231, 19);
            label18.TabIndex = 17;
            label18.Text = "🔒 Synchronization: Using Mutex";
            // 
            // label19
            // 
            label19.Location = new Point(0, 0);
            label19.Name = "label19";
            label19.Size = new Size(0, 0);
            label19.TabIndex = 18;
            label19.Visible = false;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(30, 41, 59);
            label14.Location = new Point(1052, 10);
            label14.Name = "label14";
            label14.Size = new Size(109, 19);
            label14.TabIndex = 15;
            label14.Text = "💾 Disk Space:";
            // 
            // DiskSpaceLabel
            // 
            DiskSpaceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DiskSpaceLabel.AutoSize = true;
            DiskSpaceLabel.Font = new Font("Segoe UI", 10F);
            DiskSpaceLabel.ForeColor = Color.FromArgb(15, 23, 42);
            DiskSpaceLabel.Location = new Point(1166, 10);
            DiskSpaceLabel.Name = "DiskSpaceLabel";
            DiskSpaceLabel.Size = new Size(17, 19);
            DiskSpaceLabel.TabIndex = 16;
            DiskSpaceLabel.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(30, 41, 59);
            label11.Location = new Point(464, 10);
            label11.Name = "label11";
            label11.Size = new Size(66, 19);
            label11.TabIndex = 13;
            label11.Text = "Opened:";
            // 
            // OpenedLabel
            // 
            OpenedLabel.AutoSize = true;
            OpenedLabel.Font = new Font("Segoe UI", 10F);
            OpenedLabel.ForeColor = Color.FromArgb(15, 23, 42);
            OpenedLabel.Location = new Point(536, 10);
            OpenedLabel.Name = "OpenedLabel";
            OpenedLabel.Size = new Size(17, 19);
            OpenedLabel.TabIndex = 14;
            OpenedLabel.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.ForeColor = Color.FromArgb(148, 163, 184);
            label12.Location = new Point(446, 8);
            label12.Name = "label12";
            label12.Size = new Size(13, 20);
            label12.TabIndex = 12;
            label12.Text = "|";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(30, 41, 59);
            label13.Location = new Point(338, 10);
            label13.Name = "label13";
            label13.Size = new Size(65, 19);
            label13.TabIndex = 10;
            label13.Text = "Deleted:";
            // 
            // DeletedLabel
            // 
            DeletedLabel.AutoSize = true;
            DeletedLabel.Font = new Font("Segoe UI", 10F);
            DeletedLabel.ForeColor = Color.FromArgb(15, 23, 42);
            DeletedLabel.Location = new Point(408, 10);
            DeletedLabel.Name = "DeletedLabel";
            DeletedLabel.Size = new Size(17, 19);
            DeletedLabel.TabIndex = 11;
            DeletedLabel.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.ForeColor = Color.FromArgb(148, 163, 184);
            label9.Location = new Point(320, 8);
            label9.Name = "label9";
            label9.Size = new Size(13, 20);
            label9.TabIndex = 9;
            label9.Text = "|";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(30, 41, 59);
            label10.Location = new Point(212, 10);
            label10.Name = "label10";
            label10.Size = new Size(66, 19);
            label10.TabIndex = 7;
            label10.Text = "Created:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Font = new Font("Segoe UI", 10F);
            CreatedLabel.ForeColor = Color.FromArgb(15, 23, 42);
            CreatedLabel.Location = new Point(282, 10);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(17, 19);
            CreatedLabel.TabIndex = 8;
            CreatedLabel.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.ForeColor = Color.FromArgb(148, 163, 184);
            label8.Location = new Point(194, 8);
            label8.Name = "label8";
            label8.Size = new Size(13, 20);
            label8.TabIndex = 6;
            label8.Text = "|";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(30, 41, 59);
            label7.Location = new Point(14, 10);
            label7.Name = "label7";
            label7.Size = new Size(130, 19);
            label7.TabIndex = 4;
            label7.Text = "Operations Count:";
            // 
            // OperationsCountLabel
            // 
            OperationsCountLabel.AutoSize = true;
            OperationsCountLabel.Font = new Font("Segoe UI", 10F);
            OperationsCountLabel.ForeColor = Color.FromArgb(15, 23, 42);
            OperationsCountLabel.Location = new Point(156, 10);
            OperationsCountLabel.Name = "OperationsCountLabel";
            OperationsCountLabel.Size = new Size(17, 19);
            OperationsCountLabel.TabIndex = 5;
            OperationsCountLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(215, 228, 242);
            ClientSize = new Size(1280, 710);
            Controls.Add(panel8);
            Controls.Add(Searchlabel);
            Controls.Add(textBox1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(QuickAccess);
            Controls.Add(BrowseButton);
            Controls.Add(PathLable);
            Controls.Add(PathBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1120, 660);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Explorer";
            Load += Form1_Load;
            QuickAccess.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PathBox;
        private Label PathLable;
        private Button BrowseButton;
        private Panel QuickAccess;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TextBox textBox1;
        private Label Searchlabel;
        private Label QuickAccessLable;
        private Label FileDetailsLabel;
        private Label FilesFoldersLable;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button deletebtn;
        private Button button6;
        private Button getInfobtn;
        private Button button8;
        private Button button7;
        private Panel panel7;
        private Label label5;
        private Button button10;
        private Label label3;
        private Label label4;
        private Panel panel8;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label OperationsCountLabel;
        private Label label11;
        private Label OpenedLabel;
        private Label label12;
        private Label label13;
        private Label DeletedLabel;
        private Label CreatedLabel;
        private Label label14;
        private Label DiskSpaceLabel;
        private Label CurrentOp;
        private ProgressBar progressBar;
        private Label CurrentThread;
        private Label label17;
        private Label label18;
        private Label label19;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn ModifiedDate;
        private Label ThisPCLabel;
        private Label LocalDiscCLabel;
        private Label VideosLabel;
        private Label DocumentsLabel;
        private Label PicturesLabel;
        private Label MusicLabel;
        private Label Label;
        private Label FileNameLable;
        private Label SizeLable;
        private Label label22;
        private Label ExtensionLable;
        private Label lable23;
        private Label FilePathLable;
        private Label label21;
        private Label CreatedLable;
        private Label label24;
        private Label ModifiedLable;
        private Label label25;
        private RichTextBox LogBox;
        private Label Per;
    }
}
