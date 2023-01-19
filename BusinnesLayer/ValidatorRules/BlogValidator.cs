using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidatorRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Burası bos bırakılamaz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Burası bos bırakılamaz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Burası bos bırakılamaz");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("En Az 5 karekter olusturunuz");
            RuleFor(x => x.BlogTitle).MaximumLength(55).WithMessage("En fazla 55 karekter olusturunuz");

        }
    }
}
