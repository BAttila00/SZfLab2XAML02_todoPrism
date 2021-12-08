using Prism.Windows.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPrism.Models;

namespace TodoPrism.ViewModels {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<TodoItem> Todos { get; set; } = new ObservableCollection<TodoItem>()
{
            new TodoItem()
            {
                Id = 1,
                Title = "Tejet venni",
                Description = "Ha van tojás, hozz tizet!",
                Priority = Priority.Normal,
                IsDone = true,
                Deadline = DateTimeOffset.Now + TimeSpan.FromDays(1)
            },
            new TodoItem()
            {
                Id = 2,
                Title = "Megírni a szakdolgozatot",
                Description = "Minimum 40 oldal, szépen kitöltve screenshotokkal",
                Priority = Priority.High,
                IsDone = false,
                Deadline = new DateTime(2017, 12, 08, 12, 00, 00, 00)
            }
        };
    }
}
