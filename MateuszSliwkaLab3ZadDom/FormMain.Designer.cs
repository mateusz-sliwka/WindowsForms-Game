namespace MateuszSliwkaLab1ZadDom
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timeLabel = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.startGameButton = new System.Windows.Forms.Button();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.beerTimer = new System.Windows.Forms.Timer(this.components);
            this.wineTimer = new System.Windows.Forms.Timer(this.components);
            this.champagneTimer = new System.Windows.Forms.Timer(this.components);
            this.whiskyTimer = new System.Windows.Forms.Timer(this.components);
            this.vodkaTimer = new System.Windows.Forms.Timer(this.components);
            this.homebrewTimer = new System.Windows.Forms.Timer(this.components);
            this.gameGroup = new System.Windows.Forms.GroupBox();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.gameLogGridView = new System.Windows.Forms.DataGridView();
            this.logLabel = new System.Windows.Forms.Label();
            this.deleteRowsButton = new System.Windows.Forms.Button();
            this.logInstructionLabel = new System.Windows.Forms.Label();
            this.rankGridView = new System.Windows.Forms.DataGridView();
            this.rankNameTitleLabel = new System.Windows.Forms.Label();
            this.addToRankButton = new System.Windows.Forms.Button();
            this.rankNameTextBox = new System.Windows.Forms.TextBox();
            this.rankLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTitleLabel = new System.Windows.Forms.Label();
            this.endGameLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.winePointsLabel = new System.Windows.Forms.Label();
            this.champagnePointsLabel = new System.Windows.Forms.Label();
            this.whiskyPointsLabel = new System.Windows.Forms.Label();
            this.beerPointsLabel = new System.Windows.Forms.Label();
            this.vodkaPointsLabel = new System.Windows.Forms.Label();
            this.beerLabel = new System.Windows.Forms.Label();
            this.homebrewPointsLabel = new System.Windows.Forms.Label();
            this.wineLabel = new System.Windows.Forms.Label();
            this.champagneLabel = new System.Windows.Forms.Label();
            this.whiskyLabel = new System.Windows.Forms.Label();
            this.vodkaLabel = new System.Windows.Forms.Label();
            this.homebrewLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.vodkaBox = new System.Windows.Forms.PictureBox();
            this.champagneBox = new System.Windows.Forms.PictureBox();
            this.wineBox = new System.Windows.Forms.PictureBox();
            this.beerBox = new System.Windows.Forms.PictureBox();
            this.homebrewBox = new System.Windows.Forms.PictureBox();
            this.whiskyBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.instrukcja = new System.Windows.Forms.Label();
            this.swapTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tutorialGroupBox = new System.Windows.Forms.GroupBox();
            this.gameGroup.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vodkaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.champagneBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wineBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebrewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiskyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tutorialGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeLabel.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Red;
            this.timeLabel.Location = new System.Drawing.Point(352, 16);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(138, 50);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "0:30";
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startGameButton.Location = new System.Drawing.Point(180, 594);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(187, 46);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Zacznij grać!";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.pointsLabel.Location = new System.Drawing.Point(122, 16);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(38, 43);
            this.pointsLabel.TabIndex = 11;
            this.pointsLabel.Text = "0";
            // 
            // beerTimer
            // 
            this.beerTimer.Tick += new System.EventHandler(this.beerTimer_Tick);
            // 
            // wineTimer
            // 
            this.wineTimer.Tick += new System.EventHandler(this.wineTimer_Tick);
            // 
            // champagneTimer
            // 
            this.champagneTimer.Tick += new System.EventHandler(this.champagneTimer_Tick);
            // 
            // whiskyTimer
            // 
            this.whiskyTimer.Tick += new System.EventHandler(this.whiskyTimer_Tick);
            // 
            // vodkaTimer
            // 
            this.vodkaTimer.Tick += new System.EventHandler(this.vodkaTimer_Tick);
            // 
            // homebrewTimer
            // 
            this.homebrewTimer.Tick += new System.EventHandler(this.homebrewTimer_Tick);
            // 
            // gameGroup
            // 
            this.gameGroup.Controls.Add(this.resultGroupBox);
            this.gameGroup.Controls.Add(this.drinkLabel);
            this.gameGroup.Controls.Add(this.groupBox1);
            this.gameGroup.Controls.Add(this.playAgainButton);
            this.gameGroup.Controls.Add(this.label14);
            this.gameGroup.Controls.Add(this.label13);
            this.gameGroup.Controls.Add(this.vodkaBox);
            this.gameGroup.Controls.Add(this.pointsLabel);
            this.gameGroup.Controls.Add(this.champagneBox);
            this.gameGroup.Controls.Add(this.wineBox);
            this.gameGroup.Controls.Add(this.beerBox);
            this.gameGroup.Controls.Add(this.homebrewBox);
            this.gameGroup.Controls.Add(this.whiskyBox);
            this.gameGroup.Controls.Add(this.pictureBox1);
            this.gameGroup.Controls.Add(this.timeLabel);
            this.gameGroup.Location = new System.Drawing.Point(0, 2);
            this.gameGroup.Name = "gameGroup";
            this.gameGroup.Size = new System.Drawing.Size(559, 646);
            this.gameGroup.TabIndex = 12;
            this.gameGroup.TabStop = false;
            this.gameGroup.Text = "Aktualna rozgrywka";
            this.gameGroup.Visible = false;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.gameLogGridView);
            this.resultGroupBox.Controls.Add(this.logLabel);
            this.resultGroupBox.Controls.Add(this.deleteRowsButton);
            this.resultGroupBox.Controls.Add(this.logInstructionLabel);
            this.resultGroupBox.Controls.Add(this.rankGridView);
            this.resultGroupBox.Controls.Add(this.rankNameTitleLabel);
            this.resultGroupBox.Controls.Add(this.addToRankButton);
            this.resultGroupBox.Controls.Add(this.rankNameTextBox);
            this.resultGroupBox.Controls.Add(this.rankLabel);
            this.resultGroupBox.Controls.Add(this.resultLabel);
            this.resultGroupBox.Controls.Add(this.resultTitleLabel);
            this.resultGroupBox.Controls.Add(this.endGameLabel);
            this.resultGroupBox.Location = new System.Drawing.Point(5, 0);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(544, 592);
            this.resultGroupBox.TabIndex = 16;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Podsumowanie gry";
            this.resultGroupBox.Visible = false;
            // 
            // gameLogGridView
            // 
            this.gameLogGridView.AllowUserToAddRows = false;
            this.gameLogGridView.AllowUserToDeleteRows = false;
            this.gameLogGridView.AllowUserToResizeColumns = false;
            this.gameLogGridView.AllowUserToResizeRows = false;
            this.gameLogGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gameLogGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gameLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameLogGridView.Location = new System.Drawing.Point(-5, 164);
            this.gameLogGridView.Name = "gameLogGridView";
            this.gameLogGridView.ReadOnly = true;
            this.gameLogGridView.Size = new System.Drawing.Size(551, 164);
            this.gameLogGridView.TabIndex = 15;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(224, 146);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(98, 13);
            this.logLabel.TabIndex = 14;
            this.logLabel.Text = "Przebieg twojej gry:";
            // 
            // deleteRowsButton
            // 
            this.deleteRowsButton.ForeColor = System.Drawing.Color.Red;
            this.deleteRowsButton.Location = new System.Drawing.Point(468, 468);
            this.deleteRowsButton.Name = "deleteRowsButton";
            this.deleteRowsButton.Size = new System.Drawing.Size(17, 22);
            this.deleteRowsButton.TabIndex = 13;
            this.deleteRowsButton.Text = "x";
            this.deleteRowsButton.UseVisualStyleBackColor = true;
            this.deleteRowsButton.Click += new System.EventHandler(this.deleteRowsButton_Click);
            // 
            // logInstructionLabel
            // 
            this.logInstructionLabel.AutoSize = true;
            this.logInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logInstructionLabel.Location = new System.Drawing.Point(76, 493);
            this.logInstructionLabel.Name = "logInstructionLabel";
            this.logInstructionLabel.Size = new System.Drawing.Size(429, 24);
            this.logInstructionLabel.TabIndex = 12;
            this.logInstructionLabel.Text = resources.GetString("logInstructionLabel.Text");
            // 
            // rankGridView
            // 
            this.rankGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rankGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.rankGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankGridView.Location = new System.Drawing.Point(94, 367);
            this.rankGridView.Name = "rankGridView";
            this.rankGridView.Size = new System.Drawing.Size(368, 134);
            this.rankGridView.TabIndex = 11;
            this.rankGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // rankNameTitleLabel
            // 
            this.rankNameTitleLabel.AutoSize = true;
            this.rankNameTitleLabel.Location = new System.Drawing.Point(124, 551);
            this.rankNameTitleLabel.Name = "rankNameTitleLabel";
            this.rankNameTitleLabel.Size = new System.Drawing.Size(60, 13);
            this.rankNameTitleLabel.TabIndex = 10;
            this.rankNameTitleLabel.Text = "Podaj nick:";
            // 
            // addToRankButton
            // 
            this.addToRankButton.Location = new System.Drawing.Point(356, 541);
            this.addToRankButton.Name = "addToRankButton";
            this.addToRankButton.Size = new System.Drawing.Size(126, 32);
            this.addToRankButton.TabIndex = 8;
            this.addToRankButton.Text = "Zapisz mój wynik";
            this.addToRankButton.UseVisualStyleBackColor = true;
            this.addToRankButton.Click += new System.EventHandler(this.addToRankButton_Click);
            // 
            // rankNameTextBox
            // 
            this.rankNameTextBox.Location = new System.Drawing.Point(190, 548);
            this.rankNameTextBox.Name = "rankNameTextBox";
            this.rankNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.rankNameTextBox.TabIndex = 7;
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Location = new System.Drawing.Point(236, 348);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(85, 13);
            this.rankLabel.TabIndex = 6;
            this.rankLabel.Text = "Obecny ranking:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.ForeColor = System.Drawing.Color.Gold;
            this.resultLabel.Location = new System.Drawing.Point(307, 100);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(27, 29);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "0";
            // 
            // resultTitleLabel
            // 
            this.resultTitleLabel.AutoSize = true;
            this.resultTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultTitleLabel.Location = new System.Drawing.Point(214, 107);
            this.resultTitleLabel.Name = "resultTitleLabel";
            this.resultTitleLabel.Size = new System.Drawing.Size(87, 20);
            this.resultTitleLabel.TabIndex = 3;
            this.resultTitleLabel.Text = "Twój wynik:";
            // 
            // endGameLabel
            // 
            this.endGameLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endGameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.endGameLabel.Location = new System.Drawing.Point(14, 37);
            this.endGameLabel.Name = "endGameLabel";
            this.endGameLabel.Size = new System.Drawing.Size(521, 63);
            this.endGameLabel.TabIndex = 2;
            this.endGameLabel.Text = "Koniec gry!";
            this.endGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinkLabel
            // 
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(165, 72);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(384, 20);
            this.drinkLabel.TabIndex = 29;
            this.drinkLabel.Text = "Powodzenia!";
            this.drinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.winePointsLabel);
            this.groupBox1.Controls.Add(this.champagnePointsLabel);
            this.groupBox1.Controls.Add(this.whiskyPointsLabel);
            this.groupBox1.Controls.Add(this.beerPointsLabel);
            this.groupBox1.Controls.Add(this.vodkaPointsLabel);
            this.groupBox1.Controls.Add(this.beerLabel);
            this.groupBox1.Controls.Add(this.homebrewPointsLabel);
            this.groupBox1.Controls.Add(this.wineLabel);
            this.groupBox1.Controls.Add(this.champagneLabel);
            this.groupBox1.Controls.Add(this.whiskyLabel);
            this.groupBox1.Controls.Add(this.vodkaLabel);
            this.groupBox1.Controls.Add(this.homebrewLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(160, 167);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punktacja";
            // 
            // winePointsLabel
            // 
            this.winePointsLabel.AutoSize = true;
            this.winePointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winePointsLabel.Location = new System.Drawing.Point(112, 118);
            this.winePointsLabel.Name = "winePointsLabel";
            this.winePointsLabel.Size = new System.Drawing.Size(44, 20);
            this.winePointsLabel.TabIndex = 23;
            this.winePointsLabel.Text = "2pkt";
            // 
            // champagnePointsLabel
            // 
            this.champagnePointsLabel.AutoSize = true;
            this.champagnePointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.champagnePointsLabel.Location = new System.Drawing.Point(112, 93);
            this.champagnePointsLabel.Name = "champagnePointsLabel";
            this.champagnePointsLabel.Size = new System.Drawing.Size(44, 20);
            this.champagnePointsLabel.TabIndex = 22;
            this.champagnePointsLabel.Text = "3pkt";
            // 
            // whiskyPointsLabel
            // 
            this.whiskyPointsLabel.AutoSize = true;
            this.whiskyPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.whiskyPointsLabel.Location = new System.Drawing.Point(112, 68);
            this.whiskyPointsLabel.Name = "whiskyPointsLabel";
            this.whiskyPointsLabel.Size = new System.Drawing.Size(44, 20);
            this.whiskyPointsLabel.TabIndex = 21;
            this.whiskyPointsLabel.Text = "4pkt";
            // 
            // beerPointsLabel
            // 
            this.beerPointsLabel.AutoSize = true;
            this.beerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beerPointsLabel.Location = new System.Drawing.Point(110, 143);
            this.beerPointsLabel.Name = "beerPointsLabel";
            this.beerPointsLabel.Size = new System.Drawing.Size(44, 20);
            this.beerPointsLabel.TabIndex = 25;
            this.beerPointsLabel.Text = "1pkt";
            // 
            // vodkaPointsLabel
            // 
            this.vodkaPointsLabel.AutoSize = true;
            this.vodkaPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vodkaPointsLabel.Location = new System.Drawing.Point(112, 43);
            this.vodkaPointsLabel.Name = "vodkaPointsLabel";
            this.vodkaPointsLabel.Size = new System.Drawing.Size(44, 20);
            this.vodkaPointsLabel.TabIndex = 20;
            this.vodkaPointsLabel.Text = "5pkt";
            // 
            // beerLabel
            // 
            this.beerLabel.AutoSize = true;
            this.beerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beerLabel.Location = new System.Drawing.Point(14, 143);
            this.beerLabel.Name = "beerLabel";
            this.beerLabel.Size = new System.Drawing.Size(42, 20);
            this.beerLabel.TabIndex = 24;
            this.beerLabel.Text = "Piwo";
            // 
            // homebrewPointsLabel
            // 
            this.homebrewPointsLabel.AutoSize = true;
            this.homebrewPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homebrewPointsLabel.Location = new System.Drawing.Point(112, 18);
            this.homebrewPointsLabel.Name = "homebrewPointsLabel";
            this.homebrewPointsLabel.Size = new System.Drawing.Size(44, 20);
            this.homebrewPointsLabel.TabIndex = 19;
            this.homebrewPointsLabel.Text = "6pkt";
            // 
            // wineLabel
            // 
            this.wineLabel.AutoSize = true;
            this.wineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wineLabel.Location = new System.Drawing.Point(14, 118);
            this.wineLabel.Name = "wineLabel";
            this.wineLabel.Size = new System.Drawing.Size(45, 20);
            this.wineLabel.TabIndex = 18;
            this.wineLabel.Text = "Wino";
            // 
            // champagneLabel
            // 
            this.champagneLabel.AutoSize = true;
            this.champagneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.champagneLabel.Location = new System.Drawing.Point(14, 93);
            this.champagneLabel.Name = "champagneLabel";
            this.champagneLabel.Size = new System.Drawing.Size(77, 20);
            this.champagneLabel.TabIndex = 17;
            this.champagneLabel.Text = "Szampan";
            // 
            // whiskyLabel
            // 
            this.whiskyLabel.AutoSize = true;
            this.whiskyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.whiskyLabel.Location = new System.Drawing.Point(14, 68);
            this.whiskyLabel.Name = "whiskyLabel";
            this.whiskyLabel.Size = new System.Drawing.Size(59, 20);
            this.whiskyLabel.TabIndex = 16;
            this.whiskyLabel.Text = "Whisky";
            // 
            // vodkaLabel
            // 
            this.vodkaLabel.AutoSize = true;
            this.vodkaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vodkaLabel.Location = new System.Drawing.Point(14, 43);
            this.vodkaLabel.Name = "vodkaLabel";
            this.vodkaLabel.Size = new System.Drawing.Size(59, 20);
            this.vodkaLabel.TabIndex = 15;
            this.vodkaLabel.Text = "Wódka";
            // 
            // homebrewLabel
            // 
            this.homebrewLabel.AutoSize = true;
            this.homebrewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homebrewLabel.Location = new System.Drawing.Point(14, 18);
            this.homebrewLabel.Name = "homebrewLabel";
            this.homebrewLabel.Size = new System.Drawing.Size(59, 20);
            this.homebrewLabel.TabIndex = 14;
            this.homebrewLabel.Text = "Bimber";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playAgainButton.Location = new System.Drawing.Point(175, 594);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(187, 46);
            this.playAgainButton.TabIndex = 13;
            this.playAgainButton.Text = "Graj od nowa!";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(228, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Czas do końca:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(24, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Twoje punkty:";
            // 
            // vodkaBox
            // 
            this.vodkaBox.Image = global::MateuszSliwkaLab3ZadDom.Properties.Resources.wodka;
            this.vodkaBox.Location = new System.Drawing.Point(347, 264);
            this.vodkaBox.Name = "vodkaBox";
            this.vodkaBox.Size = new System.Drawing.Size(75, 97);
            this.vodkaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.vodkaBox.TabIndex = 10;
            this.vodkaBox.TabStop = false;
            this.vodkaBox.Visible = false;
            this.vodkaBox.Click += new System.EventHandler(this.vodkaBox_Click);
            // 
            // champagneBox
            // 
            this.champagneBox.Image = global::MateuszSliwkaLab3ZadDom.Properties.Resources.champagne;
            this.champagneBox.Location = new System.Drawing.Point(347, 407);
            this.champagneBox.Name = "champagneBox";
            this.champagneBox.Size = new System.Drawing.Size(75, 92);
            this.champagneBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.champagneBox.TabIndex = 9;
            this.champagneBox.TabStop = false;
            this.champagneBox.Visible = false;
            this.champagneBox.Click += new System.EventHandler(this.champagneBox_Click);
            // 
            // wineBox
            // 
            this.wineBox.Image = global::MateuszSliwkaLab3ZadDom.Properties.Resources.wine;
            this.wineBox.Location = new System.Drawing.Point(216, 417);
            this.wineBox.Name = "wineBox";
            this.wineBox.Size = new System.Drawing.Size(75, 95);
            this.wineBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.wineBox.TabIndex = 8;
            this.wineBox.TabStop = false;
            this.wineBox.Visible = false;
            this.wineBox.Click += new System.EventHandler(this.wineBox_Click);
            // 
            // beerBox
            // 
            this.beerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.beerBox.Image = global::MateuszSliwkaLab3ZadDom.Properties.Resources.harnas;
            this.beerBox.Location = new System.Drawing.Point(73, 426);
            this.beerBox.Name = "beerBox";
            this.beerBox.Size = new System.Drawing.Size(75, 97);
            this.beerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.beerBox.TabIndex = 7;
            this.beerBox.TabStop = false;
            this.beerBox.Visible = false;
            this.beerBox.Click += new System.EventHandler(this.beerBox_Click);
            // 
            // homebrewBox
            // 
            this.homebrewBox.Image = global::MateuszSliwkaLab3ZadDom.Properties.Resources.bimber_png_;
            this.homebrewBox.Location = new System.Drawing.Point(347, 137);
            this.homebrewBox.Name = "homebrewBox";
            this.homebrewBox.Size = new System.Drawing.Size(75, 88);
            this.homebrewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homebrewBox.TabIndex = 6;
            this.homebrewBox.TabStop = false;
            this.homebrewBox.Visible = false;
            this.homebrewBox.Click += new System.EventHandler(this.homebrewBox_Click);
            // 
            // whiskyBox
            // 
            this.whiskyBox.Image = global::MateuszSliwkaLab3ZadDom.Properties.Resources.jackdnaiels;
            this.whiskyBox.Location = new System.Drawing.Point(216, 270);
            this.whiskyBox.Name = "whiskyBox";
            this.whiskyBox.Size = new System.Drawing.Size(75, 94);
            this.whiskyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.whiskyBox.TabIndex = 4;
            this.whiskyBox.TabStop = false;
            this.whiskyBox.Visible = false;
            this.whiskyBox.Click += new System.EventHandler(this.whiskyBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 494);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(548, 45);
            this.label15.TabIndex = 13;
            this.label15.Text = "ŁapButle ;-)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instrukcja
            // 
            this.instrukcja.AutoSize = true;
            this.instrukcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.instrukcja.Location = new System.Drawing.Point(10, 234);
            this.instrukcja.Name = "instrukcja";
            this.instrukcja.Size = new System.Drawing.Size(549, 336);
            this.instrukcja.TabIndex = 14;
            this.instrukcja.Text = resources.GetString("instrukcja.Text");
            this.instrukcja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // swapTimer
            // 
            this.swapTimer.Tick += new System.EventHandler(this.swapTimer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MateuszSliwkaLab3ZadDom.Properties.Resources.ferdek;
            this.pictureBox2.Location = new System.Drawing.Point(147, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 194);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // tutorialGroupBox
            // 
            this.tutorialGroupBox.Controls.Add(this.gameGroup);
            this.tutorialGroupBox.Controls.Add(this.pictureBox2);
            this.tutorialGroupBox.Controls.Add(this.startGameButton);
            this.tutorialGroupBox.Controls.Add(this.instrukcja);
            this.tutorialGroupBox.Location = new System.Drawing.Point(3, 57);
            this.tutorialGroupBox.Name = "tutorialGroupBox";
            this.tutorialGroupBox.Size = new System.Drawing.Size(557, 648);
            this.tutorialGroupBox.TabIndex = 17;
            this.tutorialGroupBox.TabStop = false;
            this.tutorialGroupBox.Text = "Instrukcja";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 709);
            this.Controls.Add(this.tutorialGroupBox);
            this.Controls.Add(this.label15);
            this.Name = "FormMain";
            this.Text = "ŁapButle - MateuszSliwkaLab1ZadDom";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.gameGroup.ResumeLayout(false);
            this.gameGroup.PerformLayout();
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vodkaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.champagneBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wineBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homebrewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiskyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tutorialGroupBox.ResumeLayout(false);
            this.tutorialGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox whiskyBox;
        private System.Windows.Forms.PictureBox homebrewBox;
        private System.Windows.Forms.PictureBox beerBox;
        private System.Windows.Forms.PictureBox wineBox;
        private System.Windows.Forms.PictureBox champagneBox;
        private System.Windows.Forms.PictureBox vodkaBox;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Timer beerTimer;
        private System.Windows.Forms.Timer wineTimer;
        private System.Windows.Forms.Timer champagneTimer;
        private System.Windows.Forms.Timer whiskyTimer;
        private System.Windows.Forms.Timer vodkaTimer;
        private System.Windows.Forms.Timer homebrewTimer;
        private System.Windows.Forms.GroupBox gameGroup;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label homebrewLabel;
        private System.Windows.Forms.Label beerPointsLabel;
        private System.Windows.Forms.Label beerLabel;
        private System.Windows.Forms.Label winePointsLabel;
        private System.Windows.Forms.Label champagnePointsLabel;
        private System.Windows.Forms.Label whiskyPointsLabel;
        private System.Windows.Forms.Label vodkaPointsLabel;
        private System.Windows.Forms.Label homebrewPointsLabel;
        private System.Windows.Forms.Label wineLabel;
        private System.Windows.Forms.Label champagneLabel;
        private System.Windows.Forms.Label whiskyLabel;
        private System.Windows.Forms.Label vodkaLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label instrukcja;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer swapTimer;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultTitleLabel;
        private System.Windows.Forms.Label endGameLabel;
        private System.Windows.Forms.Button addToRankButton;
        private System.Windows.Forms.TextBox rankNameTextBox;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.GroupBox tutorialGroupBox;

        private System.Windows.Forms.BindingSource resultsBindingSource;

        private System.Windows.Forms.Label rankNameTitleLabel;
        private System.Windows.Forms.DataGridView rankGridView;
        private System.Windows.Forms.Label logInstructionLabel;
        private System.Windows.Forms.Button deleteRowsButton;
        private System.Windows.Forms.DataGridView gameLogGridView;
        private System.Windows.Forms.Label logLabel;
    }
}

