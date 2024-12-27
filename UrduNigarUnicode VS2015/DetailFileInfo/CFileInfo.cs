// Decompiled with JetBrains decompiler
// Type: DetailFileInfo.CFileInfo
// Assembly: UrduNigarUnicode, Version=2.0.1.7, Culture=neutral, PublicKeyToken=null
// MVID: 13D238AE-1E4C-4956-9129-B526715F87B1
// Assembly location: D:\NSM\Urdu\Urdu Nigar Unicode 3.0\Reference\Setup4UrduNigarUnicode\UrduNigarUnicode.exe

using Shell32;
using System;
using System.Collections;
using System.IO;

namespace DetailFileInfo
{
  public class CFileInfo
  {
    private string sFileName = "";
    private string sFullFileName = "";
    private string sFileExtension = "";
    private string sFilePath = "";
    private string sFileComment = "";
    private string sFileAuthor = "";
    private string sFileTitle = "";
    private string sFileSubject = "";
    private string sFileCategory = "";
    private string sFileType = "";
    private long lFileLength;
    private long lFileVersion;
    private DateTime dCreationDate;
    private DateTime dModificationDate;
    private DateTime dAccessedDate;

    public string FileName
    {
      get
      {
        return this.sFileName;
      }
      set
      {
        this.sFileName = value;
      }
    }

    public string FilePath
    {
      get
      {
        return this.sFilePath;
      }
      set
      {
        this.sFilePath = value;
      }
    }

    public string FullFileName
    {
      get
      {
        return this.sFullFileName;
      }
      set
      {
        this.sFullFileName = value;
      }
    }

    public string FileExtension
    {
      get
      {
        return this.sFileExtension;
      }
      set
      {
        this.sFileExtension = value;
      }
    }

    public long FileSize
    {
      get
      {
        return this.lFileLength;
      }
      set
      {
        this.lFileLength = value;
      }
    }

    public long FileVersion
    {
      get
      {
        return this.lFileVersion;
      }
      set
      {
        this.lFileVersion = value;
      }
    }

    public DateTime FileCreationDate
    {
      get
      {
        return this.dCreationDate;
      }
      set
      {
        this.dCreationDate = value;
      }
    }

    public DateTime FileModificationDate
    {
      get
      {
        return this.dModificationDate;
      }
      set
      {
        this.dModificationDate = value;
      }
    }

    public DateTime FileAccessedDate
    {
      get
      {
        return this.dAccessedDate;
      }
      set
      {
        this.dAccessedDate = value;
      }
    }

    public string FileType
    {
      get
      {
        return this.sFileType;
      }
    }

    public string FileTitle
    {
      get
      {
        return this.sFileTitle;
      }
    }

    public string FileSubject
    {
      get
      {
        return this.sFileSubject;
      }
    }

    public string FileAuthor
    {
      get
      {
        return this.sFileAuthor;
      }
    }

    public string FileCategory
    {
      get
      {
        return this.sFileCategory;
      }
    }

    public string FileComment
    {
      get
      {
        return this.sFileComment;
      }
    }

    public CFileInfo(string sFPath)
    {
      if (!File.Exists(sFPath))
        throw new Exception("The given File does not exist");
      ArrayList arrayList = new ArrayList();
      FileInfo fileInfo = new FileInfo(sFPath);
      this.sFileName = fileInfo.Name;
      this.sFullFileName = fileInfo.FullName;
      this.sFileExtension = fileInfo.Extension;
      this.lFileLength = fileInfo.Length;
      this.sFilePath = fileInfo.Directory.ToString();
      this.dCreationDate = fileInfo.CreationTime;
      this.dModificationDate = fileInfo.LastWriteTime;
      this.dAccessedDate = fileInfo.LastAccessTime;
      foreach (DetailedFileInfo detailedFileInfo in this.GetDetailedFileInfo(sFPath))
      {
        switch (detailedFileInfo.ID)
        {
          case 2:
            this.sFileType = detailedFileInfo.Value;
            continue;
          case 9:
            this.sFileAuthor = detailedFileInfo.Value;
            continue;
          case 10:
            this.sFileTitle = detailedFileInfo.Value;
            continue;
          case 11:
            this.sFileSubject = detailedFileInfo.Value;
            continue;
          case 12:
            this.sFileCategory = detailedFileInfo.Value;
            continue;
          case 14:
            this.sFileComment = detailedFileInfo.Value;
            continue;
          default:
            continue;
        }
      }
    }

    private ArrayList GetDetailedFileInfo(string sFile)
    {
      ArrayList arrayList = new ArrayList();
      if (sFile.Length > 0)
      {
        try
        {
          Folder folder = new ShellClass().NameSpace((object) Path.GetDirectoryName(sFile));
          FolderItem folderItem = folder.ParseName(Path.GetFileName(sFile));
          for (int index = 0; index < 30; ++index)
          {
            string detailsOf = folder.GetDetailsOf((object) folderItem, index);
            DetailedFileInfo detailedFileInfo = new DetailedFileInfo(index, detailsOf);
            arrayList.Add((object) detailedFileInfo);
          }
        }
        catch (Exception ex)
        {
        }
      }
      return arrayList;
    }
  }
}
