using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidatorRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş Bırakılamaz");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Email Boş Bırakılamaz");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Bırakılamaz");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En Az İki Karakter Giriniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("50 Karakterden Fazla Deger girilemez");
        }
    }
}
