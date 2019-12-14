using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChoHoe
{
    class CssStyle
    {

        private List<string> _RawCss;
        private Regex _regex;
        private string WriteBackSelector;
        private string _RawStyles="";
        private  Dictionary<String,String> Style=new Dictionary<string, string>();
        private Dictionary<String, int> Scope = new Dictionary<String, int>();
        private string _selectorName = "";


        public CssStyle(List<string> Raw, Regex regex,string selectorn)
        {
            if (Raw.Count==0)
            {
               
            }

            _selectorName = selectorn;
            _RawCss= Raw;
            _regex = regex;
            Logger.logger.Info($"FindRawStyle()");
            FindRawStyle();
            Logger.logger.Info($"ProcessRawStyle()");
            ProcessRawStyle();
            
        }

        public void NewReplacement(Regex regex,string selectorn)
        {
            _selectorName = selectorn;
            _regex = regex;
            FindRawStyle();
            ProcessRawStyle();

        }


        private void FindRawStyle()
        {

            Scope.Clear();
            Scope.Add("StartRow", -1);
            Scope.Add("StartPosition", -1);
            Scope.Add("EndRow", -1);
            Scope.Add("EndPosition", -1);

            //htmlScope{StartRow,Html{ position,EndRow,Html} position}
            string htmlStyleText = "";


            Regex _regexfontemb = new Regex(@"[fF][oO][nN][Tt][-][fF][aA][mM][iI][lL][yY]*");//(@"[Bb][Oo][Dd][Yy][\s\S]+[{]");


            Match findHtmlStartResult;

            
            for (int i = 0; i < _RawCss.Count - 1; i++)
            {

                switch (Scope["StartRow"])
                {
                    case -1:
                        findHtmlStartResult = _regex.Match(_RawCss[i]);
                        if (findHtmlStartResult.Success)
                        {
                            Scope["StartRow"] = i;
                            Scope["StartPosition"] = _RawCss[i].IndexOf("{")+1;
                            WriteBackSelector = _RawCss[i].Substring(0, Scope["StartPosition"]);
                            Regex htmlend = new Regex("}");
                            Match findHtmlEndResult = htmlend.Match(_RawCss[i]);

                            if (findHtmlEndResult.Success)
                            {
                                Scope["EndRow"] = i;
                                Scope["EndPosition"] = _RawCss[i].IndexOf("}")-1;
                                Logger.logger.Info($"起始結尾同行");
                            }
                        }


                        break;
                    default:
                        if (Scope["EndRow"] == -1)
                        {

                            Regex htmlend = new Regex("}");
                            Match findHtmlEndResult = htmlend.Match(_RawCss[i]);

                            if (findHtmlEndResult.Success)
                            {
                                Scope["EndRow"] = i;
                                Scope["EndPosition"] = _RawCss[i].IndexOf("}");
                                Logger.logger.Info($"起始結尾不同行");
                            }

                        }

                        break;

                }





                //findHtmlStartResult = _regex.Match(_RawCss[i].ToString());
                //if (findHtmlStartResult.Success)
                //{
                //    Scope["StartRow"] = i;
                //}


            }

            Logger.logger.Debug($"scope:{Scope["StartRow"]},{Scope["StartPosition"]},{Scope["EndRow"]},{Scope["EndPosition"]}");

            if (Scope["StartRow"] != -1 && Scope["EndRow"] != -1)
            {
                if (Scope["StartRow"] == Scope["EndRow"]) //Css style at same row
                {
                    int Stylelength = Scope["EndPosition"] - Scope["StartPosition"];
                    htmlStyleText = _RawCss[Scope["StartRow"]].ToString().Substring(Scope["StartPosition"], Stylelength);
                }
                else
                {
                    for (int i = Scope["StartRow"]; i <= Scope["EndRow"]; i++)
                    {
                        if (i == Scope["StartRow"])
                        {
                            if (_RawCss[i].Length - 1 != Scope["StartPosition"]) //長度等於位置則該行無Style
                            {
                                htmlStyleText += _RawCss[i].ToString().Substring(Scope["StartPosition"]);//括號後
                            }

                        }
                        else if (i == Scope["EndRow"])
                        {
                            if ((_RawCss[i].Length - 1) != Scope["EndPosition"])
                            {
                                htmlStyleText += _RawCss[i].ToString().Substring(Scope["EndPosition"]-1 );//-1括號前
                            }


                        }
                        else
                        {
                            htmlStyleText += _RawCss[i];
                        }

                    }


                }


            }
            _RawStyles = htmlStyleText;
            
            

        }
        public void Replace()
        {
            SetWritingMode();
            string teststring = GetStyleText();

            int insertPosition = Scope["EndRow"] + 1;

            if (Scope["EndRow"]==-1 && Scope["StartRow"]==-1)
            {
                WriteBackSelector = _selectorName + " {";
                _RawCss.Insert(insertPosition, "}");
                _RawCss.Insert(insertPosition, teststring);
                _RawCss.Insert(insertPosition, WriteBackSelector);


                Logger.logger.Info($"無此selector");
                Logger.logger.Info($"Intert to :{insertPosition}");
               
            }
            else if(Scope["EndRow"] != -1)
            {
                _RawCss.Insert(insertPosition, "}");
                _RawCss.Insert(insertPosition, teststring);
                _RawCss.Insert(insertPosition, WriteBackSelector);
                int removeCount = Scope["EndRow"] - Scope["StartRow"] + 1;

                if (Scope["StartRow"] != -1 && Scope["EndRow"] != -1)
                {
                    _RawCss.RemoveRange(Scope["StartRow"], removeCount);
                }


                Logger.logger.Info($"Intert to :{insertPosition}");
                Logger.logger.Info($"Remove range : From {Scope["StartRow"]} remove counts {removeCount}");

            }
            else
            {
                Logger.logger.Error($"Scope有誤");
                Logger.logger.Error($"scope:{Scope["StartRow"]},{Scope["StartPosition"]},{Scope["EndRow"]},{Scope["EndPosition"]}");

            }
          
            



        }
       
        private bool ProcessRawStyle()
        {
            if (_RawStyles=="")
            {
                return false;

            }
            Style.Clear();
            _RawStyles=_RawStyles.Replace(" ", "");

            Logger.logger.Info($"Raw Style:{_RawStyles}");

            char[] delimiterChars = { ';'};
            string[] tempsplited = _RawStyles.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            foreach (String item in tempsplited)
            {
               
                char[] delimiterChars2 = { ':' };
                string[] tempStyle = item.Split(delimiterChars2,StringSplitOptions.RemoveEmptyEntries);
                Style.Add(tempStyle[0], tempStyle[1]);

            }
            return true;
        }
       public void SetWritingMode()
        {
            Logger.logger.Info($"SetWritingMode()");

            Style["writing-mode"] = "vertical-rl";
            Style["-webkit-writing-mode"] = "vertical-rl";
            Style["-epub-writing-mode"] = "vertical-rl";
            
        }
        public string GetStyleText()
        {
            Logger.logger.Info($"GetStyleText()");
            string styleToSend = "";
            foreach (KeyValuePair<string,string> item in Style)
            {
                styleToSend += item.Key + ": " + item.Value+";" + System.Environment.NewLine;

            }
            Logger.logger.Info(System.Environment.NewLine + $"style returning:" + System.Environment.NewLine+ $"{styleToSend}");
            return styleToSend;

        }
        
        public  List<string> GetCss()
        {

            Logger.logger.Info($"return List<string> GetCss()");
            return _RawCss;
        }
    }
}
