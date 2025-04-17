using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Config
{
    public Config(string lang, Transfer transfer, Confirmation confirmation, string[] methods)
    {
        this.lang = lang;
        this.transfer = transfer;
        this.confirmation = confirmation;
        this.methods = methods;
    }


    public string lang { get; set; }
    public Transfer transfer { get; set; }
    public Confirmation confirmation { get; set; }
    public string[] methods { get; set; }
   
}
public class Transfer
{
    public Transfer(int threshold, int low_fee, int high_fee)
    {
        this.threshold = threshold;
        this.low_fee = low_fee;
        this.high_fee = high_fee;
    }

    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }


}

public class Confirmation
{
    public Confirmation(string en, string id)
    {
        this.en = en;
        this.id = id;
    }

    public string en { get; set; }
    public string id { get; set; }
}
