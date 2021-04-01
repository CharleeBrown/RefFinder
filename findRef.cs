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
        
        public List<string> Finder(string path)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(path, true))
            {
                Body body = wordDoc.MainDocumentPart.Document.Body;
                string totaltext = body.InnerText;
                Regex regex = new Regex(@"([I-Z][A-Z]-\d\d-\d\d\d)");
                //Match match = regex.Match(totaltext);
                foreach (Match items in regex.Matches(totaltext))
                {
                    FoundRef.Add(items.ToString());
                }
                
              //  var dupes = FoundRef.GroupBy(x => x)
              //.Where(g => g.Count() > 1)
              //.Select(y => y.Key)
              //.ToList();
                wordDoc.Close();
            }
            List<string> Distinct = FoundRef.Distinct().ToList();
            return Distinct;
           
        }
    }
}
