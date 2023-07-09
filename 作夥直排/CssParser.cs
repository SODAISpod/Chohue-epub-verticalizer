using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChoHoe
{
    internal class CssParser
    {
        StringBuilder _rawCss=new StringBuilder();

        public CssParser(string RawCss) {

            _rawCss.Append( RawCss);





            //這段程式可以找出CSS STYLE 但是還沒解決多巢式class
            ////RawCss=Regex.Replace(RawCss, @"\s+", "");
            //int len= RawCss.Length-1;
            //int index= 0;
            //List<int> leftAno =new List<int>();
            //List<int> rightAno=new List<int>();    
            //List<int> leftQut =new List<int>();
            //List<int> rightQut=new List<int>();
            //List<string> selectorName= new List<string>();




            //    bool flag= false;
            //    bool flagInAnnotation= false;
            //    bool flagInQuote=false;
            //    int selectorLeft = -1;
            //    int selectorRight = -1;

            //while (index < len)
            //{
                
            //    if (index != len)
            //    {
            //        if (RawCss.Substring(index, 2) == "/*")
            //        {
            //            leftAno.Add(index);

            //            //遇到註解，停止尋找selector
            //            flag = false;
            //            flagInAnnotation = true;
            //            if (!flagInQuote)
            //            {

            //                selectorLeft = -1;
            //            }
            //        }
            //        else
            //        {
            //            if (!flagInAnnotation&&!flagInQuote)
            //            {

            //                flag = true;
            //            }
            //        }
            //        if (RawCss.Substring(index, 2) == "*/")
            //        {
            //            rightAno.Add(index);
            //            flagInAnnotation = false;
            //            index += 2;
            //            continue;
                        
            //        }

            //    }
            //    if (RawCss.Substring(index,1) == "{"&&!flagInAnnotation)
            //    {
            //        leftQut.Add(index);
            //        selectorRight = index-1;
            //        selectorName.Add(RawCss.Substring(selectorLeft, selectorRight-selectorLeft));
            //        flag = false;
            //        flagInQuote = true;
            //        selectorLeft= -1;
            //        selectorRight= -1;
                    
                    

            //    }else if (flag==true)
            //    {
            //        if(selectorLeft == -1) {
            //            selectorLeft = index;
            //        }

            //    }
            //    if (RawCss.Substring(index, 1) == "}"&&!flagInAnnotation)
            //    {
            //        rightQut.Add(index);
            //        flagInQuote=false;
            //    }
            //    Console.WriteLine(RawCss.Substring(index, 1));
            //    index++;
            //}
            //string _= RawCss;
        
        }
        public void AppendCSS(string css)
        {
            _rawCss.Append(css);


        }
        public string GetCSS()
        {
            return _rawCss.ToString();
        }
        enum CssGenre
        {
            Style,
            annotation
        }
    }
}
