using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting;
using Xunit;

namespace UnitTests
{
    public class HtmlFormatterTests
    {
        [Fact]
        public void FormatAsBold_IsCalledWithContent_ContentIsWrappedInStrongTags()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");
            // "<strong>abc</strong>"

            Assert.StartsWith("<strong>", result);
            Assert.EndsWith("</strong>", result);
            Assert.Contains("abc", result);
        }
    }
}
