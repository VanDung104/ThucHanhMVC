using ThucHanhMVC.Models;

namespace ThucHanhMVC.ViewModels
{
    public class HomeProductDetailViewModel
    {
        public TDanhMucSp danhMucSp { get; set; }
        public List<TAnhSp> anhSps { get; set; }
    }
}
