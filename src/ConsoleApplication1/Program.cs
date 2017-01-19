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
            MeCabParam mcp = new MeCabParam();
            mcp.DicDir = @"D:\github\nmecab-osdn.net\src\ConsoleApplication1\dic\ipadic\";
            mcp.OutputFormatType = "wakati";
            MeCabTagger tagger = MeCabTagger.Create(mcp);
            ;
            string searchString = @"ConsoleApplication1";// @"黄金井酒造株式会社";
            //@"大吟醸";
            string result = tagger.Parse(searchString);

            Console.Write(string.Format("{0} ==> {1}", searchString, result));
        }
    }
}
