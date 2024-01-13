using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ACMSE
{
    public class EmployeesModelView : INotifyPropertyChanged
    {
        // выбранный объект Person для отображения
        public Person SelectedPerson { get => EmpFilteredList.FirstOrDefault(p => p.Id == SelectedId); }
        // id выбранного объекта
        public int SelectedId { get; set; }
        // данные для отображения в списке
        public List<Person> EmpFullList { get; set; }
        List<Person> empFilteredList;

        //событие, высылаемое при изменении модели
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Person> EmpFilteredList
        {
            get => empFilteredList;
            set
            {
                empFilteredList = value;
                OnPropertyChanged();
            }
        }

        public EmployeesModelView () 
        {
            
        }

        public void Filter (string filter)
        {
            EmpFilteredList = EmpFullList.FindAll(p => p.NSP.Contains(filter));
        }

        //сигнал об изменении модели
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
