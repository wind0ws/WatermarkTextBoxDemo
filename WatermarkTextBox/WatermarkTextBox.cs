using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace CSharpWin
{
      /* 作者：Starts_2000
       * 日期：2009-07-25
       * 网站：http://www.csharpwin.com CS 程序员之窗。
       * 你可以免费使用或修改以下代码，但请保留版权信息。
       * 具体请查看 CS程序员之窗开源协议（http://www.csharpwin.com/csol.html）。
       */

    [ToolboxBitmap(typeof(TextBox))]
    public class WatermarkTextBox : TextBox
    {
        private string _emptyTextTip;
        private Color _emptyTextTipColor = Color.DarkGray;

        private const int WM_PAINT = 0xF;

        public WatermarkTextBox()
            : base()
        {
        }

        [DefaultValue("")]
        public string EmptyTextTip
        {
            get { return _emptyTextTip; }
            set
            {
                _emptyTextTip = value;
                base.Invalidate();
            }
        }

        [DefaultValue(typeof(Color), "DarkGray")]
        public Color EmptyTextTipColor
        {
            get { return _emptyTextTipColor; }
            set
            {
                _emptyTextTipColor = value;
                base.Invalidate();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                WmPaint(ref m);
            }
        }

        private void WmPaint(ref Message m)
        {
            using (Graphics graphics = Graphics.FromHwnd(base.Handle))
            {
                if (Text.Length == 0
                    && !string.IsNullOrEmpty(_emptyTextTip)
                    && !Focused)
                {
                    TextFormatFlags format =
                        TextFormatFlags.EndEllipsis |
                        TextFormatFlags.VerticalCenter;

                    if (RightToLeft == RightToLeft.Yes)
                    {
                        format |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
                    }

                    TextRenderer.DrawText(
                        graphics,
                        _emptyTextTip,
                        Font,
                        base.ClientRectangle,
                        _emptyTextTipColor,
                        format);
                }
            }
        }
    }
}
