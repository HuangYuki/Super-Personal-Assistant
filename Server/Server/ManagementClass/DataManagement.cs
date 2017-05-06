using Server.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ManagementClass
{
    class DataManagement
    {
        ClientAccount _client = new ClientAccount();
        List<String> _accountList = new List<String>();

        public bool doDataManagement(String data)
        {
            int dataTypeId = -1;

            dataTypeId = getDataType(data);
            seperateData(dataTypeId, data);
            compareData(dataTypeId);


            return true;
        }

        public int getDataType(String data)
        {
            int typeId = 0;

            typeId = data[0] - '0';

            return typeId;
        }

        public String[] seperateData(int typeId, string data)
        {
            char space = ' ';
            string[] words = data.Split(space);

            return words;

        }

        public bool compareData(int typeId)
        {
            if(typeId == 0)
            {

            }

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
