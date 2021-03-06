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
#endregion

namespace SageFrame.FileManager
{
    public class ATTFile
    {
        public int FileId { get; set; }
        public int PortalId { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public Guid UniqueId { get; set; }
        public Guid VersionGuid { get; set; }
        public string ContentType { get; set; }
        public string Folder { get; set; }
        public int FolderId { get; set; }
        public int StorageLocation { get; set; }
        public int IsActive { get; set; }
        public string AddedBy { get; set; }
        public string AddedOn { get; set; }
        public byte[] Content { get; set; }

        public ATTFile(string fileName, string folder, int folderID, string addedBy, string extension, int portalId, Guid uniqueId, Guid versionId, int size, string contentType, int isActive, int storageLocation)
        {
            this.FileName = fileName;
            this.Folder = folder;
            this.FolderId = folderID;
            this.AddedBy = addedBy;
            this.Extension = extension;
            this.PortalId = portalId;
            this.UniqueId = uniqueId;
            this.VersionGuid = versionId;
            this.Size = size;
            this.ContentType = contentType;
            this.IsActive = isActive;
            this.StorageLocation = storageLocation;

        }
        public ATTFile(string fileName, string folder, int size, string contentType)
        {
            this.FileName = fileName;
            this.Folder = folder;
            this.Size = size;
            this.ContentType = contentType;
        }

        public ATTFile() { }

    }
}
