using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TimeTable.Common;
using TimeTable.Data;

namespace TimeTable.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewTaskPage : ContentPage
	{
        private TimeTable.Common.Task task;
        public NewTaskPage()
        {
            InitializeComponent();
        }
		public NewTaskPage (TimeTable.Common.Task t = null)
		{
			InitializeComponent ();
            task = t;
            if (t != null)
            {
                NameEntry.Text = t.Name;
                DueDatePicker.Date = new DateTime(t.DueDateTicks);
                NotesEditor.Text = t.Notes;
            }
		}

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            DbTask dbt = new DbTask();
            if (task == null)
            {
                task = new TimeTable.Common.Task();
                task.Name = this.NameEntry.Text;
                task.DueDateTicks = this.DueDatePicker.Date.Ticks;
                task.Notes = this.NotesEditor.Text;
                task.Id = dbt.Insert(task);
            } else
            {
                task.Name = this.NameEntry.Text;
                task.DueDateTicks = this.DueDatePicker.Date.Ticks;
                task.Notes = this.NotesEditor.Text;
                dbt.Update(task);
            }
        }
	}
}