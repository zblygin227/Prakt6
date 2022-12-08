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

namespace Prakt6DeutchLand
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Triangle treugol = new Triangle(); // создание объека класса
        private void Perimtr(object sender, RoutedEventArgs e)
        {
            try 
            {
                GetValueTriangle();// получаем значение тругольника 

                Rezultat.Text = $"{treugol.Perimetr()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Uvelch(object sender, RoutedEventArgs e)
        {
            try
            {
                treugol.Uvelich();// вызов метода из класса
                Pole1.Text = $"{treugol.A}";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Pole2.Text = $"{treugol.B}";
                Pole3.Text = $"{treugol.C}";
            }
            catch
            {
                MessageBox.Show("Сначала создайте треугольник");
            }
        }
        private void GetValueTriangle()
        {
            int.TryParse(Pole1.Text, out int a);
            int.TryParse(Pole2.Text, out int b);
            int.TryParse(Pole3.Text, out int c);

            treugol.A = a;
            treugol.B = b;
            treugol.C = c;
        }
        private void Izmenenie(object sender, RoutedEventArgs e)
        {
            try
            {
                int.TryParse(Izm1.Text, out int izmenen1);
                int.TryParse(Izm2.Text, out int izmenen2);
                int.TryParse(Izm3.Text, out int izmenen3);

                if (Izm1.Text != "" && Izm2.Text != "" && Izm3.Text != "")
                {
                    Pole1.Text = Izm1.Text; Pole2.Text = Izm2.Text; Pole3.Text = Izm3.Text;

                    Izm1.Clear(); 
                    Izm2.Clear(); 
                    Izm3.Clear(); 
                    Rezultat.Clear();

                    treugol.SetParams(izmenen1, izmenen2, izmenen3);

                    return;
                }
                if (Izm1.Text != "" && Izm2.Text != "")
                {
                    Pole1.Text = Izm1.Text; Pole2.Text = Izm2.Text;

                    Izm1.Clear(); Izm2.Clear(); Rezultat.Clear();

                    treugol.SetParams(izmenen1, izmenen2);

                    return;
                }
                if (Izm1.Text != "")
                {
                    Pole1.Text = Izm1.Text;

                    Izm1.Clear(); 
                    Rezultat.Clear();

                    treugol.SetParams(izmenen1);

                    return;
                }
            }
            catch
            {
                MessageBox.Show("Создайте сначала треугольник");
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            Rezultat.Clear(); 

            Izm1.Clear(); 
            Izm2.Clear(); 
            Izm3.Clear();

            Pole1.Clear();
            Pole2.Clear(); 
            Pole3.Clear();
        }

        private void Spravka(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 5\nСоздать класс Triangle (треугольник) с полями-сторонами. Создать необходимые методы и свойства. " +
                "Определить метод вычисления периметра. Создать перегруженные методы SetParams,для установки параметров объекта," +
                "в том числе увеличения размеров треугольника в 2 раза.");
        }

        private void Quit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ExistenceTriangle(object sender, RoutedEventArgs e)
        {
            try
            {
                GetValueTriangle();
                if (treugol)
                {
                    MessageBox.Show("Треугольник может существовать");
                }
                else
                {
                    MessageBox.Show("Треугольник не может существовать");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IncreaseValue(object sender, RoutedEventArgs e)
        {   
            GetValueTriangle();
            treugol++;
            Pole1.Text = $"{treugol.A}";
            Pole2.Text = $"{treugol.B}";
            Pole3.Text = $"{treugol.C}";
        }

        private void DecreaseValue(object sender, RoutedEventArgs e)
        {
            GetValueTriangle();
            treugol--;
            Pole1.Text = $"{treugol.A}";
            Pole2.Text = $"{treugol.B}";
            Pole3.Text = $"{treugol.C}";
        }
    }
}
