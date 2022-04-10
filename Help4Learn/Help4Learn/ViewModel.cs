using System;
using System.Collections.ObjectModel;
using System.Text;
using Help4Learn.Model;
using System.Windows.Input;
using Xamarin.Forms;

namespace Help4Learn
{
    public class ViewModel
    {
        public string userName { get; set; }

        private int firstDayOfCurrentWeek { get; set; }


        public ObservableCollection<Task> tasks { get; set; }
        public ObservableCollection<Activity> activieties { get; set; }

        public ObservableCollection<Task> day1Tasks { get; set; }
        public ObservableCollection<Task> day2Tasks { get; set; }
        public ObservableCollection<Task> day3Tasks { get; set; }
        public ObservableCollection<Task> day4Tasks { get; set; }
        public ObservableCollection<Task> day5Tasks { get; set; }
        public ObservableCollection<Task> day6Tasks { get; set; }
        public ObservableCollection<Task> day7Tasks { get; set; }

        public ViewModel()
        {
            firstDayOfCurrentWeek = 10;

            User user = new User("Maciej Nowak", 10);
            userName = user.userName;

            tasks = new ObservableCollection<Task>();
            activieties = new ObservableCollection<Activity>();

            tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
                "kartkówka", "j_polski", 8, new DateTime(2022, 4, 10, 12, 10, 0)));
            tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
                "kartkówka", "j_polski", 8, new DateTime(2022, 4, 10, 12, 10, 0)));
            tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
                "kartkówka", "j_polski", 8, new DateTime(2022, 4, 12, 12, 13, 0)));
            tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
                "kartkówka", "j_polski", 8, new DateTime(2022, 4, 14, 12, 14, 0)));
            tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
                "kartkówka", "j_polski", 8, new DateTime(2022, 4, 14, 12, 22, 0)));

            activieties.Add(new Activity("Polski - nauka", "Treść lektury Konrad Wallenrod",
                "nauka", "j_polski", new DateTime(2022, 4, 8, 12, 15, 0), new DateTime(2022, 4, 8, 12, 30, 0)));

            updateTasks();
            
        }

        void reset()
        {
            day1Tasks = null;
            day2Tasks = null;
            day3Tasks = null;
            day4Tasks = null;
            day5Tasks = null;
            day6Tasks = null;
            day7Tasks = null;
        }


        public ICommand UpdateTasks_Command => new Command(updateTasks);

        void updateTasks()
        {
            reset();
            day1Tasks = new ObservableCollection<Task>();
            day2Tasks = new ObservableCollection<Task>();
            day3Tasks = new ObservableCollection<Task>();
            day4Tasks = new ObservableCollection<Task>();
            day5Tasks = new ObservableCollection<Task>();
            day6Tasks = new ObservableCollection<Task>();
            day7Tasks = new ObservableCollection<Task>();

            foreach(Task task in tasks)
            {
                int day = task.date.Day;
                if(day < firstDayOfCurrentWeek || day >= firstDayOfCurrentWeek + 7) {
                    day1Tasks.Remove(task);

                    continue;
                }

                day -= firstDayOfCurrentWeek;
                switch (day)
                {
                    case 0:
                        day1Tasks.Add(task);
                        break;
                    case 1:
                        day2Tasks.Add(task);
                        break;
                    case 2:
                        day3Tasks.Add(task);
                        break;
                    case 3:
                        day4Tasks.Add(task);
                        break;
                    case 4:
                        day5Tasks.Add(task);
                        break;
                    case 5:
                        day6Tasks.Add(task);
                        break;
                    case 6:
                        day7Tasks.Add(task);
                        break;
                    default:
                        Console.WriteLine("Skipped");
                        break;
                }
            }
        }

        public ICommand NextWeek_Command => new Command(NextWeek);
        void NextWeek()
        {      
            firstDayOfCurrentWeek += 7;
            updateTasks();
            day1Tasks = null;
            day2Tasks = null;
            day3Tasks = null;
            day4Tasks = null;
            day5Tasks = null;
            day6Tasks = null;
            day7Tasks = null;

        }

        public ICommand PastWeek_Command => new Command(PastWeek);
        void PastWeek()
        {
            firstDayOfCurrentWeek -= 7;
            updateTasks();
            day1Tasks = null;
            day2Tasks = null;
            day3Tasks = null;
            day4Tasks = null;
            day5Tasks = null;
            day6Tasks = null;
            day7Tasks = null;

        }


    }
}
