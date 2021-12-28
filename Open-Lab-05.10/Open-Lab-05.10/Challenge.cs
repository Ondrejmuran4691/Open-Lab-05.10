using System;
using System.Linq;
namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            int final = 1;
            string one = "";
            foreach (char c in num.ToString())
            {
               one = c.ToString();
                final = final * int.Parse(one);
            }
            
            return final;
        }
    }
}
