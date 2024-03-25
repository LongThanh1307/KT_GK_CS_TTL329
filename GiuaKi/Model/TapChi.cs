namespace GiuaKi.Model;

public class TapChi : TaiLieu
{
    public int SoPhatHanh { get; set; }
    public int TrangPhatHanh { get; set; }

    public TapChi(int maXb, string tenTl, string nhaPhatHanh, int maDanhMuc, int soPhatHanh, int trangPhatHanh) : base(maXb, tenTl, nhaPhatHanh, maDanhMuc)
    {
        SoPhatHanh = soPhatHanh;
        TrangPhatHanh = trangPhatHanh;
    }
}