using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassWork2
{ 
    class changeText
    {
        public string changeSpace(string text) {
            string changedText = text.Replace(' ', '-');
            return changedText;
        }
    }
}
