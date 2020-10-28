using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab_6_2
{
    class PlayerItem
    {
        public string FileExtansion()
        {
            char[] temp = this.path.ToCharArray();
            Array.Reverse(temp);
            string extansion = "";
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '.') break;
                else
                {
                    extansion = extansion.Insert(0, temp[i].ToString());
                }
            }
            return extansion;
        }

        public PlayerItem(string path)
        {
            this.path = path;
        }
        public string path { get; set; }
        public IMedia playrecorder { get; set; }
        public IPlayable player { get; set; }
        public IRecordable recorder { get; set; }
        public string posibilities { get; set; }
    }
}
