using ExCSS;
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
using ChoHoeBV;
using Ionic.Zlib;
using MetroFramework;
using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChoHoeBV
{
    public class Book
    {
       
        private
           
        List<string> css = new List<string>(), xHtml = new List<string>();
        Dictionary<string, List<string>> imgpath = new Dictionary<string, List<string>>();
        
        

        private
             string  title = "", author = "";
        string _uncompressedPath = "",
               _containerXML = "",
                   _opfPath = "",
                   _OEBPSPath="",
                    _originalFilePath="";

        List<string> gif = new List<string>();
        List<string> png = new List<string>();
        List<string> jpeg = new List<string>();



        public void Load( string _path)
        {
            _originalFilePath = _path;
            imgpath = new Dictionary<string, List<string>>();
            string Fileformat=System.IO.Path.GetExtension(_path);

            if (string.Compare(Fileformat,".epub",true)==0)
            {
                LoadAsEpub(_path);
            }
            else if (string.Compare(Fileformat, ".txt", true) == 0)
            {
                LoadAsTxt();
            }
            else
            {

            }
            
            

        }
        private void LoadAsEpub(string _path) {

            PathEditor();
            Uncompressing(_path, _uncompressedPath);
            Mimetype();
            Container(_containerXML);
            OpfReader();
        }
        private void LoadAsTxt()
        {
            try
            {

                string metadata = $"<dc:title>{Path.GetFileNameWithoutExtension(_originalFilePath)}</dc:title> \n";

                string metadataXml=Path.GetRandomFileName()+".xml";
                System.IO.File.WriteAllText($@"temp/{metadataXml}", metadata);

                using (System.Diagnostics.Process p = new System.Diagnostics.Process())
                {
                    string namer = System.IO.Path.GetRandomFileName().Replace(".", "");

                    System.Diagnostics.ProcessStartInfo PINFO = new System.Diagnostics.ProcessStartInfo();
                    string argument = $@"-o ""temp/{namer}.epub"" -t  epub3 ""{ _originalFilePath }"" --epub-metadata ""temp/{metadataXml}""" ;
                    PINFO.Arguments = argument;
                    p.StartInfo = PINFO;
                    p.StartInfo.FileName = $@"{ChoHoe.Properties.Settings.Default.PandocPath}\pandoc.exe";
                    p.StartInfo.Verb = "runas";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;

                    p.Start();

                    //waitforexit 重要 如果未經等待即執行下一步 會造成檔案尚未建立就解壓縮無法讀取的窘境
                    p.WaitForExit();


                    p.Close();




                    Load($@"temp\{namer}.epub");

                    return;
                }
            }
            catch (Exception e)
            {
                Logger.logger.Fatal($"{e.StackTrace},{e.Message}");
                MessageBox.Show(".txt 文字檔需要使用 Pandoc 以進行轉檔，請至『設定』指定 Pandoc 的路徑。");
                throw;
            }



        }
        public void Load(string path,string pandoc)
        {
            //For unit test uses.
            ChoHoe.Properties.Settings.Default.PandocPath = pandoc;
            ChoHoe.Properties.Settings.Default.Save();
            Load(path);

        }
        public string PathEditor()
        {
          

            string directoryName = System.IO.Path.GetRandomFileName().Replace(".", "");
            Logger.logger.Info($"GetRandomFileName:{directoryName}");
            _uncompressedPath = $@"temp\{directoryName}\";

            Logger.logger.Info($"Uncompressed Path:{_uncompressedPath}");
            // _oebpsPath = _uncompressedPath + "OEBPS" + @"\";
            _containerXML = _uncompressedPath + @"\META-INF\container.xml";

            Logger.logger.Info($"Container.xml Path:{_containerXML}");
            Console.WriteLine("解壓縮の路徑:"+_uncompressedPath);
            return _uncompressedPath;
        }
        private void Uncompressing(string path, string _uncompresslocation)
        {
            Logger.logger.Info($"Uncompressing");
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


                Logger.logger.Error($"Uncompress fail:{e.ToString()}");

                Console.WriteLine(e.ToString());
            }


        }
        private void Mimetype()
        {
            Logger.logger.Info($"Delete Mimetype: {_uncompressedPath + "\\mimetype"}");
            try
            {
                File.Delete(_uncompressedPath + "\\mimetype");
            }
            catch (Exception )
            {
                Logger.logger.Error($"No such Mimetype file at: {_uncompressedPath + "\\mimetype"}");
                throw;
            }
            
        }
        private string Container(string _containerpath)
        {
            Logger.logger.Info($"Read Container: {_containerpath}");
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
                Logger.logger.Error($"{e.ToString()}");
                throw;
            }


        }
        private void OpfWriter(bool PageDirection,bool Img,string Title,string Author)
        {

            Logger.logger.Info($"Writing to opf");

            {
                string PageDirectionString = PageDirection ? "rtl" : "ltr";
                Logger.logger.Debug($"PageDirection : {PageDirectionString}");
                if (Img)
                {
                    Logger.logger.Trace($"True set to replace image in book.");
                    ImgReplace();
                }
                else
                {
                    Logger.logger.Trace($"False set to replace image in book.");
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
                    Logger.logger.Error($"Error while writing to opf: {_opfrootpath} \n ");
                    if (e.Source != null)
                        Logger.logger.Error($"{e.Source}:{e.Message} ");
                    
                    throw;
                }
                XmlWriterSettings writerSettings = new XmlWriterSettings();
                writerSettings.Encoding = new UTF8Encoding(false);
                writerSettings.Indent = true;
                Logger.logger.Trace($"Save to Opf: {_opfrootpath} \n ");
                XmlWriter xmlWriter = XmlWriter.Create(_opfrootpath, writerSettings);
                XDOC.Save(xmlWriter);
                xmlWriter.Flush();
                xmlWriter.Close();
            }
        }
        private void ImgReplace()
        {
            if (imgpath["gif"].Count != 0)
            {


                foreach (string path in imgpath["gif"])


                {
                    Logger.logger.Info($"Replace gif: {path} ");
                    byte[] data; //= System.Convert.FromBase64String(作夥直排.Properties.Resources.JpegReplacement);
                    System.Drawing.Image gif = ChoHoe.Properties.Resources.Replacement_Image;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        gif.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
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
                    Logger.logger.Info($"Replace jpg: {path} ");
                    byte[] data; //= System.Convert.FromBase64String(作夥直排.Properties.Resources.JpegReplacement);
                    System.Drawing.Image jpg = ChoHoe.Properties.Resources.Replacement_Image;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        jpg.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
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
                    Logger.logger.Info($"Replace png: {path} ");
                    byte[] data; //= System.Convert.FromBase64String(作夥直排.Properties.Resources.JpegReplacement);
                    System.Drawing.Image png = ChoHoe.Properties.Resources.Replacement_Image;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        png.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
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
        private void OpfReader()
        {
            
            XmlDocument XDOC = new XmlDocument();
            string _opfrootpath = _uncompressedPath + _opfPath;
           
            _opfrootpath = _opfrootpath.Replace(@"/", @"\");
            Logger.logger.Info($"Opf read: {_opfrootpath} ");
            XDOC.Load(_opfrootpath);
            _OEBPSPath = _opfrootpath.Substring(0, _opfrootpath.LastIndexOf(@"\")) + @"\" ;
            XmlNode root = XDOC.DocumentElement;
            
            imgpath.Add("gif", gif);
            imgpath.Add("png", png);
            imgpath.Add("jpeg", jpeg);


            Logger.logger.Trace($"epub version : {root.Attributes["version"].Value} ");
            if (root.Attributes["version"].Value == "3.0")
            {
                

            }
            else //if (root.Attributes["version"].Value != "3.2")//事實上3.2也會寫成3.0
            {
                

                Logger.logger.Trace($"epub版本為2，進行轉換 ");
                //     EpubVersion = Convert.ToInt32( root.Attributes["version"].Value);
                try
                {

                    using (System.Diagnostics.Process p = new System.Diagnostics.Process())
                    {
                        string namer = System.IO.Path.GetRandomFileName().Replace(".", "");

                        System.Diagnostics.ProcessStartInfo PINFO = new System.Diagnostics.ProcessStartInfo();
                        string argument = $@"-o ""temp/{namer}.epub"" -t  epub3 ""{ _originalFilePath }""";
                        PINFO.Arguments = argument;
                        p.StartInfo = PINFO;
                        p.StartInfo.FileName = $@"{ChoHoe.Properties.Settings.Default.PandocPath}\pandoc.exe";
                        p.StartInfo.Verb = "runas";
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.CreateNoWindow = true;

                        p.Start();

                        //waitforexit 重要 如果未經等待即執行下一步 會造成檔案尚未建立就解壓縮無法讀取的窘境
                        p.WaitForExit();


                        p.Close();




                        Load($@"temp\{namer}.epub");

                        return;
                    }
                }
                catch (Exception e)
                {
                    Logger.logger.Fatal($"{e.StackTrace},{e.Message}");
                    MessageBox.Show("EPUB 2.0 的檔案需要使用 Pandoc 以進行轉檔，請至『設定』指定 Pandoc 的路徑。");
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
                                    
                                    css.Add(_OEBPSPath+childnode.Attributes["href"].Value);
                                   
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

            }
            catch (Exception e)
            {
                Logger.logger.Error($"Error while reading Opf ");
                if (e.Source != null)
                    Logger.logger.Error($"{e.Source}:{e.Message}");
                Console.WriteLine("{0}", e.Source);
                throw;
            }

        }

        public bool Convert(bool DoChineseTransfer,bool ToTradictional,bool pageDirection,bool convertMobi,bool fontEmbed, bool replacePicture,string author,string title)
        {
            this.author = author;
            this.title = title;
            Logger.logger.Info($"CSS Editing ");
            
            foreach (string path in css)
            {
                Logger.logger.Trace($"invoked CSSEdit({path},{fontEmbed})");
                CSSEdit(path, fontEmbed);
                
            }
            Logger.logger.Info($"Html Editing ");
            foreach (string path in xHtml)
            {
                Logger.logger.Trace($"invoked HtmlEdit({path},{DoChineseTransfer},{ToTradictional})");
                HtmlEdit(path,DoChineseTransfer,ToTradictional);
            }
            OpfWriter(pageDirection, replacePicture, title, author);
            ZipUp(convertMobi);
            return true;

        }

        private void HtmlEdit(string path,bool DoTransfer, bool ToTraidional)
        {
            
           // string fullpath = @"temp\unzipping\" + OpfBasedPath + @"\" + url;
            FileStream xhtmlloder = new FileStream(path, FileMode.Open, FileAccess.Read);
            
            StreamReader sr = new StreamReader(xhtmlloder);
           
            string source = sr.ReadToEnd();
            source = HttpUtility.HtmlDecode(source);
            sr.Close();
            xhtmlloder.Close();
           



            var doc = new HtmlAgilityPack.HtmlDocument();
            // doc.OptionOutputAsXml = true;
            bool hasCSSStylesheet = false;
            doc.OptionWriteEmptyNodes = true;
            doc.LoadHtml(source);
            foreach (HtmlNode node in doc.DocumentNode.ChildNodes)
            {
                if (node.Name=="html")
                {
                    foreach (HtmlNode bodynode in node.ChildNodes)
                    {
                        if (bodynode.Name=="head")
                        {
                            foreach (HtmlNode item in bodynode.ChildNodes)
                            {
                                if (item.Name=="link")
                                {
                                    if (item.Attributes["rel"].Value == "stylesheet"&& item.Attributes["type"].Value == "text/css")
                                    {
                                        hasCSSStylesheet = true;
                                    }
                                }
                            }
                            if (hasCSSStylesheet==false)
                            {
                                HtmlNode verticalstyle = doc.CreateElement("style");
                                verticalstyle.InnerHtml = ChoHoe.Properties.Resources.VerticalStyle;
                                bodynode.AppendChild(verticalstyle);
                            }
                        }
                        if (bodynode.Name=="body")
                        {
                            foreach (HtmlNode item in bodynode.ChildNodes)
                            {
                                RecursivelyReplaceText(item,ToTraidional,DoTransfer);
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
        private void RecursivelyReplaceText( HtmlNode innernode,bool toTraditional,bool doTransfer)
        {
            foreach (HtmlNode childinnenode in innernode.ChildNodes)
            {
                
                if (childinnenode.ChildNodes.Count==0)
                {
                    //Logger.logger.Debug($"To translate Xpath { childinnenode.XPath}");
                    string tempinnertext= childinnenode.InnerHtml;

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

                }
                else
                {
                    RecursivelyReplaceText(childinnenode,toTraditional,doTransfer);
                }
            }

        }
        private string EscapeCharacterReplacement(string replacement )
        {
            //if (fuck.Substring(fuck.IndexOf("&") - 1, 1)!= "\\")
            //{
            //    fuck.Remove(fuck.IndexOf("&"), 1);
            //    fuck.Insert(fuck.IndexOf("&"), "&amp;");
            //}

            // Dictionary<string, string> MyDictionary = ChoHoe.Properties.Resources.escapecharacter_txt.Split(',').ToDictionary(x => x.Split('|')[0], x => x.Split('|')[1]);


            return HttpUtility.HtmlEncode(replacement);


        }
        private void CSSEdit(string path,bool fontEmbed)
        {

            

            FileStream fst = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fst);

            List <string> _cssstrings = new List<string>();
            Logger.logger.Info($"Read .css from stream");
            while (sr.EndOfStream != true)
            {
                _cssstrings.Add(sr.ReadLine());
            }
            fst.Close();
            Logger.logger.Debug($"Create file :{path}");
            FileStream rst = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(rst);
            Regex reBody = new Regex(@"[bB][oO][dD][yY][\s]*[{]");
            Regex reHtml = new Regex(@"[Hh][Tt][Mm][Ll][\s]*[{]");
            Logger.logger.Info($"Define CssStyle ");
            Logger.logger.Info($"Replace \"body\" ");
            CssStyle css = new CssStyle(_cssstrings,reBody,"body");
            // _cssstrings = css.Replace();
            css.Replace();
            Logger.logger.Debug($"Replace \"html\" ");
            css.NewReplacement(reHtml,"html");
            css.Replace();
            _cssstrings = css.GetCss();

            //以下待修整




            sw.AutoFlush = true;
            foreach (string item in _cssstrings)
            {
                sw.WriteLine(item);
            }





            //if (htmlStart == -1 | CssSource.IndexOf("html{") == -1)//判定是否皆為true, | <--OR
            //{



            rst.Flush();
            rst.Close();
            

        }
        private void ZipUp(bool convertMobi)
        {

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
                zip.AddDirectory(_uncompressedPath );
                
                zip.EmitTimesInWindowsFormatWhenSaving = false;
                zip.UseZip64WhenSaving = Zip64Option.Never;
                zip.Save();

            }


            if (convertMobi == true)
            {

                if (ChoHoe.Properties.Settings.Default.UseCalibre)
                {
                    using (System.Diagnostics.Process p = new System.Diagnostics.Process())
                    {
                        try
                        {
                            string exeName = "ebook-convert.exe";
                            string outputMobi = outputPath.Substring(0, outputPath.Length - 5);
                            System.Diagnostics.ProcessStartInfo PINFO = new System.Diagnostics.ProcessStartInfo();
                            PINFO.Arguments = $@"""{ outputPath}"" ""{ outputMobi }.mobi"" --mobi-file-type=both";
                            p.StartInfo = PINFO;
                            p.StartInfo.FileName = ChoHoe.Properties.Settings.Default.CalibrePath + "\\" + exeName;
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = false;
                            p.StartInfo.CreateNoWindow = false;
                            p.Start();
                            p.WaitForExit();
                            p.Close();
                        }
                        catch (Exception e)
                        {
                            Logger.logger.Error($"輸出mobi時出現錯誤:{e.Source},{e.Message}");
                            throw;
                        }

                       
                        //Console.Write(p.StandardOutput.ReadToEnd());
                    }
                }
                else
                {
                    using (System.Diagnostics.Process p = new System.Diagnostics.Process())
                    {
                        try
                        {
                            string exeName = "kindlegen.exe";
                            string outputMobi = outputPath.Substring(0, outputPath.Length - 5);
                            string outputfilename = Path.GetFileName(outputMobi);
                            System.Diagnostics.ProcessStartInfo PINFO = new System.Diagnostics.ProcessStartInfo();
                            PINFO.Arguments = $@"""{ outputPath}"" -o ""{ outputfilename }.mobi"" ";
                            p.StartInfo = PINFO;
                            p.StartInfo.FileName = ChoHoe.Properties.Settings.Default.KindlegenPath + "\\" + exeName;
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = false;
                            p.StartInfo.CreateNoWindow = false;
                            p.Start();
                            p.WaitForExit();
                            p.Close();
                        }
                        catch (Exception e)
                        {
                            Logger.logger.Error($"輸出mobi時出現錯誤:{e.Source},{e.Message}");
                            throw;
                        }
                        
                        //Console.Write(p.StandardOutput.ReadToEnd());
                    }
                }
            }

        }
        
        public string GetAuthor()
        {
            return author;
        }
        public string GetTitle()
        {
            return title;
        }
       
    }
    
    
}

