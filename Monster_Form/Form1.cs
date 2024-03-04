using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prac11;

namespace Monster_Form
{
    public partial class Form1 : Form
    {
        public int player_hp;
        public int opponent_hp;

        public double playerarmor;
        public double opponentarmor;

        public string[] m1image = new string[] { "1.jpg", "2.jpg", "3.jpg", "4.jpg" };
        public string[] m2image = new string[] { "m1.jpg", "m2.jpg", "m3.jpg", "m4.jpg", "m5.jpg", "m6.jpg", "m7.jpg" };
        public int image1_num;
        public int image2_num;

        public string[] weapons = new string[] { "Без оружия", "шб", "радик", "дезоль", "даедалус", "рапира" };
        public int m1weapon_num;
        public int m2weapon_num;

        public string[] armor = new string[] { "Без брони", "Легкая", "Средняя", "Тяжелая" };
        public int m1armor_num;
        public int m2armor_num;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd_dmg = new Random();

            fight_info.ForeColor = Color.Blue;
            fight_info.Text = "";
            

            // // //

            Monster monster1 = new Monster();

            player_hp_text.Text = monster1.GetHp().ToString();
            player_dmg_text.Text = monster1.GetDamage().ToString();

            player_hp_bar.Value = Convert.ToInt32(player_hp_text.Text);

            image1_num = rnd.Next(0, m1image.Length);
            player_icon.Image = Image.FromFile($@"Рисунки\{m1image[image1_num]}");

            // // //

            Monster monster2 = new Monster();

            opponent_name.Text = monster2.CreateName();
            opponent_hp_text.Text = monster2.GetHp().ToString();
            opponent_dmg_text.Text = monster2.GetDamage().ToString();

            opponent_hp_bar.Value = Convert.ToInt32(opponent_hp_text.Text);

            image2_num = rnd.Next(0, m2image.Length);
            opponent_icon.Image = Image.FromFile($@"Рисунки\{m2image[image2_num]}");

            m2weapon_num = rnd.Next(0, weapons.Length);
            opponent_weapon_text.Text = weapons[m2weapon_num];

            m2armor_num = rnd.Next(0, armor.Length);
            opponent_armor_text.Text = armor[m2armor_num];

            switch (m2armor_num)
            {
                //без брони
                case 0:
                    monster2.SetArmor(0);
                    opponent_armor_value.Text = (monster2.GetArmor() * 100).ToString();
                    opponentarmor = monster2.GetArmor();
                    break;
                //легкая
                case 1:
                    monster2.SetArmor(0.25);
                    opponent_armor_value.Text = (monster2.GetArmor() * 100).ToString();
                    opponentarmor = monster2.GetArmor();
                    break;
                //средняя
                case 2:
                    monster2.SetArmor(0.50);
                    opponent_armor_value.Text = (monster2.GetArmor() * 100).ToString();
                    opponentarmor = monster2.GetArmor();
                    break;
                //тяжелая
                case 3:
                    monster2.SetArmor(0.75);
                    opponent_armor_value.Text = (monster2.GetArmor() * 100).ToString();
                    opponentarmor = monster2.GetArmor();
                    break;
            }

            switch (m2weapon_num)
            {
                //без оружия
                case 0:
                    monster2.SetDamage(3, 5);
                    opponent_dmg_text.Text = monster2.GetDamage().ToString();
                    break;
                //шб
                case 1:
                    monster2.SetDamage(10, 13);
                    opponent_dmg_text.Text = monster2.GetDamage().ToString();
                    break;
                //радик
                case 2:
                    monster2.SetDamage(20, 25);
                    opponent_dmg_text.Text = monster2.GetDamage().ToString();
                    break;
                //дезоль
                case 3:
                    monster2.SetDamage(31, 37);
                    opponent_dmg_text.Text = monster2.GetDamage().ToString();
                    break;
                //даедалус
                case 4:
                    monster2.SetDamage(49, 54);
                    opponent_dmg_text.Text = monster2.GetDamage().ToString();
                    break;
                //рапира
                case 5:
                    monster2.SetDamage(62, 69);
                    opponent_dmg_text.Text = monster2.GetDamage().ToString();
                    break;
            }
        }

