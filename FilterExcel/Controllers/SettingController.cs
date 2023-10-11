using FilterExcel.Models;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;

namespace FilterExcel.Controllers
{
    public static class SettingController
    {
        private static string _fileName = "setting.json";

        public static Setting GetSetting()
        {
            try
            {
                var json = File.ReadAllText(_fileName);
                return JsonConvert.DeserializeObject<Setting>(json); ;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());

                var setting = new Setting();
                setting.Save();
                return setting;
            }
        }

        public static void Save(this Setting obj)
        {
            try
            {
                var json = GetJson(obj);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    File.WriteAllText(_fileName, json);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public static string GetJson(Setting obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return default;
            }
        }
    }
}
