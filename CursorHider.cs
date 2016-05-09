/**
 * CursorHider - Hides the cursor while the UI is hidden
 * Copyright (c) Thomas P. 2016
 * Licensed under the Terms of the MIT license
 */
 
using UnityEngine;

namespace CursorHider
{
    /// <summary>
    /// Registeres handlers for hiding and restoring the cursor
    /// </summary>
    [KSPAddon(KSPAddon.Startup.Instantly, true)]
    public class CursorHider : MonoBehaviour
    {
        /// <summary>
        /// Starts the Plugin
        /// </summary>
        void Awake()
        {
            // Don't die
            DontDestroyOnLoad(this);

            // Register Handlers
            GameEvents.onShowUI.Add(OnUIShow);
            GameEvents.onHideUI.Add(OnUIHide);
        }

        /// <summary>
        /// Called when the UI gets visible
        /// </summary>
        void OnUIShow()
        {
            Cursor.visible = true;
        }

        /// <summary>
        /// Called when the UI gets visible
        /// </summary>
        void OnUIHide()
        {
            Cursor.visible = false;
        }
    }
}