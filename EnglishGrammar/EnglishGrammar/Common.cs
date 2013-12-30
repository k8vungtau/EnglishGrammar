using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EnglishGrammar
{
    public class Common
    {
        public string ReadFile(string filePath)
        {
            //this verse is loaded for the first time so fill it from the text file
            var ResrouceStream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative));
            if (ResrouceStream != null)
            {
                Stream myFileStream = ResrouceStream.Stream;
                if (myFileStream.CanRead)
                {
                    StreamReader myStreamReader = new StreamReader(myFileStream);

                    //read the content here
                    return myStreamReader.ReadToEnd();
                }
            }
            return "NULL";
        }
    }
}
