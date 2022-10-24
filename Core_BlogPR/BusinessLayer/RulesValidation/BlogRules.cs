using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.RulesValidation
{
    public class BlogRules:AbstractValidator<Blog>
    {
        public BlogRules()
        {
            RuleFor(x => x.blogTitle).NotEmpty().WithMessage("Başlık boş geçilemez.").MaximumLength(100).WithMessage("En fazla 100 karakter olabilir.").MinimumLength(20).WithMessage("En az 20 karakter olmalıdır.");
            RuleFor(x => x.blogContent).NotEmpty().WithMessage("İçerik boş geçilemez.").MinimumLength(100).WithMessage("En az 100 karakter olmalıdır.").MaximumLength(1000).WithMessage("En fazla 1000 karakter olabilir.");
            //RuleFor(x => x.blogSmallImage).NotEmpty().WithMessage("Küçük görsel boş geçilemez.");
            //RuleFor(x => x.blogThumbnailImage).NotEmpty().WithMessage("Büyük görsel boş geçilemez.");
            
        }
    }
}
