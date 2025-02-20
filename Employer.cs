﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ExercicioLista {
    class Employer {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employer(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double porcentagem) {
            Salary += Salary * porcentagem / 100.00;
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
