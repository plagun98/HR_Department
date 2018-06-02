using System;
using System.Collections.Generic;
using System.Text;

namespace HR.DAL.Entities
{
    class Worker
    {
        //id
        public int WorkerId { get; set; }
        //имя
        public string Name { get; set; }
        //фамилия
        public string Surname { get; set; }
        //номер счета зарплаты
        public int SalaryNumber { get; set; }
        //подразделение
        public string Subdivision { get; set; }
        //должность
        public string Position { get; set; }
        //стаж
        public int Experience { get; set; }
    }
}
