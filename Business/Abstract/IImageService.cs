using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IImageService
    {
        IDataResult<List<Image>> GetAll();
        IDataResult<Image> GetByImageId(int imageId);
        IResult Add(Image image);
        IResult Delete(Image image);
        IResult DeleteByImageId(int imageId);
        IResult Update(Image image);
    }
}
