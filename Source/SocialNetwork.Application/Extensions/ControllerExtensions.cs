namespace SocialNetwork.Application.Extensions
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Controllers;
    using Models.ApplicationEntities;

    public static class ControllerExtensions
    {
        public static SignInManager<User> SignInManager(this ControllerBase controller)
        {
            SignInManager<User> manager = null;
            var typeofCurrentController = controller.GetType();
            var controllerFields = typeofCurrentController
                .GetFields(
                    BindingFlags.Instance |
                    BindingFlags.DeclaredOnly |
                    BindingFlags.GetField |
                    BindingFlags.NonPublic);
            var controllerSignManager = controllerFields.FirstOrDefault(
                f => f.FieldType.FullName == manager.GetType().FullName);
            if (controllerSignManager == null)
            {
                throw new ArgumentException("SignInManager is not instance type of current controller.");
            }

            manager = (SignInManager<User>)controllerSignManager.GetValue(controller);
            return manager;
        }

        public static void AddErrorsFromIdentity(this ControllerBase controller, IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                controller.ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        public static IActionResult RedirectToLocal(this ControllerBase controller, string returnUrl)
        {
            if (controller.Url.IsLocalUrl(returnUrl))
            {
                return controller.Redirect(returnUrl);
            }

            return controller.RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}