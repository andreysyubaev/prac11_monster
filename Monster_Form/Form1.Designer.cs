namespace Monster_Form
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.player_name = new System.Windows.Forms.TextBox();
            this.player_armor = new System.Windows.Forms.ComboBox();
            this.player_weapon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.choose_player_icon_left = new System.Windows.Forms.Button();
            this.choose_player_icon_right = new System.Windows.Forms.Button();
            this.player_create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.opponent_name = new System.Windows.Forms.Label();
            this.opponent_hp_text = new System.Windows.Forms.Label();
            this.opponent_dmg_text = new System.Windows.Forms.Label();
            this.fight_button = new System.Windows.Forms.Button();
            this.opponent_hp_bar = new System.Windows.Forms.ProgressBar();
            this.opponent_icon = new System.Windows.Forms.PictureBox();
            this.player_icon = new System.Windows.Forms.PictureBox();
            this.player_hp_bar = new System.Windows.Forms.ProgressBar();
            this.player_dmg_text = new System.Windows.Forms.Label();
            this.player_hp_text = new System.Windows.Forms.Label();
            this.play_name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hit_button = new System.Windows.Forms.Button();
            this.player_weapon_text = new System.Windows.Forms.Label();
            this.player_armor_text = new System.Windows.Forms.Label();
            this.opponent_armor_text = new System.Windows.Forms.Label();
            this.opponent_weapon_text = new System.Windows.Forms.Label();
            this.help_armor_button = new System.Windows.Forms.Button();
            this.help_weapon_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.player_armor_value = new System.Windows.Forms.Label();
            this.opponent_armor_value = new System.Windows.Forms.Label();
            this.opponent_hit = new System.Windows.Forms.Button();
            this.fight_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opponent_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // player_name
            // 
            this.player_name.Location = new System.Drawing.Point(307, 32);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(170, 20);
            this.player_name.TabIndex = 0;
            this.player_name.Text = "Введите имя героя";
            this.player_name.TextChanged += new System.EventHandler(this.player_name_TextChanged);
            // 
            // player_armor
            // 
            this.player_armor.FormattingEnabled = true;
            this.player_armor.Items.AddRange(new object[] {
            "Без брони",
            "Легкая",
            "Средняя",
            "Тяжелая"});
            this.player_armor.Location = new System.Drawing.Point(307, 82);
            this.player_armor.Name = "player_armor";
            this.player_armor.Size = new System.Drawing.Size(170, 21);
            this.player_armor.TabIndex = 1;
            this.player_armor.SelectedIndexChanged += new System.EventHandler(this.player_armor_SelectedIndexChanged);
            // 
            // player_weapon
            // 
            this.player_weapon.FormattingEnabled = true;
            this.player_weapon.Items.AddRange(new object[] {
            "Без оружия",
            "шб",
            "радик",
            "дезоль",
            "даедалус",
            "рапира"});
            this.player_weapon.Location = new System.Drawing.Point(307, 122);
            this.player_weapon.Name = "player_weapon";
            this.player_weapon.Size = new System.Drawing.Size(170, 21);
            this.player_weapon.TabIndex = 2;
            this.player_weapon.SelectedIndexChanged += new System.EventHandler(this.player_weapon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите броню";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите оружие";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // choose_player_icon_left
            // 
            this.choose_player_icon_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_player_icon_left.Location = new System.Drawing.Point(42, 333);
            this.choose_player_icon_left.Name = "choose_player_icon_left";
            this.choose_player_icon_left.Size = new System.Drawing.Size(75, 23);
            this.choose_player_icon_left.TabIndex = 7;
            this.choose_player_icon_left.Text = "←";
            this.choose_player_icon_left.UseVisualStyleBackColor = true;
            this.choose_player_icon_left.Click += new System.EventHandler(this.choose_player_icon_left_Click);
            // 
            // choose_player_icon_right
            // 
            this.choose_player_icon_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_player_icon_right.Location = new System.Drawing.Point(137, 332);
            this.choose_player_icon_right.Name = "choose_player_icon_right";
            this.choose_player_icon_right.Size = new System.Drawing.Size(75, 23);
            this.choose_player_icon_right.TabIndex = 8;
            this.choose_player_icon_right.Text = "→";
            this.choose_player_icon_right.UseVisualStyleBackColor = true;
            this.choose_player_icon_right.Click += new System.EventHandler(this.choose_player_icon_right_Click);
            // 
            // player_create
            // 
            this.player_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_create.Location = new System.Drawing.Point(42, 362);
            this.player_create.Name = "player_create";
            this.player_create.Size = new System.Drawing.Size(170, 46);
            this.player_create.TabIndex = 9;
            this.player_create.Text = "Создать";
            this.player_create.UseVisualStyleBackColor = true;
            this.player_create.Click += new System.EventHandler(this.player_create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(583, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Противник";
            // 
            // opponent_name
            // 
            this.opponent_name.AutoSize = true;
            this.opponent_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opponent_name.Location = new System.Drawing.Point(584, 65);
            this.opponent_name.Name = "opponent_name";
            this.opponent_name.Size = new System.Drawing.Size(126, 20);
            this.opponent_name.TabIndex = 12;
            this.opponent_name.Text = "opponent_name";
            this.opponent_name.Click += new System.EventHandler(this.opponent_name_Click);
            // 
            // opponent_hp_text
            // 
            this.opponent_hp_text.AutoSize = true;
            this.opponent_hp_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opponent_hp_text.ForeColor = System.Drawing.Color.Black;
            this.opponent_hp_text.Location = new System.Drawing.Point(650, 90);
            this.opponent_hp_text.Name = "opponent_hp_text";
            this.opponent_hp_text.Size = new System.Drawing.Size(13, 13);
            this.opponent_hp_text.TabIndex = 13;
            this.opponent_hp_text.Text = "0";
            this.opponent_hp_text.Click += new System.EventHandler(this.opponent_hp_text_Click);
            // 
            // opponent_dmg_text
            // 
            this.opponent_dmg_text.AutoSize = true;
            this.opponent_dmg_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opponent_dmg_text.Location = new System.Drawing.Point(585, 148);
            this.opponent_dmg_text.Name = "opponent_dmg_text";
            this.opponent_dmg_text.Size = new System.Drawing.Size(14, 13);
            this.opponent_dmg_text.TabIndex = 14;
            this.opponent_dmg_text.Text = "0";
            this.opponent_dmg_text.Click += new System.EventHandler(this.opponent_dmg_text_Click);
            // 
            // fight_button
            // 
            this.fight_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fight_button.Location = new System.Drawing.Point(332, 362);
            this.fight_button.Name = "fight_button";
            this.fight_button.Size = new System.Drawing.Size(132, 46);
            this.fight_button.TabIndex = 15;
            this.fight_button.Text = "Бой";
            this.fight_button.UseVisualStyleBackColor = true;
            this.fight_button.Click += new System.EventHandler(this.fight_button_Click);
            // 
            // opponent_hp_bar
            // 
            this.opponent_hp_bar.Location = new System.Drawing.Point(588, 122);
            this.opponent_hp_bar.Name = "opponent_hp_bar";
            this.opponent_hp_bar.Size = new System.Drawing.Size(170, 23);
            this.opponent_hp_bar.TabIndex = 16;
            this.opponent_hp_bar.Click += new System.EventHandler(this.opponent_hp_bar_Click);
            // 
            // opponent_icon
            // 
            this.opponent_icon.Location = new System.Drawing.Point(588, 170);
            this.opponent_icon.Name = "opponent_icon";
            this.opponent_icon.Size = new System.Drawing.Size(170, 153);
            this.opponent_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opponent_icon.TabIndex = 10;
            this.opponent_icon.TabStop = false;
            this.opponent_icon.Click += new System.EventHandler(this.opponent_icon_Click);
            // 
            // player_icon
            // 
            this.player_icon.Location = new System.Drawing.Point(42, 173);
            this.player_icon.Name = "player_icon";
            this.player_icon.Size = new System.Drawing.Size(170, 153);
            this.player_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_icon.TabIndex = 6;
            this.player_icon.TabStop = false;
            this.player_icon.Click += new System.EventHandler(this.player_icon_Click);
            // 
            // player_hp_bar
            // 
            this.player_hp_bar.Location = new System.Drawing.Point(42, 122);
            this.player_hp_bar.Name = "player_hp_bar";
            this.player_hp_bar.Size = new System.Drawing.Size(170, 23);
            this.player_hp_bar.TabIndex = 21;
            this.player_hp_bar.Click += new System.EventHandler(this.player_hp_bar_Click);
            // 
            // player_dmg_text
            // 
            this.player_dmg_text.AutoSize = true;
            this.player_dmg_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_dmg_text.Location = new System.Drawing.Point(39, 148);
            this.player_dmg_text.Name = "player_dmg_text";
            this.player_dmg_text.Size = new System.Drawing.Size(14, 13);
            this.player_dmg_text.TabIndex = 20;
            this.player_dmg_text.Text = "0";
            this.player_dmg_text.Click += new System.EventHandler(this.player_dmg_text_Click);
            // 
            // player_hp_text
            // 
            this.player_hp_text.AutoSize = true;
            this.player_hp_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_hp_text.ForeColor = System.Drawing.Color.Black;
            this.player_hp_text.Location = new System.Drawing.Point(104, 90);
            this.player_hp_text.Name = "player_hp_text";
            this.player_hp_text.Size = new System.Drawing.Size(13, 13);
            this.player_hp_text.TabIndex = 19;
            this.player_hp_text.Text = "0";
            this.player_hp_text.Click += new System.EventHandler(this.player_hp_text_Click);
            // 
            // play_name
            // 
            this.play_name.AutoSize = true;
            this.play_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play_name.Location = new System.Drawing.Point(38, 65);
            this.play_name.Name = "play_name";
            this.play_name.Size = new System.Drawing.Size(0, 20);
            this.play_name.TabIndex = 18;
            this.play_name.Click += new System.EventHandler(this.play_name_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(37, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Игрок";
            // 
            // hit_button
            // 
            this.hit_button.Location = new System.Drawing.Point(218, 231);
            this.hit_button.Name = "hit_button";
            this.hit_button.Size = new System.Drawing.Size(75, 54);
            this.hit_button.TabIndex = 22;
            this.hit_button.Text = "удар";
            this.hit_button.UseVisualStyleBackColor = true;
            this.hit_button.Visible = false;
            this.hit_button.Click += new System.EventHandler(this.hit_button_Click);
            // 
            // player_weapon_text
            // 
            this.player_weapon_text.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.player_weapon_text.AutoSize = true;
            this.player_weapon_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_weapon_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.player_weapon_text.Location = new System.Drawing.Point(147, 148);
            this.player_weapon_text.Name = "player_weapon_text";
            this.player_weapon_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.player_weapon_text.Size = new System.Drawing.Size(11, 13);
            this.player_weapon_text.TabIndex = 23;
            this.player_weapon_text.Text = "-";
            this.player_weapon_text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.player_weapon_text.Click += new System.EventHandler(this.player_weapon_text_Click);
            // 
            // player_armor_text
            // 
            this.player_armor_text.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.player_armor_text.AutoSize = true;
            this.player_armor_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_armor_text.ForeColor = System.Drawing.Color.Black;
            this.player_armor_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.player_armor_text.Location = new System.Drawing.Point(147, 106);
            this.player_armor_text.Name = "player_armor_text";
            this.player_armor_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.player_armor_text.Size = new System.Drawing.Size(10, 13);
            this.player_armor_text.TabIndex = 24;
            this.player_armor_text.Text = "-";
            this.player_armor_text.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.player_armor_text.Click += new System.EventHandler(this.player_armor_text_Click);
            // 
            // opponent_armor_text
            // 
            this.opponent_armor_text.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.opponent_armor_text.AutoSize = true;
            this.opponent_armor_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opponent_armor_text.ForeColor = System.Drawing.Color.Black;
            this.opponent_armor_text.Location = new System.Drawing.Point(703, 106);
            this.opponent_armor_text.Name = "opponent_armor_text";
            this.opponent_armor_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.opponent_armor_text.Size = new System.Drawing.Size(10, 13);
            this.opponent_armor_text.TabIndex = 25;
            this.opponent_armor_text.Text = "-";
            this.opponent_armor_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opponent_armor_text.Click += new System.EventHandler(this.opponent_armor_text_Click);
            // 
            // opponent_weapon_text
            // 
            this.opponent_weapon_text.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.opponent_weapon_text.AutoSize = true;
            this.opponent_weapon_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opponent_weapon_text.Location = new System.Drawing.Point(702, 148);
            this.opponent_weapon_text.Name = "opponent_weapon_text";
            this.opponent_weapon_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.opponent_weapon_text.Size = new System.Drawing.Size(11, 13);
            this.opponent_weapon_text.TabIndex = 26;
            this.opponent_weapon_text.Text = "-";
            this.opponent_weapon_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opponent_weapon_text.Click += new System.EventHandler(this.opponent_weapon_text_Click);
            // 
            // help_armor_button
            // 
            this.help_armor_button.Location = new System.Drawing.Point(483, 83);
            this.help_armor_button.Name = "help_armor_button";
            this.help_armor_button.Size = new System.Drawing.Size(18, 20);
            this.help_armor_button.TabIndex = 27;
            this.help_armor_button.Text = "?";
            this.help_armor_button.UseVisualStyleBackColor = true;
            this.help_armor_button.Click += new System.EventHandler(this.help_armor_button_Click);
            // 
            // help_weapon_button
            // 
            this.help_weapon_button.Location = new System.Drawing.Point(483, 122);
            this.help_weapon_button.Name = "help_weapon_button";
            this.help_weapon_button.Size = new System.Drawing.Size(18, 20);
            this.help_weapon_button.TabIndex = 28;
            this.help_weapon_button.Text = "?";
            this.help_weapon_button.UseVisualStyleBackColor = true;
            this.help_weapon_button.Click += new System.EventHandler(this.help_weapon_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(39, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Здоровье:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(39, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Броня:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(585, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Броня:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(585, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Здоровье:";
            // 
            // player_armor_value
            // 
            this.player_armor_value.AutoSize = true;
            this.player_armor_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player_armor_value.ForeColor = System.Drawing.Color.Black;
            this.player_armor_value.Location = new System.Drawing.Point(86, 106);
            this.player_armor_value.Name = "player_armor_value";
            this.player_armor_value.Size = new System.Drawing.Size(13, 13);
            this.player_armor_value.TabIndex = 33;
            this.player_armor_value.Text = "0";
            this.player_armor_value.Click += new System.EventHandler(this.player_armor_value_Click);
            // 
            // opponent_armor_value
            // 
            this.opponent_armor_value.AutoSize = true;
            this.opponent_armor_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opponent_armor_value.ForeColor = System.Drawing.Color.Black;
            this.opponent_armor_value.Location = new System.Drawing.Point(631, 106);
            this.opponent_armor_value.Name = "opponent_armor_value";
            this.opponent_armor_value.Size = new System.Drawing.Size(13, 13);
            this.opponent_armor_value.TabIndex = 34;
            this.opponent_armor_value.Text = "0";
            this.opponent_armor_value.Click += new System.EventHandler(this.opponent_armor_value_Click);
            // 
            // opponent_hit
            // 
            this.opponent_hit.Location = new System.Drawing.Point(507, 231);
            this.opponent_hit.Name = "opponent_hit";
            this.opponent_hit.Size = new System.Drawing.Size(75, 54);
            this.opponent_hit.TabIndex = 35;
            this.opponent_hit.Text = "удар";
            this.opponent_hit.UseVisualStyleBackColor = true;
            this.opponent_hit.Visible = false;
            this.opponent_hit.Click += new System.EventHandler(this.opponent_hit_Click);
            // 
            // fight_info
            // 
            this.fight_info.AutoSize = true;
            this.fight_info.Location = new System.Drawing.Point(284, 337);
            this.fight_info.Name = "fight_info";
            this.fight_info.Size = new System.Drawing.Size(35, 13);
            this.fight_info.TabIndex = 36;
            this.fight_info.Text = "label9";
            this.fight_info.Click += new System.EventHandler(this.fight_info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.fight_info);
            this.Controls.Add(this.opponent_hit);
            this.Controls.Add(this.opponent_armor_value);
            this.Controls.Add(this.player_armor_value);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.help_weapon_button);
            this.Controls.Add(this.help_armor_button);
            this.Controls.Add(this.opponent_weapon_text);
            this.Controls.Add(this.opponent_armor_text);
            this.Controls.Add(this.player_armor_text);
            this.Controls.Add(this.player_weapon_text);
            this.Controls.Add(this.hit_button);
            this.Controls.Add(this.player_hp_bar);
            this.Controls.Add(this.player_dmg_text);
            this.Controls.Add(this.player_hp_text);
            this.Controls.Add(this.play_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.opponent_hp_bar);
            this.Controls.Add(this.fight_button);
            this.Controls.Add(this.opponent_dmg_text);
            this.Controls.Add(this.opponent_hp_text);
            this.Controls.Add(this.opponent_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.opponent_icon);
            this.Controls.Add(this.player_create);
            this.Controls.Add(this.choose_player_icon_right);
            this.Controls.Add(this.choose_player_icon_left);
            this.Controls.Add(this.player_icon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player_weapon);
            this.Controls.Add(this.player_armor);
            this.Controls.Add(this.player_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opponent_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox player_name;
        private System.Windows.Forms.ComboBox player_armor;
        private System.Windows.Forms.ComboBox player_weapon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox player_icon;
        private System.Windows.Forms.Button choose_player_icon_left;
        private System.Windows.Forms.Button choose_player_icon_right;
        private System.Windows.Forms.Button player_create;
        private System.Windows.Forms.PictureBox opponent_icon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label opponent_name;
        private System.Windows.Forms.Label opponent_hp_text;
        private System.Windows.Forms.Label opponent_dmg_text;
        private System.Windows.Forms.Button fight_button;
        private System.Windows.Forms.ProgressBar opponent_hp_bar;
        private System.Windows.Forms.ProgressBar player_hp_bar;
        private System.Windows.Forms.Label player_dmg_text;
        private System.Windows.Forms.Label player_hp_text;
        private System.Windows.Forms.Label play_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button hit_button;
        private System.Windows.Forms.Label player_weapon_text;
        private System.Windows.Forms.Label player_armor_text;
        private System.Windows.Forms.Label opponent_armor_text;
        private System.Windows.Forms.Label opponent_weapon_text;
        private System.Windows.Forms.Button help_armor_button;
        private System.Windows.Forms.Button help_weapon_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label player_armor_value;
        private System.Windows.Forms.Label opponent_armor_value;
        private System.Windows.Forms.Button opponent_hit;
        private System.Windows.Forms.Label fight_info;
    }
}

