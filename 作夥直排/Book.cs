﻿using ExCSS;
using Ionic.Zip;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web;
using System.Web.UI.WebControls;
using HtmlAgilityPack;
using System.Xml;
using ChoHoe;
using ChoHoe;
using Ionic.Zlib;
using MetroFramework;
using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using NLog;

namespace ChoHoe
{
    public class Book
    {

        private

        List<string> css = new List<string>(), xHtml = new List<string>();
        Dictionary<string, List<string>> imgpath = new Dictionary<string, List<string>>();
        bool isRemoveCss=false;



        private string
             filename ="";
        string _uncompressedPath = "",
               _containerXML = "",
                   _opfPath = "",
                   _OEBPSPath = "",
                    _originalFilePath = "";

        List<string> gif = new List<string>();
        List<string> png = new List<string>();
        List<string> jpeg = new List<string>();

        public string title = "", author = "";
        /// <summary>
        /// 
        /// </summary>
        public bool replacePunctuation { get; set; } = false;
        
        public bool ConvertChinese { get; set; } = false;
        public bool ToTriditional { get; set; } = false;
        public bool pageDirection { get; set; } = false;
        public bool convertMobi { get; set; } = false;
        public bool convertKepub { get; set; } = false;
        public bool fontEmbed { get; set; } = false;
        public bool replacePicture { get; set; } = false;
        public bool clearStylesheet { get; set; }=false;    
        public bool DONOTVerticalize { get; set; }=false;
        public bool AddCustomisedCSS { get; set; } = false;
        public bool turncateTitle { get; set; } = false;
        public bool decodeHTMLBeforeParse { get; set; } = false;

