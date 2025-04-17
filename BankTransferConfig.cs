using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.CompilerServices;



class BankTransferConfig
{
    public Config config;
    public const string filepath = @"bank_transfer_config.json";

    public BankTransferConfig()
    {
        try
        {
            ReadConfigFile();
        }
        catch(Exception) 
        {
            SetDefault();
            WriteNewConfigFile();
        }
    }

    private Config ReadConfigFile()
    {
        string configJsonData = File.ReadAllText(filepath);
        config = JsonSerializer.Deserialize<Config>(configJsonData);
        return config;
    }

    private void SetDefault()
    {

        Transfer transfer = new Transfer(25000000, 6500, 15000);
        Confirmation confirmation = new Confirmation("yes", "ya");
        string[] method = { "RTO(real-time)", "SKN", "RTGS", "BI FAST" };
        config = new Config("en", transfer, confirmation, method );
    }

    private void WriteNewConfigFile()
    {
        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(config, options);
        File.WriteAllText(filepath, jsonString);
    }
}

