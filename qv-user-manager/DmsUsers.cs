﻿using System.Collections.Generic;
using System.IO;

namespace qv_user_manager
{
    class DmsUsers
    {
        public List<string> GetUsersFromFile(string file)
        {
            var lines = new List<string>();

            using (var r = new StreamReader(file))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    if(line.Trim() != "")
                        lines.Add(line.Trim());
                }
            }
            return lines;
        }
    }
}
