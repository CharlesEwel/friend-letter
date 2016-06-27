using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/greeting_card"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables
        {Recipient=Request.Query["recipient"],
        Sender=Request.Query["sender"]};
        return View["hello.cshtml", myLetterVariables];
      };
      // Get["/"] = _ => {
      //   LetterVariables myLetterVariables = new LetterVariables();
      //   myLetterVariables.SetRecipient("Jessica");
      //   return View["hello.cshtml", myLetterVariables];
      // };
    }
  }
}
