using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using urn.items;
using System.Linq.Expressions;
using System.Diagnostics;


namespace RajSoftware.Models
{
    public interface IDataRepository
    {
        IEnumerable<LinkItem> GetData(LinkType type);
    }

}