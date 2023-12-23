using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı alanı boş geçilemez!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar Mail alanı boş geçilemez!");
            //RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Yazar Şifre alanı boş geçilemez!");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Yazar Adı Soyadı 3 Karakterden az olamaz!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Yazar Adı Soyadı 50 Karakterden fazla olamaz!");
            RuleFor(x => x.WriterPassword)
                .NotEmpty().WithMessage("Yazar Şifre alanı boş geçilemez!")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$")
                .WithMessage("Yazar Şifresi en az bir büyük harf, bir küçük harf, bir sayı içermeli ve en az 8 karakter uzunluğunda olmalıdır.");


        }
    }
}
