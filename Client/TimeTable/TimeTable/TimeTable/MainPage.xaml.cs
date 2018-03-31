using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeTable
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            lst.ItemsSource = new List<Subject>()
            {
                new Subject()
                {
                    Name = "Calculo", Place = "A12",
                },
                new Subject()
                {
                    Name = "Programacion", Place = "D03",
                },
            };
            /*
            lst2.ItemsSource = new List<Subject>()
            {
                new Subject()
                {
                    Name = "Diseño", Place = "A15",
                },
                new Subject()
                {
                    Name = "Programacion", Place = "D03",
                },
                new Subject()
                {
                    Name = "BigData", Place = "C02",
                },
            };
            */
		}
	}
}
