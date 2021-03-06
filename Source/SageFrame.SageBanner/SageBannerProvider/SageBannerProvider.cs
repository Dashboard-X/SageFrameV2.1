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
using SageFrame.SageBannner.Controller;
using SageFrame.SageBannner.Info;
using SageFrame.Web.Utilities;
using System.Data;
using System.Data.SqlClient;
using SageFrame.Web;
using SageFrame.SageBannner.SettingInfo;
#endregion

namespace SageFrame.SageBannner.Provider
{
    public class SageBannerProvider
    {
        public void SaveBannerContent(SageBannerInfo obj)
        {
            try
            {
                List<KeyValuePair<string, object>> param = new List<KeyValuePair<string, object>>();
                param.Add(new KeyValuePair<string, object>("@Caption", obj.Caption));
                param.Add(new KeyValuePair<string, object>("@ImagePath", obj.ImagePath));
                param.Add(new KeyValuePair<string, object>("@ReadMorePage", obj.ReadMorePage));
                param.Add(new KeyValuePair<string, object>("@LinkToImage", obj.LinkToImage));
                param.Add(new KeyValuePair<string, object>("@UserModuleID", obj.UserModuleID));
                param.Add(new KeyValuePair<string, object>("@BannerID", obj.BannerID));
                param.Add(new KeyValuePair<string, object>("@ImageID", obj.ImageID));
                param.Add(new KeyValuePair<string, object>("@ReadButtonText", obj.ReadButtonText));
                param.Add(new KeyValuePair<string, object>("@NavigationImage", obj.NavigationImage));
                param.Add(new KeyValuePair<string, object>("@Description", obj.Description));
                param.Add(new KeyValuePair<string, object>("@PortalID", obj.PortalID));
                param.Add(new KeyValuePair<string, object>("@CultureCode", obj.CultureCode));
                SQLHandler sagesql = new SQLHandler();
                sagesql.ExecuteNonQuery("usp_SageBannerSaveBannerContent", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void SaveBannerInformation(SageBannerInfo objB)
        {
            try
            {
                List<KeyValuePair<string, object>> para = new List<KeyValuePair<string, object>>();
                para.Add(new KeyValuePair<string, object>("@BannerName", objB.BannerName));
                para.Add(new KeyValuePair<string, object>("@BannerDescription", objB.BannerDescription));
                para.Add(new KeyValuePair<string, object>("@UserModuleID", objB.UserModuleID));
                para.Add(new KeyValuePair<string, object>("@PortalID", objB.PortalID));
                para.Add(new KeyValuePair<string, object>("@CultureCode", objB.CultureCode));
                SQLHandler sagesql = new SQLHandler();
                sagesql.ExecuteNonQuery("usp_SageBannerSaveBannerInformation", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public List<SageBannerInfo> LoadBannerImagesOnGrid(int BannerID, int UserModuleID, int PortalID, string CultureCode)
        {
            try
            {
                List<KeyValuePair<string, object>> Parameter = new List<KeyValuePair<string, object>>();
                Parameter.Add(new KeyValuePair<string, object>("@BannerID", BannerID));
                Parameter.Add(new KeyValuePair<string, object>("@UserModuleID", UserModuleID));
                Parameter.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                Parameter.Add(new KeyValuePair<string, object>("@CultureCode", CultureCode));
                SQLHandler sqlH = new SQLHandler();
                return sqlH.ExecuteAsList<SageBannerInfo>("[usp_SageBannerLoadBannerImagesOnGrid]", Parameter);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public List<SageBannerInfo> LoadHTMLContentOnGrid(int BannerID, int UserModuleID, int PortalID, string CultureCode)
        {
            try
            {
                List<KeyValuePair<string, object>> Parameter = new List<KeyValuePair<string, object>>();
                Parameter.Add(new KeyValuePair<string, object>("@BannerID", BannerID));
                Parameter.Add(new KeyValuePair<string, object>("@UserModuleID", UserModuleID));
                Parameter.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                Parameter.Add(new KeyValuePair<string, object>("@CultureCode", CultureCode));
                SQLHandler sqlH = new SQLHandler();
                return sqlH.ExecuteAsList<SageBannerInfo>("[usp_SageBannerLoadBannerHTMLContentOnGrid]", Parameter);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        public List<SageBannerInfo> LoadBannerListOnGrid(int PortalID, int UserModuleID, string CultureCode)
        {
            try
            {
                List<KeyValuePair<string, object>> Parameter = new List<KeyValuePair<string, object>>();
                Parameter.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                Parameter.Add(new KeyValuePair<string, object>("@UserModuleID", UserModuleID));
                Parameter.Add(new KeyValuePair<string, object>("@CultureCode", CultureCode));
                SQLHandler sqlH = new SQLHandler();
                return sqlH.ExecuteAsList<SageBannerInfo>("[usp_SageBannerLoadBannerListOnGrid]", Parameter);
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public List<SageBannerInfo> LoadBannerOnDropDown(int UserModuleID, int PortalID,string CultureCode)
        {
            SqlDataReader Reader = null;
            try
            {
                List<KeyValuePair<string, object>> Parameter = new List<KeyValuePair<string, object>>();
                Parameter.Add(new KeyValuePair<string, object>("@UserModuleID", UserModuleID));
                Parameter.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                Parameter.Add(new KeyValuePair<string, object>("@CultureCode", CultureCode));
                SQLHandler sqlH = new SQLHandler();

                Reader = sqlH.ExecuteAsDataReader("usp_SageBannerGetAllBanner", Parameter);
                List<SageBannerInfo> BannerListForDropDown = new List<SageBannerInfo>();
                while (Reader.Read())
                {
                    SageBannerInfo obj = new SageBannerInfo();
                    obj.BannerID = Convert.ToInt32(Reader["BannerID"]);
                    obj.BannerName = Convert.ToString(Reader["BannerName"]);
                    BannerListForDropDown.Add(obj);
                }
                return BannerListForDropDown;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Reader != null)
                {
                    Reader.Close();
                }
            }


        }


        public void SaveBannerSetting(string Key, string value, int usermoduleid, string Addedby, string Updatedby, int PortalID,string CultureCode)
        {
            try
            {
                List<KeyValuePair<string, object>> para = new List<KeyValuePair<string, object>>();
                para.Add(new KeyValuePair<string, object>("@SettingKey", Key));
                para.Add(new KeyValuePair<string, object>("@SettingValue", value));
                para.Add(new KeyValuePair<string, object>("@usermoduleid", usermoduleid));
                para.Add(new KeyValuePair<string, object>("@Addedby", Addedby));
                para.Add(new KeyValuePair<string, object>("@Updatedby", Updatedby));
                para.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                para.Add(new KeyValuePair<string, object>("@CultureCode", CultureCode));
                SQLHandler sagesql = new SQLHandler();
                sagesql.ExecuteNonQuery("[usp_SageBannerSaveBannerSetting]", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public List<SageBannerInfo> GetAllPagesOfSageFrame(int PortalID)
        {
            List<KeyValuePair<string, object>> Parameter = new List<KeyValuePair<string, object>>();
            Parameter.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
            List<SageBannerInfo> obj = new List<SageBannerInfo>();
            SQLHandler sqlH = new SQLHandler();
            obj = sqlH.ExecuteAsList<SageBannerInfo>("[usp_SageBannerGetAllPagesOfSageFrame]", Parameter);
            return obj;

        }

        public SageBannerSettingInfo GetSageBannerSettingList(int PortalID, int UserModuleID, string CultureCode)
        {
            try
            {
                SageBannerSettingInfo Getsettin = new SageBannerSettingInfo();
                List<KeyValuePair<string, object>> paramCol = new List<KeyValuePair<string, object>>();
                paramCol.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                paramCol.Add(new KeyValuePair<string, object>("@UserModuleID", UserModuleID));
                paramCol.Add(new KeyValuePair<string, object>("@CultureCode", CultureCode));
                SQLHandler sageSQL = new SQLHandler();
                Getsettin = sageSQL.ExecuteAsObject<SageBannerSettingInfo>("[dbo].[usp_SageBannerGetBannerSetting]", paramCol);
                return Getsettin;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<SageBannerInfo> GetBannerImages(int BannerID, int UserModuleID, int PortalID,string CultureCode)
        {
            try
            {
                List<SageBannerInfo> GetBannerImage = new List<SageBannerInfo>();
                List<KeyValuePair<string, object>> paramCol = new List<KeyValuePair<string, object>>();
                paramCol.Add(new KeyValuePair<string, object>("@BannerID", BannerID));
                paramCol.Add(new KeyValuePair<string, object>("@UserModuleID", UserModuleID));
                paramCol.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                paramCol.Add(new KeyValuePair<string, object>("@CultureCode", CultureCode));
                SQLHandler sageSQL = new SQLHandler();
                GetBannerImage = sageSQL.ExecuteAsList<SageBannerInfo>("[dbo].[usp_SageBannerGetBannerImages]", paramCol);
                return GetBannerImage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SageBannerInfo GetImageInformationByID(int ImageID)
        {
            try
            {
                List<KeyValuePair<string, object>> para = new List<KeyValuePair<string, object>>();
                para.Add(new KeyValuePair<string, object>("@ImageID", ImageID));
                SQLHandler SQLH = new SQLHandler();
                return SQLH.ExecuteAsObject<SageBannerInfo>("[dbo].[usp_SageBannerGetImageInformationByID]", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public SageBannerInfo GetHTMLContentForEditByID(int ImageID)
        {
            try
            {
                List<KeyValuePair<string, object>> para = new List<KeyValuePair<string, object>>();
                para.Add(new KeyValuePair<string, object>("@ImageID", ImageID));
                SQLHandler SQLH = new SQLHandler();
                return SQLH.ExecuteAsObject<SageBannerInfo>("[dbo].[usp_SageBannerGetHTMLContentForEditByID]", para);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void DeleteBannerContentByID(int ImageId)
        {
            try
            {
                List<KeyValuePair<string, object>> para = new List<KeyValuePair<string, object>>();
                para.Add(new KeyValuePair<string, object>("@ImageId", ImageId));
                SQLHandler SQLH = new SQLHandler();
                SQLH.ExecuteNonQuery("[usp_SageBannerDeleteBannerContentByID]", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void DeleteBannerAndItsContentByBannerID(int BannerID)
        {
            try
            {
                List<KeyValuePair<string, object>> para = new List<KeyValuePair<string, object>>();
                para.Add(new KeyValuePair<string, object>("@BannerID", BannerID));
                SQLHandler SQLH = new SQLHandler();
                SQLH.ExecuteNonQuery("[usp_SageBannerDeleteBannerAndItsContentByBannerID]", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void DeleteHTMLContentByID(int ImageId)
        {
            try
            {
                List<KeyValuePair<string, object>> para = new List<KeyValuePair<string, object>>();
                para.Add(new KeyValuePair<string, object>("@ImageId", ImageId));
                SQLHandler SQLH = new SQLHandler();
                SQLH.ExecuteNonQuery("[usp_SageBannerDeleteHTMLContentByID]", para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string GetFileName(int ImageId)
        {
            try
            {
                List<KeyValuePair<string, object>> Parameter = new List<KeyValuePair<string, object>>();
                Parameter.Add(new KeyValuePair<string, object>("@ImageId", ImageId));
                SQLHandler sqlH = new SQLHandler();
                return sqlH.ExecuteAsScalar<string>("usp_SageBannerGetFileName", Parameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void SortImageList(int ImageId, bool MoveUp)
        {
            try
            {
                List<KeyValuePair<string, object>> Parameter = new List<KeyValuePair<string, object>>();
                Parameter.Add(new KeyValuePair<string, object>("@ImageId", ImageId));
                Parameter.Add(new KeyValuePair<string, object>("@MoveUp", MoveUp));
                SQLHandler SQLH = new SQLHandler();
                SQLH.ExecuteNonQuery("[usp_SageBannerBannerSortOrderUpdate]", Parameter);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SaveHTMLContent(string NavImagepath, string HTMLBodyText, int Bannerid, int UserModuleId, int ImageID, int PortalID, string CultureCode)
        {
            try
            {
                SQLHandler sq = new SQLHandler();
                List<KeyValuePair<string, object>> para = new List<KeyValuePair<string, object>>();
                para.Add(new KeyValuePair<string, object>("@NavigationImage", NavImagepath));
                para.Add(new KeyValuePair<string, object>("@Content", HTMLBodyText));
                para.Add(new KeyValuePair<string, object>("@Bannerid", Bannerid));
                para.Add(new KeyValuePair<string, object>("@UserModuleId", UserModuleId));
                para.Add(new KeyValuePair<string, object>("@ImageID", ImageID));
                para.Add(new KeyValuePair<string, object>("@PortalID", PortalID));
                para.Add(new KeyValuePair<string, object>("@CultureCode", CultureCode));
                sq.ExecuteNonQuery("[usp_SageBannerAddHtmlContentToBanner]", para);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
