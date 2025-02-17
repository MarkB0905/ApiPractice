using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JET2.Entities.User
{
    public class UserAddress
    {
        public int UserId { get; set; }
        public string StreetName { get; set; }
        public int StreetNum { get; set; }
        public int BuildingNum { get; set; }
        public string ApartmentNum { get; set; }

        public UserAddress() { }

        public UserAddress(DataRow dr)
        {
            UserId = int.Parse(dr["UserId"].ToString());
            StreetName = (dr["StreetName"].ToString());
            StreetNum = int.Parse(dr["StreetNum"].ToString());
            BuildingNum = int.Parse(dr["BuildingNum"].ToString());
            ApartmentNum = (dr["Apartmentnum"].ToString());
        }
    }
}
