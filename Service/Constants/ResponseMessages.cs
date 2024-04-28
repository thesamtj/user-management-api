using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Constants
{
    public static class ResponseMessages
    {
        public static string GetEmailSuccessMessage(string emailAddress) => $"Email sent successfully to {emailAddress}";

    }
}
