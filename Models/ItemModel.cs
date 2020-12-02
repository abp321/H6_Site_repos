using AbpLib;

namespace H6_Site
{
    public class ItemModel
    {
        private double _price;

        public string ItemName { get; set; }
        public string StoredFile { get; set; }
        public double Price { get { return _price; } set { _price = value.RoundUp(); } }
    }
}
