// See https://aka.ms/new-console-template for more information

using GiuaKi.Model;

internal class Program
{
    private static List<Sach> sachs329 = new List<Sach>
    {
        new Sach(1, "Van Hoc", "Giao Duc", 1, "Long", 100),
        new Sach(2, "Toan", "Giao Duc", 2, "Thanh Long", 200),
    };
    
    private static List<Bao> baos329 = new List<Bao>
    {
        new Bao(1, "Nhan Dan", "Sao Hanh", 1, new DateTime(2024, 3, 13)),
        new Bao(2, "Tuoi Moi", "Ma Dao", 2, new DateTime(2024, 1, 11)),
    };
    
    private static List<TapChi> tapChis329 = new List<TapChi>
    {
        new TapChi(1, "Vietnam", "Dang Khoa", 1, 1, 30),
        new TapChi(2, "Thoi Trang", "Nang", 2, 2, 50),
    };

    private static List<DanhMuc> danhMucs329 = new List<DanhMuc>
    {
        new DanhMuc(1, "Hoc Sinh", 1, 2, 2),
        new DanhMuc(2, "Nguoi Lon", 2, 1, 1),
    };

    private static List<TaiLieu> taiLieus329 = new List<TaiLieu>
    {
    };
    
    public static void Main(string[] args)
    {
        taiLieus329.AddRange(sachs329);
        taiLieus329.AddRange(baos329);
        taiLieus329.AddRange(tapChis329);

        var sachLoc329 = taiLieus329.Where(tl => tl.GetType() == typeof(Sach));
        var baoLoc329 = taiLieus329.Where(tl => tl.GetType() == typeof(Bao));
        var tapChiLoc329 = taiLieus329.Where(tl => tl.GetType() == typeof(TapChi));

        var firstMarch329 = new DateTime(2024, 3, 1);
        var lastMarch329 = new DateTime(2024, 3, 31);
        
        var baoInMarch329 = baos329.Where(b => b.NgayPh >= firstMarch329 && b.NgayPh <= lastMarch329);
    }
}