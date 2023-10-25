using ThucHanhMVC.Models;
namespace ThucHanhMVC.Repository
{
    public interface ILoaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(String maloaiSp);
        TLoaiSp GetLoaiSp(string maloaiSp);

        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
