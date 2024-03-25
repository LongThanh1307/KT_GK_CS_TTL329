namespace GiuaKi.Model;

public class DanhMuc
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public int maSach { get; set; }
    public int maBao { get; set; }
    public int maTapChi { get; set; }
    
    public DanhMuc(int id, string categoryName, int maSach, int maBao, int maTapChi)
    {
        Id = id;
        CategoryName = categoryName;
        this.maSach = maSach;
        this.maBao = maBao;
        this.maTapChi = maTapChi;
    }
}