using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;

namespace HeChuyenGia
{
    /// <summary>
    /// Class biểu diễn 1 định nghĩa trong cơ sở tri thức
    /// </summary>
    internal class DinhNghia
    {
        /// <summary>
        /// Thuộc tính bệnh
        /// </summary>
        public string Benh { get; set; }
        /// <summary>
        /// Thuộc tính dấu hiệu
        /// </summary>
        public string DauHieu { get; set; }
    }
    /// <summary>
    /// Lớp giao tiếp cung cấp giao diện tương tác giữa người dùng
    /// và cơ sở tri thức
    /// </summary>
    public class GiaoTiep
    {
        /// <summary>
        /// Biến lưu giữ các định nghĩa được nạp vào
        /// </summary>
        private static List<DinhNghia> data;
        /// <summary>
        /// Map biểu diễn bệnh và các triệu chứng/dấu hiệu của bệnh
        /// </summary>
        private static Dictionary<string, IList<string>> map;

        /// <summary>
        /// Hàm đọc vào từ cơ sở tri thức.
        /// Sử dụng query prolog
        /// </summary>
        public static void DocVao()
        {
            data = new List<DinhNghia>();
            map = new Dictionary<string, IList<string>>();
            using (var query = new PlQuery("dinh_nghia(Benh, DauHieu)."))
                foreach (var sol in query.SolutionVariables)
                {
                    string benh = sol["Benh"].ToString(), dauhieu = sol["DauHieu"].ToString();
                    data.Add(new DinhNghia { Benh = benh, DauHieu = dauhieu });
                    if (!map.ContainsKey(benh)) map.Add(benh, new List<string>());
                    map[sol["Benh"].ToString()].Add(sol["DauHieu"].ToString());
                }
        }

        /// <summary>
        /// Hàm lấy ra tập dấu hiệu có trong cở sở tri thức
        /// </summary>
        /// <returns>Tập dấu hiệu có trong cơ sở tri thức</returns>
        public static IList<string> TapDauHieu()
        {
            return data.Select(dn => dn.DauHieu).Distinct().ToList();
        }

        /// <summary>
        /// Hàm lấy ra tập dấu hiệu của 1 bệnh cụ thể
        /// Sử trong trong form 2
        /// </summary>
        /// <param name="benh">Bệnh cần lấy các dấu hiệu</param>
        /// <returns></returns>
        public static IList<string> TapDauHieu(string benh)
        {
            return data.Where(dn => dn.Benh == benh).Select(dn => dn.DauHieu).Distinct().ToList();
        }

        /// <summary>
        /// Hàm lấy ra tập các bệnh có trong cơ sở tri thức
        /// </summary>
        /// <returns>Các bệnh có trong cơ sở tri thức</returns>
        public static IList<string> TapBenh()
        {
            return map.Select(x => x.Key).ToList();
        }

        /// <summary>
        /// Hàm lấy ra tập các bệnh có chứa những dấu hiệu cụ thể
        /// </summary>
        /// <param name="dauhieu"></param>
        /// <returns></returns>
        public static IList<string> TapBenh(IList<string> dauhieu)
        {
            return map.Where(item => item.Value.ContainsAll(dauhieu)).Select(item => item.Key).Distinct().ToList();
        }

        /// <summary>
        /// Lấy khuyến nghị cho query truyền vào
        /// </summary>
        /// <param name="co">List triệu chứng có</param>
        /// <param name="khong">List triệu chứng không có</param>
        /// <param name="cauhoi">List triệu chứng cần phải hỏi</param>
        /// <param name="kq">Bệnh tìm được</param>
        /// <returns>true nếu vẫn còn có thể hỏi tiếp hoặc đã tìm ra đáp án, false nếu không thể tìm ra đáp án</returns>
        public static void Suggest(IList<string> co, IList<string> khong, out IList<string> cauhoi, out IList<string> kq)
        {
            cauhoi = new List<string>();
            kq = new List<string>();
            // Lấy ra tất cả các bệnh có trong cơ sở tri thức
            var result = map.Select(x => x.Key);
            // Loại bỏ các bệnh không chứa 'co'
            result = result.Where(s => map[s].ContainsAll(co));
            // Loại bỏ các bệnh có chứa bất kỳ đáp án không nào
            result = result.Where(s => map[s].Intersect(khong).Count() == 0);
            if (result.Count() == 0) return;
            kq = result.ToList();

            // Đưa ra tập các câu hỏi chưa được hỏi
            cauhoi = data.Where(dn => result.Contains(dn.Benh)).Select(dn => dn.DauHieu).Distinct().Where(x => !co.Contains(x)).ToList();
        }
    }
    
    public static class Extension
    {
        public static bool ContainsAll<T>(this IEnumerable<T> _this, IEnumerable<T> x)
        {
            return _this.Intersect(x).Count() == x.Count();
        }
    }
}
