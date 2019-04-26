using Newtonsoft.Json;
using Nethereum.JsonRpc.WebSocketClient;

namespace MyLibrary
{
    public class Class1
    {
        public Class1()
        {
            JsonSerializerSettings setting = new JsonSerializerSettings();
        }

        public void LoadNethereum()
        {
            WebSocketClient client = new WebSocketClient(null);
        }
    }
}
