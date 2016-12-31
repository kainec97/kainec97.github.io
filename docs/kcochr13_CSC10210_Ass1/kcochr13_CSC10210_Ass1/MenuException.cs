using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kcochr13_CSC10210_Ass1
{
    public class MenuException : Exception
    {
        //exception to be thrown when the user does not select a valid entry from the menu
        public MenuException(string errorMessageString) : base(errorMessageString)
        { 
        }

        //public MenuException(int errorCodeInt) : base(errorCodeInt)
        //{
        //}
    }
}
