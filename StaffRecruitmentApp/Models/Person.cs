using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecruitmentApp.Models
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }
    }
}
