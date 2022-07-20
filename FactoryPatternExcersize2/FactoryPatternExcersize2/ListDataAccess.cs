﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExcersize2
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from List Database");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List Database");
        }
    }
}
