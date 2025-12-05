
using Events_Management.Data;
using System.Data;
using Events_Management.Models;

namespace Events_Management.Repositories
{
    public class SuKien : ISuKien
    {
        private readonly DataHelper _db;
        public int Delete(int id)
        {
            string sql = @"SELECT SuKienID, TenSuKien, MoTa, ThoiGianBatDau, ThoiGianKetThuc,
                                  DiaDiemID, ToChucID, TrangThai
                           FROM SuKien";

            var dt = DataHelper.GetDataTable(sql);
            var list = new List<SuKien>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new SuKien
                {
                    SuKienID = Convert.ToInt32(row["SuKienID"]),
                    TenSuKien = row["TenSuKien"].ToString() ?? "",
                    MoTa = row["MoTa"] == DBNull.Value ? null : row["MoTa"].ToString(),
                    ThoiGianBatDau = Convert.ToDateTime(row["ThoiGianBatDau"]),
                    ThoiGianKetThuc = Convert.ToDateTime(row["ThoiGianKetThuc"]),
                    DiaDiemID = Convert.ToInt32(row["DiaDiemID"]),
                    ToChucID = Convert.ToInt32(row["ToChucID"]),
                    TrangThai = Convert.ToByte(row["TrangThai"])
                });
            }

            return list;
        }

        public List<SuKien> GetAll()
        {
            throw new NotImplementedException();
        }

        public SuKien? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(SuKien sk)
        {
            throw new NotImplementedException();
        }

        public int Update(SuKien sk)
        {
            throw new NotImplementedException();
        }
    }
}
