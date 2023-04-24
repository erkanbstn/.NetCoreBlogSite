using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidate : AbstractValidator<Writer>
    {
        public WriterValidate()
        {
            RuleFor(b => b.WriterName).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(b => b.WriterMail).NotEmpty().WithMessage("Email Alanı Boş Geçilemez");
            RuleFor(b => b.WriterPassword).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(b => b.WriterAbout).NotEmpty().WithMessage("Hakkımda Alanı Boş Geçilemez");
        }
    }
}
