using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public IResult Add(Image image)
        {
            _imageDal.Add(image);
            return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Delete(Image image)
        {
            _imageDal.Delete(image);
            return new SuccessResult(Messages.ImageDeleted);
        }

        public IResult DeleteByImageId(int imageId)
        {
            var deletedImage = _imageDal.GetAll().SingleOrDefault(c => c.ImageId == imageId);
            _imageDal.Delete(deletedImage);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Image>> GetAll()
        {
            return new SuccessDataResult<List<Image>>(_imageDal.GetAll(), Messages.ImagesListed);
        }

        public IDataResult<Image> GetByImageId(int imageId)
        {
            return new SuccessDataResult<Image>(_imageDal.Get(b => b.ImageId == imageId));
        }

        public IResult Update(Image image)
        {
            _imageDal.Update(image);
            return new SuccessResult(Messages.ImageUpdated);
        }
    }
}
