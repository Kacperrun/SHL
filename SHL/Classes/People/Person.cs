using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHL.Classes.People
{
    class Person
    {
        #region Static Data

        private static int lastestId;

        static Person()
        {
            lastestId = 0;
        }

        #endregion

        private int id;
        private string firstName;
        private string secondName;
    }
}
