using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Specifies the zoom mode for the <see cref="CoolPrintPreviewControl"/> control.
    /// </summary>
    public enum ZoomMode
    {
        /// <summary>
        /// Show the preview in actual size.
        /// </summary>
        ActualSize,
        /// <summary>
        /// Show a full page.
        /// </summary>
        FullPage,
        /// <summary>
        /// Show a full page width.
        /// </summary>
        PageWidth,
        /// <summary>
        /// Show two full pages.
        /// </summary>
        TwoPages,
        /// <summary>
        /// Use the zoom factor specified by the <see cref="CoolPrintPreviewControl.Zoom"/> property.
        /// </summary>
        Custom
    }
}
