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
#endregion

namespace SageFrame.PortalManagement
{
    public class PortalMgrDataProvider
    {
        public static void AddPortal(string PortalName, bool IsParent, string UserName, string TemplateName)
        {

            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>();
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@PortalName", PortalName));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@IsParent", false));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@TemplateName", TemplateName));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@UserName", UserName));

            SQLHandler sagesql = new SQLHandler();
            sagesql.ExecuteNonQuery("sp_PortalAdd", ParaMeterCollection);


        }
        public static void UpdatePortal(int PortalID, string PortalName, bool IsParent, string UserName, string TemplateName)
        {
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>();
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@PortalName", PortalName));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@IsParent", IsParent));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@UserName", UserName));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@TemplateName", TemplateName));

            SQLHandler sagesql = new SQLHandler();
            sagesql.ExecuteNonQuery("[sp_PortalUpdate]", ParaMeterCollection);


        }
        public int AddStoreSubscriber(string storeName, string firstName, string lastName, string email, string companyName, bool? contact, bool? isParent, string username,
           string password, string passwordSalt, int? passwordFormat, bool? isFromFront)
        {
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>();
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@StoreName", storeName));
            
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@FirstName", firstName));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@LastName", lastName));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@Email", email));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@CompanyName", companyName));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@Contact", contact));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@IsParent", isParent));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@UserName", username));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@Password", password));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@PasswordSalt", passwordSalt));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@PasswordFormat", passwordFormat));
            ParaMeterCollection.Add(new KeyValuePair<string, object>("@IsFromFront", isFromFront));
            SQLHandler sagesql = new SQLHandler();            
            int i = sagesql.ExecuteNonQuery("[usp_Aspx_AddStoreSubscriber]", ParaMeterCollection, "@CustomerID");
            return i;
        }
    }
}
