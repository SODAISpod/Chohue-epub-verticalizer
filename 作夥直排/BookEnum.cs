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
            pandocWithReload
        }
        enum OpfReadResult
        {
            success,
            fail,
            finishDueToEpub3LoadingTookover,
            epunNeedPandocFor2to3,
            pandocConvertError
        }
    public enum LoadResult
        {
            success,
            fail
        }
    enum ExtensionResult
    {
        success,
        fail,
        finish,
        failWithPandocErrors

    }
    
}
