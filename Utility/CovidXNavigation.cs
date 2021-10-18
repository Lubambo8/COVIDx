using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class CovidXNavigation
    {
        /// <summary>
        /// Returns the bootstrap class 'active' if URL is a match
        /// </summary>
        public static string MakeActiveClass(this IUrlHelper urlHelper, string controllerName)
        {
            try
            {
                // css class name
                string result = "active";
                // get current controller
                string controller = urlHelper.ActionContext.RouteData.Values["controller"].ToString();
                // get current action
                string action = urlHelper.ActionContext.RouteData.Values["action"].ToString();
                // context is default index page
                if (string.IsNullOrEmpty(controller)) return null;
                // compare controller names
                if (controller.Equals(controllerName, StringComparison.OrdinalIgnoreCase))
                {
                    // return css class name
                    return result;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the bootstrap class 'active' if URL is a match
        /// </summary>
        public static string MakeActiveClass(this IUrlHelper urlHelper, string controllerName, string actionName)
        {
            try
            {
                // css class name
                string result = "active";
                // get current controller
                string controller = urlHelper.ActionContext.RouteData.Values["controller"].ToString();
                // get current action
                string action = urlHelper.ActionContext.RouteData.Values["action"].ToString();
                // context is default index page
                if (string.IsNullOrEmpty(controller)) return null;
                // compare controller names
                if (controller.Equals(controllerName, StringComparison.OrdinalIgnoreCase))
                {
                    // compare action names
                    if (action.Equals(actionName, StringComparison.OrdinalIgnoreCase))
                    {
                        // return css class name
                        return result;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns the bootstrap class 'menu-open' if URL is a match
        public static string MakeMenuOpenClass(this IUrlHelper urlHelper, string controllerName)
        {
            try
            {
                // css class name
                string result = "menu-open";
                // get current controller
                string controller = urlHelper.ActionContext.RouteData.Values["controller"].ToString();
                // get current action
                string action = urlHelper.ActionContext.RouteData.Values["action"].ToString();
                // context is default index page
                if (string.IsNullOrEmpty(controller)) return null;
                // compare controller names
                if (controller.Equals(controllerName, StringComparison.OrdinalIgnoreCase))
                {
                    // return css class name
                    return result;
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
