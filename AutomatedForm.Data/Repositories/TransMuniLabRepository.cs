using AutomatedForm.Core.Models;
using AutomatedForm.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedForm.Data.Repositories
{
    public class TransMuniLabRepository:ITransMuniLabRepository
    {

        private readonly DataContext _context;

        public TransMuniLabRepository(DataContext context)
        {
            _context = context;
        }

      
        public async Task<IEnumerable<TransMuniLab>> GetMuniLabsAsync()
        {
            return await _context.TransMuniLab.ToListAsync();
        }

        //public async Task<IEnumerable<TblLaboratory>> GetLabByMuniIdAsync(int muniId)
        //{
        //    // שליפת כל השורות בטבלת MUNILAB עם muniId מתאים
        //    var muniLabs = await _context.TransMuniLab
        //                                       .Where(mf => mf.MuniId == muniId)
        //                                       .ToListAsync();

        //    // יצירת רשימת labId
        //    var labIds = muniLabs.Select(mf => mf.LabId).ToList();

        //    // שליפת נתונים מטבלת LAB לפי labId
        //    var labs = await _context.TblLaboratory
        //                                   .Where(f => labIds.Contains(f.LabId))
        //                                   .ToListAsync();

        //    return labs;
        //}


public async Task<TblLaboratory> GetLabByMuniIdAsync(int muniId)
{
    // שליפת LabId מתאים מ-TransMuniLab
    var labId = await _context.TransMuniLab
                              .Where(mf => mf.MuniId == muniId)
                              .Select(mf => mf.LabId)
                              .SingleOrDefaultAsync(); // מחזיר null אם לא נמצאה תוצאה

    // אם לא נמצא LabId, מחזירים null
    if (labId == 0)
        return null;

    // שליפת המעבדה מטבלת TblLaboratory
    var lab = await _context.TblLaboratory
                            .Where(l => l.LabId == labId)
                            .SingleOrDefaultAsync(); // מחזיר null אם לא נמצאה מעבדה

    return lab; // אם לא נמצא, תחזור null
}















    }
}
