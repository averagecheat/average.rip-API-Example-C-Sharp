using System;
using System.Net;
class Program {
  public static void Main(string[] args) {
    Console.Title = "average.rip API Example C#";

    //replace this with your own informations
    string username = "anditv21";
    int uid = 1;

    //webclient definition
    WebClient webClient = new WebClient();

    //saving api response data in string format.
    string injectcount = webClient.DownloadString("https://average.rip/panel/api.php?inject");
    string user_pb = webClient.DownloadString("https://average.rip/panel/api.php?user_pb=" + username);
    string sub = webClient.DownloadString("https://average.rip/panel/api.php?days=" + username);
    string ban = webClient.DownloadString("https://average.rip/panel/api.php?bancheck=" + username);
    string verify = webClient.DownloadString("https://average.rip/panel/api.php?verifystatus=" + username);
    string staff = webClient.DownloadString("https://average.rip/panel/api.php?staffcheck=" + username);
    string discordid = webClient.DownloadString("https://average.rip/panel/api.php?getid=" + username);
    string touid = webClient.DownloadString("https://average.rip/panel/api.php?touid=" + username);
    string toname = webClient.DownloadString("https://average.rip/panel/api.php?toname=" + uid);

    Console.WriteLine("The total injection count of average is currently: {0}.", injectcount);
    Console.WriteLine("Here is {0}`s avatar url: {1}", username, user_pb);
    Console.WriteLine("{0} has {1} days sub left.", username, sub);

    if (ban == "1") {
      Console.WriteLine("{0} is banned.", username);
    } else {
      Console.WriteLine("{0} is not banned.", username);
    }

    if (verify == "1") {
      Console.WriteLine("{0} is verified.", username);
    } else {
      Console.WriteLine("{0} is not verified.", username);
    }

    if (staff == "False") {
      Console.WriteLine("{0} is not a Staff member.", username);
    } else {
      Console.WriteLine("{0} is an {1}.", username, staff);
    }

    Console.WriteLine("{0}`s Discord ID is: {1}", username, discordid);
    Console.WriteLine("{0}`s UID is: {1}", username, touid);
    Console.WriteLine("The UID {0} belongs to the user with the name: {1}", uid, toname);

    Console.ReadKey();

  }
}