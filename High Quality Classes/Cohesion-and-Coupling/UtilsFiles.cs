using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    class UtilsFiles
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("Not a file!");
            }
            else
            {
                string extension = fileName.Substring(indexOfLastDot + 1);
                return extension;
            }
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("Not a file!");
            }
            else
            {
                string extension = fileName.Substring(0, indexOfLastDot);
                return extension;
            }
        }
    }
}
