using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersBLL
    {
        private static UsersBLL instance;

        public UsersBLL()
        {

        }

        public static UsersBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UsersBLL();
                }
                return instance;
            }
        }


        public List<UsersDTO> GetUsers()
        {
            DataTable dataTable = UsersDAL.Instance.Select();

            List<UsersDTO> users = new List<UsersDTO>();
            foreach(DataRow dataRow in dataTable.Rows)
            {
                UsersDTO user = new UsersDTO();
                user.UserID = Int32.Parse(dataRow["UserID"].ToString());
                user.FullName = dataRow["FullName"].ToString();
                user.UserName = dataRow["UserName"].ToString();
                user.Password = dataRow["Password"].ToString();
                user.Email = dataRow["Email"].ToString();
                user.Phone = dataRow["Phone"].ToString();

                users.Add(user);
            }
            return users;
        }

        public UsersDTO GetByUerNameAndPassword(string _userName, string _password)
        {
            UsersDTO user = new UsersDTO();
            DataTable dataTable = new DataTable();
            dataTable = UsersDAL.Instance.Select(_userName, _password);
            foreach(DataRow dataRow in dataTable.Rows)
            {
                user.UserID = Int32.Parse(dataRow["UserID"].ToString());
                user.FullName = dataRow["FullName"].ToString();
                user.UserName = dataRow["UserName"].ToString();
                user.Password = dataRow["Password"].ToString();
                user.Email = dataRow["Email"].ToString();
                user.Phone = dataRow["Phone"].ToString();
            }
            return user;
        }

        public void Insert(string _fullName, string _userName, string _password)
        {
            UsersDAL.Instance.Insert(_fullName, _userName, _password);
        }
    }
}
