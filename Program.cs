// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        int biayaTransfer = 0;
        int totalBiayaTransfer = 0;

        if (config.config.lang == "en") {
            Console.WriteLine("please insert amount of money to transfer");
            int transfer;
            int transferNumber = int.Parse(Console.ReadLine());

            if (transferNumber <= config.config.transfer.threshold)
            {
                biayaTransfer = config.config.transfer.low_fee;
                totalBiayaTransfer = transferNumber + biayaTransfer;

            }
            else if (transferNumber > config.config.transfer.threshold)
            {
                biayaTransfer = config.config.transfer.high_fee;
                totalBiayaTransfer = transferNumber + biayaTransfer;

            }
            Console.WriteLine($"Transfer fee = {biayaTransfer} Total amount = {totalBiayaTransfer}");
            Console.WriteLine("Select transfer method: ");
        } else
        {

            Console.WriteLine("Masukkan sejumlah uang untuk di transfer");
            int transfer;
            int transferNumber = int.Parse(Console.ReadLine());

            if (transferNumber <= config.config.transfer.threshold)
            {
                biayaTransfer = config.config.transfer.low_fee;
                totalBiayaTransfer = transferNumber + biayaTransfer;

            }
            else if (transferNumber > config.config.transfer.threshold)
            {
                biayaTransfer = config.config.transfer.high_fee;
                totalBiayaTransfer = transferNumber + biayaTransfer;

            }
            Console.WriteLine($"Biaya transfer = {biayaTransfer} Total biaya = {totalBiayaTransfer}");
            Console.WriteLine("Pilih metode transfer: ");

        }
    }
}
