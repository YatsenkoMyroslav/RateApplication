using Microsoft.AspNetCore.Identity;
using RateApplication.Models;

namespace RateApplication.Services.IdentityServices;

public class SignInService
{
    SignInManager<User> signInManager;
    UserManager<User> userManager;
    

    public SignInService(SignInManager<User>signInManager,UserManager<User>userManager)
    {
        this.signInManager= signInManager;
        this.userManager = userManager;
    }
    public async Task<SignInResult> SignInWithEmailAsync(string email,string password)
    {
        User user =await userManager.FindByEmailAsync(email);
        if (user != null)
        {
            var result=await signInManager.PasswordSignInAsync(user,password,false,false);
            return result;
        }
        return SignInResult.Failed;
    }
    public async Task SignOut()
    {
        await signInManager.SignOutAsync();
    }

}