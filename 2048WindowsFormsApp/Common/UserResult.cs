using System;

namespace _2048WindowsFormsApp
{
    public class UserResult : IComparable
    {
        public string UserName { get; set; }
        public int Score { get; set; }

        public int CompareTo(object obj)
        {
            var result = obj as UserResult;
            if (result != null)
            {
                return this.Score.CompareTo(result.Score);
            }
            else throw new Exception("Объекты нельзя сравнить!");
        }
    }
}
