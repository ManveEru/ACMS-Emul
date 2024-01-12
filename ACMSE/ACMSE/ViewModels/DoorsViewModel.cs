using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ACMSE
{
    public class DoorsViewModel : INotifyPropertyChanged
    {
        // выбранный объект Door для отображения
        public Door SelectedDoor { get => DoorsFilteredList.FirstOrDefault(p => p.Id == SelectedId); }
        // id выбранного объекта
        public int SelectedId { get; set; }
        // данные для отображения в списке
        public List<Door> DoorsFullList { get; }
        List<Door> doorsFilteredList;

        //событие, высылаемое при изменении модели
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Door> DoorsFilteredList
        {
            get => doorsFilteredList;
            set
            {
                doorsFilteredList = value;
                OnPropertyChanged();
            }
        }

        public DoorsViewModel(List<Door> doors)
        {
            DoorsFullList = doors;
            DoorsFilteredList = DoorsFullList;
            SelectedId = 2;
        }

        public void Filter(int filter)
        {
            DoorsFilteredList = DoorsFullList.FindAll(p => p.LocationId == filter);
        }

        //сигнал об изменении модели
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
