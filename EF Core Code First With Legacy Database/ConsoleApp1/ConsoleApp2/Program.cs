using ConsoleApp2.Entities;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CasptoneProjectContext();
            var res = context.Set<AccountType>()
                .Include(x => x.Accounts)
                .ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(res);

        }
    }
}
