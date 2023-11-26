using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    // 중간 매개체 클래스
    public class DataContainer
    {
        private static DataContainer instance;

        private DataContainer() { }
        public static DataContainer Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataContainer();
                return instance;
            }
        }

        public DataRow[] LoginedRow { get; set; }
        public string ConvertedRemainedTime {get; set;}
    }

}
