using NMeCab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MeCabTagger tagger = MeCabTagger.Create();
            string searchString = @"もろみ純米吟醸生酒  もろみ純米吟醸生酒 Shinomine しのみね";
            //@"大吟醸";
            string result = tagger.Parse(searchString);

            Console.Write(string.Format("{0} ==> {1}", searchString, result));
        }
    }
}
