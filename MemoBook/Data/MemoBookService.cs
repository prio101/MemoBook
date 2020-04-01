using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemoBook.Models;


namespace MemoBook.Data
{
    public class MemoBookService
    {
        public Task<MemoModel[]> GetMemosAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 6).Select(index => new MemoModel
            {
                Title = "Title",
                Memo = "Memos",
                DateTime = startDate.AddDays(index)

            }).ToArray());
        }
    }
}
