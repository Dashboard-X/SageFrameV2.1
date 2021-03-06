﻿#region "Copyright"

/*
SageFrame® - http://www.sageframe.com
Copyright (c) 2009-2012 by SageFrame
Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

#endregion

#region "References"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SageFrame.Web.Utilities;
using System.Data.SqlClient;

#endregion


namespace SageFrame.PortalSetting
{
    public class PortalProvider
    {
        
        public static List<PortalInfo> GetPortalList()
        {
            try
            {
                SQLHandler SQLH = new SQLHandler();
                return SQLH.ExecuteAsList<PortalInfo>("[dbo].[sp_PortalGetList]");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        
        public static PortalInfo GetPortalByPortalID(int PortalID, string UserName)
        {
            string sp = "[dbo].[sp_PortalGetByPortalID]";
            SqlDataReader reader = null;
            try
            {

                SQLHandler SQLH = new SQLHandler();
                List<KeyValuePair<string, object>> ParamCollInput = new List<KeyValuePair<string, object>>();
                ParamCollInput.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                ParamCollInput.Add(new KeyValuePair<string, object>("@UserName", UserName));


                reader = SQLH.ExecuteAsDataReader(sp, ParamCollInput);
                PortalInfo objList = new PortalInfo();

                while (reader.Read())
                {

                    objList.PortalID = int.Parse(reader["PortalID"].ToString());
                    objList.Name = reader["Name"].ToString();
                    objList.SEOName = reader["SEOName"].ToString();
                    objList.IsParent = bool.Parse(reader["IsParent"].ToString());
                }
                return objList;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

        }
        public static void DeletePortal(int PortalID, string UserName)
        {
            string sp = "[dbo].[sp_PortalDelete]";
            SQLHandler SQLH = new SQLHandler();
            try
            {
                List<KeyValuePair<string, object>> ParamCollInput = new List<KeyValuePair<string, object>>();
                ParamCollInput.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                ParamCollInput.Add(new KeyValuePair<string, object>("@UserName", UserName));

                SQLH.ExecuteNonQuery(sp, ParamCollInput);
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void UpdatePortal(int PortalID, string PortalName, bool IsParent, string UserName)
        {
            string sp = "[dbo].[sp_PortalUpdate]";
            SQLHandler SQLH = new SQLHandler();
            try
            {
                List<KeyValuePair<string, object>> ParamCollInput = new List<KeyValuePair<string, object>>();
                ParamCollInput.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                ParamCollInput.Add(new KeyValuePair<string, object>("@PortalName", PortalName));
                ParamCollInput.Add(new KeyValuePair<string, object>("@IsParent", IsParent));
                ParamCollInput.Add(new KeyValuePair<string, object>("@UserName", UserName));

                SQLH.ExecuteNonQuery(sp, ParamCollInput);
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static List<PortalInfo> GetPortalModulesByPortalID(int PortalID, string UserName)
        {
            try
            {
                SQLHandler SQLH = new SQLHandler();
                List<KeyValuePair<string, object>> ParamCollInput = new List<KeyValuePair<string, object>>();
                ParamCollInput.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                ParamCollInput.Add(new KeyValuePair<string, object>("@UserName", UserName));

                return SQLH.ExecuteAsList<PortalInfo>("[dbo].[sp_PortalModulesGetByPortalID]", ParamCollInput);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        
        public static void UpdatePortalModules(string ModuleIDs, string IsActives, int PortalID, string UpdatedBy)
        {
            string sp = "[dbo].[sp_PortalModulesUpdate]";
            SQLHandler SQLH = new SQLHandler();
            try
            {
                List<KeyValuePair<string, object>> ParamCollInput = new List<KeyValuePair<string, object>>();
                ParamCollInput.Add(new KeyValuePair<string, object>("@ModuleIDs", ModuleIDs));
                ParamCollInput.Add(new KeyValuePair<string, object>("@IsActives", IsActives));
                ParamCollInput.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                ParamCollInput.Add(new KeyValuePair<string, object>("@UpdatedBy", UpdatedBy));

                SQLH.ExecuteNonQuery(sp, ParamCollInput);
            }

            catch (Exception ex)
            {

                throw ex;
            }
        }




    }
}
