using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace _2048WindowsFormsApp
{
    public static class FileProvider
    {     
        private static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }
        public static void SaveUserResult (UserResult userResult, string filePath)
        {
            List<UserResult> results;
            if (FileExists(filePath))
            {
                results = GetUserResults(filePath);
                results.Add(userResult);
            }
            else
            {
                results = new List<UserResult> { userResult };
            }
            File.WriteAllText(filePath, JsonConvert.SerializeObject(results, Formatting.Indented), Encoding.UTF8);
        }

        public static List<UserResult> GetUserResults(string filePath)
        {
            if (FileExists(filePath))
            {
                return JsonConvert.DeserializeObject<List<UserResult>>(File.ReadAllText(filePath));
            }
            return null;
        }
    }
}
