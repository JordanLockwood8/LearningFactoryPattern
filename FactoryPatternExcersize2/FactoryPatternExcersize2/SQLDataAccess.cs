using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExcersize2
{
    public class SQLDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from SQL Database");
        }

        public void SaveData()
        {
            Console.WriteLine("“I am saving data to a SQL database”");
        }
    }
}
