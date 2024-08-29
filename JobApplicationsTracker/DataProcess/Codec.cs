using System;
using System.Linq;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace JobApplicationsTracker.DataProcess
{
    public class Codec
    {
        Regex regexregularPattern50 = new Regex(@"^[a-zA-Z0-9-]{1,49}$");
        Regex regexURL = new Regex(@"^(https?:\/\/)?([a-zA-Z0-9.-]+\.[a-zA-Z]{2,})
                                  (\/[a-zA-Z0-9._~:\/?#\[\]@!$&'()*+,;=-]*)?\/?$");
        Regex regexFileLocation = new Regex(@"^[a-zA-Z]:\\(?:[^<>:""/\\|?*\r\n]+\\)*
                                            [^<>:""/\\|?*\r\n]*\.[a-zA-Z0-9]{1,5}$");

        public bool ValidateGeneralText(string text)
        {
            var match = regexregularPattern50.Match(text);

            if (match.Success)
            {
                return true;
            }
            return false;
        }

        public bool ValidateURL(string url)
        {
            var match = regexURL.Match(url);

            if (match.Success)
            {
                return true;
            }
            return false;
        }

        public bool ValidateFileLocation(string location)
        {
            var match = regexFileLocation.Match(location);

            if (match.Success)
            {
                return true;
            }
            return false;
        }

    }
}
