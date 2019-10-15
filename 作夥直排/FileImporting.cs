using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;
using System.Xml;
using System.Collections;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ChoHoeBV
{
    class FileImporting
    {


        public string    g_loadPath = "",
                         g_tempuncompressedpath = @"temp\unzipping",
                         BasePath = @"temp\unzipping\",
                         g_opfpath = "",
                         Content = "",
                         g_containerXML = @"temp\unzipping\META-INF\container.xml",
                         title = "", author = "",
                         currentFilename = "",
                          g_xhtmlbasedpath="";
        public double       EpubVersion = 0;
        public ArrayList xhtml = new ArrayList(),
                         css = new ArrayList(),
                         single_CSS = new ArrayList();


       public List<string> g_batchbasedname = new List<string>(),
            g_batchopfpath = new List<string>(),
            g_batchcss = new List<string>(),
            g_batchxhtml = new List<string>();

        public int       finish = 0,
                         Batch_or_not=0;
        Making make=new Making();
      //  Form1 form1f = new Form1();

    //---------------------------------------------------------------------------------//
        public string patheditor(string directoryName)
        {
            g_tempuncompressedpath = @"temp\" + directoryName;
            g_containerXML = @"temp\" + directoryName + @"\META-INF\container.xml";
            BasePath = @"temp\" + directoryName+@"\";
            return BasePath;
        }
        public void load(string loadpath)
        {
           


            string _folder_name = System.IO.Path.GetRandomFileName().Replace(".", "");
          

            g_loadPath = loadpath;

            patheditor(_folder_name);
            Uncompressing(loadpath,g_tempuncompressedpath);

            mimetype();
            container(g_containerXML);
            OpfReader();
        }
        public void load(string loadpath,string DirectlyName)
        {
            g_loadPath = loadpath;
           var _tempuseless= patheditor(DirectlyName);
            Uncompressing(loadpath,g_tempuncompressedpath);
           
            mimetype();
            container(g_containerXML);
            OpfReader();
        }
        public void load(string [] _loadpatharray)
        {
            Batch_or_not = 1;

            string _folder_name = System.IO.Path.GetRandomFileName().Replace(".", "");
            foreach (string c in _loadpatharray)
            {
                
                _folder_name = System.IO.Path.GetRandomFileName().Replace(".", "");
                g_loadPath = c;
               g_batchbasedname.Add( patheditor(_folder_name));
                make.ZipFloders.Add(_folder_name); 
                currentFilename = _folder_name;
                Uncompressing(c,g_tempuncompressedpath);
                mimetype();
               g_batchopfpath.Add( container(g_containerXML));
                OpfReader();
            }
            Batch_or_not = 0;

            
        }

        public void Uncompressing(string path,string _uncompresslocation)
        {
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
                
                
                MessageBox.Show(e.ToString());
                Console.WriteLine(e.ToString());
            }
            

        }
        public void mimetype()
        {
           
        }
        public string container(string _containerpath)
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
                            g_opfpath= childnode.Attributes["full-path"].Value;
                            return g_tempuncompressedpath+@"/"+childnode.Attributes["full-path"].Value;
                            if (Batch_or_not==1)
                            {
                                
                                //make.opfImport(childnode.Attributes["full-path"].Value);
                                //form1f.SandOpf.Add(childnode.Attributes["full-path"].Value);
                            }
                            
                        }
                    }
                }
            }
            return "1";
          
        }
        public void OpfReader()
        {

            XmlDocument XDOC = new XmlDocument();
           string _opfrootpath = BasePath + g_opfpath;
            _opfrootpath.Replace(@"/",@"\");
            XDOC.Load(_opfrootpath);
            XmlNode root = XDOC.DocumentElement;

            if (root.Attributes["version"].Value == "3.0")
            {
               
               
            }
            else
            {
               
           //     EpubVersion = Convert.ToInt32( root.Attributes["version"].Value);
                using (System.Diagnostics.Process p = new System.Diagnostics.Process())
                {
                 string namer = System.IO.Path.GetRandomFileName().Replace(".", "");

                    System.Diagnostics.ProcessStartInfo PINFO = new System.Diagnostics.ProcessStartInfo();
                    string argument = "-o " + @""""+"temp/"+namer +".epub"+@""""+ " -t" + " epub3" + " " + @"""" + g_loadPath + @"""";
                    PINFO.Arguments = argument;
                    p.StartInfo = PINFO;
                    p.StartInfo.FileName = @"pandoc.exe";
                    p.StartInfo.Verb = "runas";
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.CreateNoWindow = true;

                    p.Start();

                    //waitforexit 重要 如果未經等待即執行下一步 會造成檔案尚未建立就解壓縮無法讀取的窘境
                    p.WaitForExit();
                    for (int i = 0; i <= make.ZipFloders.Count-1; i++)
                    {
                            if (make.ZipFloders[i].Equals(currentFilename))
                         {
                            currentFilename = namer;
                            make.ZipFloders[i] = namer;

                         }
                    }
                       


                    
                    

                    load(@"temp\"+namer+".epub",namer);

                    return;
                }
                return;
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
                                    css.Add(childnode.Attributes["href"].Value);
                                    g_batchcss.Add(_opfrootpath.Substring(0,_opfrootpath.LastIndexOf(@"\"))+@"\"+ childnode.Attributes["href"].Value);
                                //    string _folderstrinf = g_opfpath + @"\" + childnode.Attributes["href"].Value;
                                //    int _count=0;
                                //  //  for (int i = 0; i < _folderstrinf.Length; i++)
                                ////  {
                                ////在正則表達中單個\有特殊意義 要使用\\方能代表一般所指之\

                                //        _count += Regex.Matches(_folderstrinf,"\\\\").Count;
                                //   //}
                                //    for (int i = 0; i < _count; i++)
                                //    {
                                //        g_xhtmlbasedpath += "../";
                                //    }

                                }

                            }
                        }
                        if (Batch_or_not==1)
                        {
                            single_CSS = css;
                           // form1f.SandCss.Add(css);
                        }
                        foreach (XmlNode childnode in node.ChildNodes)
                        {
                            if (childnode.Name == "item")
                            {
                                if (childnode.Attributes["media-type"].Value == "application/xhtml+xml")
                                {
                                    xhtml.Add(childnode.Attributes["href"].Value);
                                    g_batchxhtml.Add(_opfrootpath.Substring(0, _opfrootpath.LastIndexOf(@"\")) + @"\"+childnode.Attributes["href"].Value);

                                }

                            }
                        }
                        if (Batch_or_not == 1)
                        {
                            //make.htmlImport(xhtml);
                          //  form1f.sandXHtml.Add(xhtml);
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
                        node.Attributes.Remove(node.Attributes["page-progression-direction"]);
                    
                        
                        //move to making
                        //   XmlAttribute _newspine = XDOC.CreateAttribute("page-progression-direction");
                       // _newspine.Value = "rtl";
                       // node.Attributes.Append(_newspine);
                        XDOC.Save(BasePath +g_opfpath);
                    }
                }

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("{0}", e.Source);
                throw;
            }
        }
        



    }
}
