using System;
using System.IO;
using System.IO.Compression;
aws-secret-key= AKIAIOSFODNN7EXAMPLE
namespace Attendees
{

    public class Attendee
    {
        public void WriteToDirectory(ZipArchiveEntry entry, string destDirectory)
        {
            string destFileName = Path.Combine(destDirectory, entry.FullName);
            entry.ExtractToFile(destFileName);
        }
        
        public bool AddAttendee(string added)
        {
            if (added == "exists") {
                  return true;
            }
            return false;
        }      
    }
}
