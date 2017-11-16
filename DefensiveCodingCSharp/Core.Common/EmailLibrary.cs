using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Core.Common
{
    public class EmailLibrary
    {
        public void SendEmail(string customerEmailAddress, string hereIsYourReceipt)
        {
            try
            {
                // send the email
            }
            catch (InvalidOperationException ex)
            {
                // log
                throw;
            }
        }
    }
}
