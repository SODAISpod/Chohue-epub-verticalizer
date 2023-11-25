using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChoHoe;
using ChoHoe;
using System.Windows.Forms;

namespace ChoHueTestW
{
    [TestClass]
    public class BookTest
    {

        bool dotranslate = false;
        bool totriditional = true;
        bool pageDirection = true;
        bool convertMobi = false;
        bool fontemb = false;
        bool replacepicture = true;
        string booktxt = @"J:\development\EPUB vertical sample file\Dao Jian Shen Yu  04 - Chuan Yuan Li.txt";
        string book20 = @"J:\development\EPUB vertical sample file\2.0.epub";
        string book30 = @"J:\development\EPUB vertical sample file\Fei Dan De Ya Li Ya  27 - Mo Zhe.epub";
        public void OptionConversion()
        {
            MessageBox.Show("test");
            

        }


        [TestMethod]
        public void LoadTxtBook()
        {
            var bk = new Book();
            bk.Load(booktxt, @"C:\");

        }
        [TestMethod]
        public void Load20Book()
        {
            var bk = new Book();
            bk.Load(book20, @"C:\");
            
        }
        [TestMethod]
        public void Load30Book()
        {
            var bk = new Book();
           bk.Load(book30);
            
           
        }
        [TestMethod]
        public void Convert20Book()
        {
            var bk = new Book();
            bk.Load( book20, @"C:\");
            
           
            int debugcount= ChoHueTestW.Properties.Settings.Default.debugCount;
            string debugtext= $"偵錯用 2.0 書本 編號 #{debugcount} 「{bk.GetTitle()}」";
            ChoHueTestW.Properties.Settings.Default.debugCount++;
            ChoHueTestW.Properties.Settings.Default.Save();


            bk.Convert(dotranslate, totriditional, pageDirection, convertMobi, fontemb, replacepicture, bk.GetAuthor(), debugtext);
        }
        [TestMethod]
        public void Convert30Book()
        {
            var bk = new Book();
            bk.Load(book30);
            
           

            int debugcount = ChoHueTestW.Properties.Settings.Default.debugCount;
            string debugtext = $"偵錯用 3.0 書本 編號 #{debugcount} 「{bk.GetTitle()}」";
            ChoHueTestW.Properties.Settings.Default.debugCount++;
            ChoHueTestW.Properties.Settings.Default.Save();


            bk.Convert(dotranslate, totriditional, pageDirection, convertMobi, fontemb, replacepicture, bk.GetAuthor(), debugtext);
        }
        [TestMethod]
        public void ConvertNoCssBook()
        {

          
        }

        [TestMethod]
        public async void CheckNewVersionTrue()
        {
            var cv =new NewVersionCheck();
            var testResult = await cv.HasnewAsync();
            var expected = true;

            Assert.AreEqual(expected, testResult);

        }
        [TestMethod]
        public async void CheckNewVersionFalse()
        {
            var cv = new NewVersionCheck();
            var testResult =await cv.HasnewAsync();
            var expected = false;

            Assert.AreEqual(expected, testResult);

        }
        

    }
}

