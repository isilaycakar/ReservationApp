using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp.BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator: AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.NameSurname).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez.");
            RuleFor(x=>x.UserName).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez.");
            RuleFor(x=>x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez.");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("lütfen en az 5 karakter veri girişi yapınız");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("lütfen en fazla 20 karakter veri girişi yapınız");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("şifreler birbiriyle uyuşmuyor");
        }
    }
}
