using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EmailApp
{
    [Serializable]
    class EmailClass
    {
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }
        public string EmailMessage { get; set; }
        public string EmailDate { get; set; }

        public EmailClass(string emailFrom, string emailSubject, string emailMessage, string emailDate) {
            EmailFrom = emailFrom;
            EmailSubject = emailSubject;
            EmailMessage = emailMessage;
            EmailDate = emailDate;
        }

        public void Serialize(string outputFileName)
        {
            Stream file = new FileStream(outputFileName, FileMode.Append, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, this);
            file.Close();
        }
    }
}
