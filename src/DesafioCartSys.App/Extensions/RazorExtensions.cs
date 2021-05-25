using Microsoft.AspNetCore.Mvc.Razor;
using System;


namespace DesafioCartSys.App.Extensions
{
    public static class RazorExtensions
    {
        public static string FormataDocumento(this RazorPage page,string documento)
        {
            return  Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00");
        }
    }
}
