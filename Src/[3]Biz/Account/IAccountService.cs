
namespace Biz.Account
{
    public interface IAccountService
    {
        bool Register(UserModel userModel);
    }

    public class AccountService : IAccountService
    {
        public bool Register(UserModel userModel)
        {
            return userModel.UserName.Equals("wxy") && userModel.Password.Equals("111");
            
        }
    }
}
