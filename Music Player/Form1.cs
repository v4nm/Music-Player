using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        // Метод для настройки интерфейса при запуске
        private void customizeDesign()
        {
            // Скрываем все подменю при запуске
            panelMedia.Visible = false;
            panelPlaylist.Visible = false;
        }

        // Метод для скрытия всех подменю
        private void hideSubmenu()
        {
            if (panelMedia.Visible == true)
                panelMedia.Visible = false;
            if (panelPlaylist.Visible == true)
                panelPlaylist.Visible = false;
        }

        // Метод для показа конкретного подменю
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();  // Скрываем все подменю перед открытием нового
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false; // Скрываем, если уже было открыто
        }

        // Обработчики событий для кнопок
        private void buttonMainMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMedia);
        }

        private void buttonMainPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylist);
        }
        // Обработчики событий для скрытия подменю
        private void buttonMusicDownload_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
    }
}
