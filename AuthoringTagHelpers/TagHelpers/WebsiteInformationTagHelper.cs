using AuthoringTagHelpers.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthoringTagHelpers.TagHelpers
{
    public class WebsiteInformationTagHelper : TagHelper
    {
        public WebsiteContext Info { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.TagName = "section";
            output.Content.SetHtmlContent(
                   $@"<div class='form-group'>
                    <label>Select</label>
                    <select   class='form-control' name='Country' id='Country'>
                        <option value='MX'>Mexico</option>
                        <option value='CA'>Canada</option>
                        <option value ='US'>USA</option>
                    </select>
                   
                    </br>
                    <label>Multi Select</label>
                    <select   class='form-control' name='CountryCodes' id='CountryCodes' multiple data-val-required='The Contry Codes field is required.'>
                    < option value='MX'>Mexico</option>
                        <option value='CA'>Canada</option>
                        <option value ='US'>USA</option>
                    </select>

                    </br>
                    <label class='radio-inline'>
                    <input type='radio' name='gender' value='male'> Male<br>
                    </label>

                    <label class='radio-inline'>
                    <input type = 'radio' name ='gender' value = 'female'> Female<br>
                    </label>

                    <label class='radio-inline'>
                    <input type ='radio' name ='gender' value ='other'> Other
                    </label>


                    </div>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
