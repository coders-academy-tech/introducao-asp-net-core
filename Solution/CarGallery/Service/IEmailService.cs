using CarGallery.Models;

namespace CarGallery.Service
{
    public interface IEmailService
    {
        void SendEmail(Contact contact);
    }
}