using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wurqout.ViewModels;

namespace Wurqout.Data
{
    public class Repo
    {

        // Fields

        private static List<Exercise> records;

        // Constructor

        public Repo() { }

        // Properties

        public static List<Exercise> Records
        {
            get
            {
                if (records == null)
                {
                    // Fetch all records
                    records = new List<Exercise>();
                    records.AddRange(RepoBodyweight.Fetch());
                    records.AddRange(RepoDumbbells.Fetch());

                    // This is temporary until I create a database
                    for (int i = 0; i < records.Count - 1; i++)
                    {
                        records[i].Id = i;
                    }
                }
                return records;
            }
        }


    }
}
