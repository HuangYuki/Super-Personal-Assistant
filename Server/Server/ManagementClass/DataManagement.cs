using Server.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ManagementClass
{
    class DataManagement
    {
        ClientAccount client = new ClientAccount();

        public bool doDataManagement(String data)
        {
            int dataTypeId = -1;

            dataTypeId = getDataType(data);
            seperateData(dataTypeId, data);


            if(dataTypeId == 0 || dataTypeId == 1)
            {
                compareData(dataTypeId);
            }


            return true;
        }

        public int getDataType(String data)
        {
            int typeId = 0;

            typeId = data[0] - '0';

            return typeId;
        }

        public void seperateData(int typeId, string data)
        {
            if(typeId == 0)
            {
                char space = ' ';
                string[] words = data.Split(space);
            }
        }

        public bool compareData(int typeId)
        {
            return true;
        }

        public bool saveData(String data)
        {
            int typeId = data[0] - '0' ;

            if(typeId == 0)
            {

            }

            return true;
        }

    }
}
