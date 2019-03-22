using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SGS
{
    [ContentProperty("ReSourceID")]
    class EmbeddedImage : IMarkupExtension
    {
        public string ReSourceID { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ReSourceID))
                return null;

            return ImageSource.FromResource(ReSourceID);

        }
    }
}
