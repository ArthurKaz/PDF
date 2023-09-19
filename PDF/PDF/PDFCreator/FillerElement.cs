namespace PDFCreator
{
    public class FillerElement
    {
        public string Text { get; set; } = "Not entered";
        public float x { get; set; }
        public float y { get; set; }
        public int PageNumer { get; set; } = 1;

        public FillerElement(float x, float y, int pageNumer)
        {
            this.x = x;
            this.y = y;
            if (pageNumer > 0)
            {
                PageNumer = pageNumer;
            }
        }
    }
}
