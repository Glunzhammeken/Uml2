namespace Uml2_Maybe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.test();
            UserDialog userDialog = new UserDialog();
            userDialog.Start();
            
        }
    }
}
