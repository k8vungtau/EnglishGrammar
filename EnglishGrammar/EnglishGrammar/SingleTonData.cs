using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishGrammar
{
    public sealed class SingleTonData
    {
        private static volatile SingleTonData instance;
        private static object syncRoot = new Object();
        List<Category> lstCategory = new List<Category>();
        public SingleTonData() { }

        public static SingleTonData Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SingleTonData();
                        }
                    }
                }
                return instance;
            }
        }

        public void getDataCategory()
        {
            Common common = new Common();
            string data = common.ReadFile("Data/Category.txt");
            
            lstCategory = JsonConvert.DeserializeObject<List<Category>>(data);
        }

        public List<Category> category()
        {
            return lstCategory;
        }


    }
}
