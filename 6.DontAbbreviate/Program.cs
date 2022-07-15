// See https://aka.ms/new-console-template for more information

/**
 * 
 * Namings:
 *    - do not shorten: 
 *          var at = "fòaohlkcnkjmpfs546542j"; //bad
 *          var accessToken = "fòaohlkcnkjmpfs546542j"; //good
 *          
 *    - be semantic:
 *          var stringa = "mario.rossi@mail.com"; //bad
 *          var emailAddress = "mario.rossi@mail.com"; //good
 *    - be 'objectful' 
 *      user.Id VS user.UserId
 *    - be consistent with casing and prefixes
 *    - be consistent with language
 * 
 * 
 * **/
class SubscriptionService
{
    public MSDNsubscription CreateSubscription() => new MSDNsubscription();
    public MSDNsubscription UpdateSubscription(MSDNsubscription s, Guid MSDNSubscriptionId) {
        var a = s;
        Console.WriteLine($"updating {MSDNSubscriptionId} with {s}");
        /**
         do stuff here with s o a
         do stuff here with s
         do stuff here with s
         do stuff here with s
         do stuff here with s
         */
        return a; 

    }
    public void DeleteSubscription(Guid MSDNSubscriptionId) => Console.WriteLine($"deleting {MSDNSubscriptionId}");
}
class MSDNsubscription
{
    private decimal _ac; //azure credits
    public readonly string? MSDNSubscriptionKey;
    public Guid MSDNSubscriptionId { get; set; }
}
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
    }



}
