﻿using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ACMSE
{
    public class DoorsViewModel : INotifyPropertyChanged
    {
        // выбранный объект Person для отображения
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

        public DoorsViewModel()
        {
            //заменить на запрос к БД
            DoorsFullList = new List<Door>();
            DoorsFullList.Add(new Door(1, "Дверь 1", 1));
            DoorsFullList.Add(new Door(2, "Дверь 2", 2));
            DoorsFullList.Add(new Door(3, "Дверь 3", 3));
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