        public LoadResult Load(string _path)
        {
            _originalFilePath = _path;
            filename = Path.GetFileNameWithoutExtension(_path);
            imgpath = new Dictionary<string, List<string>>();
            string Fileformat = System.IO.Path.GetExtension(_path);

            if (string.Compare(Fileformat, ".epub", true) == 0)
            {
               return LoadAsEpub(_path);
            }
            else if (string.Compare(Fileformat, ".txt", true) == 0)
            {
               return LoadAsTxt();
            }
            return LoadResult.success;

        }
        private LoadResult LoadAsEpub(string _path)
        {

            PathEditor();
            Uncompressing(_path, _uncompressedPath);
            Mimetype();
            Container(_containerXML);
            OpfReadResult result = OpfReader();
            if (result == OpfReadResult.pandocConvertError)
            {
                ChoHoe.DoLog.logger.Fatal($"Pandoc filed to process: {_originalFilePath}");
            }
            if (result == OpfReadResult.epunNeedPandocFor2to3 || result == OpfReadResult.pandocConvertError )
            {
                return LoadResult.fail;
            }
            return LoadResult.success;
        }
        private LoadResult LoadAsTxt()
        {
            try
            {
                
                string namer = System.IO.Path.GetRandomFileName().Replace(".", "");                        
                string[] argu = { $@"""{ _originalFilePath }"" ""temp/{namer}.epub"" --epub-version 3 --no-default-epub-cover", namer };


                ExtensionProcess(ExtensionMethod.calibreTxtToEpub, argu);
                return LoadResult.success;

            }
            catch (Exception e)
            {
                DoLog.logger.Fatal($"{e.StackTrace},{e.Message}");
                MessageBox.Show("將txt轉換為epub時發生錯誤!");
                return LoadResult.fail;
                throw;
            }



        }
        public void Load(string path, string pandoc)
        {
            //For unit test uses.
            ChoHoe.Properties.Settings.Default.PandocPath = pandoc;
            ChoHoe.Properties.Settings.Default.Save();
            Load(path);

        }
        public void IsRemoveCss(bool removeCss)
        {
            isRemoveCss = removeCss;
        }
        public string PathEditor()
        {


            string directoryName = System.IO.Path.GetRandomFileName().Replace(".", "");
            DoLog.logger.Info($"GetRandomFileName:{directoryName}");
            _uncompressedPath = $@"temp\{directoryName}\";

            DoLog.logger.Info($"Uncompressed Path:{_uncompressedPath}");
            // _oebpsPath = _uncompressedPath + "OEBPS" + @"\";
            _containerXML = _uncompressedPath + @"\META-INF\container.xml";

            DoLog.logger.Info($"Container.xml Path:{_containerXML}");
            Console.WriteLine("解壓縮の路徑:" + _uncompressedPath);
            return _uncompressedPath;
        }
        private void Uncompressing(string path, string _uncompresslocation)
        {
            DoLog.logger.Info($"Uncompressing");
            //  ClearDirectory(unzipDirectory);
            try
            {
                using (ZipFile zip1 = ZipFile.Read(path))
                {
                    foreach (ZipEntry e in zip1)
                    {
                        e.Extract(_uncompresslocation, ExtractExistingFileAction.OverwriteSilently);

                    }


                }
            }
            catch (Exception e)
            {


                DoLog.logger.Error($"Uncompress fail:{e.ToString()}");

                Console.WriteLine(e.ToString());
                throw;
            }


        }
        private void Mimetype()
        {
            DoLog.logger.Info($"Delete Mimetype: {_uncompressedPath + "\\mimetype"}");
            try
            {
                File.Delete(_uncompressedPath + "\\mimetype");
            }
            catch (Exception)
            {
                DoLog.logger.Error($"No such Mimetype file at: {_uncompressedPath + "\\mimetype"}");
                throw;
            }

        }
        private string Container(string _containerpath)
        {
            DoLog.logger.Info($"Read Container: {_containerpath}");
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(_containerpath);
                XmlNode root = xdoc.DocumentElement;
                foreach (XmlNode node in root.ChildNodes)
                {
                    if (node.Name == "rootfiles")
                    {
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "rootfile")
                            {
                                _opfPath = childnode.Attributes["full-path"].Value;
                                return "0";
                                //return _uncompressedPath + @"/" + childnode.Attributes["full-path"].Value;
                                //if (Batch_or_not == 1)
                                //{

                                //    //make.opfImport(childnode.Attributes["full-path"].Value);
                                //    //form1f.SandOpf.Add(childnode.Attributes["full-path"].Value);
                                //}

                            }
                        }
                    }
                }
                return "1";
            }
            catch (Exception e)
            {
                DoLog.logger.Error($"{e.ToString()}");
                throw;
            }


        }
        private void OpfWriter(bool PageDirection, bool Img, string Title, string Author)
        {

            DoLog.logger.Info($"Writing to opf");

            {
                string PageDirectionString = PageDirection ? "ltr" : "rtl";
                DoLog.logger.Debug($"PageDirection : {PageDirectionString}");
                if (Img)
                {
                    DoLog.logger.Trace($"True set to replace image in book.");
                    ImgReplace();
                }
                else
                {
                    DoLog.logger.Trace($"False set to replace image in book.");
                }
                XmlDocument XDOC = new XmlDocument();
                string _opfrootpath = _uncompressedPath + _opfPath;
                _opfrootpath = _opfrootpath.Replace(@"/", @"\");
                XDOC.Load(_opfrootpath);
                _OEBPSPath = _opfrootpath.Substring(0, _opfrootpath.LastIndexOf(@"\")) + @"\";
                XmlNode root = XDOC.DocumentElement;


                try
                {

                    foreach (XmlNode node in root.ChildNodes)
                    {
                        if (node.Name == "metadata")
                        {
                            foreach (XmlNode titlenode in node.ChildNodes)
                            {
                                if (titlenode.Name == "dc:creator")
                                {
                                    titlenode.InnerText = Author;
                                }
                                if (titlenode.Name == "dc:title")
                                {
                                    titlenode.InnerText = Title;
                                }
                            }
                        }
                        if (node.Name == "manifest")

                        {

                            foreach (XmlNode childnode in node.ChildNodes)
                            {
                                if (childnode.Name == "item")

                                {


                                }
                            }

                        }
                    }
                    foreach (XmlNode node in root.ChildNodes)
                    {
                        if (node.Name == "spine")
                        {
                            //SpineDirection = node.Attributes["page-progression-direction"].Value;

                            //XDOC.SelectSingleNode("package/spine");
                            //XmlAttribute ar = XDOC.CreateAttribute("page-progression-direction");
                            //ar.Value = "rtl";
                            //XDOC.DocumentElement.SetAttributeNode(ar);


                            // page direction attributes has been removed will be append in class making
                            if (node.Attributes["page-progression-direction"] != null)
                            {
                                node.Attributes["page-progression-direction"].Value = PageDirectionString;
                            }
                            else
                            {
                                XmlAttribute pgd = XDOC.CreateAttribute("page-progression-direction");
                                pgd.Value = PageDirectionString;

                                node.Attributes.Append(pgd);
                            }
                            //                        node.Attributes.Remove(node.Attributes["page-progression-direction"]);



                            //move to making
                            //   XmlAttribute _newspine = XDOC.CreateAttribute("page-progression-direction");
                            // _newspine.Value = "rtl";
                            // node.Attributes.Append(_newspine);


                            // XDOC.Save(_oebpsPath + g_opfpath);
                        }
                    }

                }
                catch (Exception e)
                {
                    DoLog.logger.Error($"Error while writing to opf: {_opfrootpath} \n ");
                    if (e.Source != null)
                        DoLog.logger.Error($"{e.Source}:{e.Message} ");

                    throw;
                }
                XmlWriterSettings writerSettings = new XmlWriterSettings();
                writerSettings.Encoding = new UTF8Encoding(false);
                writerSettings.Indent = true;
                DoLog.logger.Trace($"Save to Opf: {_opfrootpath} \n ");
                XmlWriter xmlWriter = XmlWriter.Create(_opfrootpath, writerSettings);
                XDOC.Save(xmlWriter);
                xmlWriter.Flush();
                xmlWriter.Close();
            }
        }
        private void ImgReplace()
        {
            byte[] data;
            bool flag=false;
            try
            {
                System.Drawing.Image check = System.Drawing.Image.FromFile(ChoHoe.Properties.Settings.Default.Setting_CustomizedIMGPath);
            }
            catch (Exception)
            {
                DoLog.logger.Error("Can't load replacement img");
                flag = true;
            }
            System.Drawing.Image pic;
            if (flag||ChoHoe.Properties.Settings.Default.Setting_UseBuiltinIMG)
            {

                pic = ChoHoe.Properties.Resources.Replacement_Image;
            }
            else
            {
                pic = System.Drawing.Image.FromFile(ChoHoe.Properties.Settings.Default.Setting_CustomizedIMGPath);
            }

            if (imgpath["gif"].Count != 0)
            {


                foreach (string path in imgpath["gif"])


                {
                    DoLog.logger.Info($"Replace gif: {path} ");
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pic.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                        data = ms.ToArray();
                    }
                    using (var imageFile = new FileStream(path, FileMode.Create))
                    {
                        imageFile.Write(data, 0, data.Length);
                        imageFile.Flush();
                    }


                }
            }
            if (imgpath["jpeg"].Count != 0)
            {
                foreach (string path in imgpath["jpeg"])
                {
                    DoLog.logger.Info($"Replace jpg: {path} ");
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pic.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        data = ms.ToArray();
                    }
                    using (var imageFile = new FileStream(path, FileMode.Create))
                    {
                        imageFile.Write(data, 0, data.Length);
                        imageFile.Flush();
                    }



                }
            }
            if (imgpath["png"].Count != 0)
            {
                foreach (string path in imgpath["png"])
                {
                    DoLog.logger.Info($"Replace png: {path} ");
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pic.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        data = ms.ToArray();
                    }
                    using (var imageFile = new FileStream(path, FileMode.Create))
                    {
                        imageFile.Write(data, 0, data.Length);
                        imageFile.Flush();
                    }

                }
            }
        }
        private OpfReadResult OpfReader()
        {

            XmlDocument XDOC = new XmlDocument();
            string _opfrootpath = _uncompressedPath + _opfPath;

            _opfrootpath = _opfrootpath.Replace(@"/", @"\");
            DoLog.logger.Info($"Opf read: {_opfrootpath} ");
            XDOC.Load(_opfrootpath);
            _OEBPSPath = _opfrootpath.Substring(0, _opfrootpath.LastIndexOf(@"\")) + @"\";
            XmlNode root = XDOC.DocumentElement;

            imgpath.Add("gif", gif);
            imgpath.Add("png", png);
            imgpath.Add("jpeg", jpeg);


            DoLog.logger.Trace($"epub version : {root.Attributes["version"].Value} ");
            if (root.Attributes["version"].Value == "3.0")
            {


            }
            else //if (root.Attributes["version"].Value != "3.2")//事實上3.2也會寫成3.0
            {

                
                DoLog.logger.Trace($"epub版本為2，進行轉換 ");
                //     EpubVersion = Convert.ToInt32( root.Attributes["version"].Value);
                try
                {
                    string namer = System.IO.Path.GetRandomFileName().Replace(".", "");

                    string[] argu = { $@"-o ""temp/{namer}.epub"" -t  epub3 ""{ _originalFilePath }""", namer };


                    ExtensionResult result = ExtensionProcess(ExtensionMethod.pandocWithReload, argu);

                    if (result==ExtensionResult.fail)
                    {
                        return OpfReadResult.epunNeedPandocFor2to3;
                    }
                    else if (result==ExtensionResult.failWithPandocErrors)
                    {
                        return OpfReadResult.pandocConvertError;
                    }                    

                    return OpfReadResult.finishDueToEpub3LoadingTookover;
                    
                }
                catch (Exception e)
                {
                    DoLog.logger.Fatal($"{e.StackTrace},{e.Message}");
                    MessageBox.Show("EPUB 2.0 的檔案需要使用 Pandoc 以進行轉檔，請至『設定』指定 Pandoc 的路徑。");
                    return OpfReadResult.epunNeedPandocFor2to3;
                    throw;
                }


            }
            try
            {

                foreach (XmlNode node in root.ChildNodes)
                {
                    if (node.Name == "metadata")
                    {
                        foreach (XmlNode titlenode in node.ChildNodes)
                        {
                            if (titlenode.Name == "dc:creator")
                            {
                                author = titlenode.InnerText;
                            }
                            if (titlenode.Name == "dc:title")
                            {
                                title = titlenode.InnerText;
                            }
                        }
                    }
                    if (node.Name == "manifest")

                    {
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "item")
                            {
                                if (childnode.Attributes["media-type"].Value == "text/css")
                                {

                                    css.Add(_OEBPSPath + childnode.Attributes["href"].Value);

                                    // css.Add(_opfrootpath.Substring(0, _opfrootpath.LastIndexOf(@"\")) + @"\" + childnode.Attributes["href"].Value);
                                    //string _folderstrinf = g_opfpath + @"\" + childnode.Attributes["href"].Value;
                                    //int _count = 0;
                                    ////  for (int i = 0; i < _folderstrinf.Length; i++)
                                    ////  {
                                    ////在正則表達中單個\有特殊意義 要使用\\方能代表一般所指之\

                                    //_count += Regex.Matches(_folderstrinf, "\\\\").Count;
                                    ////}
                                    //for (int i = 0; i < _count; i++)
                                    //{
                                    //    //g_xhtmlbasedpath += "../";  !!!!!!!!!!!!!!!!!!
                                    //}

                                }

                            }
                        }

                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "item")

