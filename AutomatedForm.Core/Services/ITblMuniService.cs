﻿using AutomatedForm.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Core.Services
{
    public interface ITblMuniService
    {
        Task<IEnumerable<TblMuni>> GetMunisAsync();
    }
}