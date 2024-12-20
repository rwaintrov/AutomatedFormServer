﻿using AutomatedForm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Core.Services
{
    public interface ITblTemplateService
    {
        Task<IEnumerable<TblTemplate>> GetTemplatesAsync();
        Task<IEnumerable<TblTemplate>> ReturnWithActions(int muniId);

    }
}
