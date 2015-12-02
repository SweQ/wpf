using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DockPanel[] P_TTD_Panel = new DockPanel[14];
        DockPanel[] M_TTD_Panel = new DockPanel[14];
        Button[] Btn_Player = new Button[5];
        bool Player_Select = false;
        string Player_Type;
        string TTD_Type;
        string Player_Number;
        string Zone;

        public MainWindow()
        {
            InitializeComponent();
            P_TTD_Panel[0] = Zone1_P_TTD;
            P_TTD_Panel[1] = Zone2_P_TTD;
            P_TTD_Panel[2] = Zone3_P_TTD;
            P_TTD_Panel[3] = Zone4_P_TTD;
            P_TTD_Panel[4] = Zone5_P_TTD;
            P_TTD_Panel[5] = Zone6_P_TTD;
            P_TTD_Panel[6] = Zone7_P_TTD;
            P_TTD_Panel[7] = Zone8_P_TTD;
            P_TTD_Panel[8] = Zone9_P_TTD;
            P_TTD_Panel[9] = Zone10_P_TTD;
            P_TTD_Panel[10] = Zone11_P_TTD;
            P_TTD_Panel[11] = Zone12_P_TTD;
            P_TTD_Panel[12] = Zone13_P_TTD;
            P_TTD_Panel[13] = Zone14_P_TTD;

            M_TTD_Panel[0] = Zone1_M_TTD;
            M_TTD_Panel[1] = Zone2_M_TTD;
            M_TTD_Panel[2] = Zone3_M_TTD;
            M_TTD_Panel[3] = Zone4_M_TTD;
            M_TTD_Panel[4] = Zone5_M_TTD;
            M_TTD_Panel[5] = Zone6_M_TTD;
            M_TTD_Panel[6] = Zone7_M_TTD;
            M_TTD_Panel[7] = Zone8_M_TTD;
            M_TTD_Panel[8] = Zone9_M_TTD;
            M_TTD_Panel[9] = Zone10_M_TTD;
            M_TTD_Panel[10] = Zone11_M_TTD;
            M_TTD_Panel[11] = Zone12_M_TTD;
            M_TTD_Panel[12] = Zone13_M_TTD;
            M_TTD_Panel[13] = Zone14_M_TTD;

            Btn_Player[0] = Player1;
            Btn_Player[1] = Player2;
            Btn_Player[2] = Player3;
            Btn_Player[3] = Player4;
            Btn_Player[4] = Player5;

            Button_Positive.Background = Brushes.LightSeaGreen;

            for (int i = 0; i < P_TTD_Panel.Length; i++)
            {
                M_TTD_Panel[i].Visibility = Visibility.Hidden;
            }
            
        }
        
        private void Show_M_TTD(object sender, RoutedEventArgs e)
        {
            Button_Negative.Background = Brushes.LightSeaGreen;
            Button_Positive.Background = Brushes.White;
            TTD_Type = "Отрицательное";
            for (int i = 0; i < P_TTD_Panel.Length; i++)
            {
                P_TTD_Panel[i].Visibility=Visibility.Hidden;
                M_TTD_Panel[i].Visibility = Visibility.Visible;
            }
           
        }

        private void Show_P_TTD(object sender, RoutedEventArgs e)
        {
            Button_Positive.Background = Brushes.LightSeaGreen;
            Button_Negative.Background = Brushes.White;
            TTD_Type = "Положительное";
            for (int i = 0; i < P_TTD_Panel.Length; i++)
            {
                P_TTD_Panel[i].Visibility = Visibility.Visible;
                M_TTD_Panel[i].Visibility = Visibility.Hidden;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (Player_Select & TypePlayer.Text != "")
            {
                this.Player_Type = TypePlayer.Text;

                MenuItem panel = (MenuItem)e.OriginalSource;
                global::System.Windows.MessageBox.Show(string.Format("Игрок {0} {1} выполнил {2} действие:{3} В зоне: {4}", Player_Number, Player_Type, TTD_Type, panel.Header,Zone));
            }
            else
                global::System.Windows.MessageBox.Show("Выберите тип игрока и его номер!");

        }

        private void Player_Click(object sender, RoutedEventArgs e)
        {
            Player_Select = true;
            Button btn_player=new Button();
            btn_player=(Button)e.OriginalSource;
            string btn_name = btn_player.Name.ToString();

            for (int i = 0; i < Btn_Player.Length; i++) // изменение цвета кнопок с номерами игроков при нажатии 
            {
                Btn_Player[i].Background = Brushes.White;
                if (btn_name == Btn_Player[i].Name.ToString())
                {
                    Btn_Player[i].Background = Brushes.DarkOrange;
                }
            }
            Player_Number = btn_player.Content.ToString();
        }

        private void Zone_MouseEnter(object sender, MouseEventArgs e) //определяем зону 
        {
            DockPanel panel = new DockPanel();
            panel = (DockPanel)e.OriginalSource;
            Zone = panel.Name.ToString();

        }  
        
    }
}
