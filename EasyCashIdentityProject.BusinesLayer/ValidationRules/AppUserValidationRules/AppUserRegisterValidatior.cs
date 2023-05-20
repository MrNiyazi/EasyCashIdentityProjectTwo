using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinesLayer.ValidationRules.AppUserValidationRules
{
	public class AppUserRegisterValidatior :AbstractValidator<AppUserRegisterDto>
	{
		public AppUserRegisterValidatior()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
			RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş geçilemez");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
			RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifenizi tekrar giriniz");
			RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lüten en fazla 30 karakter giriniz");
			RuleFor(x => x.Name).MinimumLength(3).WithMessage("Lüten en az 3 karakter giriniz");
			RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Parolanız eşleşmiyor");
			RuleFor(x => x.Email).EmailAddress().WithMessage("Lüten geçerli bir email adresi giriniz.");
		}
	}
}
