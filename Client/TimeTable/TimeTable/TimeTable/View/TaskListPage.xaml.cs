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
	public partial class TaskListPage : ContentPage
	{
		public TaskListPage ()
		{
			InitializeComponent ();

            DbTask dbTask = new DbTask();
            IEnumerable<TimeTable.Common.Task> taskList = dbTask.GetAll();

            TaskListView.ItemsSource = taskList;

		}
	}
}