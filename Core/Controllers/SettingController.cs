using Core.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Core.Controllers
{
    public static class SettingController
    {
        private static readonly string _fileName = "setting.json";

        public static Setting Get()
        {
            try
            {
                var json = File.ReadAllText(_fileName);
                return JsonConvert.DeserializeObject<Setting>(json);
            }
            catch (Exception ex)
            { 
                LoggerController.WriteLog(ex.ToString());
                return GetOrCreateSetting(true);
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
                LoggerController.WriteLog(ex.ToString());
                return default;
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
                LoggerController.WriteLog(ex.ToString());
            }
        }

        public static Setting GetOrCreateSetting(bool forceCreate = false)
        {
            var setting = default(Setting);
            
            if (forceCreate is false)
            {
                setting = Get();
            }

            try
            {                
                if (setting is null)
                {
                    setting = new Setting()
                    {
                        ExcelSettingO = new ExcelSetting(),
                        ExcelSettingY = new ExcelSetting()
                    };
                }
                setting.Save();
                return setting;
            }
            catch (Exception ex)
            {
                LoggerController.WriteLog(ex.ToString());
                return default;
            }
        }
    }
}
