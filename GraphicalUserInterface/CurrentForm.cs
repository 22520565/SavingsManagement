using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalUserInterface
{
    public static class CurrentForm
    {
        public enum OpenForm
        {
            Login,
            Customer,
            Staff,
            Forgot,
            SignUp,
            Exit
        }

        public static OpenForm SelectedForm { get; private set; }

        public static void SetSelectedForm(OpenForm form)
        {
            SelectedForm = form;
        }
    }
}
