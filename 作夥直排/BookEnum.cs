using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ChoHoe
{

        enum ExtensionMethod
        {
            calibre,
            calibreTxtToEpub,
            kindleGen,
            pandoc,
            pandocWithReload,
            kepubify
    }
        enum OpfReadResult
        {
            success,
            fail,
            finishDueToEpub3LoadingTookover,
            epunNeedPandocFor2to3,
            pandocConvertError
        }
    /// <summary>
    /// 載入書本時候回傳的狀態值。
    /// </summary>
    public enum LoadResult
        {
            success,
            fail,
            failPandocReturnError2to3
        }
    enum ExtensionResult
    {
        success,
        fail,
        finish,
        failWithPandocErrors

    }
    
}
