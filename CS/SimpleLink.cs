using System;
using System.Drawing;
using DevExpress.XtraPrinting;

namespace PrintCustomPaperSize
{
    class SimpleLink : Link
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public SimpleLink()
        {

        }

        public SimpleLink(PrintingSystem ps, string text)
            : base(ps)
        {
            this.text = text;
        }

        protected override void CreateDetail(BrickGraphics graph)
        {
            base.CreateDetail(graph);

            SizeF textSize = graph.MeasureString(Text, (int)Math.Round(graph.ClientPageSize.Width));

            RectangleF rect = new RectangleF(0, 0, graph.ClientPageSize.Width, textSize.Height);

            graph.DrawString(text, rect);
        }
    }
}
