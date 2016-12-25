using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;

namespace HeChuyenGia
{
    internal class DinhNghia
    {
        public string Benh { get; set; }
        public string DauHieu { get; set; }
    }
    public class GiaoTiep
    {
        private static List<DinhNghia> data;
        private static Dictionary<string, IList<string>> map;
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
        public static IList<string> TapDauHieu()
        {
            return data.Select(dn => dn.DauHieu).Distinct().ToList();
        }
        public static IList<string> TapDauHieu(string benh)
        {
            return data.Where(dn => dn.Benh == benh).Select(dn => dn.DauHieu).Distinct().ToList();
        }

        public static IList<string> TapBenh()
        {
            return data.Select(dn => dn.Benh).Distinct().ToList();
        }
        public static IList<string> TapBenh(IList<string> dauhieu)
        {
            return map.Where(item => item.Value.Intersect(dauhieu).Count() == dauhieu.Count()).Select(item => item.Key).Distinct().ToList();
        }
    }
    
}
