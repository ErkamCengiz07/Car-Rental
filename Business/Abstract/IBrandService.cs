﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetByBrandId(int brandId);
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult DeleteByBrandId(int brandId);
        IResult Update(Brand brand);
    }
}
