using App.Models;
using App.Persistence.Models;

namespace App.Persistence.Services
{
    public class MediaService : PersistenceService<Media,Guid>
    {

        public MediaViewModel Create(CreateMediaRequest request)
        {
           var media = Create(new Media() { 
                Id = Guid.NewGuid(),
                UploaderEmail = request.UploaderEmail,
                Timestamp = DateTime.Now,
                Caption = request.Caption,
                FilePath = $"{Constants.MEDIA_FILE_PATH}/{request.Caption}{request.FileExtension}"
            });

            return new MediaViewModel()
            {
                FilePath = media.FilePath,
                Id = media.Id,
                Caption = media.Caption,
                UploaderEmail = media.UploaderEmail,
                Timestamp = media.Timestamp
            };
        }
    }

    public class CreateMediaRequest
    {
        public string Caption { get; set; }
        public string UploaderEmail { get; set; }
        public string FileExtension { get; set; }
    }
}
