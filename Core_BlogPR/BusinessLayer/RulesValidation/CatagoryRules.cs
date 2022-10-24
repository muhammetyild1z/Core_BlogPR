using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.RulesValidation
{
    public class CatagoryRules : AbstractValidator<Catagory>
    {
        public CatagoryRules()
        {
            RuleFor(x => x.catagoryName).NotEmpty().WithMessage("Katagori adı boş geçilemez.")
               .MaximumLength(50).WithMessage("Katagori adı en fazla 50 karakter olabilir.")
               .MinimumLength(2).WithMessage("Katagori adı en az 2 karakter olamlıdır.");

            RuleFor(x => x.catagoryDesc).NotEmpty().WithMessage("Katagori açıklaması boş geçilemez.")
                .MaximumLength(100).WithMessage("Açıklama en fazla 100 karakter olabilir.")
                .MinimumLength(5).WithMessage("Açıklama en az 5 karakter olabilir.")
                ;

            
        }
    }
}
