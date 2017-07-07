using TatAutomationFramework.Web.Pages;

namespace TatAutomationFramework.Web
{
    public class TatWeb
    {
        /// <summary>
        /// property to return an instance of the 
        /// HeaderPObjectTwo class with the elements initialized.
        /// </summary>
        public static HeaderPObject HeaderPage
        {
            get
            {
                return DoInitialize.PageElementsIn<HeaderPObject>();
            }
        }

        /// <summary>
        /// Return instance of menu page object with elements initialised
        /// </summary>
        public static MenuPObject MenuPage
        {
            get
            {
                return DoInitialize.PageElementsIn<MenuPObject>();
            }
        }

        public static SideMetaPObject SideMetaPage
        {
            get
            {
                return DoInitialize.PageElementsIn<SideMetaPObject>();
            }
        }

    }
}
