/*
 * Author:      ezhex1991@outlook.com
 * CreateTime:  6/9/2017 4:09:42 PM
 * Description:
 * 
*/
using UnityEngine;
using XLua;

namespace EZUnity.Example
{
    [LuaCallCSharp]
    public class CheckNull
    {
        public static bool IsNull(Object o)
        {
            return o == null;
        }
    }
}