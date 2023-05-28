using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.Events;

namespace CodySource
{
    public class WebGL_Clipboard
    {

        #region PUBLIC METHODS

        /// <summary>
        /// Copy to Clipboard
        /// </summary>
        [DllImport("__Internal")]
        public static extern void CopyText(string str);

        #endregion

    }
}