        private void player_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void player_armor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void player_weapon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void player_icon_Click(object sender, EventArgs e)
        {
            player_icon.Image = Image.FromFile($@"Рисунки\{m1image[image1_num]}");

        }

        private void choose_player_icon_right_Click(object sender, EventArgs e)
        {
            if (image1_num < m1image.Length - 1)
                player_icon.Image = Image.FromFile($@"Рисунки\{m1image[++image1_num]}");

        }

        private void choose_player_icon_left_Click(object sender, EventArgs e)
        {
            if (image1_num > 0)
                player_icon.Image = Image.FromFile($@"Рисунки\{m1image[--image1_num]}");

        }

        private void player_create_Click(object sender, EventArgs e)
        {
            Monster monster1 = new Monster();
            Random rnd_dmg = new Random();

            play_name.Text = player_name.Text;
            player_armor_text.Text = player_armor.Text;
            player_weapon_text.Text = player_weapon.Text;

            switch (player_armor.SelectedIndex)
            {
                //без брони
                case 0:
                    monster1.SetArmor(0);
                    player_armor_value.Text = (monster1.GetArmor() * 100).ToString();
                    playerarmor = monster1.GetArmor();
                    break;
                //легкая
                case 1:
                    monster1.SetArmor(0.25);
                    player_armor_value.Text = (monster1.GetArmor() * 100).ToString();
                    playerarmor = monster1.GetArmor();
                    break;
                //средняя
                case 2:
                    monster1.SetArmor(0.50);
                    player_armor_value.Text = (monster1.GetArmor() * 100).ToString();
                    playerarmor = monster1.GetArmor();
                    break;
                //тяжелая
                case 3:
                    monster1.SetArmor(0.75);
                    player_armor_value.Text = (monster1.GetArmor() * 100).ToString();
                    playerarmor = monster1.GetArmor();
                    break;
            }

            switch (player_weapon.SelectedIndex)
            {
                //без оружия
                case 0:
                    monster1.SetDamage(3, 5);
                    player_dmg_text.Text = monster1.GetDamage().ToString();
                    break;
                    //шб
                case 1:
                    monster1.SetDamage(10, 13);
                    player_dmg_text.Text = monster1.GetDamage().ToString();
                    break;
                //радик
                case 2:
                    monster1.SetDamage(20, 25);
                    player_dmg_text.Text = monster1.GetDamage().ToString();
                    break;
                //дезоль
                case 3:
                    monster1.SetDamage(31, 37);
                    player_dmg_text.Text = monster1.GetDamage().ToString();
                    break;
                //даедалус
                case 4:
                    monster1.SetDamage(49, 54);
                    player_dmg_text.Text = monster1.GetDamage().ToString();
                    break;
                //рапира
                case 5:
                    monster1.SetDamage(62, 69);
                    player_dmg_text.Text = monster1.GetDamage().ToString();
                    break;
            }
        }

