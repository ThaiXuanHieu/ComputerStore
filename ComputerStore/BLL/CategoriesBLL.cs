using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class CategoriesBLL
    {
        private static CategoriesBLL instance;

        public CategoriesBLL()
        {

        }

        public static CategoriesBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CategoriesBLL();
                }
                return instance;
            }
        }

        public DataTable Select()
        {
            return CategoriesDAL.Instance.Select();
        }

        //public CategoriesDTO Select()
        //{
        //    CategoriesDTO category = new CategoriesDTO();
        //    DataTable dataTable = new DataTable();
        //    dataTable = CategoriesDAL.Instance.Select();

        //    foreach(DataRow dataRow in dataTable.Rows)
        //    {
        //        category.CategoryID = Int32.Parse(dataRow["CategoryID"].ToString());
        //        category.CategoryName = dataRow["CategoryName"].ToString();
        //        category.Description = dataRow["Description"].ToString();
        //    }

        //    return category;
        //}
    }
}