                            {


                                switch (childnode.Attributes["media-type"].Value)
                                {
                                    case "image/gif":
                                        imgpath["gif"].Add(_OEBPSPath + childnode.Attributes["href"].Value);
                                        break;
                                    case "image/jpeg":
                                        imgpath["jpeg"].Add(_OEBPSPath + childnode.Attributes["href"].Value);
                                        break;
                                    case "image/png":
                                        imgpath["png"].Add(_OEBPSPath + childnode.Attributes["href"].Value);
                                        break;
                                    case "application/xhtml+xml":
                                        xHtml.Add(_OEBPSPath + childnode.Attributes["href"].Value);
                                        break;
                                    default:
                                        break;
                                }


                            }
                        }

                    }
                }

                foreach (object good in css)
                {
                    // LogWindowsSender(Convert.ToString(good));
                }
                //  csstobesend = css;
                foreach (XmlNode node in root.ChildNodes)
                {
                    if (node.Name == "spine")
                    {
                        //SpineDirection = node.Attributes["page-progression-direction"].Value;

                        //XDOC.SelectSingleNode("package/spine");
                        //XmlAttribute ar = XDOC.CreateAttribute("page-progression-direction");
                        //ar.Value = "rtl";
                        //XDOC.DocumentElement.SetAttributeNode(ar);


                        // page direction attributes has been removed will be append in class making

                        //                        node.Attributes.Remove(node.Attributes["page-progression-direction"]);



                        //move to making
                        //   XmlAttribute _newspine = XDOC.CreateAttribute("page-progression-direction");
                        // _newspine.Value = "rtl";
                        // node.Attributes.Append(_newspine);


                        // XDOC.Save(_oebpsPath + g_opfpath);
                    }
                }
                return OpfReadResult.success;
            }
            catch (Exception e)
            {
                DoLog.logger.Error($"Error while reading Opf ");
                if (e.Source != null)
                    DoLog.logger.Error($"{e.Source}:{e.Message}");
                Console.WriteLine("{0}", e.Source);
                throw;
            }

        }
        [Obsolete("Deprecated")]
        public bool Convert(bool DoChineseTransfer, bool ToTradictional, bool pageDirection, bool convertMobi, bool fontEmbed, bool replacePicture, string author, string title,bool toReplacePunctuation)
        {
            this.author = author;
            this.title = title;
            DoLog.logger.Info($"Editing C");
            replacePunctuation = toReplacePunctuation;

            foreach (string path in css)
            {
                DoLog.logger.Trace($"invoked CSSEdit({path},{fontEmbed})");
                CSSEdit(path, fontEmbed);

            }
            DoLog.logger.Info($"Html Editing ");
            foreach (string path in xHtml)
            {
                DoLog.logger.Trace($"invoked HtmlEdit({path},{DoChineseTransfer},{ToTradictional})");
                HtmlEdit(path, DoChineseTransfer, ToTradictional);
            }
            OpfWriter(pageDirection, replacePicture, title, author);
            ZipUp(convertMobi);
            return true;
           
        }
        
        public bool Convert()
        {
            this.author = author;
            this.title = title;
            if (turncateTitle)
            {
                 TurncateTitle();

            }
            DoLog.logger.Info($"Editing C");
            //replacePunctuation = toReplacePunctuation;

            foreach (string path in css)
            {
                DoLog.logger.Trace($"invoked CSSEdit({path},{fontEmbed})");
                CSSEdit(path, fontEmbed);

            }
            DoLog.logger.Info($"Html Editing ");
            foreach (string path in xHtml)
            {
                DoLog.logger.Trace($"invoked HtmlEdit({path},{ConvertChinese},{ToTriditional})");
                HtmlEdit(path, ConvertChinese, ToTriditional);
            }
            OpfWriter(pageDirection, replacePicture, title, author);
            ZipUp(convertMobi);
            return true;
        }

        private void HtmlEdit(string path, bool DoTransfer, bool ToTraidional)
        {

            // string fullpath = @"temp\unzipping\" + OpfBasedPath + @"\" + url;
            FileStream xhtmlloder = new FileStream(path, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(xhtmlloder);

            string source = sr.ReadToEnd();
            if (decodeHTMLBeforeParse)
            {

                source = HttpUtility.HtmlDecode(source);

            }
            sr.Close();
            xhtmlloder.Close();




            var doc = new HtmlAgilityPack.HtmlDocument();
            
            bool hasCSSStylesheet = false;
            doc.OptionWriteEmptyNodes = true;
            doc.OptionOutputOriginalCase = true;
            doc.LoadHtml(source);
            foreach (HtmlNode node in doc.DocumentNode.ChildNodes)
            {
                if (node.Name == "html")
                {
                    foreach (HtmlNode bodynode in node.ChildNodes)
                    {
                        if (bodynode.Name == "head")
                        {
                            foreach (HtmlNode item in bodynode.ChildNodes)
                            {
                                if (item.Name == "link")
                                {
                                    if (item.Attributes["rel"].Value == "stylesheet") //&& item.Attributes["type"].Value == "text/css"
                                    {
                                        hasCSSStylesheet = true;
                                    }
                                }
                            }
                            if (hasCSSStylesheet == false)
                            {
                                HtmlNode verticalstyle = doc.CreateElement("style");
                                verticalstyle.InnerHtml = ChoHoe.Properties.Resources.VerticalStyle;
                                bodynode.AppendChild(verticalstyle);
                            }
                        }
                        if (bodynode.Name == "body")
                        {
                            foreach (HtmlNode body_child_Node in bodynode.ChildNodes)
                            {
                                RecursivelyReplaceText(body_child_Node, ToTraidional, DoTransfer);
                                if (isRemoveCss)
                                {
                                    RemoveHtmlStyle(body_child_Node);
                                }
                                 
                            }
                        }

                    }
                }

                //if (ToTradictional == true)
                //{
                //    after = ChineseConverter.Convert(before, ChineseConversionDirection.SimplifiedToTraditional);
                //}
                //else
                //{
                //    after = ChineseConverter.Convert(before, ChineseConversionDirection.TraditionalToSimplified);
                //}
                //node.ParentNode.ReplaceChild(HtmlTextNode.CreateNode(after), node);
                //node.InnerText.Replace(node.InnerText,after);

            }
            //  Console.WriteLine(doc.DocumentNode.InnerHtml);
            FileStream sw = new FileStream(path, FileMode.Create);
            //  doc.DocumentNode.InnerHtml=  HttpUtility.HtmlEncode(doc.ParsedText);
            doc.Save(sw, System.Text.Encoding.UTF8);
            

            sw.Close();
        }
        private void RemoveHtmlStyle(HtmlNode subBodyNode)
        {
             
            foreach (HtmlNode childInnerNode in subBodyNode.ChildNodes)
            {
                foreach (var attribute in childInnerNode.Attributes )
                {
                    if (attribute.Name=="style")
                    {
                        //attribute.Value = "";
                        attribute.Remove();
                        break;
                    }

                }
                if (childInnerNode.ChildNodes.Count!=0)
                {
                    RemoveHtmlStyle(childInnerNode);
                }
            }
        }
        /// <summary>
        /// toTradition: 翻成繁體, replacePunctuation: 取代橫式標點符號成直式
        ///
        /// </summary>
        /// <param name="innernode"></param>
        /// <param name="toTraditional">翻成繁體</param>
        /// <param name="doTransfer">是否要進行轉檔，其他選項必須先滿足轉檔為是</param>
        /// <param name="replacePunctuation">取代橫式標點符號成直式</param>
        private void RecursivelyReplaceText(HtmlNode innernode, bool toTraditional, bool doTransfer)
        {
          

            foreach (HtmlNode childinnenode in innernode.ChildNodes)
            {

                if (childinnenode.ChildNodes.Count == 0)
                {
                    //DoLog.logger.Debug($"To translate Xpath { childinnenode.XPath}");
                    string tempinnertext = childinnenode.InnerHtml;

                    // tempinnertext = HttpUtility.HtmlDecode(tempinnertext);

                    if (doTransfer)
                    {
                        if (toTraditional)
                        {
                            childinnenode.InnerHtml = ChineseConverter.Convert(tempinnertext, ChineseConversionDirection.SimplifiedToTraditional);
                        }
                        else
                        {
                            childinnenode.InnerHtml = ChineseConverter.Convert(tempinnertext, ChineseConversionDirection.TraditionalToSimplified);
                        }
                    }
                    childinnenode.InnerHtml = EscapeCharacterReplacement(childinnenode.InnerHtml);
                    if (replacePunctuation)
                    {

                        childinnenode.InnerHtml = PunctuationReplacement(childinnenode.InnerHtml);//取代標點
                    }

                }
                else
                {
                    RecursivelyReplaceText(childinnenode, toTraditional, doTransfer);
                }
            }

        }
        /// <summary>
        /// 取代字串中的符號至直排符號
        /// </summary>
        /// <param name="rawString"></param>
        /// <returns></returns>
        private string PunctuationReplacement(string rawString)
        {

            StringBuilder sb = new StringBuilder(rawString);
            sb.Replace("「", "﹁");//橫式左引號
            sb.Replace("“", "﹁"); //中式左引號
            sb.Replace("”", "﹂"); //中式右引號
            sb.Replace("『", "﹃");//內部左引號
            sb.Replace("‘", "﹃"); //中式左引號
            sb.Replace("’", "﹄"); //中式右引號
            sb.Replace("』", "﹄");//內部右引號
            sb.Replace("」", "﹂");//橫式右引號
            sb.Replace("（", "︵");//橫式右括號
            sb.Replace("）", "︶");//橫式左括號
            sb.Replace("\uFE10", "\uFF0C");//逗號，
            


            return sb.ToString();



        }

        private string EscapeCharacterReplacement(string replacement)
        {
            //if (fuck.Substring(fuck.IndexOf("&") - 1, 1)!= "\\")
            //{
            //    fuck.Remove(fuck.IndexOf("&"), 1);
            //    fuck.Insert(fuck.IndexOf("&"), "&amp;");
            //}

            // Dictionary<string, string> MyDictionary = ChoHoe.Properties.Resources.escapecharacter_txt.Split(',').ToDictionary(x => x.Split('|')[0], x => x.Split('|')[1]);


            return HttpUtility.HtmlEncode(replacement);


        }
        private void CSSEdit(string path, bool fontEmbed)
        {



            FileStream fst = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fst);

            List<string> _cssstrings = new List<string>();
            DoLog.logger.Info($"Read .css from stream");
            if (!clearStylesheet)
            {
                while (sr.EndOfStream != true)
                {
                    _cssstrings.Add(sr.ReadLine());
                }
            }

            
            fst.Position = 0;
            //sr.DiscardBufferedData();
            //string fullCss = sr.ReadToEnd();
            fst.Close();

            




            DoLog.logger.Debug($"Create file :{path}");
            FileStream rst = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(rst);
            Regex reBody = new Regex(@"[bB][oO][dD][yY][\s]*[{]");
            Regex reHtml = new Regex(@"[Hh][Tt][Mm][Ll][\s]*[{]");
            DoLog.logger.Info($"Define CssStyle ");
            DoLog.logger.Info($"Replace \"body\" ");
            LagecyCssStyle css = new LagecyCssStyle(_cssstrings, reBody, "body");
            // _cssstrings = css.Replace();
            if (!DONOTVerticalize)
            {
                css.Replace(true);
                DoLog.logger.Debug($"Replace \"html\" ");
                css.NewReplacement(reHtml, "html");
                css.Replace(true);
            }
            
     


            CssParser cssParser = new CssParser(css.GetFullCss());
            if (AddCustomisedCSS)
            {
                cssParser.AppendCSS(ChoHoe.Properties.Settings.Default.CustomizedCSS);

            }
            


            //以下待修整




            sw.AutoFlush = true;

            sw.Write(cssParser.GetCSS());

            //foreach (string item in _cssstrings)
            //{
            //    sw.WriteLine(item);
            //}





            //if (htmlStart == -1 | CssSource.IndexOf("html{") == -1)//判定是否皆為true, | <--OR
            //{



            rst.Flush();
            rst.Close();


        }
        //prevent writing invalid filename
        private string InvalidFileNameReplacement(string FileName)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>() {

                {"<"," " },{">"," "},{":","："},{"\""," "},{"\\"," "},{"//"," "},{"|"," "},{"?"," "},{"*"," "}

            };
            foreach (KeyValuePair<string,string> keyword in pairs )
            {
               
               FileName =FileName.Replace(keyword.Key, keyword.Value);
            }
            return FileName;
        }
        private void ZipUp(bool convertMobi)
        {
            title = InvalidFileNameReplacement(title);
            string filenameEPUB = title + ".epub";

            string outputPath = $@"output\{filenameEPUB}";
            string outputTittle = filenameEPUB;
            string fileExsistedIndexing = title;
            if (!Directory.Exists("output"))
            {
                try
                {
                    System.IO.Directory.CreateDirectory("output");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Source.ToString());
                    throw;
                }

            }
            if (System.IO.File.Exists($@"output\{filenameEPUB}"))
            {
                int indexx = 1;
                outputPath = $@"output\{title} ({indexx}) .epub";
                outputTittle = $"{ title }  ({indexx}).epub";
                while (System.IO.File.Exists(outputPath))
                {
                    indexx += 1;
                    outputPath = $@"output\{title} ({indexx}) .epub";
                    outputTittle = $"{ title }  ({indexx}).epub";

                }
                // zip.Save( outputPath);
            }
            else
            {
                // zip.Save(outputPath);
            }



            using (ZipOutputStream zs = new ZipOutputStream(outputPath))
            {
                var o = zs.PutNextEntry("mimetype");
                o.CompressionLevel = CompressionLevel.None;

                byte[] mimetype = System.Text.Encoding.ASCII.GetBytes("application/epub+zip");
                zs.Write(mimetype, 0, mimetype.Length);



            }
            using (ZipFile zip = new ZipFile(outputPath))
            {

                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.None;
                // zip.AddFile(_uncompressedPath + "mimetype", "");
                zip.AddDirectory(_uncompressedPath);

                zip.EmitTimesInWindowsFormatWhenSaving = false;
                zip.UseZip64WhenSaving = Zip64Option.Never;
                zip.Save();

            }


            if (convertMobi == true)
            {
               

                if (ChoHoe.Properties.Settings.Default.UseCalibre)
                {

                    string outputfilename = Path.GetFileNameWithoutExtension(outputPath);
                    string[] argu = { $@"""{ outputPath}"" ""{"output\\"}{ outputfilename }.mobi""  --mobi-file-type=both " };
                    ExtensionProcess(ExtensionMethod.calibre, argu);
                }
                else
                {//todo compress option -c2 -donotaddsource
                    string outputfilename = Path.GetFileNameWithoutExtension(outputPath);
                    string[] argu = { $@"""{ outputPath}"" -o ""{ outputfilename }.mobi"" -c1 -dont_append_source" };
                    ExtensionProcess(ExtensionMethod.kindleGen, argu);

                }
            }
            if (convertKepub)
            {
                string outputfilename = Path.GetFileNameWithoutExtension(outputPath);
                string[] argu = { $@"""{outputPath}"" --output ""output\{outputfilename}.kepub.epub"" " };
                ExtensionProcess(ExtensionMethod.kepubify, argu);
            }

        }

        private ExtensionResult ExtensionProcess(ExtensionMethod method, string[] argum)
        {
            string ExtensionPath = "";

            switch (method)
            {
                case ExtensionMethod.calibreTxtToEpub:
                case ExtensionMethod.calibre:
                    ExtensionPath = ChoHoe.Properties.Settings.Default.CalibrePath + "\\" + "ebook-convert.exe";
                    if (!ExtensionChecker.calibreStatus)
                    {
                        MessageBox.Show($"需要使用 calibre 以進行轉檔，請至『設定』指定 Pandoc 的路徑。({title})");
                        return ExtensionResult.fail;
                    }
                    break;
                case ExtensionMethod.kindleGen:
                    ExtensionPath = ChoHoe.Properties.Settings.Default.KindlegenPath + "\\" + "kindlegen.exe";
                    if (!ExtensionChecker.kindleGenStatus)
                    {
                        MessageBox.Show($"需要使用 kindlegen 以進行轉檔，請至『設定』指定 Pandoc 的路徑。({title})");
                        return ExtensionResult.fail;
                    }
                    break;
                case ExtensionMethod.pandoc:
                case ExtensionMethod.pandocWithReload:

                    ExtensionPath = ChoHoe.Properties.Settings.Default.PandocPath + "\\" + "pandoc.exe";
                    if (!ExtensionChecker.pandocStatus)
                    {
                        MessageBox.Show($"需要使用 pandoc 以進行轉檔，請至『設定』指定 Pandoc 的路徑。({filename})");
                        return ExtensionResult.fail;
                    }
                    break;
                case ExtensionMethod.kepubify:

                    ExtensionPath = $"{ChoHoe.Properties.Settings.Default.kepubifyPath}\\kepubify-windows-64bit.exe";
                    if (!ExtensionChecker.kepubfyStatus)
                    {
                        MessageBox.Show($"需要使用 kepubify 以進行轉檔，請至『設定』指定 kepubify 的路徑。({filename})");
                        return ExtensionResult.fail;
                    }
                    break;
                   

            }

            using (System.Diagnostics.Process p = new System.Diagnostics.Process())
            {
                try
                {

                    //argum[0]=arguments for processes.
                    //argum[1]=reloading filename

                    StringBuilder output = new StringBuilder();

                    System.Diagnostics.ProcessStartInfo PINFO = new System.Diagnostics.ProcessStartInfo();
                    PINFO.Arguments = argum[0];
                    p.StartInfo = PINFO;
                    p.StartInfo.FileName = ExtensionPath;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
                    p.Start();
                    output.AppendLine($"Process method: {method.ToString()}");
                    while (!p.StandardOutput.EndOfStream)
                    {
                        
                         output.AppendLine(p.StandardOutput.ReadLine());
                        
                    }

                    p.WaitForExit();
                    int result = p.ExitCode;

                    output.AppendLine(System.Environment.NewLine);
                    ChoHoe.DoLog.logger.Debug(output.ToString());
                    p.Close();

                    DoLog.ProcessErrorMessage(output.ToString());
                    switch (method)
                    {
                        case ExtensionMethod.calibreTxtToEpub:
                            Load($@"temp\{argum[1]}.epub");
                            
                            break;
                        case ExtensionMethod.calibre:
                            
                            break;
                        case ExtensionMethod.kindleGen:
                            if (result == 2)
                            {
                                MessageBox.Show("kindlegen發生錯誤，無法輸出mobi檔");
                                return ExtensionResult.fail;
                            }
                            break;
                        case ExtensionMethod.pandoc:
                            if (result == 0)
                            {
                                return ExtensionResult.success;
                            }
                            else
                            {

                                ChoHoe.DoLog.logger.Fatal($"Pandoc returned Error with:{result}");
                                return ExtensionResult.failWithPandocErrors;

                            }

                            //3   PandocFailOnWarningError
                            //4   PandocAppError
                            //5   PandocTemplateError
                            //6   PandocOptionError
                            //21  PandocUnknownReaderError
                            //22  PandocUnknownWriterError
                            //23  PandocUnsupportedExtensionError
                            //31  PandocEpubSubdirectoryError
                            //43  PandocPDFError
                            //47  PandocPDFProgramNotFoundError
                            //61  PandocHttpError
                            //62  PandocShouldNeverHappenError
                            //63  PandocSomeError
                            //64  PandocParseError
                            //65  PandocParsecError
                            //66  PandocMakePDFError
                            //67  PandocSyntaxMapError
                            //83  PandocFilterError
                            //91  PandocMacroLoop
                            //92  PandocUTF8DecodingError
                            //93  PandocIpynbDecodingError
                            //97  PandocCouldNotFindDataFileError
                            //99  PandocResourceNotFound
                            break;
                        case ExtensionMethod.pandocWithReload:
                            if (result != 0)
                            {
                                return ExtensionResult.failWithPandocErrors;
                            }
                            else
                            {

                                Load($@"temp\{argum[1]}.epub");
                            }
                            break;

                    }
                    return ExtensionResult.finish;
                }
                catch (Exception e)
                {
                    DoLog.logger.Error($"輸出{argum.ToString()}時出現錯誤:{e.Source},{e.Message}");
                    return ExtensionResult.fail;
                    throw;
                }

                //Console.Write(p.StandardOutput.ReadToEnd());
            }




        }
        public void TurncateTitle()
        {
            string _title=GetTitle();
            int length = _title.Length;
            if (length > 18)
            {
                _title=$"{_title.Substring(0,9)}…{_title.Substring(length-8,8)}";

            }
            SetTitle( _title );
        }
        
        public string GetAuthor()
        {
            return author;
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string setTitle)
        {
            title = setTitle;
        }
        public void SetAuthor(string setAuthor)
        {
            author = setAuthor;
        }

    }


}

