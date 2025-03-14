using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekarz.Data.Model;

public class Book : EntityBase
{
    public string Author { get; set; }

    public string Title { get; set; }

    public int PageCount { get; set; }

    public bool IsBorrowed { get; set; }

    public Customer Borrower { get; set; }
}
