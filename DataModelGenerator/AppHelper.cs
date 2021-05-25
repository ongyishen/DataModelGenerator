using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace DataModelGenerator
{
    public static class AppHelper
    {

        public static void AlertInfo(this string info)
        {
            MessageBox.Show(info, "Information Message");
            return;
        }
        public static void AlertError(this Exception err)
        {
            err.Message.AlertError();
        }

        public static void AlertError(this string err)
        {
            MessageBox.Show(err, "Error Message", MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1);
            return;
        }

        public static T ToObject<T>(this string Json)
        {
            Json = Json.Replace("&nbsp;", "");
            return Json == null ? default(T) : JsonConvert.DeserializeObject<T>(Json);
        }

        public static string ToJson(this object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }


        public static bool IsNotEmpty(this string value)
        {
            return !value.IsEmpty();
        }

        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static string ReadAllLine(this string fileName)
        {
            try
            {
                if (fileName.IsFileExist())
                {
                    using (StreamReader rw = new StreamReader(fileName))
                    {
                        return rw.ReadLine();
                    }
                }
            }
            catch //(System.Exception)
            {

                //throw;
            }

            return string.Empty;
        }

        public static bool IsFileExist(this string filePath)
        {
            return File.Exists(filePath);
        }

        public static void SaveJson(this string fileName, string jsonString)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(jsonString);
                sw.Flush();
                sw.Close();
            }
        }


        public static void SaveCS(this string fileName, string codeString)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(codeString);
                sw.Flush();
                sw.Close();
            }
        }

        public static void DisableBtn(this Button btn)
        {
            btn.EnableBtn(false);
        }

        public static void EnableBtn(this Button btn, bool isEnable = true)
        {
            btn.Enabled = isEnable;
            Application.DoEvents();
        }
    }
}
