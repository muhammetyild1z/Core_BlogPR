using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.RulesValidation
{
  public  class WriterRules:AbstractValidator<Writer>
    {
        public WriterRules()
        {
            RuleFor(x => x.mail).NotEmpty().WithMessage("Mail kısmı boş geçilemez");

            RuleFor(x => x.writerName).NotEmpty().WithMessage("İsim kısmı boş geçilemez").MinimumLength(2).WithMessage("En az iki karekter girin").MaximumLength(30).WithMessage("En çok 30 karakter girin");

            RuleFor(x => x.password).NotEmpty().WithMessage("Şifre kısmı boş geçilemez")
              .Matches(@"[A-Z]+").WithMessage("Sifre en az bir büyük harfden ibaret olmalıdır.")
              .Matches(@"[a-z]+").WithMessage("Sifre en az bir küçük harfden ibaret olmalıdır.")
              .Matches(@"[0-9]+").WithMessage("Sifre en az bir rakamdan ibaret olmalıdır.")
              .MaximumLength(16).WithMessage("Şifre 16 karakterden fazla olamaz.")
              .MinimumLength(8).WithMessage("Şifreniz en az 8 karakter olmalıdır.");


            ;
            
        }
    }
}
