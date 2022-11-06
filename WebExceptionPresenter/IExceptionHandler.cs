﻿using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebExceptionPresenter
{
    public interface IExceptionHandler
    {
        Task Handle(ExceptionContext context);

    }
}
