/*
 * Author:      熊哲
 * CreateTime:  9/11/2017 6:45:02 PM
 * Description:
 * 
*/
using UnityEngine;

namespace EZComponent.EZProcess
{
    public class EZColorProcess : _EZProcess<Color, ColorPhase>
    {
        protected override void UpdatePhase(float lerp)
        {
            currentValue = Color.Lerp(startValue, endValue, lerp);
        }
    }
}