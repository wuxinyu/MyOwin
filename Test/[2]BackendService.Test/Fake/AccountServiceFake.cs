
using Biz.Account;

namespace BackendService.Test.Fake
{
    public class AccountServiceFake : IAccountService
    {
        public bool Register(UserModel userModel)
        {
            return userModel.UserName.Equals("zyh") && userModel.Password.Equals("222");
        }
    }
}
