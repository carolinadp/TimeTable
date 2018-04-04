using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeTable
{
	public partial class MainPage : ContentPage
	{
        ObservableCollection<Day> Week;
        public MainPage()
        {
            InitializeComponent();
            Week = new ObservableCollection<Day>() {
                new Day(){
                    Name = "Lunes",
                    Sessions =  new List<Session>()
                    {
                        new Session() {
                            Subject = new Subject()
                            {
                                Name = "Calculo", Place = "A12",
                            }
                        },
                        new Session() {
                            Subject = new Subject()
                            {
                                Name = "Programacion", Place = "D03",
                            }
                        },
                    }
                },
                new Day() {
                    Name = "Martes",
                    Sessions = new List<Session>()
                    {
                        new Session() {
                            Subject = new Subject()
                            {
                                Name = "Diseño", Place = "A15",
                            }
                        },
                        new Session(){
                            Subject = new Subject()
                            {
                                Name = "Programacion", Place = "D03",
                            }
                        },
                        new Session() {
                            Subject = new Subject()
                            {
                                Name = "BigData", Place = "C02",
                            }
                        },
                    }
                }
            };
            carousel.ItemsSource = Week;
		}
	}
}
