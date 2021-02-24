﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);//.WithMessage(""); Kendi hata mesajını yazabiliriz
            RuleFor(p => p.ProductName).Must(StarWithA).WithMessage("Ürünler A harfi ile başlamalı");//kendi kuralını koydun.
        }

        private bool StarWithA(string arg)
        {
            return arg.StartsWith("A");//arg C#'daki string fonksiyon
        }
    }
}
// CtrlK +CtrlD kodları düzeltir