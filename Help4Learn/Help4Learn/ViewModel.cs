using System;
using System.Collections.ObjectModel;
using System.Text;
using Help4Learn.Model;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Help4Learn
{
    public class ViewModel : INotifyPropertyChanged
    {
        public string userName { get; set; }
        private int _firstDayOfCurrentWeek;
        public int firstDayOfCurrentWeek
        {
            get
            {
                return _firstDayOfCurrentWeek;
            }
            set
            {
                if(_firstDayOfCurrentWeek != value)
                {
                    _firstDayOfCurrentWeek = value;
                    OnPropertyChanged();
                }
            }
        }


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

            day1Tasks = new ObservableCollection<Task>();
            day2Tasks = new ObservableCollection<Task>();
            day3Tasks = new ObservableCollection<Task>();
            day4Tasks = new ObservableCollection<Task>();
            day5Tasks = new ObservableCollection<Task>();
            day6Tasks = new ObservableCollection<Task>();
            day7Tasks = new ObservableCollection<Task>();

            tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
                "kartkówka", "j_polski", 8, new DateTime(2022, 4, 10, 12, 10, 0)));
            tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
                "kartkówka", "j_polski", 8, new DateTime(2022, 4, 10, 12, 10, 0)));
            tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
                "kartkówka", "j_polski", 8, new DateTime(2022, 4, 12, 12, 13, 0)));
            tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
                "kartkówka", "j_polski", 8, new DateTime(2022, 4, 14, 12, 14, 0)));
            tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
                "kartkówka", "j_polski", 8, new DateTime(2022, 4, 22, 12, 22, 0)));

            activieties.Add(new Activity("Polski - nauka", "Treść lektury Konrad Wallenrod",
                "nauka", "j_polski", new DateTime(2022, 4, 8, 12, 15, 0), new DateTime(2022, 4, 8, 12, 30, 0)));

            updateTasks();

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        void updateTasks()
        {
            while (day1Tasks.Count > 0)
            {
                day1Tasks.RemoveAt(0);
            }
            while (day2Tasks.Count > 0)
            {
                day2Tasks.RemoveAt(0);
            }
            while (day3Tasks.Count > 0)
            {
                day3Tasks.RemoveAt(0);
            }
            while (day4Tasks.Count > 0)
            {
                day4Tasks.RemoveAt(0);
            }
            while (day5Tasks.Count > 0)
            {
                day5Tasks.RemoveAt(0);
            }
            while (day6Tasks.Count > 0)
            {
                day6Tasks.RemoveAt(0);
            }
            while (day7Tasks.Count > 0)
            {
                day7Tasks.RemoveAt(0);
            }

            foreach (Task task in tasks)
            {
                int day = task.date.Day;
                if (day < firstDayOfCurrentWeek || day >= firstDayOfCurrentWeek + 7)
                {
                    continue;
                }
                switch (day - firstDayOfCurrentWeek)
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
                        break;
                }
            }
        }

        public ICommand NextWeek_Command => new Command(NextWeek);
        void NextWeek()
        {
            firstDayOfCurrentWeek += 7;
            updateTasks();
           // tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
           //     "kartkówka", "j_polski", 8, new DateTime(2022, 4, 24, 12, 22, 0)));
           // day6Tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
           //     "kartkówka", "j_polski", 8, new DateTime(2022, 4, 26, 12, 22, 0)));
        }

        public ICommand PastWeek_Command => new Command(PastWeek);
        void PastWeek()
        {
            firstDayOfCurrentWeek -= 7;
            // tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
            //    "kartkówka", "j_polski", 8, new DateTime(2022, 4, 24, 12, 22, 0)));
           
            updateTasks();
            // day1Tasks.Add(new Task("Karktówka Konrad Wallenrod", "Treść lektury Konrad Wallenrod",
            //     "kartkówka", "j_polski", 8, new DateTime(2022, 4, 24, 12, 22, 0)));
        }

    }
}