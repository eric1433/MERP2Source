using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SSoft.Web.Security
{
    public static class User
    {
        public static System.Security.Principal.IIdentity Identity
        {
            get { return System.Web.HttpContext.Current.User.Identity; }
        }
        

       

        //public static bool IsBelongsTo200Group
        //{
        //    get { return ThreeProbe.Web.Security.MemberHelper.BelongsTo200Group(User.Identity.Name); }
        //}

        public static string Emp_No
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["__emp_no"] == null)
                    System.Web.HttpContext.Current.Session["__emp_no"] = "";

                return System.Web.HttpContext.Current.Session["__emp_no"].ToString();
            }
            set { System.Web.HttpContext.Current.Session["__emp_no"] = value; }
        }

        public static string USR_NM
        {
            get 
            {
                if (System.Web.HttpContext.Current.Session["__USR_NM"] == null)
                    System.Web.HttpContext.Current.Session["__USR_NM"] = "";

                return System.Web.HttpContext.Current.Session["__USR_NM"].ToString(); 
            }
            set { System.Web.HttpContext.Current.Session["__USR_NM"] = value; }
        }

        public static string Emp_ID
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["__Emp_ID"] == null)
                    System.Web.HttpContext.Current.Session["__Emp_ID"] = "";

                return Convert.ToString(System.Web.HttpContext.Current.Session["__Emp_ID"]);
            }
            set { System.Web.HttpContext.Current.Session["__Emp_ID"] = value; }
        }

        public static string Last_Logindate
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["__last_logindate"] == null)
                    System.Web.HttpContext.Current.Session["__last_logindate"] = "";

                return System.Web.HttpContext.Current.Session["__last_logindate"].ToString();
            }
            set { System.Web.HttpContext.Current.Session["__last_logindate"] = value; }
        }

        //public static string GipUid
        //{
        //    get
        //    {
        //        if (System.Web.HttpContext.Current.Session["GipUid"] == null)
        //            System.Web.HttpContext.Current.Session["GipUid"] = "";

        //        return System.Web.HttpContext.Current.Session["GipUid"].ToString();
        //    }
        //    set { System.Web.HttpContext.Current.Session["GipUid"] = value; }
        //}

        //public static bool IsPartTime
        //{
        //    get
        //    {
        //        if (System.Web.HttpContext.Current.Session["IsPartTime"] == null)
        //            System.Web.HttpContext.Current.Session["IsPartTime"] = false;

        //        return Convert.ToBoolean(System.Web.HttpContext.Current.Session["IsPartTime"]);
        //    }
        //    set { System.Web.HttpContext.Current.Session["IsPartTime"] = value; }
        //}

        //public static string PartTimeUid
        //{
        //    get
        //    {
        //        if (System.Web.HttpContext.Current.Session["PartTimeUid"] == null)
        //            System.Web.HttpContext.Current.Session["PartTimeUid"] = "";

        //        return System.Web.HttpContext.Current.Session["PartTimeUid"].ToString();
        //    }
        //    set { System.Web.HttpContext.Current.Session["PartTimeUid"] = value; }
        //}

        //public static string MID
        //{
        //    get
        //    {
        //        return System.Web.HttpContext.Current.User.Identity.Name;
        //    }
        //    //set { System.Web.HttpContext.Current.Session["___System_MID"] = value; }
        //}

        //public static string UID
        //{
        //    get
        //    {
        //        return ThreeProbe.Web.Security.User.P2kMember.Uid;
        //    }
        //    //set { System.Web.HttpContext.Current.Session["___System_UID"] = value; }
        //}

        //public static bool IsPowerUser
        //{
        //    get {
        //       int _count =  ThreeProbe.Data.SqlHelper.SelectRowCount(" select * from dbo.HRXfun_PowerUser(@mid)", new System.Data.SqlClient.SqlParameter[] { new  System.Data.SqlClient.SqlParameter("@mid",ThreeProbe.Web.Security.User.MID)});
        //       if (_count > 0)
        //           return true;
        //       return false;
        //    }
        //}

        //public static ThreeProbe.Enums.GroupType GroupType
        //{
        //    get
        //    {
        //        if (System.Web.HttpContext.Current.Session["___GroupType"] == null)
        //                return ThreeProbe.Enums.GroupType._None;

        //        return (ThreeProbe.Enums.GroupType)System.Web.HttpContext.Current.Session["___GroupType"];
        //    }
        //    set { System.Web.HttpContext.Current.Session["___GroupType"] = value; }
        //}
        

        //public static void RecordLogin(string mid,string uid,bool isSuccess)
        //{
        //    string _sql = "insert into HR3LoginRecord( mid,uid,AddDate,IPAddress,FromSource,IsSuccess) values( @mid,@uid,@AddDate,@IPAddress,@FromSource,@isSuccess)";
        //    ThreeProbe.Data.SqlHelper.SelectNonQuery(_sql, new SqlParameter[] { new SqlParameter("@mid", mid),
        //                                                                        new SqlParameter("@uid", uid),
        //                                                                        new SqlParameter("@AddDate", DateTime.Now),
        //                                                                        new SqlParameter("@IPAddress", System.Web.HttpContext.Current.Request.UserHostAddress),
        //                                                                        new SqlParameter("@FromSource", "1"),
        //                                                                        new SqlParameter("@IsSuccess", isSuccess)   });
        //}

        //public static string GroupId
        //{
        //    get
        //    {
        //        if (System.Web.HttpContext.Current.Session["___GroupId"] == null)
        //            return "";

        //        return System.Web.HttpContext.Current.Session["___GroupId"].ToString();
        //    }
        //    set { System.Web.HttpContext.Current.Session["___GroupId"] = value; }
        //}

    }
}