        private void fight_button_Click(object sender, EventArgs e)
        {
            if (player_weapon.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите оружие!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (player_armor.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите броню!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (player_name.Text == "")
            {
                MessageBox.Show("Введите имя героя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (player_armor_text.Text == "-" || player_weapon_text.Text == "-" || play_name.Text == "")
            {
                MessageBox.Show("Создайте героя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                player_name.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                player_armor.Visible = false;
                player_weapon.Visible = false;

                fight_button.Visible = false;
                player_create.Visible = false;
                choose_player_icon_left.Visible = false;
                choose_player_icon_right.Visible = false;

                hit_button.Visible = true;
                opponent_hit.Visible = true;

                help_armor_button.Visible = false;
                help_weapon_button.Visible = false;
            }
        }

        private void opponent_name_Click(object sender, EventArgs e)
        {

        }

        private void opponent_hp_text_Click(object sender, EventArgs e)
        {

        }

        private void opponent_hp_bar_Click(object sender, EventArgs e)
        {

        }

        private void opponent_dmg_text_Click(object sender, EventArgs e)
        {

        }

        private void opponent_icon_Click(object sender, EventArgs e)
        {

        }

        private void play_name_Click(object sender, EventArgs e)
        {

        }

        private void player_hp_text_Click(object sender, EventArgs e)
        {

        }

        private void player_hp_bar_Click(object sender, EventArgs e)
        {

        }

        private void player_dmg_text_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hit_button_Click(object sender, EventArgs e)
        {
            Monster monster1 = new Monster();
            Monster monster2 = new Monster();

            if (player_hp_bar.Value > 0)
            {
                if (monster1.Attack())
                {
                    double hit = Convert.ToDouble(player_dmg_text.Text) - (Convert.ToDouble(player_dmg_text.Text) * opponentarmor);
                    int prOpponenthp = opponent_hp_bar.Value - Convert.ToInt32(hit);
                    if (prOpponenthp < 0)
                    {
                        prOpponenthp = 0;
                        opponent_hp_bar.Value = prOpponenthp;
                        opponent_hp_text.Text = "0";
                    }
                    else
                    {
                        opponent_hp_bar.Value = prOpponenthp;
                        opponent_hp_text.Text = opponent_hp_bar.Value.ToString();
                    }

                    fight_info.Text = $"{player_name.Text} наносит {hit} урона {opponent_name.Text}";
                }
                else
                {
                    fight_info.Text = $"{player_name.Text} промахивается";
                }
            }
            else
            {
                MessageBox.Show($"Победил: {opponent_name.Text}", "Итог", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                player_hp_text.Text = "0";
                player_hp_bar.Value = 0;
                opponent_hit.Enabled = false;
                hit_button.Enabled = false;

            }
            if (opponent_hp_bar.Value == 0)
            {
                MessageBox.Show($"Победил: {player_name.Text}", "Итог", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                opponent_hp_text.Text = "0";
                opponent_hp_bar.Value = 0;
                opponent_hit.Enabled = false;
                hit_button.Enabled = false;
            }
        }
        private void opponent_hit_Click(object sender, EventArgs e)
        {
            Monster monster1 = new Monster();
            Monster monster2 = new Monster();

            if (opponent_hp_bar.Value > 0)
            {
                if (monster2.Attack())
                {
                    double hit = Convert.ToDouble(opponent_dmg_text.Text) - (Convert.ToDouble(opponent_dmg_text.Text) * playerarmor);
                    int prOpponenthp = player_hp_bar.Value - Convert.ToInt32(hit);
                    if (prOpponenthp < 0)
                    {
                        prOpponenthp = 0;
                        player_hp_bar.Value = prOpponenthp;
                        player_hp_text.Text = "0";
                    }
                    else
                    {
                        player_hp_bar.Value = prOpponenthp;
                        player_hp_text.Text = player_hp_bar.Value.ToString();
                    }

                    fight_info.Text = $"{opponent_name.Text} наносит {hit} урона {player_name.Text}";
                }
                else
                {
                    fight_info.Text = $"{opponent_name.Text} промахивается";
                }
            }
            else
            {
                MessageBox.Show($"Победил: {player_name.Text}", "Итог", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                opponent_hp_text.Text = "0";
                opponent_hp_bar.Value = 0;
                opponent_hit.Enabled = false;
                hit_button.Enabled = false;

            }
            if (player_hp_bar.Value == 0)
            {
                MessageBox.Show($"Победил: {opponent_name.Text}", "Итог", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                player_hp_text.Text = "0";
                player_hp_bar.Value = 0;
                opponent_hit.Enabled = false;
                hit_button.Enabled = false;
            }
        }

        private void player_armor_text_Click(object sender, EventArgs e)
        {

        }

        private void player_weapon_text_Click(object sender, EventArgs e)
        {

        }

        private void opponent_armor_text_Click(object sender, EventArgs e)
        {

        }

        private void opponent_weapon_text_Click(object sender, EventArgs e)
        {

        }

        private void help_armor_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Легкая: 25\nСредняя: 50\nТяжелая: 75", "Броня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void help_weapon_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Без оружия: 3-5\nшб: 10-13\nрадик: 20-25\nдезоль: 31-37\nдаедалус: 49-54\nрапира: 62-69", "Оружие", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void opponent_armor_value_Click(object sender, EventArgs e)
        {

        }

        private void player_armor_value_Click(object sender, EventArgs e)
        {

        }

        private void fight_info_Click(object sender, EventArgs e)
        {

        }
    }
}
