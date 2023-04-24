using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidate : AbstractValidator<Blog>
    {
        public BlogValidate()
        {
            RuleFor(b => b.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz");
            RuleFor(b => b.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Geçemezsiniz");
        }
    }
}
