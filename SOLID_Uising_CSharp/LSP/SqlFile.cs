﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Uising_CSharp.LSP
{
    //The Liskov Substitution Principle emphasizes that objects of a superclass should be replaceable with objects of
    //its subclasses without affecting the correctness of the program.

    //A father is a doctor, whereas his son wants to become a cricketer. So here, the son can't replace his father even though
    //they belong to the same family hierarchy.
    public interface IReadableSqlFile
    {
        string LoadText();
    }
    public interface IWritableSqlFile
    {
        void SaveText();
    }

    public class SqlFile : IWritableSqlFile, IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            /* Code to read text from sql file */
            return "Load";
        }
        public void SaveText()
        {
            /* Code to save text into sql file */
        }
    }

    public class SqlFileManager
    {
        public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFiles)
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in aLstReadableFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles(List<IWritableSqlFile> aLstWritableFiles)
        {
            foreach (var objFile in aLstWritableFiles)
            {
                objFile.SaveText();
            }
        }
    }

}
