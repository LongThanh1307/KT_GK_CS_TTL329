namespace GiuaKi.Model;

public class Bao : TaiLieu
{
    public DateTime NgayPh { get; set; }

    public Bao(int maXb, string tenTl, string nhaPhatHanh, int maDanhMuc, DateTime ngayPh) : base(maXb, tenTl, nhaPhatHanh, maDanhMuc)
    {
        NgayPh = ngayPh;
    }
}