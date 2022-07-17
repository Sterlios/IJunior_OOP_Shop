using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller seller = new Seller("Торговец", new SellerInventory(), new ViewPosition(0, 0));
            Client client = new Client("Покупатель", new ClientInventory(), new ViewPosition(50, 0), 20000);
            bool isContinue = true;

            while (isContinue)
            {
                Console.Clear();

                seller.SetDefaultViewPosition();
                client.SetDefaultViewPosition();

                seller.Showinfo();
                client.Showinfo();

                isContinue = seller.Serve(client);

                Console.ReadKey();
            }
            
        }
    }
}
