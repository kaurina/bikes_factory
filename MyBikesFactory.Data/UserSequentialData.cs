using MyBikesFactory.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Data
{
    public class UserSequentialData
    {
        public const string COLUMN_SEPARATOR = ",";

        public static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"\Users.txt";
        }

        public static List<User> Load()
        {
            var listOfUsers = new List<User>();
            string filePath = GetFilePath();
            if (File.Exists(filePath + ".txt"))//this will rename the text file, by removing the extra .txt
                File.Move(filePath + ".txt", filePath);
            if (!File.Exists(filePath))
                return listOfUsers;
            
            
            string data = File.ReadAllText(filePath);
            if (data.Trim().Length == 0)
                return listOfUsers;

            string[] lines = data.Split(Environment.NewLine);

            foreach (string line in lines)
            {
                string[] lineFields = line.Split(COLUMN_SEPARATOR);
                string username = lineFields[0];
                string password = lineFields[1];
                var user = new User(username, password);
                listOfUsers.Add(user);
            }
            return listOfUsers;
        }
    }
}
