using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PeopleSearch.Data
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate, string include);
    }
}