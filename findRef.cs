using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using System.Text.RegularExpressions;

namespace ReferFind
{
    class findRef
    {
        List<string> FoundRef = new List<string>();
        
        public List<string> Finder(string path, string regexOption)
        {
            OpenSettings os = new OpenSettings();
            os.AutoSave = false;
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(path, true, os))
            {
                Body body = wordDoc.MainDocumentPart.Document.Body;
                string totaltext = body.InnerText;
                Regex regex = new Regex(@"([I-Z][A-Z]-\d\d-\d\d\d)");
                //Match match = regex.Match(totaltext);
                foreach (Match items in regex.Matches(totaltext))
                {
                    FoundRef.Add(items.ToString());
                }
                wordDoc.Dispose();
            }
            List<string> Distinct = FoundRef.Distinct().ToList();
            return Distinct;
           
        }
    }
}
