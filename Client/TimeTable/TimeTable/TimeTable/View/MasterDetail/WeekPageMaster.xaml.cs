﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TimeTable.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeekPageMaster : ContentPage
    {
        public ListView ListView;

        public WeekPageMaster()
        {
            InitializeComponent();

            BindingContext = new WeekPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class WeekPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<WeekPageMenuItem> MenuItems { get; set; }
            
            public WeekPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<WeekPageMenuItem>(new[]
                {
                    new WeekPageMenuItem { Id = 0, Title = "Horario", TargetType = typeof(MainPage)},
                    new WeekPageMenuItem { Id = 1, Title = "Nueva Clase" },
                    new WeekPageMenuItem { Id = 2, Title = "Nueva Tarea", TargetType = typeof(NewTaskPage) },
                    new WeekPageMenuItem { Id = 3, Title = "Tareas", TargetType = typeof(TaskListPage) },
                    new WeekPageMenuItem { Id = 4, Title = "Clase" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}