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
            finishDueToEpub3LoadingTakeover,
            epunNeedPandocFor2to3
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
        finish

    }
    
}
