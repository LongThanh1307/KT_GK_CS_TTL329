namespace GiuaKi.Model;

public abstract class TaiLieu
{
    public int MaXB { get; set; }
    public string TenTl { get; set; }
    public string NhaPhatHanh { get; set; }
    public int MaDanhMuc { get; set; }

    protected TaiLieu(int maXb, string tenTl, string nhaPhatHanh, int maDanhMuc)
    {
        MaXB = maXb;
        TenTl = tenTl;
        NhaPhatHanh = nhaPhatHanh;
        MaDanhMuc = maDanhMuc;
    }
}