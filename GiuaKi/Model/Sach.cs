namespace GiuaKi.Model;

public class Sach : TaiLieu
{
    public string TenTacGia { get; set; }
    public int SoTrang { get; set; }

    public Sach(int maXb, string tenTl, string nhaPhatHanh, int maDanhMuc, string tenTacGia, int soTrang) : base(maXb, tenTl, nhaPhatHanh, maDanhMuc)
    {
        TenTacGia = tenTacGia;
        SoTrang = soTrang;
    }
}