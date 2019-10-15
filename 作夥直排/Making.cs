using HtmlAgilityPack;
using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using ChoHoe;

namespace ChoHoeBV
{
    class Making
    {
        public string ZipFloder = "";
        private string OpfBasedPath = "";
        public ArrayList ZipFloders = new ArrayList(),
                              OpfBase = new ArrayList(),
                              CSSList = new ArrayList(),
                              HtmlList = new ArrayList();

        public int TCT = 0,
                              PageDirection = 0,
                              Mobi = 0,
                              fontembedded = 0;




        public void make()
        {

        }
        public void Batch_make(List<string> _basedpath, List<string> _opfpath, List<string> _csspath, List<string> _xhtmlpath,string _xhtmlbasedpath)
        {

            foreach (string item in _csspath)
            {

               // cssEditing(item, fontembedded,_xhtmlbasedpath);
               csscssedit(item, fontembedded, _xhtmlbasedpath);
                
                
            }
            foreach (string item in _xhtmlpath)
            {
                htmledting(item, fontembedded);
            }


            pageDirection();


            foreach (var item in ZipFloders)
            {
                compress(item.ToString());
            }
        }
        public void css()
        {

        }
        public void html()
        {

        }
        void csscssedit(string _csspath, int _fontembedde, string _xhtmlbasedpath)
        {

           



        }
        void htmledting(string _htmlpath,int _fontembedde)
        {
            //<style> * {-webkit-writing-mode:vertical-rl;}</style>
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load( _htmlpath,Encoding.UTF8);

            doc.DocumentNode.Descendants()
                            .Where(n => n.Name == "script" || n.Name == "style")
                            .ToList();
                            //.ForEach(n => n.Remove());


        }
        void cssEditing(string _csspath, int _fontembedde,string _xhtmlbasedpath)
        {


            //string OpfPath = currentFloder;
            // string[] separator = { @"/" };

            // string[] opfsplit = OpfPath.Split(separator, StringSplitOptions.None);
            // if (!(opfsplit.Length == 1))
            // {
            //     OpfBasedPath = opfsplit[0];
            // }
            // else
            // {
            //     OpfBasedPath = "";
            // }



            FileStream fst = new FileStream(_csspath, FileMode.Open);
            StreamReader sr = new StreamReader(fst);

            ArrayList _cssstrings = new ArrayList();
            while (sr.EndOfStream != true)
            {
                _cssstrings.Add(sr.ReadLine());
            }
            fst.Close();
            FileStream rst = new FileStream(_csspath, FileMode.Create);
            StreamWriter sw = new StreamWriter(rst);
            int htmlStart = -1;// = CssSource.IndexOf("html {");
            int htmlEnd = -1;
            Regex reHtml = new Regex(@"[hH][Tt][Mm][Ll][\s]*[{]"),
                _regexfontemb = new Regex(@"[fF][oO][nN][Tt][-][fF][aA][mM][iI][lL][yY]*");//(@"[Bb][Oo][Dd][Yy][\s\S]+[{]");


            Match m, writiongmode, webkit, _fontembmatch;
            int a = 0;
            if (fontembedded == 1)
            {
                while (a < _cssstrings.Count - 1)
                {
                    _fontembmatch = _regexfontemb.Match(_cssstrings[a].ToString());

                    if (_fontembmatch.Success)
                    {
                        _cssstrings.RemoveAt(a);
                    }

                    a++;
                }

            }


            int doronot = 0;
            for (int i = 0; i < _cssstrings.Count - 1; i++)
            {
                m = reHtml.Match(_cssstrings[i].ToString());
                if (m.Success)
                {
                    htmlStart = i;
                    break;
                }



            }
            if (htmlStart != -1)
            {
                reHtml = new Regex(@"[}]");
                for (int i = htmlStart; i < _cssstrings.Count - 1; i++)
                {
                    m = reHtml.Match(_cssstrings[i].ToString());
                    if (m.Success)
                    {
                        htmlEnd = i;
                        for (int x = htmlStart; x < i; x++)
                        {
                            reHtml = new Regex("-epub-writing-mode");
                            writiongmode = reHtml.Match(_cssstrings[x].ToString());
                            if (writiongmode.Success)
                            {
                                _cssstrings[x] = "-epub-writing-mode:vertical-rl;";

                            }
                            reHtml = new Regex("-webkit-writing-mode");
                            webkit = reHtml.Match(_cssstrings[x].ToString());
                            if (webkit.Success)
                            {
                                _cssstrings[x] = "-webkit-writing-mode:vertical-rl;";
                                doronot = 1;
                                break;
                            }
                        }
                        if (doronot == 0)
                        {
                            _cssstrings.Insert(htmlEnd, "-epub-writing-mode:vertical-rl;");
                            _cssstrings.Insert(htmlEnd, "-webkit-writing-mode:vertical-rl;");
                        }

                        break;
                    }
                }
                foreach (object line in _cssstrings)
                {
                    sw.WriteLine(line);
                    sw.Flush();
                }
            }

            //if (htmlStart == -1 | CssSource.IndexOf("html{") == -1)//判定是否皆為true, | <--OR
            //{
            if (htmlStart == -1)
            {
                int bodyStart = -1, bodyEnd = -1;
                reHtml = new Regex(@"[Bb][Oo][Dd][Yy][\s]*[{]");

                for (int i = 0; i < _cssstrings.Count - 1; i++)
                {
                    m = reHtml.Match(_cssstrings[i].ToString());
                    if (m.Success)
                    {
                        bodyStart = i;
                        break;
                    }



                }
                if (bodyStart != -1)
                {

                    for (int i = bodyEnd; i < _cssstrings.Count - 1; i++)
                    {
                        _cssstrings.Insert(bodyStart, "}");

                        _cssstrings.Insert(bodyStart, "-epub-writing-mode:vertical-rl;");
                        _cssstrings.Insert(bodyStart, "-webkit-writing-mode:vertical-rl;");
                        _cssstrings.Insert(bodyStart, "body {");
                        break;
                    }

                        reHtml = new Regex(@"[}]");
                    for (int i = bodyStart; i < _cssstrings.Count - 1; i++)
                    {
                        m = reHtml.Match(_cssstrings[i].ToString());

                        
                        if (m.Success)
                        {
                            bodyEnd = i;
                            _cssstrings.Insert(bodyStart, "}");
                            
                            _cssstrings.Insert(bodyStart, "-epub-writing-mode:vertical-rl;");
                            _cssstrings.Insert(bodyStart, "-webkit-writing-mode:vertical-rl;");
                            _cssstrings.Insert(bodyStart, "html {");
                            break;
                        }
                    }
                    
                }
                foreach (object line in _cssstrings)
                {
                    sw.WriteLine(line);
                    sw.Flush();
                }
            }


            rst.Close();
            fst.Close();
        }
        void pageDirection()
        {

        }
        void TCT_convert(string XhtmlPath, string currentFloder)
        {
            string fullpath = @"temp\" + currentFloder + @"\" + OpfBasedPath + @"\" + XhtmlPath;
            FileStream xhtmlloder = new FileStream(fullpath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(xhtmlloder);
            string source = sr.ReadToEnd();
            string before = "", after = "";



            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(source);
            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//text()"))
            {

                before = node.InnerText;
                if (TCT == 1)
                {
                    after = ChineseConverter.Convert(before, ChineseConversionDirection.SimplifiedToTraditional);
                }
                else
                {
                    after = ChineseConverter.Convert(before, ChineseConversionDirection.TraditionalToSimplified);
                }
                node.ParentNode.ReplaceChild(HtmlTextNode.CreateNode(after), node);
                //node.InnerText.Replace(node.InnerText,after);
                before = ""; after = "";
            }
            xhtmlloder.Close();
            doc.Save(fullpath, System.Text.Encoding.UTF8);
        }
        void compress(string CompressPath)
        {

        }
        void directlyClear()
        {

        }
    }
}
